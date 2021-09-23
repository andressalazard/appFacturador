using appFacturador.Config;
using appFacturador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFacturador.Controllers
{
    class Invoice
    {
        InvoiceModel currentInvoice;

        public Invoice(){
            currentInvoice = new InvoiceModel();
        }

        public Invoice(int invoiceID, DateTime emissionDate, decimal subTotal,
            int tax, decimal total, string RUC, string serialNumber)
        {
            currentInvoice = new InvoiceModel();
            currentInvoice.InvoiceID = invoiceID;
            currentInvoice.EmissionDate = emissionDate;
            currentInvoice.SubTotal = subTotal;
            currentInvoice.Tax = tax;
            currentInvoice.Total = total;
            currentInvoice.RUC = RUC;
            currentInvoice.SerialNumber = serialNumber;
        }

        public Invoice( DateTime emissionDate, decimal subTotal,
            int tax, decimal total, string RUC, string serialNumber)
        {
            currentInvoice = new InvoiceModel();
            currentInvoice.EmissionDate = emissionDate;
            currentInvoice.SubTotal = subTotal;
            currentInvoice.Tax = tax;
            currentInvoice.Total = total;
            currentInvoice.RUC = RUC;
            currentInvoice.SerialNumber = serialNumber;
        }

        public Invoice(DateTime emissionDate, decimal subTotal,
            int tax, decimal total, string serialNumber)
        {
            currentInvoice = new InvoiceModel();
            currentInvoice.EmissionDate = emissionDate;
            currentInvoice.SubTotal = subTotal;
            currentInvoice.Tax = tax;
            currentInvoice.Total = total;
            currentInvoice.SerialNumber = serialNumber;
        }

        public Invoice(int invoiceID, decimal subTotal,
            int tax, decimal total, string RUC, string serialNumber)
        {
            currentInvoice = new InvoiceModel();
            currentInvoice.InvoiceID = invoiceID;
            currentInvoice.SubTotal = subTotal;
            currentInvoice.Tax = tax;
            currentInvoice.Total = total;
            currentInvoice.RUC = RUC;
            currentInvoice.SerialNumber = serialNumber;
        }



        public InvoiceModel GetInvoice() {
            return currentInvoice;
        }

        public void SaveCurrentInvoice() {
            if (currentInvoice != null) {
                DBConnection connection = new DBConnection();
                connection.registerNewInvoice(currentInvoice);
            }        
        }

        public InvoiceModel GetFetchedInvoiceRecord(string serialNumber) {
            DBConnection connection = new DBConnection();
            List<InvoiceModel> list = connection.getInvoiceRecordBySerialNumber(serialNumber);
            if (list.Count > 0) {
                return list.First();
            }

            return null;
        }

    }
}
