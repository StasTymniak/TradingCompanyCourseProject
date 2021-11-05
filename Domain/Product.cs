using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }
        public override bool Equals(object obj)
        {
            return Equals(obj as Product);
        }

        public bool Equals(Product obj)
        {
            return obj != null
                && obj.ProductId == this.ProductId
                && obj.ProductName == this.ProductName
                && obj.CategoryId == this.CategoryId
                && obj.RowInsertTime == this.RowInsertTime
                && obj.RowUpdateTime == this.RowUpdateTime;
        }

        public override int GetHashCode() => (ProductId, ProductName, CategoryId, RowInsertTime, RowUpdateTime).GetHashCode();
    }

}
