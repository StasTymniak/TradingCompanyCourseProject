using courseProjectWPF.ViewModels;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace courseProjectWPF.Commands
{
    internal class GetBooksCommand : ICommand
    {
        private ProductViewModel _productViewModel;

        public GetBooksCommand(ProductViewModel productViewModel)
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
           foreach (Product product in this._productViewModel.serviceProduct.GetProductsByCategory(new Category { CategoryId = this._productViewModel.serviceCategory.GetCategory("Books").CategoryId }))
            {
                this._productViewModel.Products_Category.Add(new Tuple<Product, string>(product, this._productViewModel.serviceCategory.GetCategory(product.CategoryId).CategoryName));
            }
        }
    }
}
