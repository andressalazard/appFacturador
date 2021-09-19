using appFacturador.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFacturador.Forms
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientRegistrationView registrationView = new ClientRegistrationView();
            registrationView.ShowDialog();
            this.Close();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
        
        }

        private void btnShowProductsView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductSelectionView productView = new ProductSelectionView();
            productView.ShowDialog();
            this.Close();
        }
    }
}
