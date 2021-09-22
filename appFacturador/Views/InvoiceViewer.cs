﻿using appFacturador.Models;
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
        DateTime emissionDate;
        decimal subTotal = 0;
        decimal total = 0;
        int taxValue = 0;

        int[] TaxValues = { 12, 14, 10 };

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
            emissionDate = DateTime.Now;
        }

        private void InvoiceViewer_Load(object sender, EventArgs e)
        {
            setupDetailTable();
            populateInvoice();
            populateTaxesComboBox();
            displayInvoiceNumber();
        }

        private void setupDetailTable() {
            invoiceDetailTable = new DataTable();
            string[] fields = { "Units", "ProductDescription", "ProductPrice", "Total" };
            foreach (string field in fields){
                invoiceDetailTable.Columns.Add(field);
            }
            dgvInvoiceDetail.DataSource = invoiceDetailTable;
        }


        private void populateInvoice() {
            if (currentClient != null) {
                displayCurrentClient();
            }

            if (shoppingList != null) {
                displayPurchaseDetail();
            }

            if (subTotal != 0) {
                displayInvoiceMount();
            }
        }

        private void displayCurrentClient() {
            txtClientFirstName.Text = currentClient.FirstName;
            txtClientLastName.Text = currentClient.LastName;
            txtClientPhone.Text = currentClient.Phone;
            txtClientEmail.Text = currentClient.Email;
            txtClientAddress.Text = currentClient.Address;
            txtEmissionDate.Text = $"{getMonth(emissionDate.Month)} {emissionDate.Day}th, {emissionDate.Year}";
        }

        private void displayInvoiceMount() {
            decimal total = subTotal + (subTotal * taxValue) / 100;

            txtSubtotal.Text = String.Format("{0:0.00}",subTotal);
            txtTotal.Text = String.Format("{0:0.00}",total);
        }

        private string getMonth(int monthIndex) {
            string[] Months = {"Jan", "Feb","March","April","May",
            "June","July","Aug","Sept","Oct","Nov","Dec"};

            return Months[monthIndex-1];
        }

        private void displayPurchaseDetail() {
          foreach (ProductModel product in shoppingList) {
                DataRow row = invoiceDetailTable.NewRow();
                row["Units"] = product.ProductUnits;
                row["ProductDescription"] = $"{product.ProductName} ({product.ProductCategory})";
                row["ProductPrice"] = String.Format("{0:0.00}",product.ProductPrice);
                decimal totalCost = product.ProductPrice * product.ProductUnits;
                row["Total"] = String.Format("{0:0.00}",totalCost);

                invoiceDetailTable.Rows.Add(row);

                updateSubtotalValue(totalCost);
          }
        }

        private void displayInvoiceNumber() {
            Random random = new Random();
            int num = random.Next(1000);
            lblInvoiceID.Text = num.ToString("D7");
            lblRUCValue.Text = "1792433363001";
        }

        private void populateTaxesComboBox() {
            string[] TaxNames = { "I.V.A", "I.C.E", "Normal Discount" };
            foreach (string taxName in TaxNames) {
                cBoxTaxes.Items.Add(taxName);
            }

            cBoxTaxes.Text = cBoxTaxes.Items[0].ToString();
        }

        private void updateSubtotalValue(decimal value) {
            subTotal += value;
        }

        private void setTaxValue() {
            taxValue = TaxValues[cBoxTaxes.SelectedIndex];
        }

        private void cBoxTaxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTaxValue();
            displayInvoiceMount();
        }
    }
}
