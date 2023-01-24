using Microsoft.VisualBasic;
using System;
using System.Collections;

namespace Sum_of_Integer_Binaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n tane ikili sayı girin");
            string input= Console.ReadLine();

            string[] pairs = input.Split();
            int[] ints = Array.ConvertAll(pairs, int.Parse);
            int sumofDifferences = 0;


            foreach (int item in ints)
            {
                if (item < 67)
                {
                    sumofDifferences += 67 - ints[item];
                    Console.WriteLine(" 67'den Küçük olanların farklarının toplamı :" + sumofDifferences);
                }
              
            }

           
          



        }
    }
}
