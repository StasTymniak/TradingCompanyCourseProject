using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
