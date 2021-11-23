using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Auction
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

        public override bool Equals(object obj) => Equals(obj as Auction);
        public bool Equals(Auction obj) =>
                obj != null
                && obj.AuctionId == this.AuctionId
                && obj.AuctionName == this.AuctionName
                && obj.StrtupPrice == this.StrtupPrice
                && obj.RedemptionPrice == this.RedemptionPrice
                && obj.isActive == this.isActive
                && obj.ActivateTime == this.ActivateTime
                && obj.DeactivateTime == this.DeactivateTime
                && obj.EndTime == this.EndTime
                && obj.ProductId == this.ProductId
                && obj.RowInsertTime == this.RowInsertTime
                && obj.RowUpdateTime == this.RowUpdateTime;
        public override int GetHashCode() => (AuctionId, AuctionName, StrtupPrice, RedemptionPrice, isActive, ActivateTime, DeactivateTime, EndTime, ProductId, RowInsertTime, RowUpdateTime).GetHashCode();
    }
}
