using DAL.Interfaces;
using Domain;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EntityFramework
{
    public class CategoryRepository : IRepository<Category>
    {
        public void Create(Category obj)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                CategoryDTO category = new CategoryDTO();
                db.Categories.Add(category.MappToDTO(obj));
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
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
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                return db.Categories.Find(id).MappFromDTO();
            }
        }

        public List<Category> GetAll()
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                List<Category> categories = new List<Category>();
                foreach (CategoryDTO item in db.Categories.ToList())
                {
                    categories.Add(item.MappFromDTO());
                }
                return categories;
            }
        }

        public void Update(int id, Category tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                CategoryDTO category = db.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
                category.MappToDTO(tmp);
                db.SaveChanges();
            }
        }
    }
}
