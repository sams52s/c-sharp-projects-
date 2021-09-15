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
    public partial class makePay : Form
    {
        Controller Controller = new Controller();
        schedule schedule = new schedule();
        public void done()
        {
            string a = Controller.confirmorder();
            string b = Controller.RemoveAll();
            MessageBox.Show(a);
            MessageBox.Show(b);

        }
        public makePay()
        {
            InitializeComponent();
            dataGridView1.DataSource = Controller.GetAllCart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for being with us. Your order have been placed");
            done();
            dataGridView1.DataSource = Controller.GetAllCart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            done();
            dataGridView1.DataSource = Controller.GetAllCart();
            MessageBox.Show("Thank you for being with us.\n our bkash number is:01700000000.\n Your order have been placed");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d = Controller.RemoveAll();
            MessageBox.Show(d);
            dataGridView1.DataSource = Controller.GetAllCart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            schedule.Show();
        }

        private void makePay_Load(object sender, EventArgs e)
        {

        }
    }
}
