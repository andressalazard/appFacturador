using appFacturador.Models;
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
    public partial class InvoiceViewer : Form
    {
        DataTable invoiceDetailTable;
        ClientModel currentClient;
        List<ProductModel> shoppingList;

        public InvoiceViewer()
        {
            InitializeComponent();
            currentClient = null;
        }

        public InvoiceViewer(ClientModel selectedClient, List<ProductModel> purchasedProductsList)
        {
            InitializeComponent();
            currentClient = selectedClient;
            shoppingList = purchasedProductsList;
        }

        private void InvoiceViewer_Load(object sender, EventArgs e)
        {
            setupDetailTable();
            populateInvoice();
        }

        private void setupDetailTable() {
            invoiceDetailTable = new DataTable();
            string[] fields = { "Units", "Product Description", "ProductPrice", "Total" };
            foreach (string field in fields){
                invoiceDetailTable.Columns.Add(field);
            }
            dgvInvoiceDetail.DataSource = invoiceDetailTable;
        }


        private void populateInvoice() {
            if (currentClient != null) {
                displayCurrentClient();
            }
        }

        private void displayCurrentClient() {
            DateTime dateTime = DateTime.Now;
            txtClientFirstName.Text = currentClient.FirstName;
            txtClientLastName.Text = currentClient.LastName;
            txtClientPhone.Text = currentClient.Phone;
            txtClientEmail.Text = currentClient.Email;
            txtClientAddress.Text = currentClient.Address;
            txtEmissionDate.Text = $"{getMonth(dateTime.Month)} {dateTime.Day}th, {dateTime.Year}";
        }

        private string getMonth(int monthIndex) {
            string[] Months = {"Jan", "Feb","March","April","May",
            "June","July","Aug","Sept","Oct","Nov","Dec"};

            return Months[monthIndex-1];
        }
    }
}
