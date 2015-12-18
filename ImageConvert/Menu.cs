using System;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace PreStickerize
{
     
    class Menu
    {
        
        static void Main(string[] args)
        {
            string path = Path.GetFullPath(args[0]);
            
            if (path.Contains("."))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path) + "\\ConvertedImages");
                Conversion.singleFileConversion(path);
            }
            else
            {
                Directory.CreateDirectory(path + "\\ConvertedImages");
                Conversion.folderLevelConversion(path);
            }

            Console.ReadLine();
        }
    }
}
