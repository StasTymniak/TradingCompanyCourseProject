using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICategory
    {
        List<Category> GetAll();
        Category Get(int id);
        Category Create(Category obj);
        void Update(int id, Category obj);
        void Delete(int id);
    }
}
