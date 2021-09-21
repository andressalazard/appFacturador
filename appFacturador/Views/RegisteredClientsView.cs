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
        ClientModel selectedClient = null;

        public RegisteredClientsView()
        {
            InitializeComponent();
            SetProductPurchaseBtnBehavior();
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
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToClientRegistrationView(this);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToHomeView(this);
        }

        private void btnGoToProductsView_Click(object sender, EventArgs e)
        {
            AppNavigation navigation = new AppNavigation();
            navigation.NavigateToProductsView(this, selectedClient);
        }
        #endregion

        private void gridRegisteredClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
                selectedClient = new ClientModel();
                DataGridViewRow dgvRow = gridRegisteredClients.Rows[e.RowIndex];

                selectedClient.ClientId = Convert.ToInt32(dgvRow.Cells[0].Value);
                selectedClient.FirstName = dgvRow.Cells[1].Value.ToString();
                selectedClient.LastName = dgvRow.Cells[2].Value.ToString();
                selectedClient.Phone = dgvRow.Cells[3].Value.ToString();
                selectedClient.Email = dgvRow.Cells[4].Value.ToString();
                selectedClient.Address = dgvRow.Cells[5].Value.ToString();
            }

            UpdateUI();
        }

        private void DisplaySelectedClient() {
            if (selectedClient != null) {
                txtFirstName.Text = selectedClient.FirstName;
                txtLastName.Text = selectedClient.LastName;
                txtPhone.Text = selectedClient.Phone;
                txtEmail.Text = selectedClient.Email;
                txtAddress.Text = selectedClient.Address;
            }
        }

        private void SetProductPurchaseBtnBehavior(){
            if (selectedClient != null){
                btnGoToProductsView.Enabled = true;
            }
            else {
                btnGoToProductsView.Enabled = false;
            }
        }

        private void UpdateUI() {
            DisplaySelectedClient();
            SetProductPurchaseBtnBehavior();
        }

        
    }
}
