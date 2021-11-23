using System.Collections.Generic;

using DTO;

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
