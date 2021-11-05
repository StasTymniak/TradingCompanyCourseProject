using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Domain
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }
        public override bool Equals(object obj)
        {
            return Equals(obj as Category);
        }

        public bool Equals(Category obj)
        {
            return obj != null
                && obj.CategoryId == this.CategoryId
                && obj.CategoryName == this.CategoryName
                && obj.RowInsertTime == this.RowInsertTime
                && obj.RowUpdateTime == this.RowUpdateTime;
        }

        public override int GetHashCode() => (CategoryId, CategoryName, RowInsertTime, RowUpdateTime).GetHashCode();

    }
}