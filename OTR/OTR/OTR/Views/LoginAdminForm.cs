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
    public partial class LoginAdminForm : Form
    {
        public LoginAdminForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = tBUsername.Text;
            string password = tBPassword.Text;
            var result = AdminController.AuthenticateUser(username, password);
            if (result != null)
            {
                new AdminHandForm().Show();
            }
            else
                MessageBox.Show("User NOT Valid");
            
        }
    }
}
