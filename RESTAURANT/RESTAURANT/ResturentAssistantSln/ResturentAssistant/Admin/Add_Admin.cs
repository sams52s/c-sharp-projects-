using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResturentAssistant
{
    public partial class Add_Admin : Form
    {
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Restaurants;Integrated Security=True");
        public Add_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("INSERT INTO SignUp (ID,UserType,Name,PassWord,PhoneNumber,Gmail,City) values (@ID,@UserType,@Name,@PassWord,@PhoneNumber,@Gmail,@City)", con);
                com.Parameters.AddWithValue("@ID", textBox1.Text.ToString());
                com.Parameters.AddWithValue("@UserType","Admin");
                com.Parameters.AddWithValue("@Name", textBox2.Text.ToString());
                com.Parameters.AddWithValue("@PassWord", textBox3.Text.ToString());
                com.Parameters.AddWithValue("@PhoneNumber", textBox5.Text.ToString());
                com.Parameters.AddWithValue("@Gmail", textBox4.Text.ToString());
                com.Parameters.AddWithValue("@City", textBox6.Text.ToString());
               // com.ExecuteNonQuery();
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("An Admin Added.");
                    Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               Close();
            }
            Close();
        }

        private void Add_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
