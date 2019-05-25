using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace FileSystemSnippets
{
    class GetFileOwner
    {
        private static string GetFileOwnerName(string path)
        {
            FileSecurity fileSecurity = File.GetAccessControl(path);
            IdentityReference identityReference = fileSecurity.GetOwner(typeof(SecurityIdentifier));
            NTAccount ntAccount = identityReference.Translate(typeof(NTAccount)) as NTAccount;
            return ntAccount.Value;
        }

        public static void Launch()
        {
            string path = "C:\\Windows\\system32\\calc.exe";
            Console.WriteLine("{0}: {1}", path, GetFileOwnerName(path));
        }
    }
}