using System;
using System.Collections.Generic;
using System.Linq;

namespace FileSystemSnippets
{
    class SpecialFolders
    {
        public static void Launch()
        {
            IEnumerable<Environment.SpecialFolder> specialFolders =
                Enum.GetValues(typeof(Environment.SpecialFolder)).Cast<Environment.SpecialFolder>();

            foreach (Environment.SpecialFolder specialFolder in specialFolders)
            {
                Console.WriteLine("{0}: {1}", specialFolder, Environment.GetFolderPath(specialFolder));
            }
        }
    }
}