using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Commands
{
    public class ProductCommands
    {
        IRepository<Product> product;
        IRepository<Category> category;

        public ProductCommands(string conn)
        {
            product = new ProductRepository(conn);
            category = new CategoryRepository(conn);
        }
        public void PrintProduct(Product product)
        {
            Console.WriteLine($"ID--{product.ProductId}\nName--{product.ProductName}\nCategory--{category.Get(product.CategoryId).CategoryName}");
        }

        public Product GetProduct(int id)
        {
            return product.Get(id);
        }
        public void PrintProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"ID--{product.ProductId}\nName--{product.ProductName}\nCategory--{category.Get(product.CategoryId).CategoryName}");
            }
        }

        public void ShowAllProducts()
        {
            List<Product> products = product.GetAll();
            foreach (Product product in products)
            {
                Console.WriteLine($"ID--{product.ProductId}\nName--{product.ProductName}\nCategory--{category.Get(product.CategoryId).CategoryName}\n");
            }
        }
        public void SortProductsByCategory()
        {
            List<Product> products = product.GetAll();
            var productsSorted = from product in products
                                 orderby product.CategoryId ascending
                                 select product;
            foreach (Product product in productsSorted)
            {
                Console.WriteLine($"ID--{product.ProductId}\nName--{product.ProductName}\nCategory--{category.Get(product.CategoryId).CategoryName}\n");
            }
        }
        public List<Product> FindProductsByCategory(string requestedCategory)
        {
            List<Product> products = product.GetAll();
            var selectedproducts = from product in products
                                   where category.Get(product.CategoryId).CategoryName == requestedCategory
                                   select product;
            List<Product> findedproducts = new List<Product>();
            foreach (Product item in selectedproducts)
            {
                findedproducts.Add(item);
            }
            return findedproducts;
        }
    }
}
