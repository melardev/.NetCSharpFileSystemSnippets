using System;

namespace FileSystemSnippets
{
    class PathCombineSnippet
    {
        public static void Launch()
        {
            string appFolder = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                ".NetCSharpFileSystemSnippets");

            Console.WriteLine("Application Folder: {0}", appFolder);
        }
    }
}