using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IServiceAuth
    {
        void RegUser();
        string HashPass(string pass, int iteraton);
        byte[] Hash(string pass, int iteraton);
        string GenerateSalt();
        bool ConfirmPass(string enteredPass, string dbString);
        bool LogIn(string enteredEmail, string enteredPass);
    }
}
