using System;
using System.IO;

namespace FileSystemSnippets
{
    class IsPathRootedUsage
    {
        public static void Launch()
        {
            string[] paths = {@"C:\Windows", "Desktop/Images", "D:/Temp", "C:\\Program Files"};
            foreach (string path in paths)
            {
                bool isAbsolute = Path.IsPathRooted(path);
                Console.WriteLine("'{0}' Is Absolute? {1}", path, isAbsolute);
            }
        }
    }
}