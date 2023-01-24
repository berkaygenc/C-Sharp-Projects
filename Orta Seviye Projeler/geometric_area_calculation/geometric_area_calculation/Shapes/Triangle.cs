using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_area_calculation.Shapes
{
    public class Triangle:GeometricShapes
    {
        private double height;
        private double baseLength;


        public void CalculateArea()
        {
            Console.WriteLine("Yükseklik giriniz:");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Taban giriniz:");
            baseLength = double.Parse(Console.ReadLine());

            Area = height * baseLength;
            Console.WriteLine("Üçgenin Alanı:"+Area);


        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Kenar giriniz:");
            baseLength = double.Parse(Console.ReadLine());

            Perimeter = baseLength*3;
            Console.WriteLine("Üçgenin Çevresi:" + Perimeter);
        }
    }
}
