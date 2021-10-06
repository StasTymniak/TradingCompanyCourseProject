using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class CategoryDAL:ICategoryDAL
    {
        public CategoryDTO Get(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                return db.Categories.Find(id);
            }
        }
        public List<CategoryDTO> GetAll()
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                return db.Categories.ToList();
            }
        }
        public void Create(CategoryDTO tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                db.Categories.Add(tmp);
                db.SaveChanges();
            }
        }
        public void Update(int id, CategoryDTO tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                CategoryDTO category = db.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
                category.CategoryName = tmp.CategoryName;
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
    }
}

