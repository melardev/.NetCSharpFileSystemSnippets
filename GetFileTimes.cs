using System;
using System.IO;

namespace FileSystemSnippets
{
    class GetFileTimes
    {
        public static void Launch()
        {
            string path = @"C:\Windows\System32\calc.exe";

            Console.WriteLine($"{path}\n" +
                              $"\tCreation Time: {File.GetCreationTime(path)}\n" +
                              $"\tLast Access Time: {File.GetLastAccessTime(path)}\n" +
                              $"\tLast Write Time: {File.GetLastWriteTime(path)}\n"
            );
        }
    }
}