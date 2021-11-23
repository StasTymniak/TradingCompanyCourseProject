using BLL.Interfaces;
using BLL.Services;
using DAL.ADO.NET;
using DAL.EntityFramework;
using DAL.Interfaces;
using Domain;
using System;
using System.Windows.Forms;
using Unity;

namespace courseProjectWF
{
    internal static class Program
    {
        public static UnityContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureUnity();

            LogInForm logInForm = Container.Resolve<LogInForm>();
            if (logInForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(Container.Resolve<mainForm>());
            }
            else
            {
                Application.Exit();
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
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
    }
}
