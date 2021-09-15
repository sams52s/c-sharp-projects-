using logicl_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIUB_Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if(ID.Text!=null && Pass.Text !=null)
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
                        ViewItem viewItem = new ViewItem();
                        viewItem.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show(r);
                        break;
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
