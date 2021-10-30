using DAL.Interfaces;
using Domain;
using DTO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace DAL.EntityFramework
{
    public class ProductRepository : IRepository<Product>
    {

        public string conn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public ProductRepository()
        {
        }
        public Product Create(Product obj)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                ProductDTO product = new ProductDTO();
                db.Products.Add(product.CreateMappToDTO(obj));
                db.SaveChanges();
            }
            return obj;
        }

        public void Delete(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
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
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                return db.Products.Find(id).MappFromDTO();
            }
        }

        public List<Product> GetAll()
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
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
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                ProductDTO product = db.Products.Where(x => x.ProductId == id).SingleOrDefault();
                product.UpdateMappToDTO(tmp);
                db.SaveChanges();
            }
        }
    }
}
