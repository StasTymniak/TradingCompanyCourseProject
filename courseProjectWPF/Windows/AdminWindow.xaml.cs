using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

using courseProjectWPF.ViewModels;

using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using BLL.Interfaces;
using BLL.Services;

using Unity;

namespace courseProjectWPF.Windows
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public static UnityContainer Container;
        public AdminWindow()
        {

            ConfigureUnity();
            InitializeComponent();
            DataContext = Container.Resolve<AdminMainViewModel>();

        }
        static private void ConfigureUnity()
        {
            Container = new UnityContainer();
            Container.RegisterType<IServiceCategory, ServiceCategory>()
                     .RegisterType<IRepository<Category>, CategoryRepository>()
                     .RegisterType<IServiceProduct, ServiceProduct>()
                     .RegisterType<IRepository<Product>, ProductRepository>();
        }
    }
}
