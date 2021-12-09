using courseProjectWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace courseProjectWPF.Commands
{
    public class CreateAuctionCommand : ICommand
    {
        private MainViewModel _mainViewModel;
        private ProductViewModel _productViewModel;

        public CreateAuctionCommand(ProductViewModel productViewModel,MainViewModel mainViewModel)
        {
            this._mainViewModel = mainViewModel;
            this._productViewModel = productViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this._productViewModel.ButtonCreateIsEnable;
        }

        public void Execute(object parameter)
        {
            this._mainViewModel.ServiceAuction.AddAuction(
                this._productViewModel.SelectedItem.Item1.ProductId,
                $"{this._productViewModel.SelectedItem.Item1.ProductName} Auction",
                float.Parse(this._productViewModel.AuctionStartupPrice),
                float.Parse(this._productViewModel.AuctionRedemptionPrice),
                Convert.ToDateTime(this._productViewModel.AuctionEndTime));
            this._productViewModel.AuctionStartupPrice = "";
            this._productViewModel.AuctionRedemptionPrice = "";
            this._productViewModel.AuctionEndTime = "";
        }
    }
}
