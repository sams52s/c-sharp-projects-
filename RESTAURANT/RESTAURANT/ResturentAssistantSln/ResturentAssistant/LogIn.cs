using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ResturentAssistant
{
    public partial class LogIn : Form
    {
        SqlCommand com;
        SqlDataAdapter da;
      // SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Restaurants;Integrated Security=True");
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com = new SqlCommand("SELECT * FROM SignUp WHERE id= '" + int.Parse(textBox1.Text) + "' and PassWord='" + textBox2.Text.ToString() + "'", con);
                da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataReader dr = com.ExecuteReader();
                if (dt.Rows.Count > 0)
                {
                    con.Close();
                    con.Open();
                    SqlCommand com = new SqlCommand("SELECT * FROM SignUp WHERE id= " + int.Parse(textBox1.Text), con);
                    dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        String v = (dr["UserType"].ToString());
                        if(v== "ResturantOwner")
                        {
                            Restaurant restaurant = new Restaurant();
                            restaurant.Show();
                            this.Close();
                        }
                        else if(v== "Customer")
                        {
                            MainFrom mainFrom = new MainFrom();
                            mainFrom.Show();
                            this.Close();
                        }
                        else
                        {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Close();
                        }
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Your Id is not found");
                }
                
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
