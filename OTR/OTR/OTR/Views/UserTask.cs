using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTR.Views
{
    public partial class UserTask : Form
    {
        public UserTask()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new AppCart().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AppviewForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Placed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Canceled");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dynamic r = rBbKash;
            if (r=true) 
            {
                MessageBox.Show("Plesse Give bKash Number and Password");
                new bKash().Show();
            }

           
        }
    }
}
