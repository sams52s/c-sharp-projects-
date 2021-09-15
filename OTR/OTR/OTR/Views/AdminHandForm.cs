using OTR.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTR.Views
{
    public partial class AdminHandForm : Form
    {
        public AdminHandForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tBSraech.Text;
            dynamic user = AdminController.GetUser(username);
            if (user != null)
            {
                tBName.Text = user.Name;
                tBUsername.Text = user.Username;

            }
            else
            {
                tBName.Text = "";
                tBUsername.Text = "";
                MessageBox.Show("No user found");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Name = tBName.Text,
                Username = tBUsername.Text,
            };
            var result = AdminController.UpdateUser(user);
            if (result)
            {
                MessageBox.Show("User Upddated");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = AdminController.DeleteUser(tBUsername.Text);
            if (r)
            {
                MessageBox.Show("User Deleated");
            }
            else
            {
                MessageBox.Show("Could not deleate");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new OrderInfoForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new InventoryForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new RevenueForm().Show();
        }
    }
}
