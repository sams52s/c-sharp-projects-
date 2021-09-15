using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class Admin : Form
    {
        userController userController = new userController();
        public String ind;
        public Admin()
        {
            InitializeComponent();
            dataGridView2.DataSource = userController.GetAll();
        }

        private void cafeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shop Shop = new Shop();
            Shop.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addbyAdmin addbyAdmin = new addbyAdmin();
            addbyAdmin.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool d = userController.Delete(ind);
            if (d == true)
            {
                MessageBox.Show("User removed succesfully");
                dataGridView2.DataSource = userController.GetAll();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = userController.GetAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Form1 form = new Form1();
            form.Show();
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
