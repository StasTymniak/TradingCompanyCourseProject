using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
