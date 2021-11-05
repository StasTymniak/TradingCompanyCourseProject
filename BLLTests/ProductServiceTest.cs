using System.Collections.Generic;
using System.Linq;

using BLL.Services;
using DAL.Interfaces;
using Domain;
using Moq;
using NUnit.Framework;

namespace BLLTests
{
    [TestFixture]
    public class ProductServiceTest
    {
        private ServiceProduct _serviceProduct;
        private Mock<IRepository<Product>> _productRepo;

        [SetUp]
        public void Setup()
        {
            _productRepo = new Mock<IRepository<Product>>(MockBehavior.Strict);
            _serviceProduct = new ServiceProduct(_productRepo.Object);
        }
        [Test]
        public void GetAllProducts_ReturnList_AreEqual()
        {
            //Arrange
            List<Product> products_in = new List<Product>()
            {
                new Product{ProductId=1,ProductName="Iphone 12",CategoryId=5},
                new Product{ProductId=2,ProductName="Dune",CategoryId=6},
                new Product{ProductId=3,ProductName="Iphone 13",CategoryId=5}
            };
            List<Product> products_out = new List<Product>()
            {
                new Product{ProductId=1,ProductName="Iphone 12",CategoryId=5},
                new Product{ProductId=2,ProductName="Dune",CategoryId=6},
                new Product{ProductId=3,ProductName="Iphone 13",CategoryId=5}

            };
            _productRepo.Setup(p => p.GetAll())
                        .Returns(products_in);
            //Act
            List<Product> res = _serviceProduct.GetAllProducts();
            bool isEqual = Enumerable.SequenceEqual(products_out, res);
            //Assert
            Assert.IsTrue(isEqual);
        }
        [Test]
        public void GetProduct_ReturnProduct_AreEqual()
        {
            //Arrange
            Product expected_product = new Product { ProductId = 2, ProductName = "Dune", CategoryId = 6 };
            _productRepo.Setup(p => p.Get(2))
                        .Returns(expected_product);
            //Act
            Product res = _serviceProduct.GetProduct(2);
            bool isEqual = Equals(expected_product, res);
            //Assert
            Assert.IsTrue(isEqual);
        }
        [Test]
        public void GetProductByCategory_ReturnList_AreEqual()
        {
            //Arrange
            List<Product> products_in = new List<Product>()
            {
                new Product{ProductId=1,ProductName="Iphone 12",CategoryId=5},
                new Product{ProductId=2,ProductName="Dune",CategoryId=6}
            };
            List<Product> products_out = new List<Product>()
            {
                new Product{ProductId=1,ProductName="Iphone 12",CategoryId=5}
                
            };
            Category expected_category = new Category()
            {
                CategoryId = 5,
                CategoryName = "Phones"
            };
            _productRepo.Setup(p=>p.GetAll())
                        .Returns(products_in);
            //Act
            List<Product> res = _serviceProduct.GetProductsByCategory(expected_category);
            bool isEqual = Enumerable.SequenceEqual(products_out, res);
            //Assert
            Assert.IsTrue(isEqual);            
        }

        [Test]
        public void SortProductsByCategory_ReturnList_AreEqual()
        {
            //Arrange
            List<Product> products_in = new List<Product>()
            {
                new Product{ProductId=1,ProductName="Iphone 12",CategoryId=5},
                new Product{ProductId=2,ProductName="Dune",CategoryId=6},
                new Product{ProductId=3,ProductName="Iphone 13",CategoryId=5},
            };
            List<Product> products_out = new List<Product>()
            {
                new Product{ProductId=2,ProductName="Dune",CategoryId=6},
                new Product{ProductId=1,ProductName="Iphone 12",CategoryId=5},
                new Product{ProductId=3,ProductName="Iphone 13",CategoryId=5}
            };

            _productRepo.Setup(p => p.GetAll())
                        .Returns(products_in);
            //Act
            List<Product> res = _serviceProduct.SortProducts();
            bool isEqual = Enumerable.SequenceEqual(products_out, res);
            //Assert
            Assert.IsTrue(isEqual);
        }

    }
}

