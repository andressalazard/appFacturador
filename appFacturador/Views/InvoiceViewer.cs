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

        public InvoiceViewer()
        {
            InitializeComponent();
        }

        private void InvoiceViewer_Load(object sender, EventArgs e)
        {
            setupDetailTable();
        }

        private void setupDetailTable() {
            invoiceDetailTable = new DataTable();
            string[] fields = { "Units", "Product Description", "ProductPrice", "Total" };
            foreach (string field in fields){
                invoiceDetailTable.Columns.Add(field);
            }
            dgvInvoiceDetail.DataSource = invoiceDetailTable;
        }
    }
}
