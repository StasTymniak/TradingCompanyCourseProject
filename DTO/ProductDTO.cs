using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class ProductDTO
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
        public AuctionDTO Auction { get; set; }
    }
}
