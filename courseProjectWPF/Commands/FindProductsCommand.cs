using System;
using System.Windows.Input;

using courseProjectWPF.ViewModels;

using Domain;
namespace courseProjectWPF.Commands
{
    internal class FindProductsCommand : ICommand
    {
        private ProductViewModel _productViewModel;

        public FindProductsCommand(ProductViewModel productViewModel)
        {
            this._productViewModel = productViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {           
            return true;
        }

        public void Execute(object parameter)
        {
            this._productViewModel.Products_Category.Clear();
            if (parameter.ToString() == "" || parameter.ToString()==null)
            {
                foreach (Product product in this._productViewModel.serviceProduct.GetAllProducts())
                {
                    this._productViewModel.Products_Category.Add(new Tuple<Product, string>(product, this._productViewModel.serviceCategory.GetCategory(product.CategoryId).CategoryName));
                }
            }
            else
            {
                foreach (Product product in this._productViewModel.serviceProduct.GetProductsByCategory(new Category { CategoryId = this._productViewModel.serviceCategory.GetCategory(parameter.ToString()).CategoryId }))
                {
                    this._productViewModel.Products_Category.Add(new Tuple<Product, string>(product, this._productViewModel.serviceCategory.GetCategory(product.CategoryId).CategoryName));
                }
            }
        }
    }
}
