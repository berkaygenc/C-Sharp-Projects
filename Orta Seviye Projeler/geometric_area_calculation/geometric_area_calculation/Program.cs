using geometric_area_calculation.Shapes;
using System;

namespace geometric_area_calculation
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Geometrik Şekiller: " +
                                "\n1) Daire" +
                                "\n2) Üçgen" +
                                "\n3) Kare" +
                                "\n4) Dikdörtgen");

            Console.Write("Şekil seçiniz: ");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:{
                        Circle circle = new Circle();
                        if ( SelectinCalc() == 1)
                            circle.CalculateArea(); 
                        else
                            circle.CalculatePerimeter(); break;}

                case 2:
                    {
                        Triangle triangle = new Triangle();
                        if (SelectinCalc() == 1)
                            triangle.CalculateArea();
                        else
                            triangle.CalculatePerimeter(); break;
                    }
                case 3:
                    {
                        Square square = new Square();
                        if (SelectinCalc() == 1)
                            square.CalculateArea();
                        else
                            square.CalculatePerimeter(); break;
                    }
                case 4:
                    {
                        Rectangle rectangle = new Rectangle();
                        if (SelectinCalc() == 1)
                            rectangle.CalculateArea();
                        else
                            rectangle.CalculatePerimeter(); break;
                    }
                default:
                    break; 
            }

        }

        public static int SelectinCalc()
        {
            Console.WriteLine("İşlem Seçin: " +
                                "\n1) Alan Hesapla" +
                                "\n2) Çevre Hesapla");
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
