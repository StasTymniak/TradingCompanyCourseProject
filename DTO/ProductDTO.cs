using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public ProductDTO CreateMappToDTO(Product product)
        {
            this.ProductId = this.ProductId;
            this.ProductName = product.ProductName;
            this.CategoryId = product.CategoryId;
            this.RowInsertTime = product.RowInsertTime;
            this.RowUpdateTime = this.RowUpdateTime;
            return this;
        }
        public ProductDTO UpdateMappToDTO(Product product)
        {
            this.ProductId = this.ProductId;
            this.ProductName = product.ProductName;
            this.CategoryId = product.CategoryId;
            this.RowInsertTime = this.RowInsertTime;
            this.RowUpdateTime = product.RowUpdateTime;
            return this;
        }
    }
}
