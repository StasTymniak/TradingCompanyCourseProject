using BLL.Interfaces;
using DAL.Interfaces;
using Domain;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ServiceCategory : IServiceCategory
    {
        private readonly IRepository<Category> _categoryRepository;

        public ServiceCategory(IRepository<Category> categoryRepository)
            => this._categoryRepository = categoryRepository;

        public List<Category> GetAllCategory()
            => this._categoryRepository.GetAll();

        public Category GetCategory(int id)
            => this._categoryRepository.Get(id);

        public Category GetCategory(string name)
            => this._categoryRepository.Get(name);

    }
}
