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

    public class AuctionRepositoryTest
    {
        private string _connection = @"Server=(localdb)\MSSQLLocalDB;Database=tradingCompanyTest;Trusted_Connection=True;";

        IRepository<Auction> auctionRep;
        [OneTimeSetUp]
        public void InitialSetupTest()
        {
            auctionRep = new AuctionRepository(_connection);
        }

        [Test]
        public void GetByIdTest()
        {
            var res = auctionRep.Get(7);
            Assert.IsTrue(res.AuctionName == "Iphone 12 Auction");
        }

        [Test]
        public void CreateTest()
        {
            Auction a = new Auction
            {
                AuctionName = "Ready Player One Auction",
                StrtupPrice = 10,
                RedemptionPrice = 50,
                ProductId = 5
            };
            var res = auctionRep.Create(a);
            Assert.IsTrue(res.AuctionName == "Ready Player One Auction");
        }

        [Test]
        public void GetAllTest()
        {
            var auction = auctionRep.GetAll();

            Assert.IsTrue(auction.Any(a => a.AuctionName == "Iphone 12 Auction"));

        }
        [Test]
        public void UpdateTest()
        {
            Auction a = new Auction
            {
                AuctionName = "Iphone 12 Auction",
                StrtupPrice = 10,
                RedemptionPrice = 50,
                ProductId = 5
            };
            auctionRep.Update(7, a);
            Assert.IsTrue(auctionRep.Get(7).AuctionName == "Iphone 12 Auction");
        }

        [Test]
        public void DeleteTest()
        {
            auctionRep.Delete(14);
            Assert.IsTrue(!auctionRep.GetAll().Any(a => a.AuctionId == 14));
        }
    }
}
