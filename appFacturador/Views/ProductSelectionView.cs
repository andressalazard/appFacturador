using appFacturador.Config;
using appFacturador.Controllers;
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
        ClientModel selectedClient;
        
        public ProductSelectionView(ClientModel client=null)
        {
            InitializeComponent();
            InitializeSummaryGrid();
            this.selectedClient = client;
        }



        private void ProductSelectionView_Load_1(object sender, EventArgs e)
        {
            populateAvailableProducts();
            this.showCurrentClient();
        }

        #region Initialization
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
        private void showCurrentClient() {
            if (this.selectedClient != null) {
                lblClientName.Text = $"{this.selectedClient.FirstName} {this.selectedClient.LastName}";
            }
        }
        #endregion



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ShowSelectedProductItems() {
            foreach (ProductItem item in availableProducts) { 
             if (item.IsSelected){
                DataRow row = summaryPurchase.NewRow();
                    row["ProductName"] = item.ProductTitle;
                    row["Units"] = item.SelectedUnits;
                    row["Total"] = String.Format("{0:0.00}",item.ProductPrice * item.SelectedUnits);
                    summaryPurchase.Rows.Add(row);
             }
            }        
        }

        private List<ProductModel> getSelectedProducts() {
            List<ProductModel> purchasedProducts = new List<ProductModel>();
            foreach (ProductItem item in availableProducts) {
                if (item.IsSelected) {
                  ProductModel product = new ProductModel(
                    item.ProductID, item.ProductTitle, item.ProductPrice, 
                    item.ProductCategory,item.SelectedUnits);
                    purchasedProducts.Add(product);
                }
            }
            return purchasedProducts;
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


        #region Custom Events
        private void Item_ProductIsSelectedEvent(object sender, ProductItem item)
        {
            DisplaySelectedProducts();
        }

        #endregion

        #region
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }

        private void btnSavePurchase_Click(object sender, EventArgs e)
        {
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToInvoiceViewer(this,selectedClient, getSelectedProducts());
        }
        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangeClient_Click(object sender, EventArgs e)
        {
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToRegisteredClientsView(this);
        }
    }
}
