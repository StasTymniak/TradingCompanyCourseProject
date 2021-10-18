using System;
using System.ComponentModel.DataAnnotations;
using Domain;
namespace DTO
{
    public class ProductDTO
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }
        public Product MappFromDTO() => new Product
        {
            ProductId = this.ProductId,
            ProductName = this.ProductName,
            CategoryId = this.CategoryId,
            RowInsertTime = this.RowInsertTime,
            RowUpdateTime = this.RowUpdateTime
        };

        public ProductDTO MappToDTO(Product product)
        {
            this.ProductId = this.ProductId;
            this.ProductName = product.ProductName;
            this.CategoryId = product.CategoryId;
            this.RowInsertTime = product.RowInsertTime;
            this.RowUpdateTime = product.RowUpdateTime;
            return this;
        }
    }
}
