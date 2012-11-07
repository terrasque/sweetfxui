using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IniParser;

namespace WindowsFormsApplication1
{
    public class injector
    {
        String path;
        IniParser.FileIniDataParser parser = new FileIniDataParser();
        public IniData parsedData;

        public injector(String path)
        {
            this.path = path;
            
            parsedData = parser.LoadFile(path);
        }

        public void writeIni()
        {
            parser.SaveFile(path, parsedData);
        }
    }
}
