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

        private ClientModel generateClientRecord() {
            ClientModel clientRecord;

            if (txtFirstName.Text != "" &&
                txtLastName.Text != "" &&
                txtPhone.Text != "" &&
                txtEmail.Text != "" &&
                txtAddress.Text != "")
            {

                clientRecord = new ClientModel(
                  txtFirstName.Text, txtLastName.Text,
                  txtPhone.Text, txtEmail.Text, txtAddress.Text);

                return clientRecord;
            }
            else {
                MessageBox.Show("Llene todos los campos!");
                return clientRecord = null;
            }
        }

        private void registerClientRecord() {
            ClientModel record = generateClientRecord();

            if (record != null) {
                DBConnection connection = new DBConnection();
                connection.registerNewClient(record);
            }

        }
    }
}
