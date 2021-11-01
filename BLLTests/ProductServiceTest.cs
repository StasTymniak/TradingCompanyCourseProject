using BLL.Services;
using DAL.Interfaces;
using Domain;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace BLLTests
{
    [TestFixture]
    internal class ProductServiceTest
    {
        private ServiceProduct _serviceProduct;
        private Mock<IRepository<Product>> _productRepository;
        private Mock<IRepository<Category>> _categoryRepository;
        
        [SetUp]

        public void SetUp()
        {
            _productRepository = new Mock<IRepository<Product>>(MockBehavior.Strict);
            _categoryRepository = new Mock<IRepository<Category>>(MockBehavior.Default);
            
            _serviceProduct = new ServiceProduct(_productRepository.Object, _categoryRepository.Object);
        }

        [Test]
        public void GetProducts_ReturnsList_AreEqual()
        {
            //Arrange
            List<Product>_productList = new List<Product>() {
                new Product() { ProductId = 1, ProductName="Iphone 13",CategoryId = 5},
                new Product() { ProductId = 2, ProductName="Dune",CategoryId = 6},
                new Product() { ProductId = 1, ProductName="Iphone 12",CategoryId = 5}
            };
            _productRepository
                .Setup(p => p.GetAll())
                .Returns(_productList);

            //Act
            var res = _serviceProduct.GetAllProducts();

            //Assert
            Assert.AreEqual(_productList, res);
        }

        [Test]
        public void GetProduct_ReturnProduct_AreEqual()
        {
            //Arrange
            Product outProduct = new Product()
            {
                ProductId = 2,
                ProductName = "Dune",
                CategoryId = 6
            };
            _productRepository
                .Setup(p => p.Get(2))
                .Returns(outProduct);

            //Act
            var res = _serviceProduct.GetProduct(2);

            //Assert
            Assert.AreEqual(outProduct, res);
        }
        [Test]
        public void GetProductsByCategory_ReturnList_AreEqual()
        {
            //Arrange
            string categoryName = "Phones";
            Category expectedCategory = new Category()
            {
                CategoryId = 5,
                CategoryName = "Phones"
            };
            List<Product> expactedList = new List<Product>() {
                new Product() { ProductId = 1, ProductName="Iphone 13",CategoryId = 5},
                new Product() { ProductId = 1, ProductName="Iphone 12",CategoryId = 5}
            };
            List<Product> productList = new List<Product>() {
                new Product() { ProductId = 1, ProductName="Iphone 13",CategoryId = 5},
                new Product() { ProductId = 2, ProductName="Dune",CategoryId = 6},
                new Product() { ProductId = 1, ProductName="Iphone 12",CategoryId = 5}
            };
            _categoryRepository
                .Setup(p => p.Get(It.IsAny<Product>().CategoryId))
                .Returns(expectedCategory);
            _productRepository
                .Setup(p => p.GetAll())
                .Returns(productList);

            //Act
            var res = _serviceProduct.GetProductsByCategory(categoryName);

            //Assert
            Assert.AreEqual(expactedList, res);
        }
    }
}
