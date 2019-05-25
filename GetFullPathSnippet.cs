using System;
using System.IO;

namespace FileSystemSnippets
{
    class GetFullPathSnippet
    {
        public static void Launch()
        {
            string[] paths =
            {
                "First",
                "../First",
                @"..\..\First\..\Second",
                "./.././First/./Second",
                "./\\First", @".\\First\\.//.\Second/"
            };

            foreach (string path in paths)
            {
                Console.Out.WriteLine("{0}:\n{1}\n", path, Path.GetFullPath(path));
            }
        }
    }
}