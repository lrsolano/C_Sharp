using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Files
{
    class Caminho
    {
        public static void AulaPath()
        {
            var caminho = @"c:\temp\test.txt";

            
            Console.WriteLine("Extension: " + Path.GetExtension(caminho));
            Console.WriteLine("File Name: " + Path.GetFileName(caminho));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(caminho));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(caminho));



        }
    }
}
