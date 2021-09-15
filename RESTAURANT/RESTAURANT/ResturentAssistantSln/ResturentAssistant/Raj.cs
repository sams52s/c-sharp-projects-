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
    public partial class Raj : Form
    {
        string d;
        SqlCommand com;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Restaurants;Integrated Security=True");
        public Raj()
        {
                
            InitializeComponent();
        }

        private void Raj_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Beside Nagarvaban 2nd floar.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImHere h = new ImHere();
            h.getRname("GCC");
            h.l();
            h.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = d;
        }
    }
}
