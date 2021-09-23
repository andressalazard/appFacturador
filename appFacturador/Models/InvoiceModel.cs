using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFacturador.Models
{
    class InvoiceModel
    {

        private int _invoiceID;
        private DateTime _emissionDate;
        private decimal _subTotal;
        private int _tax;
        private decimal _total;
        private string _RUC;
        private string _serialNumber;


        public int InvoiceID
        {
            get { return _invoiceID; }
            set { _invoiceID = value; }
        }

        public DateTime EmissionDate
        {
            get { return _emissionDate; }
            set { _emissionDate = value; }
        }

        public decimal SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        public int Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public string RUC
        {
            get { return _RUC; }
            set { _RUC = value; }
        }

        public string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }








    }
}
