using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.Controller
{
    public class UserController : User
    {
        public User LoginUser()
        {
                Console.Write("\nKullanıcı adı: ");
                Username = Console.ReadLine();
                Console.Write("Şifre: ");
                Password = Console.ReadLine();
                User kullanici = getUserByUserId(Username, Password);

                if (kullanici != null)
                {
                        Console.WriteLine("Hoşgeldiniz " + kullanici.Username + "\n");
                        return kullanici;
                }
                else
                {
                    return null;
                }
        }

    }

}
