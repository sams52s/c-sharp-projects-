using OTR.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTR.Views
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            var products = GetAllProducts();
            dGrid.DataSource = products;

        }

       
        public ArrayList GetAllProducts()
        {
            ArrayList products = new ArrayList();
            var conn = Database.ConnectBD();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string pName = tBProductName.Text;
            string pPrice = tBProductPrice.Text;
            string pQuantity = tBQuantity.Text;
            var conn = Database.ConnectBD();
            conn.Open();
            string query = String.Format("INSERT INTO Products VALUES('{0}','{1}','{2}')", pName,pPrice,pQuantity);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Value inserted");
            }
            else
            {
                MessageBox.Show("Value not inserted");
            }
            conn.Close();
            var products = GetAllProducts();
            dGrid.DataSource = products;

        }
    }
    
}
