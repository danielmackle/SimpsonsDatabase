
namespace SimpsonsSystem.Frontend.Forms
{
    partial class FrmStockControl
    {
        ///<summary>
        /// Required designer variable.
        ///</summary>
        private System.ComponentModel.IContainer components=null;

        ///<summary>
        /// Clean up any resources being used.
        ///</summary>
        ///<param name="disposing">true ifmanaged resources should be disposed;otherwise,false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        ///<summary>
        /// Required method for Designer support-do not modify
        /// the contents of this method with the code editor.
        ///</summary>
        private void InitializeComponent()
        {
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAutoOrder = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.lblNamePrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChina = new System.Windows.Forms.Button();
            this.btnCutlery = new System.Windows.Forms.Button();
            this.btnBedding = new System.Windows.Forms.Button();
            this.btnAppliances = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lblList = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnFastMoving = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnIdentlfy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(14, 14);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(5);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 25;
            this.dgvStock.Size = new System.Drawing.Size(1395, 530);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FindRow);
            // 
            // btnAutoOrder
            // 
            this.btnAutoOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoOrder.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoOrder.Location = new System.Drawing.Point(1078, 611);
            this.btnAutoOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnAutoOrder.Name = "btnAutoOrder";
            this.btnAutoOrder.Size = new System.Drawing.Size(143, 77);
            this.btnAutoOrder.TabIndex = 4;
            this.btnAutoOrder.Text = "Auto Order Items";
            this.btnAutoOrder.UseVisualStyleBackColor = false;
            this.btnAutoOrder.Click += new System.EventHandler(this.AutoOrderClicked);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxAmount.Location = new System.Drawing.Point(784, 608);
            this.tbxAmount.Margin = new System.Windows.Forms.Padding(5);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(87, 34);
            this.tbxAmount.TabIndex = 7;
            this.tbxAmount.TextChanged += new System.EventHandler(this.CheckAmount);
            // 
            // lblNamePrice
            // 
            this.lblNamePrice.AutoSize = true;
            this.lblNamePrice.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNamePrice.Location = new System.Drawing.Point(211, 636);
            this.lblNamePrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNamePrice.Name = "lblNamePrice";
            this.lblNamePrice.Size = new System.Drawing.Size(296, 27);
            this.lblNamePrice.TabIndex = 8;
            this.lblNamePrice.Text = "Productname(ProductPrice)";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(538, 611);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(248, 27);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount to Be Ordered:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(896, 611);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(172, 77);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Add to Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.Order);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(14, 609);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 77);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // btnChina
            // 
            this.btnChina.BackColor = System.Drawing.Color.Transparent;
            this.btnChina.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChina.Location = new System.Drawing.Point(1417, 636);
            this.btnChina.Margin = new System.Windows.Forms.Padding(5);
            this.btnChina.Name = "btnChina";
            this.btnChina.Size = new System.Drawing.Size(112, 62);
            this.btnChina.TabIndex = 1;
            this.btnChina.Text = "China";
            this.btnChina.UseVisualStyleBackColor = false;
            this.btnChina.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnCutlery
            // 
            this.btnCutlery.BackColor = System.Drawing.Color.Transparent;
            this.btnCutlery.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCutlery.Location = new System.Drawing.Point(1529, 566);
            this.btnCutlery.Margin = new System.Windows.Forms.Padding(5);
            this.btnCutlery.Name = "btnCutlery";
            this.btnCutlery.Size = new System.Drawing.Size(126, 70);
            this.btnCutlery.TabIndex = 2;
            this.btnCutlery.Text = "Cutlery";
            this.btnCutlery.UseVisualStyleBackColor = false;
            this.btnCutlery.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnBedding
            // 
            this.btnBedding.BackColor = System.Drawing.Color.Transparent;
            this.btnBedding.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBedding.Location = new System.Drawing.Point(1417, 566);
            this.btnBedding.Margin = new System.Windows.Forms.Padding(5);
            this.btnBedding.Name = "btnBedding";
            this.btnBedding.Size = new System.Drawing.Size(112, 70);
            this.btnBedding.TabIndex = 3;
            this.btnBedding.Text = "Bedding";
            this.btnBedding.UseVisualStyleBackColor = false;
            this.btnBedding.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnAppliances
            // 
            this.btnAppliances.BackColor = System.Drawing.Color.Transparent;
            this.btnAppliances.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAppliances.Location = new System.Drawing.Point(1654, 566);
            this.btnAppliances.Margin = new System.Windows.Forms.Padding(5);
            this.btnAppliances.Name = "btnAppliances";
            this.btnAppliances.Size = new System.Drawing.Size(132, 70);
            this.btnAppliances.TabIndex = 6;
            this.btnAppliances.Text = "Appliances";
            this.btnAppliances.UseVisualStyleBackColor = false;
            this.btnAppliances.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnClearFilters.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearFilters.Location = new System.Drawing.Point(1654, 636);
            this.btnClearFilters.Margin = new System.Windows.Forms.Padding(5);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(132, 62);
            this.btnClearFilters.TabIndex = 12;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // lbxList
            // 
            this.lbxList.ItemHeight = 27;
            this.lbxList.Location = new System.Drawing.Point(1417, 41);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(359, 463);
            this.lbxList.TabIndex = 13;
            this.lbxList.DoubleClick += new System.EventHandler(this.DeleteFromList);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(1451, 9);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(283, 27);
            this.lblList.TabIndex = 14;
            this.lblList.Text = "Stock Items to be Ordered:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(538, 654);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(149, 27);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price of Item:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(1419, 534);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(129, 27);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComplete.Location = new System.Drawing.Point(1254, 611);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(5);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(143, 77);
            this.btnComplete.TabIndex = 17;
            this.btnComplete.Text = "Complete Order";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.Complete);
            // 
            // btnFastMoving
            // 
            this.btnFastMoving.BackColor = System.Drawing.Color.Transparent;
            this.btnFastMoving.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFastMoving.Location = new System.Drawing.Point(1532, 636);
            this.btnFastMoving.Margin = new System.Windows.Forms.Padding(5);
            this.btnFastMoving.Name = "btnFastMoving";
            this.btnFastMoving.Size = new System.Drawing.Size(123, 62);
            this.btnFastMoving.TabIndex = 18;
            this.btnFastMoving.Text = "Fast Moving";
            this.btnFastMoving.UseVisualStyleBackColor = false;
            this.btnFastMoving.Click += new System.EventHandler(this.ApplyFilter);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(384, 556);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(336, 34);
            this.tbxSearch.TabIndex = 19;
            this.tbxSearch.TextChanged += new System.EventHandler(this.Search);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(14, 559);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(362, 27);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search By Model or Manufacturer:";
            // 
            // btnIdentlfy
            // 
            this.btnIdentlfy.BackColor = System.Drawing.Color.Transparent;
            this.btnIdentlfy.Location = new System.Drawing.Point(896, 552);
            this.btnIdentlfy.Name = "btnIdentlfy";
            this.btnIdentlfy.Size = new System.Drawing.Size(325, 51);
            this.btnIdentlfy.TabIndex = 21;
            this.btnIdentlfy.Text = "Identify Low Stock";
            this.btnIdentlfy.UseVisualStyleBackColor = false;
            this.btnIdentlfy.Click += new System.EventHandler(this.ColourDGV);
            // 
            // FrmStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpsonsSystem.Properties.Resources.cartoonyflow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1792, 699);
            this.Controls.Add(this.btnIdentlfy);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnFastMoving);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblNamePrice);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.btnAppliances);
            this.Controls.Add(this.btnAutoOrder);
            this.Controls.Add(this.btnBedding);
            this.Controls.Add(this.btnCutlery);
            this.Controls.Add(this.btnChina);
            this.Controls.Add(this.dgvStock);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmStockControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmStockControl";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnAutoOrder;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label lblNamePrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChina;
        private System.Windows.Forms.Button btnCutlery;
        private System.Windows.Forms.Button btnBedding;
        private System.Windows.Forms.Button btnAppliances;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnFastMoving;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnIdentlfy;
        private System.Windows.Forms.Button btnClearFilters;
    }
}