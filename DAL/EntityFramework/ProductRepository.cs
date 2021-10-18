using DAL.Interfaces;
using Domain;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EntityFramework
{
    public class ProductRepository : IRepository<Product>
    {
        public void Create(Product obj)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                ProductDTO product = new ProductDTO();
                db.Products.Add(product.MappToDTO(obj));
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

        public Product Get(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                return db.Products.Find(id).MappFromDTO();
            }
        }

        public List<Product> GetAll()
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                List<Product> auctions = new List<Product>();
                foreach(ProductDTO item in db.Products.ToList())
                {
                    auctions.Add(item.MappFromDTO());
                }
                return auctions;
            }
        }

        public void Update(int id, Product tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                ProductDTO product = db.Products.Where(x => x.ProductId == id).SingleOrDefault();
                product.MappToDTO(tmp);
                db.SaveChanges();
            }
        }
    }
}
