
namespace OTR.Views
{
    partial class UserRegisteredForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cMCity = new System.Windows.Forms.ComboBox();
            this.cMAge = new System.Windows.Forms.ComboBox();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.tBPhone = new System.Windows.Forms.TextBox();
            this.tBMail = new System.Windows.Forms.TextBox();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Registered = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cMGender = new System.Windows.Forms.ComboBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoginpage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Informations :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cMCity
            // 
            this.cMCity.FormattingEnabled = true;
            this.cMCity.Items.AddRange(new object[] {
            "Dhaka",
            "Khulna",
            "Rajshahi",
            "Cumilla",
            "Dinajpur",
            "Chittogram"});
            this.cMCity.Location = new System.Drawing.Point(123, 210);
            this.cMCity.Name = "cMCity";
            this.cMCity.Size = new System.Drawing.Size(121, 26);
            this.cMCity.TabIndex = 5;
            // 
            // cMAge
            // 
            this.cMAge.FormattingEnabled = true;
            this.cMAge.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.cMAge.Location = new System.Drawing.Point(123, 178);
            this.cMAge.Name = "cMAge";
            this.cMAge.Size = new System.Drawing.Size(121, 26);
            this.cMAge.TabIndex = 16;
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(126, 86);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(318, 24);
            this.tBPassword.TabIndex = 3;
            // 
            // tBPhone
            // 
            this.tBPhone.Location = new System.Drawing.Point(123, 242);
            this.tBPhone.Name = "tBPhone";
            this.tBPhone.Size = new System.Drawing.Size(303, 24);
            this.tBPhone.TabIndex = 3;
            // 
            // tBMail
            // 
            this.tBMail.Location = new System.Drawing.Point(123, 118);
            this.tBMail.Name = "tBMail";
            this.tBMail.Size = new System.Drawing.Size(306, 24);
            this.tBMail.TabIndex = 3;
            // 
            // tBUsername
            // 
            this.tBUsername.Location = new System.Drawing.Point(123, 47);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(306, 24);
            this.tBUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gander: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "City : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mail :";
            // 
            // Registered
            // 
            this.Registered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Registered.Location = new System.Drawing.Point(149, 383);
            this.Registered.Name = "Registered";
            this.Registered.Size = new System.Drawing.Size(177, 28);
            this.Registered.TabIndex = 20;
            this.Registered.Text = "Registered";
            this.Registered.UseVisualStyleBackColor = false;
            this.Registered.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cMGender);
            this.groupBox1.Controls.Add(this.tBName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cMCity);
            this.groupBox1.Controls.Add(this.cMAge);
            this.groupBox1.Controls.Add(this.tBPassword);
            this.groupBox1.Controls.Add(this.tBPhone);
            this.groupBox1.Controls.Add(this.tBMail);
            this.groupBox1.Controls.Add(this.tBUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(26, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 289);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // cMGender
            // 
            this.cMGender.FormattingEnabled = true;
            this.cMGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cMGender.Location = new System.Drawing.Point(123, 149);
            this.cMGender.Name = "cMGender";
            this.cMGender.Size = new System.Drawing.Size(121, 26);
            this.cMGender.TabIndex = 19;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(123, 17);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(306, 24);
            this.tBName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name :";
            // 
            // btnLoginpage
            // 
            this.btnLoginpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoginpage.Location = new System.Drawing.Point(332, 383);
            this.btnLoginpage.Name = "btnLoginpage";
            this.btnLoginpage.Size = new System.Drawing.Size(135, 28);
            this.btnLoginpage.TabIndex = 21;
            this.btnLoginpage.Text = "Login Page";
            this.btnLoginpage.UseVisualStyleBackColor = false;
            this.btnLoginpage.Click += new System.EventHandler(this.btnLoginpage_Click);
            // 
            // UserRegisteredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(646, 447);
            this.Controls.Add(this.btnLoginpage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registered);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserRegisteredForm";
            this.Text = "UserRegisteredForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cMCity;
        private System.Windows.Forms.ComboBox cMAge;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.TextBox tBPhone;
        private System.Windows.Forms.TextBox tBMail;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Registered;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cMGender;
        private System.Windows.Forms.Button btnLoginpage;
    }
}