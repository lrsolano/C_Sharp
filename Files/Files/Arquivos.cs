using System;
using System.IO;

namespace Files
{
    class Arquivos
    {
        public static void AulaArquivo()
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);


            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...", true);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            
        }
    }
}
