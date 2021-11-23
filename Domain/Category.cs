using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


namespace Domain
{
    public class Category: INotifyPropertyChanged
    {
        [Key]
        private int _categoryId;
        private string _categoryName;
        private DateTime _rowInsertTime;
        private DateTime _rowUpdateTime;
        public int CategoryId
        {
            get { return _categoryId; }
            set
            {
                _categoryId = value;
                OnPropertyChanged("CategoryId");
            }
        }
        public string CategoryName
        {
            get { return _categoryName; }
            set
            {
                _categoryName = value;
                OnPropertyChanged("CategoryName");
            }
        }
        public DateTime RowInsertTime
        {
            get { return _rowInsertTime; }
            set
            {
                _rowInsertTime = value;
                OnPropertyChanged("RowInsertTime");
            }
        }
        public DateTime RowUpdateTime
        {
            get { return _rowUpdateTime; }
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

        //GetHashCode override
        public override int GetHashCode() => (CategoryId, CategoryName, RowInsertTime, RowUpdateTime).GetHashCode();

    }
}