using appFacturador.Config;
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
            populateClientsTable();
        }

        private void InitClientsTable() {
            clientTable = new DataTable();
            string[] fields = { "ClientID","FirstName", "LastName", "Phone", "Email", "PersonalAddress" };
            foreach (string field in fields) {
                clientTable.Columns.Add(field);
            }
            gridRegisteredClients.DataSource = clientTable;
        }

        private void populateClientsTable() {
            DBConnection connection = new DBConnection();
            List<ClientModel>registeredClients = connection.getRegisteredClients();

            foreach (ClientModel record in registeredClients) {
                DataRow row = clientTable.NewRow();
                row["ClientID"] = record.ClientId;
                row["FirstName"] = record.FirstName;
                row["LastName"] = record.LastName;
                row["Phone"] = record.Phone;
                row["Email"] = record.Email;
                row["PersonalAddress"] = record.Address;

                clientTable.Rows.Add(row);
            }

        }

        #endregion

        #region Event Handlers
        private void btnCreateRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToHomeView(this);
        }
        #endregion

        private void gridRegisteredClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
