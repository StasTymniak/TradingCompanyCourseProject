using System;
using System.ComponentModel.DataAnnotations;

using Domain;

namespace DTO
{
    public class AuctionDTO
    {
        [Key]
        public int AuctionId { get; set; }
        public string AuctionName { get; set; }
        public float StrtupPrice { get; set; }
        public float RedemptionPrice { get; set; }
        public bool isActive { get; set; }
        public DateTime ActivateTime { get; set; }
        public DateTime DeactivateTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ProductId { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }

        public Auction MappFromDTO() => new Auction
        {
            AuctionId = this.AuctionId,
            AuctionName = this.AuctionName,
            StrtupPrice = this.StrtupPrice,
            RedemptionPrice = this.RedemptionPrice,
            isActive = this.isActive,
            ActivateTime = this.ActivateTime,
            DeactivateTime = this.DeactivateTime,
            EndTime = this.EndTime,
            ProductId = this.ProductId,
            RowInsertTime = this.RowInsertTime,
            RowUpdateTime = this.RowUpdateTime
        };
        public AuctionDTO CreateMappToDTO(Auction auction)
        {
            this.AuctionId = this.AuctionId;
            this.AuctionName = auction.AuctionName;
            this.StrtupPrice = auction.StrtupPrice;
            this.RedemptionPrice = auction.RedemptionPrice;
            this.isActive = auction.isActive;
            this.ActivateTime = auction.ActivateTime;
            this.DeactivateTime = auction.DeactivateTime;
            this.EndTime = auction.EndTime;
            this.ProductId = auction.ProductId;
            this.RowInsertTime = auction.RowInsertTime;
            this.RowUpdateTime = this.RowUpdateTime;
            return this;
        }
        public AuctionDTO UpdateMappToDTO(Auction auction)
        {
            this.AuctionId = this.AuctionId;
            this.AuctionName = auction.AuctionName;
            this.StrtupPrice = auction.StrtupPrice;
            this.RedemptionPrice = auction.RedemptionPrice;
            this.isActive = auction.isActive;
            this.ActivateTime = auction.ActivateTime;
            this.DeactivateTime = auction.DeactivateTime;
            this.EndTime = auction.EndTime;
            this.ProductId = auction.ProductId;
            this.RowInsertTime = this.RowInsertTime;
            this.RowUpdateTime = auction.RowUpdateTime;
            return this;
        }

    }
}
