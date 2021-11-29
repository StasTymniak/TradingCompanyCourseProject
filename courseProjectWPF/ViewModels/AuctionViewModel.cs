using BLL.Interfaces;
using BLL.Services;
using Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace courseProjectWPF.ViewModels
{
    public class AuctionViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private Auction _selectedAuction;
        private IServiceProduct _serviceProduct;
        private IServiceCategory _serviceCategory;
        private IServiceAuction _serviceAuction;

        public IEnumerable<Auction> Auctions { get; set; }
        public IServiceProduct serviceProduct { get => this._serviceProduct; }
        public IServiceCategory serviceCategory { get => this._serviceCategory; }
        public IServiceAuction serviceAuction { get => this._serviceAuction; }
        public Auction SelectedAuction
        {
            get { return this._selectedAuction; }
            set
            {
                this._selectedAuction = value;
                OnPropertyChanged("SelectedAuction");
            }
        }

        public AuctionViewModel(IServiceProduct serviceProduct, IServiceCategory serviceCategory, IServiceAuction serviceAuction)
        {
            this._serviceProduct = serviceProduct;
            this._serviceCategory = serviceCategory;
            this._serviceAuction = serviceAuction;
            LoadData();

        }

        public void LoadData()
        {
            Auctions = this._serviceAuction.GetAllAuctions();
        }

        #region INotify
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
