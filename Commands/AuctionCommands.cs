using System;
using Domain;
using DAL.Interfaces;
using DAL.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace Commands
{
    public class AuctionCommands
    {
        IRepository<Auction> auction;
        public AuctionCommands(string conn)
        {
            auction = new AuctionRepository(conn);
        }
        public void ShowAllAuctions()
        {
            List<Domain.Auction> auctions = auction.GetAll();
            foreach (Domain.Auction auction in auctions)
            {
                Console.WriteLine($"ID--{auction.AuctionId}\nName--{auction.AuctionName}\nStartup price--{auction.StrtupPrice}\nRedemption price--{auction.RedemptionPrice}\n is Active--{auction.isActive}\nEnd time--{auction.EndTime}\n");
            }
        }

        public void ShowAllActiveAuctions()
        {
            List<Domain.Auction> auctions = auction.GetAll();
            var selectedauctions = from auction in auctions
                                   where auction.isActive == true
                                   select auction;
            List<Domain.Auction> findedauctions = new List<Domain.Auction>();
            foreach (Domain.Auction item in selectedauctions)
            {
                findedauctions.Add(item);
            }
            foreach (Domain.Auction auction in findedauctions)
            {
                Console.WriteLine($"ID--{auction.AuctionId}\nName--{auction.AuctionName}\nStartup price--{auction.StrtupPrice}\nRedemption price--{auction.RedemptionPrice}\n is Active--{auction.isActive}\nEnd time--{auction.EndTime}\nActivate time--{auction.ActivateTime}\n");
            }
        }

        public void ActivateAuction(int id)
        {
            Auction auction = new Auction();
            auction.AuctionName = this.auction.Get(id).AuctionName;
            auction.StrtupPrice = this.auction.Get(id).StrtupPrice;
            auction.RedemptionPrice = this.auction.Get(id).RedemptionPrice;
            auction.ActivateTime = DateTime.Now;
            auction.DeactivateTime = this.auction.Get(id).DeactivateTime;
            auction.EndTime = DateTime.Today;
            auction.isActive = true;
            auction.ProductId = this.auction.Get(id).ProductId;
            auction.RowUpdateTime = DateTime.Now;
            this.auction.Update(id, auction);
        }

        public void DeactivateAuction(int id)
        {
            Auction auction = new Auction();
            auction.AuctionName = this.auction.Get(id).AuctionName;
            auction.StrtupPrice = this.auction.Get(id).StrtupPrice;
            auction.RedemptionPrice = this.auction.Get(id).RedemptionPrice;
            auction.ActivateTime = this.auction.Get(id).ActivateTime;
            auction.DeactivateTime = DateTime.Now;
            auction.EndTime = DateTime.Today;
            auction.isActive = false;
            auction.ProductId = this.auction.Get(id).ProductId;
            auction.RowUpdateTime = DateTime.Now;
            this.auction.Update(id, auction);
        }

        public void AddProductAuction(int productId, string auctionName, float startupPrice, float redemptionPrice, DateTime endtime)
        {
            Auction auction = new Auction();
            auction.AuctionName = auctionName;
            auction.StrtupPrice = startupPrice;
            auction.RedemptionPrice = redemptionPrice;
            auction.EndTime = endtime;
            auction.isActive = false;
            auction.ProductId = productId;
            auction.RowInsertTime = DateTime.Now;
            this.auction.Create(auction);
        }
    }


}
