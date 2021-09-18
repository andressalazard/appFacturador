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
        ClientModel selectedClient;

        public List<ClientModel> getClientsList() {
            return ClientList;
        }

    }
}
