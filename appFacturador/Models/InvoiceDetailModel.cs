using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFacturador.Models
{
    class InvoiceDetailModel
    {

        private int _clientID;
        private int _productID;
        private int _invoiceID;
        private int _productUnits;
        private decimal _productTotalCost;

        public int ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public int InvoiceID
        {
            get { return _invoiceID; }
            set { _invoiceID = value; }
        }
 
        public int ProductUnits
        {
            get { return _productUnits; }
            set { _productUnits = value; }
        }

        public decimal ProductTotalCost
        {
            get { return _productTotalCost; }
            set { _productTotalCost = value; }
        }







    }
}
