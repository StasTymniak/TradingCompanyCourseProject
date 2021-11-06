using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Interfaces;
using Domain;

namespace BLL.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IRepository<Product> _productRepository;

        public ServiceProduct(IRepository<Product> productRepository)
            => this._productRepository = productRepository;
        public List<Product> GetAllProducts()
            => this._productRepository.GetAll();

        public Product GetProduct(int id)
            => this._productRepository.Get(id);

        public List<Product> GetProductsByCategory(Category requestedCategory)
        {
            IEnumerable<Product> products = this._productRepository.GetAll()
                .Where(p => p.CategoryId == requestedCategory.CategoryId)
                .Select(p => new Product
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    RowInsertTime = p.RowInsertTime,
                    RowUpdateTime = p.RowUpdateTime
                });

            var productsFinded = new List<Product>();
            foreach (Product item in products)
                productsFinded.Add(item);

            return productsFinded;
        }

        public List<Product> SortProducts()
        {
            List<Product> products = this._productRepository.GetAll()
                .OrderByDescending(p => p.CategoryId).ToList();
 
            List<Product> sortedproducts = new List<Product>();
            foreach (Product item in products)
            {
                sortedproducts.Add(item);
            }

            return sortedproducts;
        }
    }
}
