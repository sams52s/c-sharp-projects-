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
    public partial class makePay : Form
    {
        orderController orderController = new orderController();
        Viewcart Viewcart = new Viewcart();
        public makePay()
        {
            InitializeComponent();
            dataGridView1.DataSource = orderController.GetAllCart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Viewcart.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your all order have been canceled");
            done();
            this.Close();
            Viewcart.Show();
        }
        public void done()
        {
           string a= orderController.confirmorder();
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
    }
}
