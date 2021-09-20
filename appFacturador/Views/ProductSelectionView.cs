using appFacturador.Config;
using appFacturador.Models;
using appFacturador.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFacturador.Views
{
    public partial class ProductSelectionView : Form
    {
        ProductItem[] availableProducts;
        DataTable summaryPurchase;
        
        public ProductSelectionView()
        {
            InitializeComponent();
            InitializeSummaryGrid();
        }

        private void ProductSelectionView_Load_1(object sender, EventArgs e)
        {
            populateAvailableProducts();
        }

        private void InitializeSummaryGrid() {
            summaryPurchase = new DataTable();
            string[] fieldNames = { "ProductName", "Units", "Total" };
            foreach (string field in fieldNames) {
                summaryPurchase.Columns.Add(field);
            }
            gridSummary.DataSource = summaryPurchase;
        }

        private void populateAvailableProducts() {
            DBConnection connection = new DBConnection();
            List<ProductModel>dbProducts =  connection.getAvailableProducts();
            availableProducts = new ProductItem[dbProducts.Count];

            for (int i = 0; i < dbProducts.Count; i++) {
                ProductItem productItem = new ProductItem(
                dbProducts[i].ProductId,
                dbProducts[i].ProductName,
                dbProducts[i].ProductPrice,
                dbProducts[i].ProductCategory);
                availableProducts[i] = productItem;

                flowLayoutPanel1.Controls.Add(availableProducts[i]);
                availableProducts[i].ProductIsSelectedEvent += Item_ProductIsSelectedEvent;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSavePurchase_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowSelectedProductItems() {
            foreach (ProductItem item in availableProducts) { 
             if (item.IsSelected){
                DataRow row = summaryPurchase.NewRow();
                    row["ProductName"] = item.ProductTitle;
                    row["Units"] = item.SelectedUnits;
                    row["Total"] = item.ProductPrice * item.SelectedUnits;
                    summaryPurchase.Rows.Add(row);
             }
            }        
        }

        private void DisplaySelectedProducts() {
            InitializeSummaryGrid();
            ShowSelectedProductItems();
        }

        private void ClearSelection(){
            foreach (ProductItem item in availableProducts) {
                item.ResetProductItem();
            }
        }


        #region Events
        private void Item_ProductIsSelectedEvent(object sender, ProductItem item)
        {
            DisplaySelectedProducts();
        }

        #endregion

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }
    }
}
