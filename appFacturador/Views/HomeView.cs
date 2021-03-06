using appFacturador.Config;
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
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToClientRegistrationView(this);
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToRegisteredClientsView(this);
        }

        private void btnShowProductsView_Click(object sender, EventArgs e)
        {
        }

        private void btnInvoiceViewer_Click(object sender, EventArgs e)
        {
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToInvoiceViewer(this);
        }
    }
}
