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
    public partial class UserRegisteredForm : Form
    {
        public UserRegisteredForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            var user = new
            {

                Name = tBName.Text,
                Username = tBUsername.Text,
                Phone = tBPhone.Text,
                Mail = tBMail.Text,
                Age = cMAge.Text,
                City = cMCity.Text,
                Gender = cMGender.Text,
                Password = tBPassword.Text
            };
            var result = UserController.AddUser(user);
            if (result)
            {
                MessageBox.Show("User Added");
            }
            else
            {
                MessageBox.Show("Could Not add user");
            }
        }

        private void btnLoginpage_Click(object sender, EventArgs e)
        {
            new LoginFormUser().Show();
        }
    }
}
