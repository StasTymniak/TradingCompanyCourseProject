using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Domain;
using BLL.Services;
using DAL.EntityFramework;
using BLL.Interfaces;

namespace courseProjectWPF.ViewModels
{
    public class CategoryViewModel :BaseViewModel, INotifyPropertyChanged
    {
        private Category selectedCategory;

        private IServiceCategory _serviceCategory;
        public IEnumerable<Category> Categories { get; set; }
        public Category SelectedCategory
        {
            get { return selectedCategory; }
            set
            {
                selectedCategory = value;
                OnPropertyChanged("SelectedCategory");
            }
        }

        public CategoryViewModel(IServiceCategory serviceCategory)
        {
            _serviceCategory = serviceCategory;
            Categories = _serviceCategory.GetAllCategory();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
