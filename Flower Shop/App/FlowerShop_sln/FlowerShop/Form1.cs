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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (ID.Text != null && Pass.Text != null)
            {
                userController userController = new userController();
                string r = userController.get(ID.Text.ToString(), Pass.Text.ToString());
                switch (r)
                {
                    case "Admin":
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                        break;
                    case "Customer":
                        Flowers flowers = new Flowers();
                        flowers.Show();
                        this.Hide();
                        break;
                    case "Employee":
                        Worker worker = new Worker();
                        worker.Show();
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
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
