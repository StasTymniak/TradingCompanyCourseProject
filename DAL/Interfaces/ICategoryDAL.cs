using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICategoryDAL
    {
        List<CategoryDTO> GetAll();
        CategoryDTO Get(int id);
        void Create(CategoryDTO category);
        void Update(int item, CategoryDTO category);
        void Delete(int id);
    }
}
