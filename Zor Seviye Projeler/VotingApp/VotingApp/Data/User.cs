using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Data
{
    public class User
    {
        private int id;
        private string email;
        private string username;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }



        public static List<User> userList = new List<User>()
            {
                new User(){Id=1,Username="berkaygnc",Password="berkay123" },
                new User(){Id=2,Username="zikriye",Password="zikriye123" },
            };

        public User getUserByUserId(string username,string password)
        {
            return userList.Find(x => x.username == username && x.password==password);
        }

        public void Add()
        {
            User newUser = new User();
            Console.Write("E-posta: ");
            newUser.Email = Console.ReadLine();
            Console.Write("Kullanıcı Adı: ");
            newUser.Username = Console.ReadLine();
            Console.Write("Şifre: ");
            newUser.Password = Console.ReadLine();

            userList.Add(newUser);
        }

    }
}
