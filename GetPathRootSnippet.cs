using System;
using System.IO;

namespace FileSystemSnippets
{
    class GetPathRootSnippet
    {
        public static void Launch()
        {
            // Just for curiosity, when you do new DriveInfo(path)
            // DriveInfo internally uses GetPathRoot to retrieve the path root he is gonna be using

            string[] paths = new string[] {@"C:\\", @"D:/Images", "C:/Users/MelarDev", ".", "/", ".\\"};

            foreach (string path in paths)
            {
                string rootPath = Path.GetPathRoot(path);
                Console.WriteLine("Path: {0}\nPath Root: {1}\n\n", path, rootPath);
            }
        }
    }
}