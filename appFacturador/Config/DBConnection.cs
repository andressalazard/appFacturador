using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using appFacturador.Models;

namespace appFacturador.Config
{
    class DBConnection
    {
        string connectionString = @"Data Source=DESKTOP-0FAOJ20\SQLEXPRESS;
                        Initial Catalog = marketDB; User ID= sa; Password=andres1234";

        SqlConnection dbConnection;
        
        public void ConnectToDatabase() {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            MessageBox.Show("Connection Open!");
        }

        public void ConsultQuery(string sqlRequest) {
            SqlCommand command;
            SqlDataReader dataReader;
            string output = "";
            command = new SqlCommand(sqlRequest, dbConnection);
            dataReader = command.ExecuteReader();
            //Object[] values = new Object[dataReader.FieldCount];

            while (dataReader.Read()) {
                Object[] values = new Object[dataReader.FieldCount];
                for (int i = 0; i < dataReader.FieldCount; i++) {
                    Console.WriteLine("Values of: "+values[i]);
                }
            }
            dataReader.Close();

        }

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

            /*foreach (ProductModel product in productsList) {
                Console.WriteLine($"product ID: {product.ProductId}, name: {product.ProductName}, price: {product.ProductPrice}, category: {product.ProductCategory}");
            }*/

            return productsList;
        }


        public List<ProductModel> getAvailableProducts() {
            ConnectToDatabase();
            List<ProductModel>productList = FetchDatabaseProducts();
            DisconnectToDatabase();
            return productList;
        }



        public void DisconnectToDatabase() {
            dbConnection.Close();
            MessageBox.Show("Connection Closed!");
        }

    }
}
