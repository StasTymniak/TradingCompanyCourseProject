using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore.Storage;
using NUnit.Framework;
using System;

using System.Linq;

namespace DALTests
{
    [TestFixture]

    public class CategoryRepositoryTest
    {
        private string _connection = @"Server=(localdb)\MSSQLLocalDB;Database=tradingCompanyTest;Trusted_Connection=True;";

        IRepository<Category> categoryRep;
        [OneTimeSetUp]
        public void InitialSetupTest()
        {
            categoryRep = new CategoryRepository(_connection);
        }

        [Test]
        public void GetByIdTest()
        {
            var res = categoryRep.Get(1);
            Assert.IsTrue(res.CategoryName=="PC");
        }

        [Test]
        public void CreateTest()
        {
            Category c = new Category
            {
                CategoryName = "Knifes",
                RowInsertTime = DateTime.Now,
                RowUpdateTime = DateTime.Now
            };
            var res = categoryRep.Create(c);
            Assert.IsTrue(res.CategoryName== "Knifes");
        }

        [Test]
        public void GetAllTest()
        {
            var categories = categoryRep.GetAll();

            Assert.IsTrue(categories.Any(c => c.CategoryName == "PC"));
            
        }
        [Test]
        public void UpdateTest()
        {
            Category c = new Category
            {
                CategoryName = "Mobiles",
                RowInsertTime = DateTime.Now,
                RowUpdateTime = DateTime.Now
            };
            categoryRep.Update(5, c);
            Assert.IsTrue(categoryRep.Get(5).CategoryName == "Mobiles");
        }

        [Test]
        public void DeleteTest()
        {
            categoryRep.Delete(9);
            Assert.IsTrue(!categoryRep.GetAll().Any(c=>c.CategoryId==9));
        }
    }
}
