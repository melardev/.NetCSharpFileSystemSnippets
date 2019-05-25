using System;
using System.IO;

namespace FileSystemSnippets
{
    class DirInfoGetFilesGlob
    {
        public static void Launch()
        {
            DirectoryInfo windowsDirInfo = new DirectoryInfo(@"C:\Windows");

            FileInfo[] executables = windowsDirInfo.GetFiles("*.exe");

            Console.WriteLine("Found {0} executables", executables.Length);
            foreach (FileInfo pngImage in executables)
            {
                Console.WriteLine("Image Found at {0}; Size: {1}",
                    pngImage.FullName,
                    pngImage.Length);
            }

            Console.WriteLine("Finished enumeration");
        }
    }
}