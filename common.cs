using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    public static class common
    {
        public static List<String> getRelativeFileList(String directory, String subdir)
        {
            String workingdir = Path.Combine(directory, subdir);
            List<String> files = new List<string>();
            String[] dirs = Directory.GetDirectories(workingdir);
            foreach (String s in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(s);
                files.AddRange(getRelativeFileList(directory, Path.Combine(subdir, di.Name)));
            }
            foreach (String f in Directory.GetFiles(workingdir)) {
                files.Add(Path.Combine(subdir, Path.GetFileName(f)));
            }
            return files;
        }

        public static List<String> getFolderList(String directory, String subdir)
        {
            String workingdir = Path.Combine(directory, subdir);
            List<String> directories = new List<string>();
            String[] dirs = Directory.GetDirectories(workingdir);
            foreach (String s in dirs)
            {
                DirectoryInfo di = new DirectoryInfo(s);
                String nowpath = Path.Combine(subdir, di.Name);
                directories.AddRange(getFolderList(directory, nowpath));
                directories.Add(nowpath);
            }
            return directories;
        }
    }
}
