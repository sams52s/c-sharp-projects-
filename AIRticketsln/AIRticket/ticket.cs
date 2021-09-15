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
    public partial class ticket : Form
    {
        Controller Controller = new Controller();
        public ticket()
        {
            InitializeComponent();
            dataGridView1.DataSource = Controller.getAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string er = Controller.get(int.Parse(textBox2.Text), textBox1.Text.ToString());
            MessageBox.Show(er);
            textBox1.Clear();
            textBox2.Clear();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            schedule.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        schedule schedule = new schedule();

        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schedule.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
