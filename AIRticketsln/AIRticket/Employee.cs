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
    public partial class Employee : Form
    {
        Controller Controller = new Controller();
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your ticket has been purcesed. Thank you");

        }
        public void refr()
        {
            dataGridView2.DataSource = Controller.getAll();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            refr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addflight addflight = new addflight();
            addflight.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
