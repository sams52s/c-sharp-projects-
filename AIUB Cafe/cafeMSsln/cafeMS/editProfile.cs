using DEL.Entity;
using DEL.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeMS
{
    public partial class editProfile : Form
    {
        public editProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            viewProfile viewProfile = new viewProfile();
            this.Close();
            viewProfile.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewProfile viewProfile = new viewProfile();
            EntityUsers entityUsers = new EntityUsers();
            OperationInsertion operationInsertion = new OperationInsertion();


                entityUsers.name = Convert.ToString(textBox1.Text);
                entityUsers.password = Convert.ToString(textBox2.Text);
                entityUsers.email = Convert.ToString(textBox3.Text);
                entityUsers.phone = Convert.ToString(textBox4.Text);
                entityUsers.usertype = "user";
                bool flag = operationInsertion.insert(entityUsers);
                if (flag == true) { MessageBox.Show("Update Succesfull"); }
                else { MessageBox.Show("Update failed"); }


                this.Close();
                viewProfile.Show();
            


        }
    }
}
