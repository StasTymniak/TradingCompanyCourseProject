using BLL.Interfaces;
using BLL.Services;
using courseProjectWPF.Commands;
using Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace courseProjectWPF.ViewModels
{
    public class ProductViewModel:BaseViewModel, INotifyPropertyChanged
    {
        private Product _selectedProduct;
        private string _selectedCategoryName;
        private Tuple<Product, string> _selectedItem;
        private IServiceProduct _serviceProduct;
        private IServiceCategory _serviceCategory;
        private ObservableCollection<Tuple<Product, string>> _Products_Category = new ObservableCollection<Tuple<Product, string>>();
        public ICommand GetBooks { get; set; }
        public ICommand FindProductsCommand { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IServiceProduct serviceProduct { get => this._serviceProduct;}
        public IServiceCategory serviceCategory { get => this._serviceCategory; }
        public Product SelectedProduct
        {
            get { return this._selectedProduct; }
            set
            {
                this._selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        public string SelectedCategoryName
        {
            get { return this._selectedCategoryName; }
            set
            {
                this._selectedCategoryName = value;
                OnPropertyChanged("SelectedCategoryName");
            }
        }
        public Tuple<Product, string> SelectedItem
        {
            get { return this._selectedItem; }
            set
            {
                this._selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public ObservableCollection<Tuple<Product, string>> Products_Category
        {
            get => this._Products_Category;
            set
            {
                this._Products_Category = value;
                OnPropertyChanged("Products_Category");
            }
        }
        public ProductViewModel(IServiceProduct serviceProduct, IServiceCategory serviceCategory)
        {
            this._serviceProduct = serviceProduct;
            this._serviceCategory = serviceCategory;
            LoadData();
        }

        public void LoadData()
        {
            Products = this._serviceProduct.GetAllProducts();
            foreach (Product product in Products)
            {
                Products_Category.Add(new Tuple<Product, string>(product, this._serviceCategory.GetCategory(product.CategoryId).CategoryName));
            }
            GetBooks = new GetBooksCommand(this);
            FindProductsCommand = new FindProductsCommand(this);
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
