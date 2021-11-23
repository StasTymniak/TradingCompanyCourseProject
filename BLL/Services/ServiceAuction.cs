using System;
using System.Collections.Generic;
using System.Linq;

using BLL.Services;
using DAL.Interfaces;
using Domain;

namespace BLL.Interfaces
{
    public class ServiceAuction : IServiceAuction
    {
        private readonly IRepository<Auction> _auctionRepository;

        public ServiceAuction(IRepository<Auction> auctionRepository)
            => this._auctionRepository = auctionRepository;

        public Auction ActiveAuction(int id)
            => this._auctionRepository.Update(id,
                new Auction
                {
                    AuctionName = this._auctionRepository.Get(id).AuctionName,
                    StrtupPrice = this._auctionRepository.Get(id).StrtupPrice,
                    RedemptionPrice = this._auctionRepository.Get(id).RedemptionPrice,
                    ActivateTime = DateTime.Now,
                    DeactivateTime = this._auctionRepository.Get(id).DeactivateTime,
                    EndTime = this._auctionRepository.Get(id).EndTime,
                    isActive = true,
                    ProductId = this._auctionRepository.Get(id).ProductId,
                    RowUpdateTime = DateTime.Now
                });

        public Auction DeactiveAuction(int id)
        => this._auctionRepository.Update(id,
                new Auction
                {
                    AuctionName = this._auctionRepository.Get(id).AuctionName,
                    StrtupPrice = this._auctionRepository.Get(id).StrtupPrice,
                    RedemptionPrice = this._auctionRepository.Get(id).RedemptionPrice,
                    ActivateTime = DateTime.Now,
                    DeactivateTime = this._auctionRepository.Get(id).DeactivateTime,
                    EndTime = this._auctionRepository.Get(id).EndTime,
                    isActive = false,
                    ProductId = this._auctionRepository.Get(id).ProductId,
                    RowUpdateTime = DateTime.Now
                });

        public List<Auction> GetAllActiveAuctions()
            => this._auctionRepository
                .GetAll().FindAll(a => a.isActive == true).ToList();

        public List<Auction> GetAllAuctions()
            => _auctionRepository.GetAll();

        public Auction AddAuction(int productId, string auctionName, float startupPrice, float redemptionPrice, DateTime endtime)
            => this._auctionRepository.Create(
                new Auction
                {
                    AuctionName = auctionName,
                    StrtupPrice = startupPrice,
                    RedemptionPrice = redemptionPrice,
                    EndTime = endtime,
                    isActive = false,
                    ProductId = productId,
                    RowInsertTime = DateTime.Now
                });
    }
}