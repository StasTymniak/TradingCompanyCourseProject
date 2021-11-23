using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IServiceAuth
    {
        void RegUser();
        List<int> LogIn(string enteredEmail, string enteredPass);
    }
}
