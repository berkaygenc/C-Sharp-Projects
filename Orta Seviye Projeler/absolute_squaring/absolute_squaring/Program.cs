using System;

namespace absolute_squaring
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boşluk bırakarak sayılar girin : ");
            string input = Console.ReadLine();

            string[] strings = input.Split();

            int[] numbers = new int[strings.Length];

            int sumofDifferences = 0;
            double absoluteSquaring = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                int x = int.Parse(strings[i]);
                numbers[i] = x;

                if (numbers[i] <= 67)
                {
                    sumofDifferences += 67 - numbers[i];
                    Console.WriteLine("Küçük olanların farklarının toplamı :" + sumofDifferences);
                }
                else
                {
                    absoluteSquaring += Math.Pow((numbers[i] - 67), 2);
                    Console.WriteLine("Büyük olanların farkların mutlak karelerini alarak toplamı : " + absoluteSquaring);
                }

            }
        }
    }
}
