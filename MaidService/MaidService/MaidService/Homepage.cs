using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaidService
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            this.Visible = false;
            option.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Visible = false;
            home.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application Exit!", "Are you sure want to exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WhatWeOffer whatweOffer = new WhatWeOffer();
            this.Visible = false;
            whatweOffer.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WhyUs whyus = new WhyUs();
            this.Visible = false;
            whyus.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContactUs contactus = new ContactUs();
            this.Visible = false;
            contactus.Visible = true;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
