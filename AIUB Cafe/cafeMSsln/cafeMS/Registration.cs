using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEL.Entity;
using DEL.Operation;

namespace cafeMS
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewProfile viewProfile = new viewProfile();
            EntityUsers entityUsers = new EntityUsers();
            OperationInsertion operationInsertion = new OperationInsertion();

            if(Convert.ToString(textBox2.Text)== Convert.ToString(textBox3.Text))
            {
                entityUsers.name = Convert.ToString(textBox1.Text);
                entityUsers.password = Convert.ToString(textBox2.Text);
                entityUsers.email = Convert.ToString(textBox3.Text);
                entityUsers.phone = Convert.ToString(textBox4.Text);
                if (radioButton1.Checked) {entityUsers.gender = "Male";}
                if (radioButton2.Checked) { entityUsers.gender = "Female"; }
                if (radioButton3.Checked) { entityUsers.gender = "Other"; }
                entityUsers.usertype = "admin";
                bool flag= operationInsertion.insert(entityUsers);
                if (flag == true) { MessageBox.Show("Registration Succesfull"); }
                else { MessageBox.Show("Registration failed"); }


                this.Close();
                viewProfile.Show();
            }
            else
            {
                MessageBox.Show("Password and Confirm Password did not matched");
            }


            
            
        }
    }
}
