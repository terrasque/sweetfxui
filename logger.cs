using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public static class logger
    {
        private static System.IO.StreamWriter file;
        public enum loglevel {DEBUG=1, INFO, WARNING, ERROR};

        public static void log(String text, loglevel level)
        {
            //if (level >= logginglevel) 
            file.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + " | " + level.ToString() + " | " + text);
            file.Flush();
        }

        public static void setLogfile(String bla) {
            logger.file = new System.IO.StreamWriter(bla);
        }

        public static void debug(String text)
        {
            log(text, loglevel.DEBUG);
        }

        public static void info(String text)
        {
            log(text, loglevel.INFO);
        }
    }
}
