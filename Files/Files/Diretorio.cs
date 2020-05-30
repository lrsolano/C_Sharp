using System;
using System.IO;

namespace Files
{
    class Diretorio
    {
        public static void AulaDiretorio()
        {
            Directory.CreateDirectory(@"c:\temp");
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\temp","*.*",SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directores = Directory.GetDirectories(@"C:\temp", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directores)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("....");

            var direcoryInfo = new DirectoryInfo("...");
            direcoryInfo.GetFiles();
            direcoryInfo.GetDirectories();
        }
    }
}
