using appFacturador.Forms;
using appFacturador.Models;
using appFacturador.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFacturador.Config
{
    class AppNavigation
    {
        public void NavigateToProductsView( Form OriginView, ClientModel currentClient ) {
            OriginView.Hide();
            ProductSelectionView productsView = new ProductSelectionView(currentClient);
            productsView.ShowDialog();
            OriginView.Close();
        }

        public void NavigateToRegisteredClientsView(Form OriginView) {
            OriginView.Hide();
            RegisteredClientsView registeredClientsView = new RegisteredClientsView();
            registeredClientsView.ShowDialog();
            OriginView.Close();
        }

        public void NavigateToHomeView(Form OriginView)
        {
            OriginView.Hide();
            HomeView homeView = new HomeView();
            homeView.ShowDialog();
            OriginView.Close();
        }

        public void NavigateToInvoiceViewer(Form OriginView) {
            OriginView.Hide();
            InvoiceViewer invoiceViewer = new InvoiceViewer();
            invoiceViewer.ShowDialog();
            OriginView.Close();
        }


    }
}
