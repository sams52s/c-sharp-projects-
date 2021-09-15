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
    public partial class Shop : Form
    {
        ItemsController itemsController = new ItemsController();
        public String ind;
        public Shop()
        {
            InitializeComponent();
            showItem();
        }
        public void showItem()
        {
            dataGridView1.DataSource = itemsController.getAll();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int rid = int.Parse(textBox1.Text);
                string show = itemsController.Remove(rid);
                MessageBox.Show(show);
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addFlower flowers = new addFlower();
            flowers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showItem();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        }
    }
}
