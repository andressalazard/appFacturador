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
        }

        private void ProductSelectionView_Load_1(object sender, EventArgs e)
        {
            populateProductItems();
        }

        private void InitializeSummaryGrid() {
            summaryPurchase = new DataTable();
            string[] fieldNames = { "ProductName", "Units" };
            foreach (string field in fieldNames) {
                summaryPurchase.Columns.Add(field);
            }
            gridSummary.DataSource = summaryPurchase;
        }

        private void populateProductItems() {
            availableProducts = new ProductItem[10];
            string[] productTitles = {
               "Chef Antons Cajun Seasoning",
               "Aniseed Syrup",
               "Mishi Kobe Niku",
               "Queso Cabrales",
               "Gustafs Knäckebröd",
               "Guarana Fantastica",
               "Konbu",
               "Tofu",
               "Pavlova",
               "Sir Rodneys Marmalade"
            };
            string[] productCategories = {
              "Cooking",
              "Condiments",
              "Meat/Pouldry",
              "Dairy Products",
              "Grains/Cereals",
              "Beverages",
              "SeaFood",
              "Produce",
              "Produce",
              "Confections"
            };

            double[] productPrices = {
              22.00D,
              22.00D,
              97.00D,
              21.00D,
              21.00D,
              4.50D,
              4.50D,
              23.75D,
              17.45D,
              81.00D
            };

            for (int i = 0; i < availableProducts.Length; i++) {
                availableProducts[i] = new ProductItem();
                availableProducts[i].ProductTitle = productTitles[i];
                availableProducts[i].ProductCategory = productCategories[i];
                availableProducts[i].ProductPrice = productPrices[i];

                flowLayoutPanel1.Controls.Add(availableProducts[i]);
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
            InitializeSummaryGrid();
            ShowSelectedProductItems();
        }

        private void ShowSelectedProductItems() {
            foreach (ProductItem item in availableProducts) { 
             if (item.IsSelected){
                DataRow row = summaryPurchase.NewRow();
                    row["ProductName"] = item.ProductTitle;
                    row["Units"] = item.SelectedUnits;

                    summaryPurchase.Rows.Add(row);
             }
            }
        
        }
    }
}
