using BLL.Interfaces;
using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ServiceCategory:IServiceCategory
    {
        IRepository<Category> _categoryRepository;
        public ServiceCategory(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<Category> GetAllCategory()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategory(int id)
        {
            return _categoryRepository.Get(id);
        }

        public Category GetCategory(string name)
        {           
            return _categoryRepository.GetAll().FirstOrDefault(x => x.CategoryName == name);
        }

    }
}
