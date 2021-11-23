using System.Collections.Generic;
using System.Linq;

using DAL.Interfaces;
using Domain;

namespace BLL.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ServiceProduct(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            this._productRepository = productRepository;
            this._categoryRepository = categoryRepository;
        }

        public List<Product> GetAllProducts()
            => this._productRepository.GetAll();


        public Product GetProduct(int id)
            => this._productRepository.Get(id);

        public List<Product> GetProductsByCategory(Category requestedCategory)
            => this._productRepository.GetAll()
                .Where(p => p.CategoryId == requestedCategory.CategoryId)
                .Select(p => new Product
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    RowInsertTime = p.RowInsertTime,
                    RowUpdateTime = p.RowUpdateTime
                }).ToList();

        public List<Product> SortProducts()
            => this._productRepository.GetAll()
                .OrderByDescending(p => p.CategoryId).ToList();

    }
}
