using System;
using DAL.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class ProductDAL : IProductDAL
    {
        public ProductDTO Get(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                return db.Products.Find(id);
            }
        }
        public List<ProductDTO> GetAll()
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                return db.Products.ToList();
            }
        }
        public void Create(ProductDTO tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                db.Products.Add(tmp);
                db.SaveChanges();
            }
        }
        public void Update(int id, ProductDTO tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                ProductDTO product = db.Products.Where(x => x.ProductId == id).SingleOrDefault();
                product.ProductName = tmp.ProductName;
                product.CategoryId = tmp.CategoryId;
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                var product = db.Products.Where(x => x.ProductId == id).SingleOrDefault();
                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                }
            }
        }
    }
}
