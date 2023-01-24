using System;

namespace fibonacci_average_calculate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Lütfen derinlik girin: ");
            int input = int.Parse(Console.ReadLine());
            double avg = AvgCalc(SumCalc(FibonacciCalc(input)), input);
            Console.WriteLine("Fibonacci serisinin ortalaması: " + avg);
        }
        public static int SumCalc(Array array)
        {
            int sum =0;
            foreach (int item in array)
            {
                sum=sum+item;
            }
            return sum;
        }
        public static double AvgCalc(double sum,double depth)
        {
           double avg=sum/depth;
           return avg;
        }
        public static Array FibonacciCalc(int depth)
        {
            int a, b = 1, result = 0;
            int[] fibonacci=new int[depth];

            for (int i = 0; i < depth; i++)
            {
                a = b;
                b = result;
                result = a + b;
                fibonacci[i] = result;
            }
            return fibonacci ;
        }
    }
    
}
