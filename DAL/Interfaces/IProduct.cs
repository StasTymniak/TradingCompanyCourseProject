using System.Collections.Generic;

using Domain;

namespace DAL.Interfaces
{
    interface IProduct
    {
        List<Product> GetAll();
        Product Get(int id);
        Product Create(Product obj);
        void Update(int id, Product obj);
        void Delete(int id);
    }
}
