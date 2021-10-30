using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IServiceProduct
    {
        public List<Product> GetAllProducts();
        public Product GetProduct(int id);
        public List<Product> SortProducts(string category);
        public List<Product> GetProductsByCategory(string category);
    }
}
