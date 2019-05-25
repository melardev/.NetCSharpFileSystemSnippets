using System;
using System.IO;

namespace FileSystemSnippets
{
    class GetDrivesSnippet
    {
        public static void Launch()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
            {
                Console.Out.WriteLine("Volume {0}", driveInfo.Name);
                Console.Out.WriteLine($"Format: {driveInfo.DriveFormat}" +
                                      $"\n\tLabel: {driveInfo.VolumeLabel}" +
                                      $"\n\tDrive Type: {driveInfo.DriveType.ToString()}" +
                                      $"\n\tFree Space: {driveInfo.AvailableFreeSpace}" +
                                      $"\n\tTotal Space: {driveInfo.TotalSize}"
                );
            }
        }
    }
}