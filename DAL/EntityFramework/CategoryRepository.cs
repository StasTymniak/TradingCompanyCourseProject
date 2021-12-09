using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using DAL.Interfaces;
using Domain;
using DTO;

namespace DAL.EntityFramework
{
    public class CategoryRepository : IRepository<Category>
    {
        public string conn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        //string conn = ConfigurationManager.AppSettings["connString"].ToString();

        public Category Create(Category obj)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                CategoryDTO category = new CategoryDTO();
                db.Categories.Add(category.CreateMappToDTO(obj));
                db.SaveChanges();
            }
            return obj;
        }

        public void Delete(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                var category = db.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
                if (category != null)
                {
                    db.Categories.Remove(category);
                    db.SaveChanges();
                }
            }
        }

        public Category Get(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                return db.Categories.Find(id).MappFromDTO();
            }
        }

        public Category Get(string name)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                return db.Categories.Where(c => c.CategoryName == name).FirstOrDefault().MappFromDTO();
            }
        }

        public List<Category> GetAll()
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                List<Category> categories = new List<Category>();
                foreach (CategoryDTO item in db.Categories.ToList())
                {
                    categories.Add(item.MappFromDTO());
                }
                return categories;
            }
        }

        public Category Update(int id, Category tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext(conn))
            {
                CategoryDTO category = db.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
                category.UpdateMappToDTO(tmp);
                db.SaveChanges();
                return tmp;
            }
        }
    }
}
