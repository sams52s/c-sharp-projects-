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
    public partial class AppviewForm : Form
    {
        public AppviewForm()
        {
            InitializeComponent();
            var products = GetAllProducts();
            dGrid.DataSource = products;
        }

        private void VC_Click(object sender, EventArgs e)
        {
            new AppCart().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LoginFormUser().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item Add to cart");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item Add to cart");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item Add to cart");
        }
        public ArrayList GetAllProducts()
        {
            ArrayList products = new ArrayList();
            var conn = Database.ConnectBD();
            conn.Open();
            string query = "SELECT * FROM Products ORDER BY Price";
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

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
