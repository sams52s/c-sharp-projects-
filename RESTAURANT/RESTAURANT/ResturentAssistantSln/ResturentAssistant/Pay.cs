using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturentAssistant
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Wait for a moment.\n We are coming with your bill";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Wait for a moment.\n We are Sending Our Bkash details";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainFrom m = new MainFrom();
            m.Show();
            Close();
        }
    }
}
