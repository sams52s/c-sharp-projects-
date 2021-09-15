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
    public partial class Admin : Form
    {
        public String ind;
        public String ind2;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F9IRGFB;Initial Catalog=Restaurants;Integrated Security=True");
        //this two meth just for showing dataGridView1 and dataGridView2 in place....
        public void userDB()
        {
            SqlDataAdapter da=null;
            DataTable dt2 = new DataTable();
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM SignUp ", con);
            da.Fill(dt2);
            dataGridView2.DataSource = dt2;
            con.Close();
        }
        public void EmpDB()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1=null;
            con.Open();
            da1 = new SqlDataAdapter("SELECT * FROM Restaurant", con);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }
        public Admin()
        {
            InitializeComponent();
            userDB();
            EmpDB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (ind==null)
                {
                    MessageBox.Show("Not selected");
                }

                else
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("DELETE FROM SignUp WHERE id= '" + int.Parse(ind) +"'", con);

                    com.ExecuteNonQuery();
                    MessageBox.Show("An USER deleted ");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Admin add_Admin = new Add_Admin();
            add_Admin.Show();
           
}

        private void button5_Click(object sender, EventArgs e)
        {
            userDB();
            EmpDB();
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            MessageBox.Show(ind);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ind2 == null)
                {
                    MessageBox.Show("Not selected");
                }

                else
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("DELETE FROM Restaurant WHERE nid= '" + int.Parse(ind2) + "'", con);

                    com.ExecuteNonQuery();
                    MessageBox.Show("An Restaurant deleted ");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind2 = dataGridView1.Rows[e.RowIndex].Cells["NID"].Value.ToString();
            MessageBox.Show(ind2);
        }
    }
}
