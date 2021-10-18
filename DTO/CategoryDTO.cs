using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Domain;

namespace DTO
{
    public class CategoryDTO
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }
        public Category MappFromDTO() => new Category
        {
            CategoryId=this.CategoryId,
            CategoryName=this.CategoryName,
            RowInsertTime=this.RowInsertTime,
            RowUpdateTime=this.RowUpdateTime
        };
        public CategoryDTO MappToDTO(Category category)
        {
            this.CategoryId = this.CategoryId;
            this.CategoryName = category.CategoryName;
            this.RowInsertTime = category.RowInsertTime;
            this.RowUpdateTime = category.RowUpdateTime;
            return this;
        }
    }
}