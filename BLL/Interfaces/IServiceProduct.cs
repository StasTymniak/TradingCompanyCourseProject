using System.Collections.Generic;

using Domain;

namespace BLL.Services
{
    public interface IServiceProduct
    {
        List<Product> GetAllProducts();
        Product GetProduct(int id);
        List<Product> SortProducts();
        List<Product> GetProductsByCategory(Category requestedCategory);
    }
}
