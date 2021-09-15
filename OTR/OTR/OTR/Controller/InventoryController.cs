using OTR.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTR.Controller
{
    class InventoryController
    {
        static Database db = new Database();


        public static bool AddProduct(dynamic product)
        {
            Product p = new Product();
            p.Name = product.Name;
            p.Price = product.Price;
            p.Quentity = product.Quentity;

            return db.Products.AddProduct(p);
        }

        public static Product GetProduct(string name)
        {
            return db.Products.GetProduct(name);
        }
        public static ArrayList GetAllProducts()
        {
            return db.Products.GetAllProducts();
        }
    }
}
