using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore.Storage;
using NUnit.Framework;
using System;
using System.Configuration;

namespace UnitTests
{
    [TestFixture]

    public class CategoryRepositoryTest
    {
        private string connection = ConfigurationManager.ConnectionStrings["TestconnString"].ConnectionString;
        IRepository<Category> categories;
        [OneTimeSetUp]
        public void InitialSetupTest()
        {
            categories = new CategoryRepository(connection);
        }

        [Test]
        public void CreateTest()
        {
            Category c = new Category
            {
                CategoryName = "PC",
                RowInsertTime = DateTime.Now,
                RowUpdateTime = DateTime.Now
            };

            var res = categories.Create(c);
            Assert.Greater(res.CategoryId, 0);
        }
    }
}
