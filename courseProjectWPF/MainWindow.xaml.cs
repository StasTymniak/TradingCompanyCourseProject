using System.Windows;

using courseProjectWPF.ViewModels;

using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using BLL.Interfaces;
using BLL.Services;

using Unity;

namespace courseProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static UnityContainer Container;
        public MainWindow()
        {

            ConfigureUnity();
            InitializeComponent();
            DataContext = Container.Resolve<MainViewModel>();

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
