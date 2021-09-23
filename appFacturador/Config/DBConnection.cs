using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using appFacturador.Models;
using System.Windows.Forms;
using appFacturador.Controllers;

namespace appFacturador.Config
{
    class DBConnection
    {
        string connectionString = @"Data Source=DESKTOP-0FAOJ20\SQLEXPRESS;
                        Initial Catalog = marketDB; User ID= sa; Password=andres1234";

        SqlConnection dbConnection;

        #region connect-disconnect methods
        
        public void ConnectToDatabase() {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            Console.WriteLine("Connection Open!");
        }

        public void DisconnectToDatabase()
        {
            dbConnection.Close();
            Console.WriteLine("Connection Closed!");
        }

        #endregion



        #region SQL-fetching methods

        public List<ProductModel> FetchDatabaseProducts() {
            string sql = "SELECT * FROM PRODUCT";
            List<ProductModel> productsList = new List<ProductModel>();
            SqlCommand command = new SqlCommand(sql, dbConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read()) {
                ProductModel fetchedProduct = new ProductModel(
                    (int)dataReader["ProductID"],
                    dataReader["ProductName"].ToString(),
                    (decimal)dataReader["ProductPrice"],
                    dataReader["ProductCategory"].ToString()
                    );
                productsList.Add(fetchedProduct);
            }
            dataReader.Close();
            return productsList;
        }

        public List<ClientModel> FetchDatabaseClients()
        {
            List<ClientModel> registeredClients = new List<ClientModel>();
            string sql = "SELECT * FROM CLIENT";
            SqlCommand command = new SqlCommand(sql, dbConnection);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read()) {
                ClientModel fetchedClient = new ClientModel(
                    (int)dataReader["ClientID"],
                    dataReader["FirstName"].ToString(),
                    dataReader["LastName"].ToString(),
                    dataReader["Phone"].ToString(),
                    dataReader["Email"].ToString(),
                    dataReader["PersonalAddress"].ToString()
                    );
                registeredClients.Add(fetchedClient);
            }

            dataReader.Close();
            return registeredClients;
        }

        public List<InvoiceModel> FetchInvoiceRecord(string serialNumber) {
            string sql = $"SELECT * FROM INVOICE WHERE SerialNumber = '{serialNumber}'";
            List<InvoiceModel> fetchedList = new List<InvoiceModel>();
            SqlCommand command = new SqlCommand(sql, dbConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read()) {
                Console.WriteLine(dataReader);
                Invoice fetchedInvoice = new Invoice(
                    (int)dataReader["InvoiceID"],
                    (decimal)dataReader["Subtotal"],
                    (int)dataReader["Tax"],
                    (decimal)dataReader["Total"],
                    dataReader["RUC"].ToString(),
                    dataReader["SerialNumber"].ToString());
                fetchedList.Add(fetchedInvoice.GetInvoice());
            }

            dataReader.Close();

            return fetchedList;
        }


        public void InsertClientRecord(ClientModel clientRecord) {
           
            string storedProcedureName = "SP_Insert_Client";
            SqlCommand command = new SqlCommand(storedProcedureName, dbConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FirstName", clientRecord.FirstName);
            command.Parameters.AddWithValue("@LastName", clientRecord.LastName);
            command.Parameters.AddWithValue("@Phone", clientRecord.Phone);
            command.Parameters.AddWithValue("@Email", clientRecord.Email);
            command.Parameters.AddWithValue("PersonalAddress", clientRecord.Address);

            int i = command.ExecuteNonQuery();

            if (i != 0) {
                MessageBox.Show(i + "Client Successfully save on DB!");
            }
        }

        public void InsertInvoiceRecord(InvoiceModel invoiceRecord) {
            string storedProcedureName = "SP_Insert_Invoice";
            SqlCommand command = new SqlCommand(storedProcedureName, dbConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@EmissionDate", invoiceRecord.EmissionDate);
            command.Parameters.AddWithValue("@Subtotal", invoiceRecord.SubTotal);
            command.Parameters.AddWithValue("@Tax", invoiceRecord.Tax);
            command.Parameters.AddWithValue("@Total", invoiceRecord.Total);
            command.Parameters.AddWithValue("@SerialNumber", invoiceRecord.SerialNumber);

            int i = command.ExecuteNonQuery();
            if (i != 0) {
                MessageBox.Show(i + "Invoice Successfully save on DB!");
            }
        }

        public void InsertInvoiceDetailRecord(InvoiceDetailModel invoiceDetailRecord) {
            string storedProcedureName = "SP_InsertInvoiceDetail";
            SqlCommand command = new SqlCommand(storedProcedureName, dbConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ClientID", invoiceDetailRecord.ClientID);
            command.Parameters.AddWithValue("@ProductID", invoiceDetailRecord.ProductID);
            command.Parameters.AddWithValue("@InvoiceID", invoiceDetailRecord.InvoiceID);
            command.Parameters.AddWithValue("@ProductUnits", invoiceDetailRecord.ProductUnits);
            command.Parameters.AddWithValue("@ProductTotalCost", invoiceDetailRecord.ProductTotalCost);

            int i = command.ExecuteNonQuery();
            if (i != 0) {
                MessageBox.Show($"{i} - Invoice Successfully save on DB!");
            }
        }



        #endregion



        #region api-calls

        public List<ProductModel> getAvailableProducts() {
            ConnectToDatabase();
            List<ProductModel>productList = FetchDatabaseProducts();
            DisconnectToDatabase();
            return productList;
        }

        public List<ClientModel> getRegisteredClients() {
            ConnectToDatabase();
            List<ClientModel> clientList = FetchDatabaseClients();
            DisconnectToDatabase();
            return clientList;
        }

        public void registerNewClient(ClientModel client) {
            ConnectToDatabase();
            InsertClientRecord(client);
            DisconnectToDatabase();
        }

        public void registerNewInvoice(InvoiceModel invoice) {
            ConnectToDatabase();
            InsertInvoiceRecord(invoice);
            DisconnectToDatabase();
        }

        public void registerNewInvoiceDetailRecord(InvoiceDetailModel invoiceDetail) {
            ConnectToDatabase();
            InsertInvoiceDetailRecord(invoiceDetail);
            DisconnectToDatabase();
        }

        public List<InvoiceModel> getInvoiceRecordBySerialNumber(string serialNumber) {
            ConnectToDatabase();
            List<InvoiceModel> fetchedList= FetchInvoiceRecord(serialNumber);
            DisconnectToDatabase();

            return fetchedList;
        }

        


        #endregion



       

    }
}
