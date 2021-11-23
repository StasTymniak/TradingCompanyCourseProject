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
        private AdminMainViewModel _adminViewModel;

        public UpdateViewCommand(AdminMainViewModel adminViewModel)
        {
            this._adminViewModel = adminViewModel;
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
                this._adminViewModel.SelectedViewModel = new CategoryViewModel(this._adminViewModel.ServiceCategory);
            }
            else if(parameter.ToString() == "Products")
            {
                this._adminViewModel.SelectedViewModel = new ProductViewModel(this._adminViewModel.ServiceProduct, this._adminViewModel.ServiceCategory);
            }
        }
    }
}
