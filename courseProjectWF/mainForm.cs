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

    }
}
