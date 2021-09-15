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
    public partial class addFlower : Form
    {
        ItemsController itemsController = new ItemsController();
        public addFlower()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = itemsController.getAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string er = itemsController.create(textBox1.Text.ToString(), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            MessageBox.Show(er);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == null)
            {
                MessageBox.Show("You must give id");
            }
            else
            {
                int id = int.Parse(textBox4.Text);
                if (textBox5.Text != "" && textBox6.Text != "")
                {
                    int Quantity = int.Parse(textBox5.Text);
                    int price = int.Parse(textBox6.Text);
                    itemsController.updatequantity(id, Quantity);
                    itemsController.updatePrice(id, price);
                }
                if (textBox5.Text == null && textBox6.Text != null)
                {
                    int price = int.Parse(textBox6.Text);
                    itemsController.updatePrice(id, price);
                }
                if (textBox5.Text != null && textBox6.Text == null)
                {
                    int Quantity = int.Parse(textBox5.Text);
                    itemsController.updatequantity(id, Quantity);
                }
            }
        }
    }
}
