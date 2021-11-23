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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {

        public static UnityContainer Container;
        public UserWindow()
        {
            ConfigureUnity();
            InitializeComponent();
            DataContext = Container.Resolve<UserMainViewModel>();

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
