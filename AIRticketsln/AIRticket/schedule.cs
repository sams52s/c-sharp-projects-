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
    public partial class schedule : Form
    {
        Controller Controller = new Controller();
        public String ind;
        public schedule()
        {
            InitializeComponent();
            dataGridView1.DataSource = Controller.GetAllCart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string d = Controller.RemoveAll();
            MessageBox.Show(d);
            dataGridView1.DataSource = Controller.GetAllCart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string er = Controller.updatequantity(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            MessageBox.Show(er);
            textBox2.Clear();
            textBox3.Clear(); 
            dataGridView1.DataSource = Controller.GetAllCart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d = Controller.Remove(int.Parse(textBox1.Text));
            MessageBox.Show(d);
            textBox1.Clear();
            dataGridView1.DataSource = Controller.GetAllCart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makePay makePay = new makePay();
            this.Close();
            makePay.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Controller.GetAllCart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            if (ind != null)
            {
                MessageBox.Show("Sellected");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ticket ticket = new ticket();
            ticket.Show();
            this.Close();
        }
    }
}
