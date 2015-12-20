using System;

//It's a simple project that converts most image formats to jpeg using System.Drawing and System.Drawing.Imaging .

namespace JPG_Compressor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input image address: (like pic.bmp)");
            string inputImageAddress = Console.ReadLine();
            Console.WriteLine("Enter output address:");
            string outputAddress = Console.ReadLine();
            Compressor compressor = new Compressor();
            compressor.ConvertToJPG(inputImageAddress, outputAddress);
        }
    }
}
