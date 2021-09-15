using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculetor
{
    public partial class Form1 : Form
    {
        public double number;
        public int count;
        public double ans;
        public double temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            label1.Text = label1.Text + 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            label1.Text = label1.Text + 2;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            label1.Text = label1.Text + 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            label1.Text = label1.Text +4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            label1.Text = label1.Text + 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            label1.Text = label1.Text + 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            label1.Text = label1.Text + 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;

            label1.Text = label1.Text + 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            label1.Text = label1.Text + 9;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            label1.Text = label1.Text + 0;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + ".";
            label1.Text = label1.Text + ".";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(number== 0)
            {
                number = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                ans = number + Convert.ToDouble(textBox1.Text);
                number = ans;
                textBox1.Text = ans.ToString();
            }
            
            textBox1.Text = textBox1.Text + "+";
            label1.Text = label1.Text + "+";
            textBox1.Clear();
            textBox1.Focus();
            count = 1;

        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                ans = number - Convert.ToDouble(textBox1.Text);
                number = ans;
                textBox1.Text = ans.ToString();
            }
            number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "-";
            label1.Text = label1.Text + "-";
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                ans = number * Convert.ToDouble(textBox1.Text);
                number = ans;
                textBox1.Text = ans.ToString();
            }
            number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "*";
            label1.Text = label1.Text + "*";
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                number = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                ans = number / Convert.ToDouble(textBox1.Text);
                number = ans;
                textBox1.Text = ans.ToString();
            }
            number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "/";
            label1.Text = label1.Text + "/";
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void equ_Click(object sender, EventArgs e)
        {
            compute(count);
            label1.Text = label1.Text + "="+ ans.ToString();
            textBox1.Text = ans.ToString();
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = number + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = number - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                
                case 3:
                    ans = number * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = number / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
            private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            count = 0;
        }
    }
}
