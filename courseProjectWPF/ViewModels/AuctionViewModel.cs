using BLL.Interfaces;
using BLL.Services;
using courseProjectWPF.Commands;
using Domain;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace courseProjectWPF.ViewModels
{
    public class AuctionViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private Auction _selectedAuction;
        private ObservableCollection<Auction> _auctions = new ObservableCollection<Auction>();
        private IServiceProduct _serviceProduct;
        private IServiceCategory _serviceCategory;
        private IServiceAuction _serviceAuction;
        private string _auctionButtonContent;
        private MainViewModel _mainViewModel;
        public IServiceProduct serviceProduct { get => this._serviceProduct; }
        public IServiceCategory serviceCategory { get => this._serviceCategory; }
        public IServiceAuction serviceAuction { get => this._serviceAuction; }
        public Auction SelectedAuction
        {
            get { return this._selectedAuction; }
            set
            {
                this._selectedAuction = value;
                if(this._selectedAuction != null)
                {
                    if (this._selectedAuction.isActive == true)
                    {
                        AuctionButtonContent = "Deactivate";
                    }
                    else if (this._selectedAuction.isActive == false)
                    {
                        AuctionButtonContent = "Activate";
                    }
                    else
                    {
                        AuctionButtonContent = "";
                    }
                }
                
                OnPropertyChanged("SelectedAuction");
            }
        }
        public ObservableCollection<Auction> Auctions
        {
            get => this._auctions;
            set
            {
                this._auctions = value;
                OnPropertyChanged("Auctions");
            }
        }
        public string AuctionButtonContent
        {
            get=> this._auctionButtonContent;
            set
            {
                this._auctionButtonContent = value;
                OnPropertyChanged("AuctionButtonContent");
            }
        }

        public ICommand AuctionButtonCommand { get; set; }
        public AuctionViewModel(IServiceProduct serviceProduct, IServiceCategory serviceCategory, IServiceAuction serviceAuction, MainViewModel mainViewModel)
        {
            this._serviceProduct = serviceProduct;
            this._serviceCategory = serviceCategory;
            this._serviceAuction = serviceAuction;
            this._mainViewModel = mainViewModel;
            AuctionButtonCommand = new AuctionIsActiveCommand(this, this._mainViewModel);
            LoadData();
            
        }

        public void LoadData()
        {
            List<Auction> auctions = this._serviceAuction.GetAllAuctions();
            foreach (Auction auction in auctions)
            {
                Auctions.Add(auction);
            }
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
