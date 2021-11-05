using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using Domain;
using Moq;
using NUnit.Framework;
namespace BLLTests
{
    internal class AuctionServiceTest
    {
        private ServiceAuction _serviceAuction;
        private Mock<IRepository<Auction>> _auctionRepo;

        [SetUp]
        public void Setup()
        {
            _auctionRepo = new Mock<IRepository<Auction>>();
            _serviceAuction = new ServiceAuction(_auctionRepo.Object);
        }

        [Test]
        public void GetAllAuctions_ReturnList_AreEqual()
        {
            //Arrange
            List<Auction> auctions_in = new List<Auction>()
            {
                new Auction{
                    AuctionId=1,
                    AuctionName="Iphone 12 Auction",
                    StrtupPrice=100,
                    RedemptionPrice=1000,
                    isActive=false,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime =DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=1
                },
                new Auction{
                    AuctionId=1,
                    AuctionName="Iphone 13 Auction",
                    StrtupPrice=500,
                    RedemptionPrice=1000,
                    isActive=false,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=3
                },
                new Auction{
                    AuctionId=1,
                    AuctionName="Dune Auction",
                    StrtupPrice=50,
                    RedemptionPrice=100,
                    isActive=false,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=2
                }
            };
            List<Auction> auctions_out = new List<Auction>()
            {
                new Auction{
                    AuctionId=1,
                    AuctionName="Iphone 12 Auction",
                    StrtupPrice=100,
                    RedemptionPrice=1000,
                    isActive=false,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=1
                },
                new Auction{
                    AuctionId=1,
                    AuctionName="Iphone 13 Auction",
                    StrtupPrice=500,
                    RedemptionPrice=1000,
                    isActive=false,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=3
                },
                new Auction{
                    AuctionId=1,
                    AuctionName="Dune Auction",
                    StrtupPrice=50,
                    RedemptionPrice=100,
                    isActive=false,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=2
                }
            };
            _auctionRepo.Setup(a => a.GetAll())
                        .Returns(auctions_in);
            //Act
            List<Auction> res = _serviceAuction.GetAllAuctions();
            bool isEqual = Enumerable.SequenceEqual(auctions_out, res);
            //Assert
            Assert.IsTrue(isEqual);
        }
        [Test]
        public void GetAllActiveAuctions_ReturnList_AreEqual()
        {
            //Arrange
            List<Auction> auctions_in = new List<Auction>()
            {
                new Auction{
                    AuctionId=1,
                    AuctionName="Iphone 12 Auction",
                    StrtupPrice=100,
                    RedemptionPrice=1000,
                    isActive=true,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime =DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=1
                },
                new Auction{
                    AuctionId=1,
                    AuctionName="Iphone 13 Auction",
                    StrtupPrice=500,
                    RedemptionPrice=1000,
                    isActive=false,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=3
                },
                new Auction{
                    AuctionId=1,
                    AuctionName="Dune Auction",
                    StrtupPrice=50,
                    RedemptionPrice=100,
                    isActive=true,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=2
                }
            };
            List<Auction> auctions_out = new List<Auction>()
            {
                new Auction{
                    AuctionId=1,
                    AuctionName="Iphone 12 Auction",
                    StrtupPrice=100,
                    RedemptionPrice=1000,
                    isActive=true,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=1
                },
                new Auction{
                    AuctionId=1,
                    AuctionName="Dune Auction",
                    StrtupPrice=50,
                    RedemptionPrice=100,
                    isActive=true,
                    ActivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    DeactivateTime=DateTime.Parse("2021-11-01 20:37:40"),
                    EndTime=DateTime.Parse("2021-11-01 20:37:40"),
                    ProductId=2
                }
            };
            _auctionRepo.Setup(a => a.GetAll())
                        .Returns(auctions_in);
            //Act
            List<Auction> res = _serviceAuction.GetAllActiveAuctions();
            bool isEqual = Enumerable.SequenceEqual(auctions_out, res);
            //Assert
            Assert.IsTrue(isEqual);
        }
        [Test]
        public void ActivateAuction_ReturnAuction_IsTrue()
        {
            //Arrange
            Auction auction_in = new Auction
            {
                AuctionId = 1,
                AuctionName = "Iphone 13 Auction",
                StrtupPrice = 500,
                RedemptionPrice = 1000,
                isActive = false,
                ActivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                DeactivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                EndTime = DateTime.Parse("2021-11-01 20:37:40"),
                ProductId = 3
            };
            Auction auction_out = new Auction
            {
                AuctionId = 1,
                AuctionName = "Iphone 13 Auction",
                StrtupPrice = 500,
                RedemptionPrice = 1000,
                isActive = true,
                ActivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                DeactivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                EndTime = DateTime.Parse("2021-11-01 20:37:40"),
                ProductId = 3
            };
            _auctionRepo.Setup(a => a.Get(1))
                        .Returns(auction_in);
            _auctionRepo.Setup(a=>a.Update(1, auction_out))
                        .Returns(auction_out);
            //Act
           Auction res = _serviceAuction.ActiveAuction(1);
            
            //Assert
            Assert.AreEqual(auction_out.isActive, res.isActive);
        }

        [Test]
        public void DeactivateAuction_ReturnAuction_IsTrue()
        {
            //Arrange
            Auction auction_in = new Auction
            {
                AuctionId = 1,
                AuctionName = "Iphone 13 Auction",
                StrtupPrice = 500,
                RedemptionPrice = 1000,
                isActive = true,
                ActivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                DeactivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                EndTime = DateTime.Parse("2021-11-01 20:37:40"),
                ProductId = 3
            };
            Auction auction_out = new Auction
            {
                AuctionId = 1,
                AuctionName = "Iphone 13 Auction",
                StrtupPrice = 500,
                RedemptionPrice = 1000,
                isActive = false,
                ActivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                DeactivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                EndTime = DateTime.Parse("2021-11-01 20:37:40"),
                ProductId = 3
            };
            _auctionRepo.Setup(a => a.Get(1))
                        .Returns(auction_in);
            _auctionRepo.Setup(a => a.Update(1, auction_out))
                        .Returns(auction_out);
            //Act
            Auction res = _serviceAuction.DeactiveAuction(1);

            //Assert
            Assert.AreEqual(auction_out.isActive, res.isActive);
        }

        [Test]
        public void CreateAuction_ReturnsAuction_AreEqual()
        {
            //Arrange
            Auction auction_in = new Auction
            {
                AuctionName = "Dune Auction",
                StrtupPrice = 50,
                RedemptionPrice = 100,
                isActive = false,
                ActivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                DeactivateTime = DateTime.Parse("2021-11-01 20:37:40"),
                EndTime = DateTime.Parse("2021-11-01 20:37:40"),
                ProductId = 2
            };
            Auction auction_out = new Auction { AuctionId = 0 };
            _auctionRepo.Setup(a => a.Create(auction_in))
                        .Returns(auction_in);
            //Act
            Auction res = _serviceAuction.AddAuction(auction_in.ProductId, auction_in.AuctionName, auction_in.StrtupPrice, auction_in.RedemptionPrice, auction_in.EndTime);
            //Assert
            Assert.AreEqual(auction_out.AuctionId, res.AuctionId);
        }
    }
}
