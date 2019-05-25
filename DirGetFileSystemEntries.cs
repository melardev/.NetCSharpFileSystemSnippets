using System;
using System.IO;

namespace FileSystemSnippets
{
    class DirGetFileSystemEntries
    {
        public static void Launch()
        {
            string[] files = Directory.GetFileSystemEntries(@"D:\");
            foreach (var file in files)
            {
                Console.Out.WriteLine(file);
            }
        }
    }
}