using System.Collections.Generic;
using System.Linq;

using Moq;
using NUnit.Framework;

using BLL.Services;
using DAL.Interfaces;
using Domain;

namespace BLLTests
{
    [TestFixture]
    internal class CategoryServiceTest
    {
        private ServiceCategory _serviceCategory;
        private Mock<IRepository<Category>> _categoryRepo;

        [SetUp]
        public void Setup()
        {
            _categoryRepo = new Mock<IRepository<Category>>(MockBehavior.Strict);
            _serviceCategory = new ServiceCategory(_categoryRepo.Object);
        }

        [Test]
        public void GetAllCategory_ReturnList_AreEqual()
        {
            //Arrange
            List<Category> category_in = new List<Category>()
            {
                new Category{CategoryId=5,CategoryName="Phones"},
                new Category{CategoryId = 6,CategoryName ="Books"},
            };
            List<Category> category_out = new List<Category>()
            {
                new Category{CategoryId=5,CategoryName="Phones"},
                new Category{CategoryId = 6,CategoryName ="Books"}
            };
            _categoryRepo.Setup(c => c.GetAll())
                        .Returns(category_in);
            //Act
            List<Category> res = _serviceCategory.GetAllCategory();
            bool isEqual = Enumerable.SequenceEqual(category_out, res);
            //Assert
            Assert.IsTrue(isEqual);
        }

        [Test]
        public void GetCategory_IntIn_ReturnCategory_AreEqual()
        {
            //Arrange
            Category category_in = new Category { CategoryId = 5, CategoryName = "Phones" };
            Category category_out = new Category { CategoryId = 5, CategoryName = "Phones" };
            _categoryRepo.Setup(c=>c.Get(5))
                         .Returns(category_in);
            //Act
            Category res = _serviceCategory.GetCategory(5);
            bool isEqual = Equals(category_out, res);
            //Assert
            Assert.IsTrue(isEqual);
        }
        [Test]
        public void GetCategory_IntString_ReturnCategory_AreEqual()
        {
            //Arrange
            Category category_in = new Category { CategoryId = 6, CategoryName = "Books" };
            Category category_out = new Category { CategoryId = 6, CategoryName = "Books" };
            _categoryRepo.Setup(c => c.Get("Books"))
                         .Returns(category_in);
            //Act
            Category res = _serviceCategory.GetCategory("Books");
            bool isEqual = Equals(category_out, res);
            //Assert
            Assert.IsTrue(isEqual);
        }
    }
}
