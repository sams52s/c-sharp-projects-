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
    public partial class Flowers : Form
    {
        ItemsController itemsController = new ItemsController();
        orderController orderController = new orderController();
        Cart cart = new Cart();
        public Flowers()
        {
            InitializeComponent();
            dataGridView1.DataSource = itemsController.getAll();
        }
        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cart.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string er = orderController.get(int.Parse(textBox2.Text), textBox1.Text.ToString());
            MessageBox.Show(er);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cart.Show();
            this.Close();
        }
    }
}
