using nQuant;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreStickerize_Interface
{
    class Compression
    {
        static WuQuantizer wuquantizer = new WuQuantizer();

        public static System.Drawing.Image compress(Bitmap bitmapImage)
        {
            System.Drawing.Image compressedImage = wuquantizer.QuantizeImage(bitmapImage);
            return compressedImage;
        }
    }
}
