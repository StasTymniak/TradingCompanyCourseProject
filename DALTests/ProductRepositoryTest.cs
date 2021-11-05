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

    public class ProductRepositoryTest
    {
        private string _connection = @"Server=(localdb)\MSSQLLocalDB;Database=tradingCompanyTest;Trusted_Connection=True;";

        IRepository<Product> productRep;
        [OneTimeSetUp]
        public void InitialSetupTest()
        {
            productRep = new ProductRepository();
        }

        [Test]
        public void GetByIdTest()
        {
            var res = productRep.Get(1);
            Assert.IsTrue(res.ProductName == "Iphone 12");
        }

        [Test]
        public void CreateTest()
        {
            Product p = new Product
            {
                ProductName="Duna",
                CategoryId=10,
                RowInsertTime = DateTime.Now,
                RowUpdateTime = DateTime.Now
            };
            var res = productRep.Create(p);
            Assert.IsTrue(res.ProductName == "Duna");
        }

        [Test]
        public void GetAllTest()
        {
            var categories = productRep.GetAll();

            Assert.IsTrue(categories.Any(c => c.ProductName == "Arius 5 Pro"));

        }
        [Test]
        public void UpdateTest()
        {
            Product p = new Product
            {
                ProductName = "Iphone 12",
                CategoryId = 5,
                RowInsertTime = DateTime.Now,
                RowUpdateTime = DateTime.Now
            };
            productRep.Update(1, p);
            Assert.IsTrue(productRep.Get(1).ProductName == "Iphone 12");
        }

        [Test]
        public void DeleteTest()
        {
            productRep.Delete(3);
            Assert.IsTrue(!productRep.GetAll().Any(c => c.CategoryId == 3));
        }
    }
}
