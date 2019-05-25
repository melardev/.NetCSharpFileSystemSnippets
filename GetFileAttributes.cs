using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystemSnippets
{
    class GetFileAttributes
    {
        public static void Launch()
        {
            string[] paths = {@"C:\Windows\System32\calc.exe", "C:/Windows", "C:\\"};

            foreach (var path in paths)
            {
                FileAttributes fileAttributes = File.GetAttributes(path);
                List<string> attributes = new List<string>();
                Console.Write("{0} -> ", path);
                if ((fileAttributes & FileAttributes.Archive) == FileAttributes.Archive)
                    attributes.Add("Archive");
                if ((fileAttributes & FileAttributes.Compressed) == FileAttributes.Compressed)
                    attributes.Add("Compressed");
                if ((fileAttributes & FileAttributes.Device) == FileAttributes.Device)
                    attributes.Add("Device");
                if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                    attributes.Add("Directory");
                if ((fileAttributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
                    attributes.Add("Encrypted");
                if ((fileAttributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    attributes.Add("Hidden");
                if ((fileAttributes & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed)
                    attributes.Add("NotContentIndexed");
                if ((fileAttributes & FileAttributes.Offline) == FileAttributes.Offline)
                    attributes.Add("Offline");
                if ((fileAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    attributes.Add("ReadOnly");
                if ((fileAttributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint)
                    attributes.Add("ReparsePoint");
                if ((fileAttributes & FileAttributes.SparseFile) == FileAttributes.SparseFile)
                    attributes.Add("SparseFile");
                if ((fileAttributes & FileAttributes.System) == FileAttributes.System)
                    attributes.Add("System");
                if ((fileAttributes & FileAttributes.Temporary) == FileAttributes.Temporary)
                    attributes.Add("Temporary");


                Console.WriteLine(string.Join(" | ", attributes));
            }
        }
    }
}