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
    public partial class Worker : Form
    {
        orderController orderController = new orderController();
        ItemsController itemsController = new ItemsController();
        public Worker()
        {
            InitializeComponent();
            refr();
        }
        public void refr()
        {
            dataGridView2.DataSource = itemsController.getAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderController.order(int.Parse(textBox1.Text), int.Parse(textBox2.Text), textBox3.Text.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            refr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addFlower flowers = new addFlower();
            flowers.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
