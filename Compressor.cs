using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace JPG_Compressor
{
    class Compressor
    {
        //It's a simple function that converts most image formats to Jpeg
        public void ConvertToJPG(string inputImageAddress, string outputAddress)
        {
            using (Image inputImage = Image.FromFile(inputImageAddress))
            {
                inputImage.Save(outputAddress, ImageFormat.Jpeg);
            }
        }
    }
}
