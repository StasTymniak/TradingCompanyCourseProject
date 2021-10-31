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
        List<Product> GetAllProducts();
        Product GetProduct(int id);
        List<Product> SortProducts(string category);
        List<Product> GetProductsByCategory(string category);
    }
}
