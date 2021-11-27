using System.Windows;
using System.Windows.Input;

using courseProjectWPF.ViewModels;

using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using BLL.Interfaces;
using BLL.Services;

using Unity;
using DAL.ADO.NET;

namespace courseProjectWPF.Windows
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
            Container.RegisterType<IServiceAuction, ServiceAuction>()
                      .RegisterType<IServiceCategory, ServiceCategory>()
                      .RegisterType<IServiceAuth, ServiceAuth>()
                      .RegisterType<IServiceProduct, ServiceProduct>()
                      .RegisterType<IUserRepository, UserRepository>()
                      .RegisterType<IRepository<Auction>, AuctionRepository>()
                      .RegisterType<IRepository<Product>, ProductRepository>()
                      .RegisterType<IRepository<Category>, CategoryRepository>();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }
        private void CloseCommandBinding_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            if (MessageBox.Show("Close?", "Close", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }

        }
    }
}
