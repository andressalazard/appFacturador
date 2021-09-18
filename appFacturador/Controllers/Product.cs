using appFacturador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFacturador.Controllers
{
    class Product
    {
        List<ProductModel> ProductList = new List<ProductModel>();

        public List<ProductModel> getProductList() {
            return ProductList;
        }
    }
}
