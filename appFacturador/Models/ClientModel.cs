using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFacturador.Models
{
    public class ClientModel
    {
        
        public ClientModel()
        {

        }

        public ClientModel(string FirstName, string LastName, 
          string Phone, string Email, string Address){
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
        }

        public ClientModel(int ClientID, string FirstName, string LastName,
          string Phone, string Email, string Address)
        {
            this.ClientId = ClientID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
        }


        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
