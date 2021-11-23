namespace courseProjectWF
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roleControl = new System.Windows.Forms.TabControl();
            this.userPage = new System.Windows.Forms.TabPage();
            this.userPageControl = new System.Windows.Forms.TabControl();
            this.userProductPage = new System.Windows.Forms.TabPage();
            this.userFindBtn = new System.Windows.Forms.Button();
            this.userCategoryBox = new System.Windows.Forms.ComboBox();
            this.userSortButton = new System.Windows.Forms.Button();
            this.userProductdataGrid = new System.Windows.Forms.DataGridView();
            this.userAuctionPage = new System.Windows.Forms.TabPage();
            this.userAuctionGrid = new System.Windows.Forms.DataGridView();
            this.adminPage = new System.Windows.Forms.TabPage();
            this.ProductAuctionControl = new System.Windows.Forms.TabControl();
            this.ProductPage = new System.Windows.Forms.TabPage();
            this.endTimeBox = new System.Windows.Forms.TextBox();
            this.redemptionPriceBox = new System.Windows.Forms.TextBox();
            this.startUpPriceBox = new System.Windows.Forms.TextBox();
            this.EndTime = new System.Windows.Forms.Label();
            this.lblRedemptionPrice = new System.Windows.Forms.Label();
            this.lblStartUpPrice = new System.Windows.Forms.Label();
            this.btnGoToAuctions = new System.Windows.Forms.Button();
            this.findByCategory = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.bthSort = new System.Windows.Forms.Button();
            this.SortLabel = new System.Windows.Forms.Label();
            this.ChosenProductName = new System.Windows.Forms.Label();
            this.ChoosenProductId = new System.Windows.Forms.Label();
            this.adminProductDataGrid = new System.Windows.Forms.DataGridView();
            this.AuctionPage = new System.Windows.Forms.TabPage();
            this.lblChoosenId = new System.Windows.Forms.Label();
            this.btnDeactivateAuction = new System.Windows.Forms.Button();
            this.btnActivateAuction = new System.Windows.Forms.Button();
            this.adminAuctionDataGrid = new System.Windows.Forms.DataGridView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.roleControl.SuspendLayout();
            this.userPage.SuspendLayout();
            this.userPageControl.SuspendLayout();
            this.userProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProductdataGrid)).BeginInit();
            this.userAuctionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAuctionGrid)).BeginInit();
            this.adminPage.SuspendLayout();
            this.ProductAuctionControl.SuspendLayout();
            this.ProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminProductDataGrid)).BeginInit();
            this.AuctionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAuctionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // roleControl
            // 
            this.roleControl.Controls.Add(this.userPage);
            this.roleControl.Controls.Add(this.adminPage);
            this.roleControl.Location = new System.Drawing.Point(7, 5);
            this.roleControl.Name = "roleControl";
            this.roleControl.SelectedIndex = 0;
            this.roleControl.Size = new System.Drawing.Size(1047, 545);
            this.roleControl.TabIndex = 0;
            // 
            // userPage
            // 
            this.userPage.Controls.Add(this.userPageControl);
            this.userPage.Location = new System.Drawing.Point(4, 29);
            this.userPage.Name = "userPage";
            this.userPage.Padding = new System.Windows.Forms.Padding(3);
            this.userPage.Size = new System.Drawing.Size(1039, 512);
            this.userPage.TabIndex = 0;
            this.userPage.Text = "User";
            this.userPage.UseVisualStyleBackColor = true;
            // 
            // userPageControl
            // 
            this.userPageControl.Controls.Add(this.userProductPage);
            this.userPageControl.Controls.Add(this.userAuctionPage);
            this.userPageControl.Location = new System.Drawing.Point(-2, 3);
            this.userPageControl.Name = "userPageControl";
            this.userPageControl.SelectedIndex = 0;
            this.userPageControl.Size = new System.Drawing.Size(1043, 506);
            this.userPageControl.TabIndex = 1;
            // 
            // userProductPage
            // 
            this.userProductPage.Controls.Add(this.userFindBtn);
            this.userProductPage.Controls.Add(this.userCategoryBox);
            this.userProductPage.Controls.Add(this.userSortButton);
            this.userProductPage.Controls.Add(this.userProductdataGrid);
            this.userProductPage.Location = new System.Drawing.Point(4, 29);
            this.userProductPage.Name = "userProductPage";
            this.userProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.userProductPage.Size = new System.Drawing.Size(1035, 473);
            this.userProductPage.TabIndex = 0;
            this.userProductPage.Text = "Products";
            this.userProductPage.UseVisualStyleBackColor = true;
            // 
            // userFindBtn
            // 
            this.userFindBtn.Location = new System.Drawing.Point(7, 105);
            this.userFindBtn.Name = "userFindBtn";
            this.userFindBtn.Size = new System.Drawing.Size(104, 33);
            this.userFindBtn.TabIndex = 6;
            this.userFindBtn.Text = "Find";
            this.userFindBtn.UseVisualStyleBackColor = true;
            this.userFindBtn.Click += new System.EventHandler(this.findByCategory_Click);
            // 
            // userCategoryBox
            // 
            this.userCategoryBox.FormattingEnabled = true;
            this.userCategoryBox.Location = new System.Drawing.Point(7, 71);
            this.userCategoryBox.Name = "userCategoryBox";
            this.userCategoryBox.Size = new System.Drawing.Size(104, 28);
            this.userCategoryBox.TabIndex = 5;
            // 
            // userSortButton
            // 
            this.userSortButton.Location = new System.Drawing.Point(6, 11);
            this.userSortButton.Name = "userSortButton";
            this.userSortButton.Size = new System.Drawing.Size(53, 43);
            this.userSortButton.TabIndex = 4;
            this.userSortButton.Text = "Sort";
            this.userSortButton.UseVisualStyleBackColor = true;
            this.userSortButton.Click += new System.EventHandler(this.bthSort_Click);
            // 
            // userProductdataGrid
            // 
            this.userProductdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userProductdataGrid.Location = new System.Drawing.Point(117, 14);
            this.userProductdataGrid.Name = "userProductdataGrid";
            this.userProductdataGrid.RowHeadersWidth = 51;
            this.userProductdataGrid.RowTemplate.Height = 29;
            this.userProductdataGrid.Size = new System.Drawing.Size(660, 456);
            this.userProductdataGrid.TabIndex = 0;
            // 
            // userAuctionPage
            // 
            this.userAuctionPage.Controls.Add(this.userAuctionGrid);
            this.userAuctionPage.Location = new System.Drawing.Point(4, 29);
            this.userAuctionPage.Name = "userAuctionPage";
            this.userAuctionPage.Padding = new System.Windows.Forms.Padding(3);
            this.userAuctionPage.Size = new System.Drawing.Size(1035, 473);
            this.userAuctionPage.TabIndex = 1;
            this.userAuctionPage.Text = "Auctions";
            this.userAuctionPage.UseVisualStyleBackColor = true;
            // 
            // userAuctionGrid
            // 
            this.userAuctionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAuctionGrid.Location = new System.Drawing.Point(10, 12);
            this.userAuctionGrid.Name = "userAuctionGrid";
            this.userAuctionGrid.RowHeadersWidth = 51;
            this.userAuctionGrid.RowTemplate.Height = 29;
            this.userAuctionGrid.Size = new System.Drawing.Size(879, 453);
            this.userAuctionGrid.TabIndex = 0;
            // 
            // adminPage
            // 
            this.adminPage.Controls.Add(this.ProductAuctionControl);
            this.adminPage.Location = new System.Drawing.Point(4, 29);
            this.adminPage.Name = "adminPage";
            this.adminPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminPage.Size = new System.Drawing.Size(1039, 512);
            this.adminPage.TabIndex = 1;
            this.adminPage.Text = "Admin";
            this.adminPage.UseVisualStyleBackColor = true;
            // 
            // ProductAuctionControl
            // 
            this.ProductAuctionControl.Controls.Add(this.ProductPage);
            this.ProductAuctionControl.Controls.Add(this.AuctionPage);
            this.ProductAuctionControl.Location = new System.Drawing.Point(0, 6);
            this.ProductAuctionControl.Name = "ProductAuctionControl";
            this.ProductAuctionControl.SelectedIndex = 0;
            this.ProductAuctionControl.Size = new System.Drawing.Size(1043, 500);
            this.ProductAuctionControl.TabIndex = 0;
            // 
            // ProductPage
            // 
            this.ProductPage.Controls.Add(this.endTimeBox);
            this.ProductPage.Controls.Add(this.redemptionPriceBox);
            this.ProductPage.Controls.Add(this.startUpPriceBox);
            this.ProductPage.Controls.Add(this.EndTime);
            this.ProductPage.Controls.Add(this.lblRedemptionPrice);
            this.ProductPage.Controls.Add(this.lblStartUpPrice);
            this.ProductPage.Controls.Add(this.btnGoToAuctions);
            this.ProductPage.Controls.Add(this.findByCategory);
            this.ProductPage.Controls.Add(this.categoryBox);
            this.ProductPage.Controls.Add(this.bthSort);
            this.ProductPage.Controls.Add(this.SortLabel);
            this.ProductPage.Controls.Add(this.ChosenProductName);
            this.ProductPage.Controls.Add(this.ChoosenProductId);
            this.ProductPage.Controls.Add(this.adminProductDataGrid);
            this.ProductPage.Location = new System.Drawing.Point(4, 29);
            this.ProductPage.Name = "ProductPage";
            this.ProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductPage.Size = new System.Drawing.Size(1035, 467);
            this.ProductPage.TabIndex = 0;
            this.ProductPage.Text = "Products";
            this.ProductPage.UseVisualStyleBackColor = true;
            // 
            // endTimeBox
            // 
            this.endTimeBox.Location = new System.Drawing.Point(756, 254);
            this.endTimeBox.Name = "endTimeBox";
            this.endTimeBox.Size = new System.Drawing.Size(267, 27);
            this.endTimeBox.TabIndex = 13;
            // 
            // redemptionPriceBox
            // 
            this.redemptionPriceBox.Location = new System.Drawing.Point(756, 198);
            this.redemptionPriceBox.Name = "redemptionPriceBox";
            this.redemptionPriceBox.Size = new System.Drawing.Size(267, 27);
            this.redemptionPriceBox.TabIndex = 12;
            // 
            // startUpPriceBox
            // 
            this.startUpPriceBox.Location = new System.Drawing.Point(756, 142);
            this.startUpPriceBox.Name = "startUpPriceBox";
            this.startUpPriceBox.Size = new System.Drawing.Size(267, 27);
            this.startUpPriceBox.TabIndex = 11;
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndTime.Location = new System.Drawing.Point(756, 228);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(78, 23);
            this.EndTime.TabIndex = 10;
            this.EndTime.Text = "End time";
            // 
            // lblRedemptionPrice
            // 
            this.lblRedemptionPrice.AutoSize = true;
            this.lblRedemptionPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRedemptionPrice.Location = new System.Drawing.Point(756, 172);
            this.lblRedemptionPrice.Name = "lblRedemptionPrice";
            this.lblRedemptionPrice.Size = new System.Drawing.Size(145, 23);
            this.lblRedemptionPrice.TabIndex = 9;
            this.lblRedemptionPrice.Text = "Redemption price";
            // 
            // lblStartUpPrice
            // 
            this.lblStartUpPrice.AutoSize = true;
            this.lblStartUpPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartUpPrice.Location = new System.Drawing.Point(756, 116);
            this.lblStartUpPrice.Name = "lblStartUpPrice";
            this.lblStartUpPrice.Size = new System.Drawing.Size(112, 23);
            this.lblStartUpPrice.TabIndex = 8;
            this.lblStartUpPrice.Text = "Start up price";
            // 
            // btnGoToAuctions
            // 
            this.btnGoToAuctions.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToAuctions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoToAuctions.Location = new System.Drawing.Point(769, 405);
            this.btnGoToAuctions.Name = "btnGoToAuctions";
            this.btnGoToAuctions.Size = new System.Drawing.Size(254, 58);
            this.btnGoToAuctions.TabIndex = 7;
            this.btnGoToAuctions.Text = "Create Auction";
            this.btnGoToAuctions.UseVisualStyleBackColor = true;
            this.btnGoToAuctions.Click += new System.EventHandler(this.btnGoToAuctions_Click);
            // 
            // findByCategory
            // 
            this.findByCategory.Location = new System.Drawing.Point(7, 105);
            this.findByCategory.Name = "findByCategory";
            this.findByCategory.Size = new System.Drawing.Size(104, 33);
            this.findByCategory.TabIndex = 6;
            this.findByCategory.Text = "Find";
            this.findByCategory.UseVisualStyleBackColor = true;
            this.findByCategory.Click += new System.EventHandler(this.findByCategory_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(7, 71);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(104, 28);
            this.categoryBox.TabIndex = 5;
            // 
            // bthSort
            // 
            this.bthSort.Location = new System.Drawing.Point(6, 11);
            this.bthSort.Name = "bthSort";
            this.bthSort.Size = new System.Drawing.Size(53, 43);
            this.bthSort.TabIndex = 4;
            this.bthSort.Text = "Sort";
            this.bthSort.UseVisualStyleBackColor = true;
            this.bthSort.Click += new System.EventHandler(this.bthSort_Click);
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(773, 24);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(0, 20);
            this.SortLabel.TabIndex = 3;
            // 
            // ChosenProductName
            // 
            this.ChosenProductName.AutoSize = true;
            this.ChosenProductName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChosenProductName.Location = new System.Drawing.Point(756, 68);
            this.ChosenProductName.Name = "ChosenProductName";
            this.ChosenProductName.Size = new System.Drawing.Size(163, 32);
            this.ChosenProductName.TabIndex = 2;
            this.ChosenProductName.Text = "Product name";
            // 
            // ChoosenProductId
            // 
            this.ChoosenProductId.AutoSize = true;
            this.ChoosenProductId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoosenProductId.Location = new System.Drawing.Point(756, 14);
            this.ChoosenProductId.Name = "ChoosenProductId";
            this.ChoosenProductId.Size = new System.Drawing.Size(126, 32);
            this.ChoosenProductId.TabIndex = 1;
            this.ChoosenProductId.Text = "Product ID";
            // 
            // adminProductDataGrid
            // 
            this.adminProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminProductDataGrid.Location = new System.Drawing.Point(117, 14);
            this.adminProductDataGrid.Name = "adminProductDataGrid";
            this.adminProductDataGrid.RowHeadersWidth = 51;
            this.adminProductDataGrid.RowTemplate.Height = 29;
            this.adminProductDataGrid.Size = new System.Drawing.Size(633, 456);
            this.adminProductDataGrid.TabIndex = 0;
            this.adminProductDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminProductDataGrid_CellContentClick);
            this.adminProductDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminProductDataGrid_CellContentClick);
            // 
            // AuctionPage
            // 
            this.AuctionPage.Controls.Add(this.lblChoosenId);
            this.AuctionPage.Controls.Add(this.btnDeactivateAuction);
            this.AuctionPage.Controls.Add(this.btnActivateAuction);
            this.AuctionPage.Controls.Add(this.adminAuctionDataGrid);
            this.AuctionPage.Location = new System.Drawing.Point(4, 29);
            this.AuctionPage.Name = "AuctionPage";
            this.AuctionPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuctionPage.Size = new System.Drawing.Size(1035, 467);
            this.AuctionPage.TabIndex = 1;
            this.AuctionPage.Text = "Auctions";
            this.AuctionPage.UseVisualStyleBackColor = true;
            // 
            // lblChoosenId
            // 
            this.lblChoosenId.AutoSize = true;
            this.lblChoosenId.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChoosenId.Location = new System.Drawing.Point(895, 12);
            this.lblChoosenId.Name = "lblChoosenId";
            this.lblChoosenId.Size = new System.Drawing.Size(116, 30);
            this.lblChoosenId.TabIndex = 3;
            this.lblChoosenId.Text = "Chosen Id ";
            // 
            // btnDeactivateAuction
            // 
            this.btnDeactivateAuction.Location = new System.Drawing.Point(920, 141);
            this.btnDeactivateAuction.Name = "btnDeactivateAuction";
            this.btnDeactivateAuction.Size = new System.Drawing.Size(112, 61);
            this.btnDeactivateAuction.TabIndex = 2;
            this.btnDeactivateAuction.Text = "Deactivate";
            this.btnDeactivateAuction.UseVisualStyleBackColor = true;
            this.btnDeactivateAuction.Click += new System.EventHandler(this.btnDeactivateAuction_Click);
            // 
            // btnActivateAuction
            // 
            this.btnActivateAuction.Location = new System.Drawing.Point(920, 74);
            this.btnActivateAuction.Name = "btnActivateAuction";
            this.btnActivateAuction.Size = new System.Drawing.Size(112, 61);
            this.btnActivateAuction.TabIndex = 1;
            this.btnActivateAuction.Text = "Activate";
            this.btnActivateAuction.UseVisualStyleBackColor = true;
            this.btnActivateAuction.Click += new System.EventHandler(this.btnActivateAuction_Click);
            // 
            // adminAuctionDataGrid
            // 
            this.adminAuctionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminAuctionDataGrid.Location = new System.Drawing.Point(10, 12);
            this.adminAuctionDataGrid.Name = "adminAuctionDataGrid";
            this.adminAuctionDataGrid.RowHeadersWidth = 51;
            this.adminAuctionDataGrid.RowTemplate.Height = 29;
            this.adminAuctionDataGrid.Size = new System.Drawing.Size(879, 453);
            this.adminAuctionDataGrid.TabIndex = 0;
            this.adminAuctionDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminAuctionDataGrid_CellContentClick);
            this.adminAuctionDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminAuctionDataGrid_CellContentClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1064, 34);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(76, 39);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1109, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 39);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 562);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.roleControl);
            this.Name = "mainForm";
            this.Text = "Auction Manager";
            this.roleControl.ResumeLayout(false);
            this.userPage.ResumeLayout(false);
            this.userPageControl.ResumeLayout(false);
            this.userProductPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userProductdataGrid)).EndInit();
            this.userAuctionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAuctionGrid)).EndInit();
            this.adminPage.ResumeLayout(false);
            this.ProductAuctionControl.ResumeLayout(false);
            this.ProductPage.ResumeLayout(false);
            this.ProductPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminProductDataGrid)).EndInit();
            this.AuctionPage.ResumeLayout(false);
            this.AuctionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAuctionDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl roleControl;
        private System.Windows.Forms.TabPage userPage;
        private System.Windows.Forms.TabPage adminPage;
        private System.Windows.Forms.TabControl ProductAuctionControl;
        private System.Windows.Forms.TabPage AuctionPage;
        private System.Windows.Forms.TabPage ProductPage;
        private System.Windows.Forms.Button bthSort;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label ChosenProductName;
        private System.Windows.Forms.Label ChoosenProductId;
        private System.Windows.Forms.DataGridView adminProductDataGrid;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button findByCategory;
        private System.Windows.Forms.Button btnGoToAuctions;
        private System.Windows.Forms.Label lblStartUpPrice;
        private System.Windows.Forms.Label EndTime;
        private System.Windows.Forms.Label lblRedemptionPrice;
        private System.Windows.Forms.TextBox endTimeBox;
        private System.Windows.Forms.TextBox redemptionPriceBox;
        private System.Windows.Forms.TextBox startUpPriceBox;
        private System.Windows.Forms.Button btnDeactivateAuction;
        private System.Windows.Forms.Button btnActivateAuction;
        private System.Windows.Forms.DataGridView adminAuctionDataGrid;
        private System.Windows.Forms.TabControl userPageControl;
        private System.Windows.Forms.TabPage userProductPage;
        private System.Windows.Forms.Button userFindBtn;
        private System.Windows.Forms.ComboBox userCategoryBox;
        private System.Windows.Forms.Button userSortButton;
        private System.Windows.Forms.DataGridView userProductdataGrid;
        private System.Windows.Forms.TabPage userAuctionPage;
        private System.Windows.Forms.DataGridView userAuctionGrid;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblChoosenId;
    }
}
