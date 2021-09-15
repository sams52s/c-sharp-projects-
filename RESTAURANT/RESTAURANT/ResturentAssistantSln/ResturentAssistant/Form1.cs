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
using System.Data.Sql;

namespace ResturentAssistant
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Restaurants;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SignUp ", con);
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp sup = new SignUp();
            sup.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
