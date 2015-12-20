using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreStickerize_Interface
{
    class Conversion
    {
    
        public static void imageLoader(string[] files, string folder)
        {

            Parallel.ForEach(files, (file) =>
            {
                try
                {
                    Image fileImage = Image.FromFile(file);

                    imageProcessor(fileImage).Save(folder + "\\" + Path.GetFileNameWithoutExtension(file) + "_PreStickerized.png", ImageFormat.Png );
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("something wrong occurred in attempt to load " + Path.GetFileNameWithoutExtension(file));
                }
                catch (InvalidImageDimensionsException)
                {
                    MessageBox.Show("Error while handling image dimensions");
                }

            }
            
            );
            MessageBox.Show("Done :D");
        }


        public static Image imageProcessor(Image image) 
        {
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            if (imageWidth > imageHeight)
            {
                imageWidth = imageWidth - (imageWidth - 512);

                if (imageHeight - (image.Width - 512) <= 0)
                {
                    imageHeight = imageHeight - (imageHeight - 512);
                }
                else
                {
                    imageHeight = imageHeight - (image.Width - 512);
                }
            }
            else if (imageHeight > imageWidth)
            {
                imageHeight = imageHeight - (imageHeight - 512);

                if (imageWidth - (image.Height - 512) <= 0)
                {
                    imageWidth = imageWidth - (imageWidth - 512);
                }
                else
                {
                    imageWidth = imageWidth - (image.Height - 512);
                }
            }
            else if (image.Width == image.Height)
            {
                imageWidth = imageWidth - (imageWidth - 512);
                imageHeight = imageHeight - (imageHeight - 512);
            }

            try
            {
                Bitmap imageBitmap = new Bitmap(image, new Size(imageWidth, imageHeight));
                return Compression.compress(imageBitmap);
                //compressedImage.Save(folder + "\\" + name + "_PNG.png");
            }
            catch (OutOfMemoryException)
            {
                return image = null;
                throw new InvalidImageDimensionsException();
               
            }

        }
    }
}
