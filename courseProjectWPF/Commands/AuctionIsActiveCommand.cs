using courseProjectWPF.ViewModels;
using Domain;
using System;
using System.Windows.Input;

namespace courseProjectWPF.Commands
{
    internal class AuctionIsActiveCommand : ICommand
    {
        private AuctionViewModel _auctionViewModel;
        private MainViewModel _mainViewModel;
        public AuctionIsActiveCommand(AuctionViewModel auctionViewModel, MainViewModel mainViewModel)
        {
            this._auctionViewModel = auctionViewModel;
            this._mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (this._auctionViewModel.SelectedAuction.isActive == true)
            {
                this._auctionViewModel.serviceAuction.DeactiveAuction(this._auctionViewModel.SelectedAuction.AuctionId);
                this._auctionViewModel.Auctions.Clear();
                foreach (Auction auction in this._auctionViewModel.serviceAuction.GetAllAuctions())
                {
                    this._auctionViewModel.Auctions.Add(auction);
                }
            }
            else if (this._auctionViewModel.SelectedAuction.isActive == false)
            {
                this._auctionViewModel.serviceAuction.ActiveAuction(this._auctionViewModel.SelectedAuction.AuctionId);
                this._auctionViewModel.Auctions.Clear();
                foreach (Auction auction in this._auctionViewModel.serviceAuction.GetAllAuctions())
                {
                    this._auctionViewModel.Auctions.Add(auction);
                }
            }
        }
    }
}
