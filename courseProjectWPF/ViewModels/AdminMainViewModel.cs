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
    internal class AdminMainViewModel:BaseViewModel
    {
        private IServiceCategory _serviceCategory;
        private IServiceProduct _serviceProduct;
        private BaseViewModel _selectedViewModel;
        public AdminMainViewModel(IServiceCategory serviceCategory, IServiceProduct serviceProduct)
        {
            this._serviceCategory = serviceCategory;
            this._serviceProduct = serviceProduct;
            this._selectedViewModel = new ProductViewModel(this._serviceProduct,this._serviceCategory);
            UpdateViewCommand = new UpdateViewCommand(this);

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
