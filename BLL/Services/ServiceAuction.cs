using BLL.Services;
using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public class ServiceAuction : IServiceAuction
    {
        private readonly IRepository<Auction> _auctionRepository;
        public ServiceAuction(IRepository<Auction> auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }
        public bool ActiveAuction(int id)
        {
            Auction auction = new Auction();
            auction.AuctionName = this._auctionRepository.Get(id).AuctionName;
            auction.StrtupPrice = this._auctionRepository.Get(id).StrtupPrice;
            auction.RedemptionPrice = this._auctionRepository.Get(id).RedemptionPrice;
            auction.ActivateTime = DateTime.Now;
            auction.DeactivateTime = this._auctionRepository.Get(id).DeactivateTime;
            auction.EndTime = this._auctionRepository.Get(id).EndTime;
            auction.isActive = true;
            auction.ProductId = this._auctionRepository.Get(id).ProductId;
            auction.RowUpdateTime = DateTime.Now;
            this._auctionRepository.Update(id, auction);
            return true;
        }

        public bool DeactiveAuction(int id)
        {
            Auction auction = new Auction();
            auction.AuctionName = this._auctionRepository.Get(id).AuctionName;
            auction.StrtupPrice = this._auctionRepository.Get(id).StrtupPrice;
            auction.RedemptionPrice = this._auctionRepository.Get(id).RedemptionPrice;
            auction.ActivateTime = this._auctionRepository.Get(id).ActivateTime;
            auction.DeactivateTime = DateTime.Now;
            auction.EndTime = this._auctionRepository.Get(id).EndTime;
            auction.isActive = false;
            auction.ProductId = this._auctionRepository.Get(id).ProductId;
            auction.RowUpdateTime = DateTime.Now;
            this._auctionRepository.Update(id, auction);
            return true;
        }

        public List<Auction> GetAllActiveAuctions()
        {
            List<Auction> auctions = _auctionRepository.GetAll();
            var selectedauctions = from auction in auctions
                                   where auction.isActive == true
                                   select auction;
            List<Auction> findedauctions = new List<Auction>();
            foreach (Auction item in selectedauctions)
            {
                findedauctions.Add(item);
            }
            return findedauctions;
        }

        public List<Auction> GetAllAuctions()
        {
            List<Auction> auctions = _auctionRepository.GetAll();
            return auctions;
        }
        public void AddAuction(int productId, string auctionName, float startupPrice, float redemptionPrice, DateTime endtime)
        {
            Auction auction = new Auction();
            auction.AuctionName = auctionName;
            auction.StrtupPrice = startupPrice;
            auction.RedemptionPrice = redemptionPrice;
            auction.EndTime = endtime;
            auction.isActive = false;
            auction.ProductId = productId;
            auction.RowInsertTime = DateTime.Now;
            this._auctionRepository.Create(auction);
        }
    }
}
