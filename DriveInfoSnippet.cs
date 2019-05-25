using System;

namespace FileSystemSnippets
{
    class DriveInfoSnippet
    {
        public static void Launch()
        {
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");
            Console.WriteLine("Name: {0}", di.Name);
            Console.WriteLine("RootDirectory: {0}", di.RootDirectory);
            Console.WriteLine("DriveType: {0}", di.DriveType);
            Console.WriteLine("Drive Format: {0}", di.DriveFormat);
            Console.WriteLine("Volume Label: {0}", di.VolumeLabel);
        }
    }
}