using BLL.Interfaces;
using BLL.Services;
using courseProjectWPF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace courseProjectWPF.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        private IServiceCategory _serviceCategory;
        private IServiceProduct _serviceProduct;
        private IServiceAuth _serviceAuth;
        private BaseViewModel _selectedViewModel;
        private BaseViewModel _selectedAuthViewModel;
        private string _userRole;
        

        public MainViewModel(IServiceCategory serviceCategory, IServiceProduct serviceProduct, IServiceAuth serviceAuth)
        {
            this._serviceCategory = serviceCategory;
            this._serviceProduct = serviceProduct;
            this._serviceAuth = serviceAuth;
            this._selectedViewModel = new ProductViewModel(_serviceProduct, _serviceCategory);
            this._selectedAuthViewModel = new LoginViewModel(this,_serviceAuth);
            UpdateViewCommand = new UpdateViewCommand(this);
           
        }
        public string UserRole
        {
            get => this._userRole;
            set
            {
                this._userRole = value;
                OnPropertyChanged("UserRole");
            }
        }
        public BaseViewModel SelectedViewModel
        {
            get => this._selectedViewModel;
            set
            {
                this._selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public BaseViewModel SelectedAuthViewModel
        {
            get => this._selectedAuthViewModel;
            set
            {
                this._selectedAuthViewModel = value;
                OnPropertyChanged(nameof(SelectedAuthViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }
        public IServiceCategory ServiceCategory
        { 
            get => this._serviceCategory; 
            set => this._serviceCategory = value;
        }
        public IServiceProduct ServiceProduct
        {
            get => this._serviceProduct;
            set => this._serviceProduct = value;
        }
    }
}
