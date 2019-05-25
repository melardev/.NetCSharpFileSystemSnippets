using System;
using System.IO;

namespace FileSystemSnippets
{
    class FileInfoUsage
    {
        public static void Launch()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Windows\System32\calc.exe");
            Console.WriteLine("Info for {0}", fileInfo.FullName);
            Console.WriteLine("Filename {0}", fileInfo.Name);
            Console.WriteLine("Dir Name {0}", fileInfo.DirectoryName);
            Console.WriteLine("Creation time for parent folder {0} ", fileInfo.Directory.CreationTimeUtc);
            Console.WriteLine("Last Access Time at {0}", fileInfo.LastAccessTimeUtc);
            Console.WriteLine("Created at {0}", fileInfo.CreationTimeUtc);
            Console.WriteLine("Accessed at {0}", fileInfo.LastAccessTimeUtc);
        }
    }
}