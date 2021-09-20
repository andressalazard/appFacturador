using appFacturador.Config;
using appFacturador.Controllers;
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

namespace appFacturador.Forms
{
    public partial class ClientRegistrationView : Form
    {
        public ClientRegistrationView()
        {
            InitializeComponent();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeView homeView = new HomeView();
            homeView.ShowDialog();
            this.Close();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            registerClientRecord();
        }

        private ClientModel GenerateClientRecord() {
            Client client = new Client();
            
            if (txtFirstName.Text != "" &&
                txtLastName.Text != "" &&
                txtPhone.Text != "" &&
                txtEmail.Text != "" &&
                txtAddress.Text != "")
            {
                client.SetSelectedClient(client.GenerateClient(txtFirstName.Text, txtLastName.Text,
                    txtPhone.Text, txtEmail.Text, txtAddress.Text));
            }
            else {
                MessageBox.Show("Llene todos los campos!");
                client.SetSelectedClient(null);
            }

            return client.GetSelectedClient();
        }

        private void registerClientRecord() {
            ClientModel record = GenerateClientRecord();

            if (record != null) {
                DBConnection connection = new DBConnection();
                connection.registerNewClient(record);
                AppNavigation navigation = new AppNavigation();
                navigation.NavigateToProductsView(this, record);
            }
        }
    }
}
