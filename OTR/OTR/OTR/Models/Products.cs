using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTR.Models
{
   class Products
    {
        SqlConnection conn;
        public Products() { }
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddProduct(Product product)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Products VALUES('{0}','{1}','{2}')", product.Name,product.Price,product.Quentity);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;


        }

        public ArrayList GetAllProducts()
        {
            ArrayList products = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                product.Quentity = reader.GetInt32(reader.GetOrdinal("Quantity"));

                products.Add(product);

            }
            conn.Close();
            return products;
        }
        public Product GetProduct(string name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Products WHERE Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = null;
            while (reader.Read())
            {
                product = new Product();
                product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                product.Quentity = reader.GetInt32(reader.GetOrdinal("Quantity"));
            }
            conn.Close();
            return product;
        }
    }
}
