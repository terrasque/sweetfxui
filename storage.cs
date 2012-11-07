using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using IniParser;

namespace WindowsFormsApplication1
{
    public class storage
    {
        public String storageFile;
        public List<gameEntry> games = new List<gameEntry>();

        IniData parsedData = new IniData();
        FileIniDataParser parser = new FileIniDataParser();

        public storage(String iniFile)
        {
            this.storageFile = iniFile;
            loadSettings();
        }

        public void loadSettings()
        {
            if (!File.Exists(storageFile))
            {
                logger.debug("Ini file not found");
                return;
            }
            parsedData = parser.LoadFile(storageFile);
            foreach (SectionData section in parsedData.Sections)
            {
                if (section.SectionName.StartsWith("game:"))
                {
                    gameEntry newGame = new gameEntry(section.Keys["exec"], section.Keys["name"]);
                    if (section.Keys.ContainsKey("args")) newGame.runArgs = section.Keys["args"];
                    if (section.Keys.ContainsKey("specialfolder")) newGame.special_subfolder = section.Keys["specialfolder"];
                    if (section.Keys.ContainsKey("special")) newGame.special_install = section.Keys["special"] == "1" ? true:false ;
                    games.Add(newGame);
                }
            }
        }

        public bool loadGamesFromFile(String storageFile)
        {
            // Old way of saving games
            if (File.Exists(storageFile))
            {
                string[] lines = System.IO.File.ReadAllLines(storageFile);
                foreach (string l in lines)
                {
                    if (l.Contains("|"))
                    {
                        addGame(l.Split('|')[0], l.Split('|')[1]);
                    } else addGame(l);
                }
            }
            return false;
        }

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private void addValue(String section, String key, String value)
        {
            parsedData.Sections.AddSection(section);
            parsedData[section].AddKey(key);
            parsedData[section][key] = value;
        }

        public void saveSettings()
        {
            foreach (gameEntry g in games)
            {
                String section = "game:" + CalculateMD5Hash(g.path);
                addValue(section, "exec", g.path);
                addValue(section, "name", g.shortName);
                addValue(section, "args", g.runArgs);
                addValue(section, "specialfolder", g.special_subfolder);
                addValue(section, "special", g.special_install ? "1" : "0");
            }
            parser.SaveFile(storageFile, parsedData);
        }
        public void removeGame(gameEntry entry)
        {
            games.Remove(entry);
            String section = "game:" + CalculateMD5Hash(entry.path);
            parsedData.Sections.RemoveSection(section);
            saveSettings();
        }
        public void addGame(String filePath)
        {
            games.Add(new gameEntry(filePath));
            saveSettings();
        }

        public void addGame(String filePath, String name)
        {
            games.Add(new gameEntry(filePath, name));
            saveSettings();
        }

        public List<gameEntry> getGames() {
            return this.games;
        }
    }
}
