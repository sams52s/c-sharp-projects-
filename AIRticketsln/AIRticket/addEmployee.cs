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
    public partial class addEmployee : Form
    {
        public string Name, AIUBId, password, mail, Phonenumber, gender, UserType = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        Controller controller = new Controller();
        public addEmployee()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.textBox3.Text.ToString() == this.textBox6.Text.ToString())
                {
                    string er;
                    int flag = 0;
                    
                    if (this.textBox2.Text != null)
                    {
                        AIUBId = this.textBox2.Text.ToString();
                        if (AIUBId.Length != 15) { AIUBId = ""; MessageBox.Show("You have to give NID ID"); flag = 1; }
                    }
                    else
                    {
                        MessageBox.Show("You have to give AIUB ID");
                        flag = 1;
                    }
                    if (this.textBox1.Text != null) { Name = this.textBox1.Text.ToString(); }
                    else
                    {
                        MessageBox.Show("You have to give Your Name");
                        flag = 1;
                    }
                    if (this.textBox3.Text != null) { password = this.textBox3.Text.ToString(); }
                    else
                    {
                        MessageBox.Show("You have to give a valide password");
                        flag = 1;
                    }
                    if (this.textBox4.Text != null)
                    {
                        mail = this.textBox4.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("You have to give a valide mail ID");
                        flag = 1;
                    }
                    if (this.textBox5.Text != null)
                    {
                        Phonenumber = this.textBox5.Text.ToString();
                        if (Phonenumber.Length != 11) { Phonenumber = ""; flag = 1; }
                    }
                    else
                    {
                        MessageBox.Show("You have to give a valide Phonenumber ");
                        flag = 1;
                    }
                    if (Male.Checked) { gender = "Male"; }
                    else if (Female.Checked) { gender = "Female"; }
                    else { gender = "Other"; }
                    if (this.comboBox2.SelectedItem.ToString() == null)
                    {
                        MessageBox.Show("You did not select any User Type ");
                        flag = 1;
                    }
                    else { UserType = this.comboBox2.SelectedItem.ToString(); }
                    if (flag != 1)
                    {
                        er = controller.create(AIUBId, Name, password, mail, Phonenumber, gender, UserType);
                        MessageBox.Show(er);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Confirm password and password ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
