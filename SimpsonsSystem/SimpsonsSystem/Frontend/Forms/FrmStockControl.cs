using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsSystem.Frontend.Forms
{
    public partial class FrmStockControl : Form
    {
        #region Public Constructor
        public FrmStockControl()
        {
            InitializeComponent();
            FillDGV();
        }
        #endregion
        #region Private Variables
        private readonly Backend.Classes.ClsDatabase db = new();
        List<Backend.Classes.ClsStock> listStock = new();
        readonly List<Backend.Classes.ClsStock> listToBuy = new();
        readonly List<int> amountToBuy = new();
        decimal totalPrice = 0;
        Backend.Classes.ClsStock selectedStock = new();
        #endregion
        #region Private Methods
        //Fill the DGV with values from sDBA.GetDataTableStock()
        private void FillDGV()
        {
            Backend.Database.StockDBAccess sDBA = new(db);
            dgvStock.DataSource = sDBA.GetDataTableStock();
            listStock = sDBA.GetStockObjects();
        }
        //Make row red if under restock level, yellow if less than or equal to 125% restock level and green if 125% restock level.
        private void ColourDGV()
        {
            for(int i=0; i < dgvStock.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvStock.Rows[i].Cells[2].Value) < Convert.ToInt32(dgvStock.Rows[i].Cells[3].Value))
                {
                    dgvStock.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(dgvStock.Rows[i].Cells[2].Value) < (Convert.ToInt32(dgvStock.Rows[i].Cells[3].Value) * 1.25))
                {
                    dgvStock.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dgvStock.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
            totalPrice = 0;
            RefreshPrice();
        }
        //exits this form, opens menu
        private void Exit(object sender, EventArgs e)
        {
            FrmTitlePage f = new();
            Backend.Classes.ClsSystem.OpenNewForm(this,f);
        }
        //ensure value entered into tbxamount is a positive integer
        private void CheckAmount(object sender, EventArgs e)
        {
            if (Backend.Classes.ClsSystem.ValidateAmountFromText(tbxAmount.Text))
            {
                tbxAmount.ForeColor = Color.Green;
                lblPrice.Text = "Price of Item: " + selectedStock.StockPrice * Convert.ToInt32(tbxAmount.Text);
            }
            else
            {
                tbxAmount.ForeColor = Color.Red;
            }
        }
        private void FindRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvStock.Rows[dgvStock.SelectedCells[0].RowIndex];
                selectedStock = listStock[row.Index];
                lblNamePrice.Text = Convert.ToString(row.Cells[0].Value) + " (" + Convert.ToDecimal(row.Cells[3].Value) + ")";
            }
            catch{}
        }
        private void Order(object sender, EventArgs e)
        {
            if (tbxAmount.ForeColor == Color.Green && dgvStock.SelectedCells.Count != 0)
            {
                listToBuy.Add(selectedStock);
                amountToBuy.Add(Convert.ToInt32(tbxAmount.Text));
                lbxList.Items.Clear();
                for(int i = 0; i < listToBuy.Count; i++)
                {
                    lbxList.Items.Add(listToBuy[i].StockName+" | Amount:"+amountToBuy[i]);
                }
                totalPrice += Convert.ToInt32(tbxAmount.Text) * selectedStock.StockPrice;
                RefreshPrice();
            }
        }
        private void Complete(object sender, EventArgs e)
        {
            RunPurchase();
        }
        private void RunPurchase()
        {
            try
            {
                Backend.Database.PurchaseDBAccess pDBA = new(db);
                pDBA.InsertPurchase(true);
                Backend.Database.PurchaseBridgeStockDBAccess pBSDBA = new(db);
                int pid = pDBA.GetBackPid();
                int i = 0;
                Backend.Database.StockDBAccess sDBA = new(db);
                foreach (Backend.Classes.ClsStock s in listToBuy)
                {
                    Backend.Classes.Database.ClsPurchaseBridgeStock pBS = new(s.StockId, pid, amountToBuy[i]);
                    pBSDBA.InsertPurchaseBridgeStock(pBS);
                    sDBA.UpdateAmount(amountToBuy[i]);
                    i++;
                }
                Wipe();
                MessageBox.Show("Order Successful!","Thank You!");
            }
            catch { }
        }
        private void Wipe()
        {
            lbxList.Items.Clear();
            listToBuy.Clear();
            amountToBuy.Clear();
            RefreshPrice();
            FillDGV();
        }
        private bool searchByFastMoving = false;
        private void ApplyFilter(object sender, EventArgs e)
        {
            Backend.Database.StockDBAccess sDBA = new(db);
            if ((sender as Button).Name == "btnFastMoving")
            {
                if (searchByFastMoving)
                {
                    searchByFastMoving = false;
                }
                else
                {
                    searchByFastMoving = true;
                }
            }
            dgvStock.DataSource = sDBA.ApplyFilterDGV(sender as Button, searchByFastMoving);
            listStock = sDBA.ApplyFilterList(sender as Button, searchByFastMoving); 
            totalPrice = 0;
            RefreshPrice();
        }
        private void AutoOrderClicked(object sender, EventArgs e)
        {
            AutoOrder();
        }
        private void AutoOrder()
        {
            lbxList.Items.Clear();
            listToBuy.Clear();
            amountToBuy.Clear();
            RefreshPrice();
            int i = 0;
            foreach (Backend.Classes.ClsStock s in listStock)
            {
                if (dgvStock.Rows[i].DefaultCellStyle.BackColor == Color.Red)
                {
                    listToBuy.Add(s);
                    amountToBuy.Add(s.RestockValue1 - s.AmountHeld);
                }
                i++;
            }
            if (amountToBuy.Count != 0)
            {
                RunPurchase();
            }
            ColourDGV();
        }
        private void RefreshPrice()
        {
            lblTotalPrice.Text = "Total Price: "+Convert.ToString(totalPrice);
        }
        private void DeleteFromList(object sender, EventArgs e)
        {
            totalPrice -= amountToBuy[lbxList.SelectedIndex] * selectedStock.StockPrice;
            RefreshPrice();
            amountToBuy.RemoveAt(lbxList.SelectedIndex);
            listToBuy.RemoveAt(lbxList.SelectedIndex);
            lbxList.Items.RemoveAt(lbxList.SelectedIndex);
        }
        private void Search(object sender, EventArgs e)
        {
            SearchByModelManufacturer();
        }
        private void SearchByModelManufacturer()
        {
            Backend.Database.StockDBAccess sDBA = new(db);
            dgvStock.DataSource = null;
            DataTable dt = sDBA.SearchByModelManufacturerDataTable(tbxSearch.Text);
            if (dt.Rows.Count == 0 && tbxSearch.Text != "")
            {
                dgvStock.DataSource = null;
            }
            else
            {
                dgvStock.DataSource = sDBA.SearchByModelManufacturerDataTable(tbxSearch.Text);
            }
            listStock.Clear();
            listStock = sDBA.SearchByModelManufacturer(tbxSearch.Text);
            ColourDGV();
        }
        #endregion

        private void ColourDGV(object sender, EventArgs e)
        {
            ColourDGV();
        }
    }
}
