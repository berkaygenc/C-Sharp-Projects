using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Data
{
    public class Category
    {
        private int id;
        private string categoryname;
        private int votepoint;

        public int Id { get => id; set => id = value; }
        public string Categoryname { get => categoryname; set => categoryname = value; }
        public int VotePoint { get => votepoint; set => votepoint = value; }

        public static List<Category> categoryList = new List<Category>()
            {
                new Category(){Id=1,Categoryname="Film"},
                new Category(){Id=2,Categoryname="Tech Stack"},
                new Category(){Id=3,Categoryname="Spor"},
             };


        public void Votes()
        {
            Console.WriteLine("Lütfen oylamanızı 0 ile 10 üzerinden puanlıyın ! ");


            foreach (var item in categoryList)
            {
                tekrar:
                Console.Write(item.id + " - " + item.categoryname + " = ");
                int puan = int.Parse(Console.ReadLine());
                if (puan > 0 && puan <= 10)
                    item.votepoint = puan;
                else
                {
                    Console.WriteLine("Lütfen 0-10 arasında bir değer giriniz1");
                    goto tekrar;
                }
            }
            Console.WriteLine(" \n Oylanama Sonuçları ; \n ");

            foreach (var item in categoryList)
            {
                Console.Write(item.id + " - " + item.categoryname + " = ");
                Console.Write(" % " + item.votepoint * 10 + "\n");

            }
        }
    }
}
