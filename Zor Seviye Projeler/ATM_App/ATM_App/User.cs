using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private int balance;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Balance { get => balance; set => balance = value; }

        public static List<User> userList = new List<User>()
            {
                new User(){Id=1,Username="berkaygnc",Password="berkay123",Balance=5000 },
                new User(){Id=2,Username="zikriye",Password="zikriye123",Balance=3000 },
            };

        public User getUserByUserId(string username,string password)
        {
            return userList.Find(x => x.username == username && x.password==password);
        }

    }
}
