using System.Collections.Generic;

using Domain;

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
