using BLL.Interfaces;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ServiceAuth : IServiceAuth
    {
        private readonly IUserRepository _userRepository;
        public ServiceAuth(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool ConfirmPass(string enteredPass, string dbString)
        {
            string[] objects = dbString.Split('.');
            int iteration = Convert.ToInt32(objects[0]);
            string salt = objects[1];
            string expectedPass = objects[2];
            string pass = salt + enteredPass;
            if (expectedPass == Convert.ToBase64String(Hash(pass, iteration)))
                return true;
            else
                return false;
        }
        public string GenerateSalt()
        {
            RNGCryptoServiceProvider rncCsp = new RNGCryptoServiceProvider();
            byte[] salt = new byte[16];
            rncCsp.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }
        public string HashPass(string pass, int iteration)
        {
            string salt = GenerateSalt();
            pass = salt + pass;
            byte[] hashed;
            using (var sha = SHA256.Create())
            {
                var asBytes = Encoding.Default.GetBytes(pass);
                for (int i = 0; i < iteration; i++)
                {
                    asBytes = sha.ComputeHash(asBytes);
                }

                hashed = sha.ComputeHash(asBytes);
                return iteration.ToString() + "." + salt + "." + Convert.ToBase64String(hashed);
            }
        }
        public byte[] Hash(string pass, int iteration)
        {
            byte[] hashed;
            using (var sha = SHA256.Create())
            {
                var asBytes = Encoding.Default.GetBytes(pass);
                for (int i = 0; i < iteration; i++)
                {
                    asBytes = sha.ComputeHash(asBytes);
                }

                hashed = sha.ComputeHash(asBytes);
                string str = Convert.ToBase64String(hashed);
                return hashed;
            }
        }
        public void RegUser()
        {
            UserDTO user = new UserDTO();
            string passC;
            Console.Write("Login ");
            user.Login = Console.ReadLine();
            Console.Write("Password ");
            passC = Console.ReadLine();
            string pass = HashPass(passC, 4);
            user.Password = pass;
            Console.Write("Role ID ");
            user.RoleId = Convert.ToInt32(Console.ReadLine());
            _userRepository.Create(user);
        }
        public bool LogIn(string enteredEmail,string enteredPass)
        {
            var user = _userRepository.LoginData(enteredEmail);
            string userpassDB = _userRepository.Get(user.Id).Password;
            return ConfirmPass(enteredPass, userpassDB);
        }
    }
}
