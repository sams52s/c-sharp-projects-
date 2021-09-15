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
namespace AIUB_Student_Cafe
{
   
    public partial class Selldtls : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AA3QK5F;Initial Catalog=AIUB_CAFE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Selldtls()
        {
            InitializeComponent();
            cartDB();
        }
        public void cartDB()
        {
            SqlDataAdapter da = null;
            DataTable dt2 = new DataTable();
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM AllSelli ", con);
            da.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
        }

    }
}
