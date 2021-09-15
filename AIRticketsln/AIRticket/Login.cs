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
    public partial class Login : Form
    {
        Controller userController = new Controller();
        public Login()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (ID.Text != null && Pass.Text != null)
            {
                string r = userController.get(ID.Text.ToString(), Pass.Text.ToString());
                switch (r)
                {
                    case "Admin":
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                        break;
                    case "Customer":
                        ticket ticket = new ticket();
                        ticket.Show();
                        this.Hide();
                        break;
                    case "Employee":
                        Employee empo = new Employee();
                        empo.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show(r);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
