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
    public partial class MainFrom : Form
    {

        public MainFrom()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          //  ";
        }

        private void zeroPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raj gcc = new Raj();
            gcc.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "KFC Bhatara (Bashundhara R/A) \n Call + 8809613666666 or \n order online at www.kfcbd.com!.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text= " Bashundhara R/A.\n Beside Gate";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImHere h = new ImHere();
            h.getRname("KFC");
            h.l();
            h.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImHere h = new ImHere();
            h.getRname("BK");
            h.l();
            h.Show();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
