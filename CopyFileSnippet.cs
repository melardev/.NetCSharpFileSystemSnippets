using System;
using System.IO;

namespace FileSystemSnippets
{
    class CopyFileSnippet
    {
        public static void Launch()
        {
            string calcSrc = @"C:\Windows\system32\calc.exe";
            if (File.Exists(calcSrc))
            {
                try
                {
                    System.IO.File.Copy(calcSrc, Path.GetFullPath("./calc.exe"),
                        true /*Overwrite if a file with that name exists*/);
                    Console.WriteLine("File copied successfully to {0}", Path.GetFullPath("./calc.exe"));
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Error: {0}", exception);
                }
            }
        }
    }
}