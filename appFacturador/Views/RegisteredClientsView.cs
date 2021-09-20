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
    public partial class RegisteredClientsView : Form
    {
        DataTable clientTable;

        public RegisteredClientsView()
        {
            InitializeComponent();
        }

        #region onInit Methods
        private void RegisteredClientsView_Load(object sender, EventArgs e){
            InitClientsTable();
        }

        private void InitClientsTable() {
            clientTable = new DataTable();
            string[] fields = { "FirstName", "LastName", "Phone", "Email", "PersonalAddress" };
            foreach (string field in fields) {
                clientTable.Columns.Add(field);
            }
            gridRegisteredClients.DataSource = clientTable;
        }

        #endregion

        private void btnCreateRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void gridRegisteredClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
