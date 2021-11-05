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
        {
            _productRepository = productRepository;
        }
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _productRepository.Get(id);
        }

        /*public List<Product> GetProductsByCategory(string requestedCategory)
        {
            List<Product> products = _productRepository.GetAll();
            var selectedproducts = from product in products
                                   where _categoryRepository.Get(product.CategoryId).CategoryName == requestedCategory
                                   select product;

            List<Product> findedproducts = new List<Product>();
            foreach (Product item in selectedproducts)
            {
                findedproducts.Add(item);
            }
            return findedproducts;
        }*/
        public List<Product> GetProductsByCategory(Category requestedCategory)
        {
            List<Product> products = _productRepository.GetAll();
            var query = products
                .Where(p => p.CategoryId == requestedCategory.CategoryId)
                .Select(p => new Product
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    RowInsertTime = p.RowInsertTime,
                    RowUpdateTime = p.RowUpdateTime
                });
                return query.ToList();
            
        }

        public List<Product> SortProducts()
        {
            List<Product> products = _productRepository.GetAll();
            var productsSorted = from product in products
                                 orderby product.CategoryId descending
                                 select product;
            List<Product> sortedproducts = new List<Product>();
            foreach (Product item in productsSorted)
            {
                sortedproducts.Add(item);
            }
            return sortedproducts;
        }



    }
}
