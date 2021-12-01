using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Domain
{
    public class Auction:INotifyPropertyChanged
    {
        [Key]
        private int _id;
        private string _name;
        private float _startuPrice;
        private float _redemptionPrice;
        private bool _isActive;
        private DateTime _activateTime;
        private DateTime _deactivateTime;
        private DateTime _endTime;
        private int _productId;
        private DateTime _rowInsertTime;
        private DateTime _rowUpdateTime;
        public int AuctionId 
        { 
            get=>this._id;
            set
            {
                this._id = value;
                OnPropertyChanged("AuctionId");
            }
        }
        public string AuctionName
        {
            get => this._name;
            set
            {
                this._name = value;
                OnPropertyChanged("AuctionName");
            }
        }
        public float StrtupPrice
        {
            get => this._startuPrice;
            set
            {
                this._startuPrice = value;
                OnPropertyChanged("StrtupPrice");
            }
        }
        public float RedemptionPrice
        {
            get => this._redemptionPrice;
            set
            {
                this._redemptionPrice = value;
                OnPropertyChanged("RedemptionPrice");
            }
        }
        public bool isActive
        {
            get => this._isActive;
            set
            {
                this._isActive = value;
                OnPropertyChanged("isActive");
            }
        }
        public DateTime ActivateTime
        {
            get => this._activateTime;
            set
            {
                this._activateTime = value;
                OnPropertyChanged("ActivateTime");
            }
        }
        public DateTime DeactivateTime
        {
            get => this._deactivateTime;
            set
            {
                this._deactivateTime = value;
                OnPropertyChanged("DeactivateTime");
            }
        }
        public DateTime EndTime
        {
            get => this._endTime;
            set
            {
                this._endTime = value;
                OnPropertyChanged("EndTime");
            }
        }
        public int ProductId
        {
            get => this._productId;
            set
            {
                this._productId = value;
                OnPropertyChanged("ProductId");
            }
        }
        public DateTime RowInsertTime
        {
            get => this._rowInsertTime;
            set
            {
                this._rowInsertTime = value;
                OnPropertyChanged("RowInsertTime");
            }
        }
        public DateTime RowUpdateTime
        {
            get => this._rowUpdateTime;
            set
            {
                this._rowUpdateTime = value;
                OnPropertyChanged("RowUpdateTime");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

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
