using System;
using System.IO;

namespace FileSystemSnippets
{
    class GetFileNameUsage
    {
        public static void Launch()
        {
            string[] paths =
            {
                @"C:\Windows\System32/calc.exe",
                "./non_existent_dir/non_existent_app.exe",
                "D:\\temp/myFile.txt",
                "C:\\"
            };

            foreach (var path in paths)
            {
                Console.WriteLine(path);
                Console.WriteLine("FileName: {0}", Path.GetFileName(path));
                Console.WriteLine();
            }
        }
    }
}