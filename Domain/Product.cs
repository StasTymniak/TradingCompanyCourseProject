using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


namespace Domain
{
    public class Product: INotifyPropertyChanged
    {
        [Key]
        private int _productId;
        private string _productName;
        private int _categoryId;
        private DateTime _rowInsertTime;
        private DateTime _rowUpdateTime;

        public int ProductId
        {
            get => _productId;
            set
            {
                _productId = value;
                OnPropertyChanged("ProductId");
            }
        }
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }
        public int CategoryId
        {
            get => _categoryId;
            set
            {
                _categoryId = value;
                OnPropertyChanged("CategoryId");
            }
        }
        public DateTime RowInsertTime
        {
            get => _rowInsertTime;
            set
            {
                _rowInsertTime = value;
                OnPropertyChanged("RowInsertTime");
            }
        }
        public DateTime RowUpdateTime
        {
            get => _rowUpdateTime;
            set
            {
                _rowUpdateTime = value;
                OnPropertyChanged("RowUpdateTime");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        //Equals override
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
        //GetHashCode override
        public override int GetHashCode() => (ProductId, ProductName, CategoryId, RowInsertTime, RowUpdateTime).GetHashCode();
    }

}
