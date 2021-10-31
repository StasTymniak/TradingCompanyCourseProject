using System;
using BLL.Interfaces;
using BLL.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace courseProjectWF
{
    public partial class mainForm : Form
    {
        private readonly IServiceAuction _serviceAuction;
        public mainForm(IServiceAuction serviceAuction)
        {
            _serviceAuction = serviceAuction;  
            InitializeComponent();
            List<Auction> auctions = _serviceAuction.GetAllAuctions();
        }

        private void CreateDynamicLabelAndInput()
        {
            Label NameOfAuction = new Label();
            this.Controls.Add(NameOfAuction);

            NameOfAuction.Location = new Point(50, 50);
            NameOfAuction.Size = new Size(100, 25);
            NameOfAuction.Text = "Name Of Auction";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDynamicLabelAndInput();
        }
    }
}
