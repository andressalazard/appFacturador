using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFacturador.Models
{
    public class ProductModel
    {
        public ProductModel(int productID, string productName, decimal productPrice, string productCategory) {
            this.ProductId = productID;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.ProductCategory = productCategory;
        }

        public ProductModel(int productID, string productName, 
            decimal productPrice, string productCategory, int productUnits)
        {
            this.ProductId = productID;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.ProductCategory = productCategory;
            this.ProductUnits = productUnits;
        }

        public ProductModel() { }
        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public int ProductUnits { get; set; }

    }
}
