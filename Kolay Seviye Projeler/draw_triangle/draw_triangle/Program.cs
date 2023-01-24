using System;

namespace draw_triangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Çizmek istediğiniz üçgenin boyutunu girin: ");
            int boyut = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < boyut; i++)
            {
                for (int k = i; k < boyut; k++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("^");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
