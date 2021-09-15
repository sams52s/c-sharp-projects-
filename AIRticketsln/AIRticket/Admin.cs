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
    public partial class Admin : Form
    {
        public String ind;
        Controller Controller = new Controller();
        public Admin()
        {
            InitializeComponent();
            dataGridView2.DataSource = Controller.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmployee addEmployee = new addEmployee();
            addEmployee.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool d = Controller.Delete(ind);
            if (d == true)
            {
                MessageBox.Show("User removed succesfully");
                dataGridView2.DataSource = Controller.GetAll();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Controller.GetAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void cafeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketinventory ticketinventory = new ticketinventory();
            ticketinventory.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            if (ind != null)
            {
                MessageBox.Show("Sellected");
            }
        }
    }
}
