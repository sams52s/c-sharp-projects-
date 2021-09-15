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
    public partial class Bill : Form
    {
        orderController orderController = new orderController();
        Cart cart = new Cart();
        public Bill()
        {
            InitializeComponent();
            dataGridView1.DataSource = orderController.GetAllCart();
        }
        public void done()
        {
            string a = orderController.confirmorder();
            string b = orderController.RemoveAll();
            MessageBox.Show(a);
            MessageBox.Show(b);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for being with us. Your order have been placed");
            done();
            dataGridView1.DataSource = orderController.GetAllCart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            done();
            dataGridView1.DataSource = orderController.GetAllCart();
            MessageBox.Show("Thank you for being with us.\n our bkash number is:01700000000.\n Your order have been placed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your all order have been canceled");
            done();
            this.Close();
            cart.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            cart.Show();
        }
    }
}
