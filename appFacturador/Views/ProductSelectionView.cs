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
        public ProductSelectionView()
        {
            InitializeComponent();
        }

        private void ProductSelectionView_Load_1(object sender, EventArgs e)
        {
            populateProductItems();
        }

        private void populateProductItems() {
            ProductItem[] productsItemsList = new ProductItem[5];
            string[] productTitles = {
               "Salchichas",
               "Gaseosa",
               "Papitas",
               "Gelatina",
               "Leche"
            };
            string[] productCategories = {
              "Meets",
              "Drinks",
              "Snacks",
              "Candies",
              "Dairies"
            };
            for(int i = 0; i < productsItemsList.Length; i++) {
                productsItemsList[i] = new ProductItem();
                productsItemsList[i].ProductTitle = productTitles[i];
                productsItemsList[i].ProductCategory = productCategories[i];
                productsItemsList[i].IsSelected = false;

                flowLayoutPanel1.Controls.Add(productsItemsList[i]);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
