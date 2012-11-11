using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public class gameEntry
    {
        public String path;
        public String shortName;
        public string folder;
        public string execfolder;

        public string installFXfolder;

        public bool isActivated = false;
        public sweetConfig Config;
        public injector injectordata;
        private static String setting_config = "SweetFX_settings.txt";
        private static String setting_injector = "injector.ini";
        private static String check_for_active_file = "d3d9.dll";

        private static String[] special_files = { "dxgi.dll", "injector.ini", "d3d9.dll" };

        public Boolean special_install = false;
        public String special_folder = "bin";

        public String runArgs = "";

        public List<configPreset> presets = new List<configPreset>();

        public gameEntry(String path, String shortName)
        {
            this.path = path;
            this.shortName = shortName;
            init();
        }


        public bool hasWriteAccessToFolder()
        {
            try
            {
                string dir = Path.Combine(folder, "test_access_rnd548");
                Directory.CreateDirectory(dir);
                Directory.Delete(dir);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        public void loadPresets()
        {
            presets.Clear();
            string presetFolder = Path.Combine(folder, Form1.sweetfxFolderName, configPreset.presetFolder);
            if (Directory.Exists(presetFolder))
            {
                String[] files = Directory.GetFiles(presetFolder);
                foreach (string file in files)
                {
                    presets.Add(new configPreset(file));
                }
            }
        }

        public void loadPreset(configPreset preset)
        {
            Config.loadPreset(preset);
        }

        private void init()
        {
            this.folder = Path.GetDirectoryName(path);
            this.execfolder = this.folder;
            this.installFXfolder = this.folder;
            this.special_folder = this.folder;
            foreach (String s in Directory.GetDirectories(this.folder))
            {
                if (s.ToLower() == "bin" || s.ToLower() == "bin32")
                {
                    this.special_folder = Path.Combine(this.folder, s);
                }
            }
            checkActive();
            loadPresets();
        }

        public gameEntry(String path)
        {
            this.path = path;
            this.shortName = findShortName(path);
            init();
        }

        private String findShortName(String path)
        {
            String sname = "";
            FileVersionInfo data = FileVersionInfo.GetVersionInfo(path);
            sname = data.ProductName;
            if (sname == null || sname.Trim() == "") sname = Path.GetFileName(path);
            return sname;
        }

        public bool checkActive()
        {

            String installed = this.getPathFor(check_for_active_file);
            String settingsfile = getPathFor(setting_config);
            String injectfile = getPathFor(setting_injector);
            if (File.Exists(installed))
            {
                if (!isActivated)
                {
                    if (File.Exists(settingsfile)) this.Config = new sweetConfig(settingsfile);
                    if (File.Exists(injectfile)) injectordata = new injector(injectfile);
                }
                isActivated = true;
            }
            else
            {
                isActivated = false;
                injectordata = null;
                Config = null;
            }
            return isActivated;
        }

        private String getPathFor(String file)
        {
            logger.debug("Checking path for " + file);
            if (special_install && special_files.Contains(file))
            {
                String nfile = Path.Combine(special_folder, file);
                logger.debug("Returning file changed to " + nfile);
                return nfile;
            }
            return Path.Combine(this.installFXfolder, file);
        }

        private void removeRecursive(String source, String[] exceptions)
        {
            List<String> files = common.getRelativeFileList(source, "");
            foreach (String f in files)
            {
                if (!exceptions.Contains(f))
                {
                    String file = getPathFor(f);
                    File.Delete(file);
                }
            }
            List<String> folders = common.getFolderList(source, "");
            foreach (String f in folders)
            {
                String folder = getPathFor(f);
                if (Directory.GetFiles(folder).Count() == 0)
                {
                    try
                    {
                        Directory.Delete(folder);
                    }
                    catch (Exception e)
                    {
                        logger.info("Removing SweetFX : Could not remove dir " + f);
                        logger.debug("Remove error : " + e.ToString());
                    }
                }
            }
        }

        private void copyRecursive(String source)
        {
            List<String> files = common.getRelativeFileList(source, "");
            List<String> folders = common.getFolderList(source, "");
            foreach (String f in folders)
            {
                String target = getPathFor(f);
                Directory.CreateDirectory(target);
            }
            foreach (String f in files)
            {
                String target = getPathFor(f);
                try
                {
                    File.Copy(Path.Combine(source, f), target);
                }
                catch (Exception e)
                {
                    logger.info("Installing SweetFX : Could not copy file " + f);
                    logger.debug("Copy error : " + e.ToString());
                }
            }
        }

        public void removeSweetFX()
        {
            if (isActivated)
            {
                string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
                String[] exc = { setting_config, setting_injector };
                removeRecursive(Path.Combine(baseFolder, Form1.sweetfx_folder), exc);
            }
            checkActive();
        }

        public void launchGame()
        {
            System.Diagnostics.ProcessStartInfo starter = new System.Diagnostics.ProcessStartInfo(this.path);
            starter.WorkingDirectory = execfolder;
            starter.Arguments = runArgs;
            System.Diagnostics.Process.Start(starter);
        }

        public bool installSweetFX()
        {
            if (!isActivated)
            {
                string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
                copyRecursive(Path.Combine(baseFolder, Form1.sweetfx_folder));
            }
            return checkActive();
        }

        public override string ToString()
        {
            String r;
            if (this.shortName.Length > 19)
            {
                r = this.shortName.Substring(0, 19);
            }
            else
            {
                r = this.shortName.PadRight(19);
            }
            if (isActivated)
            {
                r = r + " Active";
            }
            else
            {
                r = r + " Not active";
            }
            if (Config != null)
            {
                r = r + " (" + Config.configVersion.ToString() + ")";
            }
            return r;
        }

        internal void createPreset(string presetName)
        {
            if (Config != null)
            {
                configPreset preset = new configPreset(presetName, this);
                presets.Add(preset);
            }
        }

        internal void deletePreset(configPreset preset)
        {
            if (presets.Contains(preset))
            {
                preset.removeFile();
                presets.Remove(preset);
            }
        }
    }
}
