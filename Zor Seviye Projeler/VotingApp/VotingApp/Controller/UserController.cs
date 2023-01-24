using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Data;

namespace VotingApp.Controller
{
    public class UserController:User
    {
        public void LoginUser()
        {
            Console.Write("\nKullanıcı adı: ");
            Username = Console.ReadLine();
            Console.Write("Şifre: ");
            Password = Console.ReadLine();
            
            User kullanici = getUserByUserId(Username,Password);

            if (kullanici != null)
            {
                if (kullanici.Password == Password)
                {
                    Console.WriteLine("Hoşgeldiniz " + kullanici.Username+"\n");
                    Category category = new Category();
                    category.Votes();
                }

                else
                    Console.WriteLine("Yanlış");
            }
            else
            {
                Console.WriteLine("Girdiğiniz bilgiler yanlış veya üyeliğiniz bulunmamaktadır.");
                Console.WriteLine("\nYapmak istediğiniz işlemi seçin:" +
                                  "\n1) Tekrar giriş yapmak için" +
                                  "\n2) Üye olmak için");
                int secim = int.Parse(Console.ReadLine());
                if(secim==1)
                    LoginUser();
                if (secim == 2)
                {
                    Add();
                    LoginUser();
                }

            }

        }


    }
}
