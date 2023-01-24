using System;
using VotingApp.Controller;
using VotingApp.Data;

namespace VotingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserController userController = new UserController();
            Category category = new Category();
            Console.WriteLine("Lütfen oylamaya katılabilmek için giriş yapınız.");
            userController.LoginUser();

        }
    }
}
