using courseProjectWPF.ViewModels;
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
            if (parameter.ToString() == "Categories")
            {
                _mainViewModel.SelectedViewModel = new CategoryViewModel(_mainViewModel.ServiceCategory);
            }
            else if(parameter.ToString() == "Products")
            {
                _mainViewModel.SelectedViewModel = new ProductViewModel(_mainViewModel.ServiceProduct, _mainViewModel.ServiceCategory);
            }
        }
    }
}
