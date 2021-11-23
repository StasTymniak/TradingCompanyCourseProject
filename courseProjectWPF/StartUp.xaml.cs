using System.Windows;

using courseProjectWPF.ViewModels;

using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using BLL.Interfaces;
using BLL.Services;

using Unity;
using DAL.ADO.NET;

namespace courseProjectWPF
{
    /// <summary>
    /// Interaction logic for StartUp.xaml
    /// </summary>
    public partial class StartUp : Window
    {
        public static UnityContainer Container;
        public StartUp()
        {
            
            ConfigureUnity();
            InitializeComponent();
            LogInWindow loginWindow = Container.Resolve<LogInWindow>();
            this.Close();
            loginWindow.Show(); 
        }
        static private void ConfigureUnity()
        {
            Container = new UnityContainer();
            Container.RegisterType<IServiceAuth, ServiceAuth>()
                     .RegisterType<IUserRepository, UserRepository>();
        }
    }
}
