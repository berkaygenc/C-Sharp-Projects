using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_area_calculation.Shapes
{
    public class Circle:GeometricShapes
    {
        private double radius;
        private double piNumber=3.14;

        public void CalculateArea()
        {

            Console.Write("Yarıçapını giriniz: ");
            radius = double.Parse(Console.ReadLine());

            if (radius <= 0)
                Console.WriteLine("eksi yarıçap olamaz");
            Area = piNumber * (radius * radius);
            Console.WriteLine("Dairenin Alanı: " + Area);
        }

        public void CalculatePerimeter()
        {
            Console.Write("Yarıçapını giriniz: ");
            radius = double.Parse(Console.ReadLine());

            if (radius <= 0)
                Console.WriteLine("eksi yarıçap olamaz");
            else
                Perimeter = 2 * piNumber * radius;

            Console.WriteLine("Dairenin Çevresi: " + Perimeter);
        }
    }
}
