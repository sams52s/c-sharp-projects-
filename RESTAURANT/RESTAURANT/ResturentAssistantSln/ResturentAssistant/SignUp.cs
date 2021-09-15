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
    public partial class SignUp : Form
    {
 
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Restaurants;Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (this.textBox6.Text.Length == 10)
            {
                try
            {
                SqlCommand com = new SqlCommand("INSERT INTO SignUp (ID,UserType,Name,PassWord,PhoneNumber,Gmail,City) values (@ID,@UserType,@Name,@PassWord,@PhoneNumber,@Gmail,@City)", con);
                com.Parameters.AddWithValue("@ID", this.textBox6.Text);
                com.Parameters.AddWithValue("@UserType", this.comboBox1.SelectedItem.ToString());
                com.Parameters.AddWithValue("@Name", this.textBox1.Text);
                com.Parameters.AddWithValue("@PassWord", this.textBox4.Text);
                com.Parameters.AddWithValue("@PhoneNumber", this.textBox3.Text);
                com.Parameters.AddWithValue("@Gmail", this.textBox5.Text);
                com.Parameters.AddWithValue("@City", this.textBox2.Text);
                com.ExecuteNonQuery();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

                if (checkBox1.Checked && acp.Checked)
                {
                    MessageBox.Show("Sign Up Succesful");
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Plese Check Those Box");
                }
            }
            else
            {
                MessageBox.Show("In valid Id.");
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
