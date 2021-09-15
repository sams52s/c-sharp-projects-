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
    public partial class ImHere : Form
    {
        public string name;
        public void getRname(string rn)
        {
            name = rn;
        }
        public String setRname()
        {
            return name;
        }
        public ImHere()
        {
            InitializeComponent();
        }
        public void l()
            { label1.Text = setRname(); }
   
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ImHere_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Resurvation Accepted in : "+ setRname()+"\nResurvation will be cancled after 30min \n IF you do not come.\n Thank you.\n See You soon");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Pleace wait.\n we are coming for you..";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pay p = new Pay();
            p.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFrom m = new MainFrom();
            m.Show();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
