using System;
using BLL.Interfaces;
using BLL.Services;
using DAL.EntityFramework;
using DAL.Interfaces;
using System.Windows.Forms;
using System.Configuration;
using Domain;
using System.Collections.Generic;

namespace courseProjectWF
{
    public partial class LogInForm : Form
    {

        IServiceAuction _serviceAuction;
        IServiceCategory _serviceCategory;
        IServiceAuth _serviceAuth;
        IServiceProduct _serviceProduct;
        int userRole;
        List<int> logInData;
        mainForm MainForm;
        void UISetup()
        {
            tbPassword.PasswordChar = '*';
        }
        public LogInForm(IServiceAuction serviceAuction, IServiceAuth serviceAuth, IServiceProduct serviceProduct, IServiceCategory serviceCategory)
        {
            _serviceCategory = serviceCategory;
            _serviceAuction = serviceAuction;
            _serviceAuth = serviceAuth;
            _serviceProduct = serviceProduct;
            InitializeComponent();
            UISetup();          
        }

        private void bthLogIn_Click(object sender, EventArgs e)
        {
            logInData = _serviceAuth.LogIn(tbEmail.Text,tbPassword.Text);

            if(logInData[0]==1)
            {
                this.Hide();
                MainForm = new mainForm(_serviceAuction, _serviceProduct, _serviceCategory, logInData[1]);
                MainForm.ShowDialog();
            }
            else
                MessageBox.Show("Invalid data");
        }
    }
}
