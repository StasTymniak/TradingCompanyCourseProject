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
    public class ProductViewModel:BaseViewModel, INotifyPropertyChanged, IDataErrorInfo
    {

        private Product _selectedProduct;
        private string _selectedCategoryName;
        private Tuple<Product, string> _selectedItem;
        private string _startupPrice;
        private string _redemptionPrice;
        private string _endTime;
        private IServiceProduct _serviceProduct;
        private IServiceCategory _serviceCategory;
        private MainViewModel _mainViewModel;
        private bool _buttonCreateIsEnable;
        private ObservableCollection<Tuple<Product, string>> _Products_Category = new ObservableCollection<Tuple<Product, string>>();
        public ICommand FindProductsCommand { get; set; }
        public ICommand CreateNewAuctionCommand { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IServiceProduct serviceProduct { get => this._serviceProduct;}
        public IServiceCategory serviceCategory { get => this._serviceCategory; }

        public ProductViewModel(IServiceProduct serviceProduct, IServiceCategory serviceCategory, MainViewModel mainViewModel)
        {
            this._serviceProduct = serviceProduct;
            this._serviceCategory = serviceCategory;
            this._mainViewModel = mainViewModel;
            LoadData();

        }

        #region Properties
        public MainViewModel MainViewModel
        {
            get => this._mainViewModel;
        }
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

        public string AuctionStartupPrice
        { 
            get => this._startupPrice;
            set
            {
                this._startupPrice = value;
                OnPropertyChanged("AuctionStartupPrice");
            }
        }
        public string AuctionRedemptionPrice
        { 
            get => this._redemptionPrice;
            set
            {
                this._redemptionPrice = value;
                OnPropertyChanged("AuctionRedemptionPrice");
            }
        }
        public string AuctionEndTime
        {
            get => this._endTime;
            set
            {
                this._endTime = value;
                OnPropertyChanged("AuctionEndTime");
            }
        }

        public bool ButtonCreateIsEnable
        {
            get => this._buttonCreateIsEnable;
            set
            {
                this._buttonCreateIsEnable = value;
                OnPropertyChanged("ButtonCreateIsEnable");
            }
        }
        #endregion

        #region Methods
        public void LoadData()
        {
            Products = this._serviceProduct.GetAllProducts();
            foreach (Product product in Products)
            {
                Products_Category.Add(new Tuple<Product, string>(product, this._serviceCategory.GetCategory(product.CategoryId).CategoryName));
            }
            CreateNewAuctionCommand = new CreateAuctionCommand(this, this._mainViewModel);
            FindProductsCommand = new FindProductsCommand(this);
        }
        #endregion

        #region Validation

        private float _starpUpPrice;
        private float _redmPrice;
        private DateTime _endTimeV;

        public string Error { get { return null; } }
        public Dictionary<string,string> ErrorCollection { get; private set; } = new Dictionary<string,string>();
        private bool _isValidPrice1 { get; set; }
        private bool _isValidPrice2 { get; set; }
        private bool _isValidEndTime { get; set; }

        public bool IsValidPrice1
        {
            get => this._isValidPrice1;
            set
            {
                if (this._isValidPrice1 != value)
                    this._isValidPrice1 = value;
            }
        }
        public bool IsValidPrice2
        {
            get => this._isValidPrice2;
            set
            {
                if (this._isValidPrice2 != value)
                    this._isValidPrice2 = value;
            }
        }
        public bool IsValidEndTime
        {
            get => this._isValidEndTime;
            set
            {
                if (this._isValidEndTime != value)
                    this._isValidEndTime = value;
            }
        }
        public string this[string name]
        {
            get
            {
                string _result = null;
                switch (name)
                {                   
                    case "AuctionStartupPrice":
                        if (string.IsNullOrWhiteSpace(AuctionStartupPrice))
                        {
                            _result = "Price cannot be empty";
                            IsValidPrice1 = false;
                        }
                        else if (!float.TryParse(AuctionStartupPrice, out this._starpUpPrice))
                        {
                            _result = "Entered data is not float type";
                            IsValidPrice1 = false;
                        }
                        else if (float.Parse(AuctionStartupPrice) < 0)
                        {
                            _result = "Price must be positive";
                            IsValidPrice1 = false;
                        }
                        else
                        {
                            IsValidPrice1 = true;
                        }
                        break;
                    case "AuctionRedemptionPrice":
                        if (string.IsNullOrWhiteSpace(AuctionRedemptionPrice))
                        {
                            _result = "Price cannot be empty";
                            IsValidPrice2 = false;
                        }
                        else if (!float.TryParse(AuctionRedemptionPrice, out this._redmPrice))
                        {
                            _result = "Entered data is not float type";
                            IsValidPrice2 = false;
                        }
                        else if (float.Parse(AuctionRedemptionPrice) < 0)
                        {
                            _result = "Price must be positive";
                            IsValidPrice2 = false;
                        }
                        else
                        {
                            IsValidPrice2 = true;
                        }
                        break;
                    case "AuctionEndTime":
                        if (string.IsNullOrWhiteSpace(AuctionEndTime))
                        {
                            _result = "Date cannot be empty";
                            IsValidEndTime = false;
                        }
                        else if (!DateTime.TryParse(AuctionEndTime, out this._endTimeV))
                        {
                            _result = "Entered data is not Date time format";
                            IsValidEndTime = false;
                        }
                        else
                        {
                            IsValidEndTime = true;
                        }
                        break;
                        
                }

                if (ErrorCollection.ContainsKey(name))
                    ErrorCollection[name] = _result;
                else if(_result != null)
                    ErrorCollection.Add(name, _result);
                if (IsValidPrice1 && IsValidPrice2 && IsValidEndTime)
                    ButtonCreateIsEnable = true;
                else
                    ButtonCreateIsEnable = false;

                OnPropertyChanged("ErrorCollection");               
                return _result;
            }
        }

        #endregion
        
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
