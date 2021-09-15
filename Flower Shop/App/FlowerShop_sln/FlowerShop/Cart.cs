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
    public partial class Cart : Form
    {
        orderController orderController = new orderController();
        public String ind;
        public Cart()
        {
            InitializeComponent();
            dataGridView1.DataSource = orderController.GetAllCart();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orderController.GetAllCart();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            if (ind != null)
            {
                MessageBox.Show("Sellected");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string er = orderController.updatequantity(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            MessageBox.Show(er);
            textBox2.Clear();
            textBox3.Clear(); dataGridView1.DataSource = orderController.GetAllCart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            this.Close();
            bill.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string d = orderController.RemoveAll();
            MessageBox.Show(d);
            dataGridView1.DataSource = orderController.GetAllCart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d = orderController.Remove(int.Parse(textBox1.Text));
            MessageBox.Show(d);
            textBox1.Clear();
            dataGridView1.DataSource = orderController.GetAllCart();
        }
    }
}
