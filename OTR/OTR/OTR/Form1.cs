﻿using OTR.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            new LoginFormUser().Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new LoginAdminForm().Show();
        }
    }
}
