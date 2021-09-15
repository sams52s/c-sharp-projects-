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
    public partial class LoginFormUser : Form
    {
        public LoginFormUser()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            new UserRegisteredForm().Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            string username = tBUsername.Text;
            string password = tBPassword.Text;
            var result = UserController.AuthenticateUser(username, password);
            if (result != null)
            {
                new AppviewForm().Show();
            }
            else
                MessageBox.Show("User NOT Valid");
        }
    }
}
