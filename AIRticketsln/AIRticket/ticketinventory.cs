using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIRticket
{
    public partial class ticketinventory : Form
    {
        Controller Controller = new Controller();
        public ticketinventory()
        {
            InitializeComponent();
            showItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int rid = int.Parse(textBox1.Text);
                string show = Controller.Remove(rid);
                MessageBox.Show(show);
                textBox1.Clear();
            }
        }
        public void showItem()
        {
            dataGridView1.DataSource = Controller.getAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addflight addflight = new addflight();
            addflight.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showItem();
        }
        public String ind;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
