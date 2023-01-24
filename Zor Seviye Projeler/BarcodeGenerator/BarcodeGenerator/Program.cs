using System;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using BarcodeLib;
using BardocodeGenerator;

namespace BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Barcode barcode = Generator.CreateAndSaveBarcode("111");
        }
    }
}
