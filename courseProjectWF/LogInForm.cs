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
       
        IServiceAuction _serviceAuction = null;
        mainForm MainForm;
        void UISetup()
        {
            tbPassword.PasswordChar = '*';
        }
        public LogInForm(IServiceAuction serviceAuction)
        {
            _serviceAuction = serviceAuction;
            InitializeComponent();
            UISetup();
            MainForm = new mainForm(_serviceAuction);
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            MainForm.ShowDialog();
        }
    }
}
