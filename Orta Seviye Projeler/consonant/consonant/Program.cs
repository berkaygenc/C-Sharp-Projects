using System;
using System.Linq;

namespace consonant
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümle girin");
            string cumle = Console.ReadLine();
            foreach (var item in cumle.Split())
            {
                bool def = false;
                for (int i = 1; i < item.Length; i++)
                {
                    if (sessizMi(item[i]) == sessizMi(item[i - 1]))
                        def = true;
                }
                Console.Write(def + " ");
            }

        }

        static bool sessizMi(char c)
        {
            return !"aeıioöuü".ToCharArray().Contains(c);
        }
    }
}
