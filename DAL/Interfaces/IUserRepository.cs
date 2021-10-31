using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        List<UserDTO> GetAll();
        UserDTO Get(int id);
        void Create(UserDTO user);
        void Delete(int id);
        UserDTO LoginData(string login);
    }
}
