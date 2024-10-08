﻿namespace AddressBookFiles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbxName = new ComboBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lbxAddress = new ListBox();
            btnNewAddress = new Button();
            btnDeleteAddress = new Button();
            btnEdit = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbxName
            // 
            cbxName.FormattingEnabled = true;
            cbxName.Location = new Point(3, 23);
            cbxName.Name = "cbxName";
            cbxName.Size = new Size(207, 23);
            cbxName.TabIndex = 0;
            cbxName.SelectedIndexChanged += cbxName_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(2, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(2, 170);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(208, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(2, 121);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(208, 23);
            txtPhone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 51);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 152);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 103);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(cbxName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPhone);
            panel1.Location = new Point(13, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 210);
            panel1.TabIndex = 8;
            // 
            // lbxAddress
            // 
            lbxAddress.FormattingEnabled = true;
            lbxAddress.ItemHeight = 15;
            lbxAddress.Location = new Point(249, 31);
            lbxAddress.Name = "lbxAddress";
            lbxAddress.Size = new Size(267, 214);
            lbxAddress.TabIndex = 9;
            // 
            // btnNewAddress
            // 
            btnNewAddress.Location = new Point(16, 255);
            btnNewAddress.Name = "btnNewAddress";
            btnNewAddress.Size = new Size(109, 23);
            btnNewAddress.TabIndex = 10;
            btnNewAddress.Text = "Add new Address";
            btnNewAddress.UseVisualStyleBackColor = true;
            btnNewAddress.Click += btnNewAddress_Click;
            // 
            // btnDeleteAddress
            // 
            btnDeleteAddress.Location = new Point(131, 255);
            btnDeleteAddress.Name = "btnDeleteAddress";
            btnDeleteAddress.Size = new Size(112, 23);
            btnDeleteAddress.TabIndex = 11;
            btnDeleteAddress.Text = "Delete Address";
            btnDeleteAddress.UseVisualStyleBackColor = true;
            btnDeleteAddress.Click += btnDeleteAddress_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(249, 255);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit Entry";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(15, 3);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 13;
            label4.Text = "Address Book";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(523, 285);
            Controls.Add(label4);
            Controls.Add(btnEdit);
            Controls.Add(btnDeleteAddress);
            Controls.Add(btnNewAddress);
            Controls.Add(lbxAddress);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxName;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private ListBox lbxAddress;
        private Button btnNewAddress;
        private Button btnDeleteAddress;
        private Button btnEdit;
        private Label label4;
    }
}
