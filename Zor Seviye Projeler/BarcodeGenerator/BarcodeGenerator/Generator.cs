using BarcodeLib;
using System;
using System.Text.Json;

namespace BardocodeGenerator
{
    class Generator
    {
        static TYPE type = TYPE.PHARMACODE;
        public static Barcode CreateAndSaveBarcode(string data)
        {
            Barcode barcode = new Barcode(data, type);
            barcode.Encode(type, data);
            barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barkod oluşturuldu");
            return barcode;
        }
        public static string ReadBarcode(Barcode barcode)
        {
            return "Barkod değeri = " + barcode.RawData + " \n";
        }
    }
}