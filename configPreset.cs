using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IniParser;
using System.IO;

namespace WindowsFormsApplication1
{
    public class configPreset
    {
        String path;

        public static string presetFolder = "config_presets";
        public static string fxpresetsFolder = "config_presets2";


        public String name;
        String description = "";

        IniParser.FileIniDataParser parser = new FileIniDataParser();
        public IniData parsedData = new IniData();

        public configPreset(String path)
        {
            setupINI();
            this.path = path;
            loadPreset();
        }

        public void updateFromConfig(sweetConfig conf)
        {
            foreach (sweetConfig.FXSetting s in conf.FXSettings)
            {
                parsedData["setting"].AddKey(s.name);
                parsedData["setting"][s.name] = s.value;
            }
            savePreset();
        }

        public String getValueOf(string setting)
        {
            return parsedData["setting"][setting];
        }

        private void setupINI()
        {
            parsedData.Sections.AddSection("preset");
            parsedData.Sections.AddSection("setting");
        }

        public override string ToString()
        {
            return this.name;
        }

        public configPreset(String name, gameEntry game, sweetConfig config)
        {
            initConfigPreset(name, game, config);
        }

        public configPreset(String name, gameEntry game)
        {
            initConfigPreset(name, game, game.Config);
        }

        public void initConfigPreset(String name, gameEntry game, sweetConfig config)
        {
            this.name = name;
            setupINI();

            path = Path.Combine(game.folder, Form1.sweetfxFolderName);
            path = Path.Combine(path, presetFolder);
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string basename = "preset";
            int i = 0;

            String filename = Path.Combine(path, basename + i.ToString() + ".ini");

            while (File.Exists(filename)) {
                i++;
                filename = Path.Combine(path, basename + i.ToString() + ".ini");
            }
            path = filename;

            updateFromConfig(config);
        }

        private void loadPreset()
        {
            parsedData = parser.LoadFile(path);
            name = parsedData["preset"]["name"];
            description = parsedData["preset"]["description"];
        }

        public void savePreset()
        {
            parsedData["preset"].AddKey("name");
            parsedData["preset"].AddKey("description");
            parsedData["preset"]["name"] = name;
            parsedData["preset"]["description"] = description;
            parser.SaveFile(path, parsedData);
        }

        internal bool haveSetting(string p)
        {
            return parsedData["setting"].ContainsKey(p);
        }

        internal void removeFile()
        {
            File.Delete(path);
            path = ":"; // should cause an exception instead of recreating file if save wrongly called
        }
    }
}
