using System;
using BLL.Interfaces;
using BLL.Services;
using DAL.EntityFramework;
using DAL.Interfaces;
using System.Windows.Forms;
using System.Configuration;
using Domain;

namespace courseProjectWF
{
    public partial class LogInForm : Form
    {

        IServiceAuction _serviceAuction;
        IServiceAuth _serviceAuth;
        mainForm MainForm;
        void UISetup()
        {
            tbPassword.PasswordChar = '*';
        }
        public LogInForm(IServiceAuction serviceAuction, IServiceAuth serviceAuth)
        {
            _serviceAuction = serviceAuction;
            _serviceAuth = serviceAuth;
            InitializeComponent();
            UISetup();
            MainForm = new mainForm(_serviceAuction);
        }

        private void bthLogIn_Click(object sender, EventArgs e)
        {
            if (_serviceAuth.LogIn(tbEmail.Text, tbPassword.Text))
                MainForm.ShowDialog();
            else
                MessageBox.Show("Invalid data");
        }
    }
}
