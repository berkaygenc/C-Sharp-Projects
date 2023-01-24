using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_area_calculation.Shapes
{
    public class Rectangle:GeometricShapes
    {
        private int length;
        private int breadth;

        public void CalculateArea()
        {

            Console.Write("Uzunluk giriniz: ");
            length = int.Parse(Console.ReadLine());

            Console.Write("Genişlik giriniz: ");
            breadth = int.Parse(Console.ReadLine());

            Area = length * breadth;
            Console.WriteLine("Dikdörtgenin Alanı: " + Area);
        }

        public void CalculatePerimeter()
        {

            Console.Write("Uzunluk giriniz: ");
            length = int.Parse(Console.ReadLine());

            Console.Write("Genişlik giriniz: ");
            breadth = int.Parse(Console.ReadLine());

            Perimeter = 2 * (length + breadth);
            Console.WriteLine("Dikdörtgenin Çevresi: " + Perimeter);
        }
    }
}
