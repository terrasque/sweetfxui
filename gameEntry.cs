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
        public bool isActivated = false;
        public sweetConfig Config;
        public injector injectordata;
        private static String setting_config = "SweetFX_settings.txt";
        private static String setting_injector = "injector.ini";
        private static String check_for_active_file = "d3d9.dll";

        private static String[] special_files = { "dxgi.dll", "injector.ini", "d3d9.dll" };

        public Boolean special_install = false;
        public String special_subfolder = "bin";

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

            String installed = Path.Combine(folder, this.getSubPathFor(check_for_active_file));
            String settingsfile = Path.Combine(folder, getSubPathFor(setting_config));
            String injectfile = Path.Combine(folder, getSubPathFor(setting_injector));
            if (File.Exists(installed))
            {
                if (!isActivated) {
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

        private String getSubPathFor(String file)
        {
            logger.debug("Checking path for "+ file);
            if (special_install && special_files.Contains(file))
            {
                String nfile = Path.Combine(special_subfolder, file);
                logger.debug("Returning file changed to " + nfile);
                return nfile;
            }
            return file;
        }

        private void removeRecursive(String source, String destination, String[] exceptions)
        {
            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);
            String[] dirs = Directory.GetDirectories(source);

            foreach (String dir in dirs)
            {
                String dname = new DirectoryInfo(dir).Name;
                removeRecursive(Path.Combine(source, dname), Path.Combine(destination, dname), exceptions);
            }

            string[] files = Directory.GetFiles(source);
            foreach (string f in files)
            {
                string sourceName = Path.GetFileName(f);
                sourceName = getSubPathFor(sourceName);
                string target = Path.Combine(destination, sourceName);
                //File.Copy(f, target, true);
                if (!exceptions.Contains(sourceName)) {
                    File.Delete(target);
                }
            }
        }

        private void copyRecursive(String source, String destination)
        {
            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);
            String[] dirs = Directory.GetDirectories(source);
            
            foreach (String dir in dirs) {
                String dname = new DirectoryInfo(dir).Name;
                copyRecursive(Path.Combine(source, dname), Path.Combine(destination, dname));
            }

            string[] files = Directory.GetFiles(source);
            foreach (string f in files)
            {
                string sourceName = Path.GetFileName(f);
                sourceName = getSubPathFor(sourceName);
                string target = Path.Combine(destination, sourceName);
                try
                {
                    File.Copy(f, target);
                }
                catch (Exception e)
                {
                    logger.info("Installing SweetFX : Could not copy file " + sourceName);
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
                removeRecursive(Path.Combine(baseFolder, Form1.sweetfx_folder), folder, exc);
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

        public bool installSweetFX() {
            if (!isActivated)
            {
                string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
                copyRecursive(Path.Combine(baseFolder, Form1.sweetfx_folder), folder);
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
