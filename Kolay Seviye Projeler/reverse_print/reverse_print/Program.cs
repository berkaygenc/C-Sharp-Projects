using System;

namespace reverse_print
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle girin: ");
            string cumle = Console.ReadLine();
            Console.WriteLine(Reverse(cumle));
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
