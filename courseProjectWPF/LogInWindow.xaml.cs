using BLL.Interfaces;
using courseProjectWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace courseProjectWPF
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        private IServiceAuth _serviceAuth;
        private List<int> _logInData;
        public LogInWindow(IServiceAuth serviceAuth)
        {
            InitializeComponent();
            this._serviceAuth = serviceAuth;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            this._logInData = _serviceAuth.LogIn(txtEmail.Text, txtPassword.Text);

            if (this._logInData[0] == 1)
            {
                if (this._logInData[1] == 2)
                {
                    this.Hide();
                    UserWindow userWindow = new UserWindow();
                    userWindow.Show();
                }
                else if(this._logInData[1] == 1)
                {
                    this.Hide();
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                }
            }
            else
                MessageBox.Show("Invalid data");
        }
    }
}
