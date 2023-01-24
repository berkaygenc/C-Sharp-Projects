using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_area_calculation.Shapes
{
    public class Square:GeometricShapes
    {
        private int side;

        public int Side { get => side; set => side = value; }

        public void CalculateArea()
        {
            Console.Write("Kenar giriniz: ");
            side = int.Parse(Console.ReadLine());

            Area = side*side;
            Console.WriteLine("Karenin Alanı: " + Area);
        }

        public void CalculatePerimeter()
        {
            Console.Write("Kenar giriniz: ");
            side = int.Parse(Console.ReadLine());

            Perimeter = side*4;
            Console.WriteLine("Karenin Çevresi: " + Perimeter);
        }
    }
}
