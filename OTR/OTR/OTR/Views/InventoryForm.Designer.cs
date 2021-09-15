
namespace OTR.Views
{
    partial class InventoryForm
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
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBQuantity = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tBProductPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrid
            // 
            this.dGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Location = new System.Drawing.Point(12, 53);
            this.dGrid.Name = "dGrid";
            this.dGrid.Size = new System.Drawing.Size(458, 274);
            this.dGrid.TabIndex = 19;
            this.dGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Inventory Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(476, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Product Name : ";
            // 
            // tBProductName
            // 
            this.tBProductName.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tBProductName.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBProductName.ForeColor = System.Drawing.SystemColors.Info;
            this.tBProductName.Location = new System.Drawing.Point(644, 76);
            this.tBProductName.MaxLength = 100;
            this.tBProductName.Name = "tBProductName";
            this.tBProductName.Size = new System.Drawing.Size(265, 31);
            this.tBProductName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(492, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Quentity : ";
            // 
            // tBQuantity
            // 
            this.tBQuantity.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tBQuantity.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBQuantity.ForeColor = System.Drawing.SystemColors.Info;
            this.tBQuantity.Location = new System.Drawing.Point(644, 184);
            this.tBQuantity.MaxLength = 100;
            this.tBQuantity.Name = "tBQuantity";
            this.tBQuantity.Size = new System.Drawing.Size(265, 31);
            this.tBQuantity.TabIndex = 24;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(737, 295);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(172, 32);
            this.btnSignIn.TabIndex = 23;
            this.btnSignIn.Text = "Add To Inventory";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(488, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Product Price :";
            // 
            // tBProductPrice
            // 
            this.tBProductPrice.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tBProductPrice.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBProductPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.tBProductPrice.Location = new System.Drawing.Point(644, 132);
            this.tBProductPrice.MaxLength = 100;
            this.tBProductPrice.Name = "tBProductPrice";
            this.tBProductPrice.Size = new System.Drawing.Size(265, 31);
            this.tBProductPrice.TabIndex = 21;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBQuantity);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBProductPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGrid);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBQuantity;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBProductPrice;
    }
}