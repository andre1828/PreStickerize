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

        public Bitmap imageProcessor(Image image)
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
                return new Bitmap(image, new Size(imageWidth, imageHeight));
            }
            catch (OutOfMemoryException)
            {
                return null;
                throw new InvalidImageDimensionsException();

            }

        }
    }
}
