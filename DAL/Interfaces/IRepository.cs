using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        T Get(string id);
        T Create(T obj);
        T Update(int id, T obj);
        void Delete(int id);
    }
}
