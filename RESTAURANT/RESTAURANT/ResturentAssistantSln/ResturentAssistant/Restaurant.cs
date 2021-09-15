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
    public partial class Restaurant : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Restaurants;Integrated Security=True");
        public Restaurant()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Restaurant (NID,Name,PhoneNumber,Gmail,City,About) values (@NID,@Name,@PhoneNumber,@Gmail,@City,@About)", con);
                com.Parameters.AddWithValue("@NID", this.textBox6.Text);
                com.Parameters.AddWithValue("@Name", this.textBox1.Text);
                com.Parameters.AddWithValue("@PhoneNumber", this.textBox3.Text);
                com.Parameters.AddWithValue("@Gmail", this.textBox5.Text);
                com.Parameters.AddWithValue("@City", this.comboBox1.SelectedItem.ToString());
                com.Parameters.AddWithValue("@About", this.richTextBox1.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Your Info have been assigned. Thank you...");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }
    }
}
