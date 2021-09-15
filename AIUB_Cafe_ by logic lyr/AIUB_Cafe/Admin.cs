using logicl_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIUB_Cafe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            dataGridView2.DataSource = userController.GetAll();
        }
        userController userController = new userController();
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
        public String ind;

        private void button1_Click(object sender, EventArgs e)
        {
            addbyAdmin addbyAdmin = new addbyAdmin();
            addbyAdmin.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cafeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cafeInventory cafeInventory = new cafeInventory();
            cafeInventory.Show();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            bool d= userController.Delete(ind);
            if(d==true)
            {
                MessageBox.Show("User removed succesfully");
                dataGridView2.DataSource = userController.GetAll();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            if (ind != null)
            {
                MessageBox.Show("Sellected");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView2.DataSource = userController.GetAll();
        }

    }
}
