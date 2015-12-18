﻿using System;
using System.Drawing;
using System.IO;

namespace PreStickerize
{
    class Conversion
    {

        public static void folderLevelConversion(string folder)
        {
 
            string[] files = Directory.GetFiles(folder);


            foreach (string file in files)
            {
                try
                {
                    singleFileConversion(file);
                    
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("some shit happened with that ===> " + Path.GetFileNameWithoutExtension(file));
                }
                

            }
            Console.WriteLine("done");
        }


        public static void singleFileConversion(string file)
        {
    
            Image fileImage = Image.FromFile(file);
            Console.WriteLine("Converting " + Path.GetFileName(file));

            imageResizer(fileImage, Path.GetDirectoryName(file) + "\\ConvertedImages", Path.GetFileNameWithoutExtension(file));

            Console.WriteLine("Converted !");

        }


        public static void imageResizer(Image image, string folder, string name)
        {
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            if (imageWidth > imageHeight)
            {
                imageWidth = imageWidth - (imageWidth - 512);

                if ( imageHeight - (image.Width - 512) <= 0 )
                {
                    imageHeight = imageHeight - (imageHeight - 512);
                }
                else
                {
                    imageHeight = imageHeight - (image.Width - 512);
                }
            }
            else if(imageHeight > imageWidth)
            {
                imageHeight = imageHeight - (imageHeight - 512);

                if (imageWidth - (image.Height - 512) <= 0 )
                {
                    imageWidth = imageWidth - (imageWidth - 512);
                }
                else
                {
                    imageWidth = imageWidth - (image.Height - 512);
                }
            }
            else if(image.Width == image.Height)
            {
                imageWidth = imageWidth - (imageWidth - 512);
                imageHeight = imageHeight - (imageHeight - 512);
            }
   
            try
            {
                Bitmap imageBitmap = new Bitmap(image, new Size(imageWidth, imageHeight));
                Image compressedImage = Compression.compress(imageBitmap);
                compressedImage.Save(folder + "\\" + name + "_PNG.png");
            }
            catch (Exception)
            {

                Console.WriteLine(imageWidth + " " + imageHeight);
            }
        }
    }
}