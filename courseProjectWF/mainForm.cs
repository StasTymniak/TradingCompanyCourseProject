using System;
using System.Data;
using System.Windows.Forms;

using BLL.Interfaces;
using BLL.Services;
using Domain;

namespace courseProjectWF
{
    public partial class mainForm : Form
    {
        int productId;
        string auctionName;
        int indexRowD;
        int _roleID;
        int auctionChosenId;
        private readonly IServiceAuction _serviceAuction;
        private readonly IServiceProduct _serviceProduct;
        private readonly IServiceCategory _serviceCategory;
        public mainForm(IServiceAuction serviceAuction, IServiceProduct serviceProduct, IServiceCategory serviceCategory, int roleID)
        {
            _roleID = roleID;
            _serviceAuction = serviceAuction;
            _serviceProduct = serviceProduct;
            _serviceCategory = serviceCategory;
            InitializeComponent();
            RoleCheak();
            LoadProducts();
            LoadAuctions();
            FillcategoryBox();
        }
        private void RoleCheak()
        {
            if (_roleID == 2)
            {
                roleControl.TabPages.Remove(adminPage);
            }
        }
        private void FillcategoryBox()
        {
            foreach (Category category in _serviceCategory.GetAllCategory())
            {
                categoryBox.Items.Add(category.CategoryName);
                userCategoryBox.Items.Add(category.CategoryName);
            }
        }
        private void LoadProducts()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("RowInsertTime", typeof(DateTime));
            table.Columns.Add("RowUpdateTime", typeof(DateTime));

            foreach (Product product in _serviceProduct.GetAllProducts())
            {
                table.Rows.Add(product.ProductId, product.ProductName, _serviceCategory.GetCategory(product.CategoryId).CategoryName, product.RowInsertTime, product.RowUpdateTime);
            }

            adminProductDataGrid.DataSource = table;
            userProductdataGrid.DataSource = table;
        }
        private void adminProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowD = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = adminProductDataGrid.Rows[indexRowD];
                try
                {
                    ChoosenProductId.Text = $"Product ID {row.Cells[0].Value}";
                    productId = Convert.ToInt32(row.Cells[0].Value);
                    ChosenProductName.Text = $"Product name {row.Cells[1].Value}";
                    auctionName = Convert.ToString(row.Cells[1].Value) + " Auction";
                }
                catch (Exception)
                {

                    MessageBox.Show("Wrong row");
                }
            }
        }
        private void adminAuctionDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowD = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = adminAuctionDataGrid.Rows[indexRowD];
                lblChoosenId.Text = $"Chosen ID {row.Cells[0].Value}";
                try
                {
                    auctionChosenId = Convert.ToInt32(row.Cells[0].Value);
                }
                catch (Exception)
                {

                    MessageBox.Show("Wrong row");
                }

            }
        }
        private void bthSort_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("RowInsertTime", typeof(DateTime));
            table.Columns.Add("RowUpdateTime", typeof(DateTime));

            foreach (Product product in _serviceProduct.SortProducts())
            {
                table.Rows.Add(product.ProductId, product.ProductName, _serviceCategory.GetCategory(product.CategoryId).CategoryName, product.RowInsertTime, product.RowUpdateTime);
            }

            adminProductDataGrid.DataSource = table;
            userProductdataGrid.DataSource = table;
        }
        private void findByCategory_Click(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            table1.Columns.Add("Id", typeof(int));
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Category", typeof(string));
            table1.Columns.Add("RowInsertTime", typeof(DateTime));
            table1.Columns.Add("RowUpdateTime", typeof(DateTime));

            if (_roleID == 1)
            {
                if (roleControl.SelectedTab == roleControl.TabPages["userPage"])
                {
                    foreach (Product product in _serviceProduct.GetProductsByCategory(_serviceCategory.GetCategory(userCategoryBox.SelectedItem.ToString())))
                    {
                        table1.Rows.Add(product.ProductId, product.ProductName, _serviceCategory.GetCategory(product.CategoryId).CategoryName, product.RowInsertTime, product.RowUpdateTime);
                    }
                    adminProductDataGrid.DataSource = table1;
                    userProductdataGrid.DataSource = table1;
                }
                if (roleControl.SelectedTab == roleControl.TabPages["adminPage"])
                {
                    foreach (Product product in _serviceProduct.GetProductsByCategory(_serviceCategory.GetCategory(categoryBox.SelectedItem.ToString())))
                    {
                        table1.Rows.Add(product.ProductId, product.ProductName, _serviceCategory.GetCategory(product.CategoryId).CategoryName, product.RowInsertTime, product.RowUpdateTime);
                    }
                    adminProductDataGrid.DataSource = table1;
                    userProductdataGrid.DataSource = table1;
                }
            }
            else
            {
                foreach (Product product in _serviceProduct.GetProductsByCategory(_serviceCategory.GetCategory(userCategoryBox.SelectedItem.ToString())))
                {
                    table1.Rows.Add(product.ProductId, product.ProductName, _serviceCategory.GetCategory(product.CategoryId).CategoryName, product.RowInsertTime, product.RowUpdateTime);
                }
                adminProductDataGrid.DataSource = table1;
                userProductdataGrid.DataSource = table1;
            }

        }
        private void btnGoToAuctions_Click(object sender, EventArgs e)
        {
            float startUpPrice = float.Parse(startUpPriceBox.Text);
            float redempitonPrice = float.Parse(redemptionPriceBox.Text);
            DateTime endTime = Convert.ToDateTime(endTimeBox.Text);

            _serviceAuction.AddAuction(productId, auctionName, startUpPrice, redempitonPrice, endTime);
            startUpPriceBox.Text = "";
            redemptionPriceBox.Text = "";
            endTimeBox.Text = "";
            LoadAuctions();
        }
        private void LoadAuctions()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Startup Price", typeof(float));
            table.Columns.Add("Redemption Price", typeof(float));
            table.Columns.Add("Is active", typeof(bool));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Activate time", typeof(DateTime));
            table.Columns.Add("Deactivate time", typeof(DateTime));
            table.Columns.Add("RowInsertTime", typeof(DateTime));
            table.Columns.Add("RowUpdateTime", typeof(DateTime));

            foreach (Auction auction in _serviceAuction.GetAllAuctions())
            {
                table.Rows.Add(auction.AuctionId, auction.AuctionName, auction.StrtupPrice, auction.RedemptionPrice, auction.isActive, _serviceProduct.GetProduct(auction.ProductId).ProductName, auction.ActivateTime, auction.DeactivateTime, auction.RowInsertTime, auction.RowUpdateTime);
            }

            adminAuctionDataGrid.DataSource = table;
            userAuctionGrid.DataSource = table;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   
        private void btnDeactivateAuction_Click(object sender, EventArgs e)
        {
            _serviceAuction.DeactiveAuction(auctionChosenId);
            LoadAuctions();
        }
        private void btnActivateAuction_Click(object sender, EventArgs e)
        {
            _serviceAuction.ActiveAuction(auctionChosenId);
            LoadAuctions();
        }
    }
}
