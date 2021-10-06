using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductDAL
    {
        List<ProductDTO> GetAll();
        ProductDTO Get(int id);
        void Create(ProductDTO product);
        void Update(int item, ProductDTO product);
        void Delete(int id);
    }
}
