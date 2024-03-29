﻿using courseProjectWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace courseProjectWPF.Commands
{
    internal class UpdateViewCommand : ICommand
    {
        private MainViewModel _mainViewModel;

        public UpdateViewCommand(MainViewModel mainViewModel)
        {
            this._mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(_mainViewModel.UserRole == "Admin")
            {
                if (parameter.ToString() == "Categories")
                {
                    this._mainViewModel.SelectedViewModel = new CategoryViewModel(this._mainViewModel.ServiceCategory);
                }
                else if (parameter.ToString() == "Products")
                {
                    this._mainViewModel.SelectedViewModel = new ProductViewModel(this._mainViewModel.ServiceProduct, this._mainViewModel.ServiceCategory,this._mainViewModel);
                }
                else if (parameter.ToString() == "Auctions")
                {
                    this._mainViewModel.SelectedViewModel = new AuctionViewModel(this._mainViewModel.ServiceProduct, this._mainViewModel.ServiceCategory,this._mainViewModel.ServiceAuction, this._mainViewModel);
                }
            }
            else
            {
                if (parameter.ToString() == "Products")
                {
                    this._mainViewModel.SelectedViewModel = new UserProductViewModel();
                }
                else if (parameter.ToString() == "Categories")
                {
                    this._mainViewModel.SelectedViewModel =  new UserProductViewModel();
                }
            }
        }
    }
}
