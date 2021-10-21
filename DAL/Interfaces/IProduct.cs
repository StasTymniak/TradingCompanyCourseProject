using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
