using appFacturador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFacturador.Controllers
{
    class Client
    {
        List<ClientModel> ClientList = new List<ClientModel>();
        ClientModel selectedClient = new ClientModel();

        public List<ClientModel> getClientsList() {
            return ClientList;
        }

        public ClientModel GenerateClient( string FirstName, string LastName, 
            string Phone, string Email, string Address ) {
            return new ClientModel(FirstName, LastName, Phone, Email, Address);
        }

        public ClientModel GenerateUniqueClient(int ClientID, string FirstName, string LastName,
            string Phone, string Email, string Address){
            return new ClientModel(ClientID, FirstName, LastName, Phone, Email, Address);
        }

        public void SetSelectedClient(ClientModel client) {
            this.selectedClient = client;
        }

        public ClientModel GetSelectedClient() {
            return this.selectedClient;
        }

    }
}
