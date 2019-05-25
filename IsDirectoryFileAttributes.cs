using System;
using System.Diagnostics;
using System.IO;

namespace FileSystemSnippets
{
    class IsDirectoryFileAttributes
    {
        public static void Launch()
        {
            string path = @"C:\Windows";
            try
            {// attributes.HasFlag(FileAttributes.Directory);
                FileAttributes attributes = File.GetAttributes(path);
                if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                }
                else
                {
                    Debug.WriteLine("{0} Is not a directory");
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Error trying to retrieve attributes on {0}\n{1}",
                    path, exception.ToString());
            }
        }
    }
}