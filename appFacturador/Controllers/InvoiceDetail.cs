using appFacturador.Config;
using appFacturador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFacturador.Controllers
{
    class InvoiceDetail
    {
        InvoiceDetailModel invoiceDetail;

        public InvoiceDetail() { 
        
        }

        public InvoiceDetail(int ClientID, int ProductID,
            int InvoiceID, int ProductUnits, decimal ProductTotalCost) {

            invoiceDetail = new InvoiceDetailModel();

            invoiceDetail.ClientID = ClientID;
            invoiceDetail.ProductID = ProductID;
            invoiceDetail.InvoiceID = InvoiceID;
            invoiceDetail.ProductUnits = ProductUnits;
            invoiceDetail.ProductTotalCost = ProductTotalCost;
        }

        public InvoiceDetailModel GetInvoiceDetail() {
            return invoiceDetail;
        }

        public void SaveInvoiceDetail() {
            if (invoiceDetail != null) {
                DBConnection connection = new DBConnection();
                connection.registerNewInvoiceDetailRecord(invoiceDetail);
            }
        }

    }
}
