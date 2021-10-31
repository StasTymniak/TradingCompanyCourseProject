using BLL.Interfaces;
using BLL.Services;
using DAL.ADO.NET;
using DAL.Interfaces;
using DTO;
using System;

namespace courseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Menu.ShowMenu();*/
            IUserRepository userRepository = new UserRepository();
            IServiceAuth serviceAuth = new ServiceAuth(userRepository);
            UserDTO userLogIn = new UserDTO();
            Console.Write("Login: ");
            string enteredEmail = Console.ReadLine();
            Console.Write("Password: ");
            string enteredPass = Console.ReadLine();
            userLogIn = userRepository.LoginData(enteredEmail);
            string userpassDB = userRepository.Get(userLogIn.Id).Password;
            if (serviceAuth.ConfirmPass(enteredPass, userpassDB))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("Wrong Pass");
        }
    }
}

