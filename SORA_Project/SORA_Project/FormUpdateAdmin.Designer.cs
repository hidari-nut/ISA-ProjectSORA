﻿namespace SORA_Project
{
    partial class FormUpdateAdmin
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonG;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(357, 373);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(128, 50);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "SAVE";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Province";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Country";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Surabaya"});
            this.comboBoxCity.Location = new System.Drawing.Point(264, 226);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(116, 28);
            this.comboBoxCity.TabIndex = 13;
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(134, 226);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(116, 28);
            this.comboBoxProvince.TabIndex = 12;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(6, 226);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(116, 28);
            this.comboBoxCountry.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.textBoxAddress);
            this.panel8.Location = new System.Drawing.Point(6, 267);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(374, 65);
            this.panel8.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.White;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Location = new System.Drawing.Point(3, 7);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PlaceholderText = "Address";
            this.textBoxAddress.Size = new System.Drawing.Size(366, 53);
            this.textBoxAddress.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "First Name";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBoxPhoneNum);
            this.panel5.Location = new System.Drawing.Point(7, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 34);
            this.panel5.TabIndex = 6;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.BackColor = System.Drawing.Color.White;
            this.textBoxPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneNum.Location = new System.Drawing.Point(3, 7);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.PlaceholderText = "Phone Number";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(207, 20);
            this.textBoxPhoneNum.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 34);
            this.panel2.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Location = new System.Drawing.Point(3, 7);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.Size = new System.Drawing.Size(176, 20);
            this.textBoxPassword.TabIndex = 0;
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.BackColor = System.Drawing.Color.White;
            this.textBoxConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmPass.Location = new System.Drawing.Point(3, 7);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.PlaceholderText = "Confirm Password";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(176, 20);
            this.textBoxConfirmPass.TabIndex = 0;
            // 
            // textBoxLName
            // 
            this.textBoxLName.BackColor = System.Drawing.Color.White;
            this.textBoxLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLName.Location = new System.Drawing.Point(3, 6);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.PlaceholderText = "Last Name";
            this.textBoxLName.Size = new System.Drawing.Size(176, 20);
            this.textBoxLName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxEmail);
            this.panel3.Location = new System.Drawing.Point(7, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 34);
            this.panel3.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Location = new System.Drawing.Point(3, 7);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "email@address";
            this.textBoxEmail.Size = new System.Drawing.Size(207, 20);
            this.textBoxEmail.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBoxConfirmPass);
            this.panel6.Location = new System.Drawing.Point(196, 161);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 34);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.textBoxPassword);
            this.panel7.Location = new System.Drawing.Point(6, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(184, 34);
            this.panel7.TabIndex = 4;
            // 
            // textBoxFName
            // 
            this.textBoxFName.BackColor = System.Drawing.Color.White;
            this.textBoxFName.Location = new System.Drawing.Point(0, 5);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(179, 27);
            this.textBoxFName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxFName);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 34);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxLName);
            this.panel4.Location = new System.Drawing.Point(196, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 34);
            this.panel4.TabIndex = 2;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxCustomer.Controls.Add(this.label3);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Controls.Add(this.label1);
            this.groupBoxCustomer.Controls.Add(this.comboBoxCity);
            this.groupBoxCustomer.Controls.Add(this.comboBoxProvince);
            this.groupBoxCustomer.Controls.Add(this.comboBoxCountry);
            this.groupBoxCustomer.Controls.Add(this.panel8);
            this.groupBoxCustomer.Controls.Add(this.panel5);
            this.groupBoxCustomer.Controls.Add(this.panel3);
            this.groupBoxCustomer.Controls.Add(this.panel4);
            this.groupBoxCustomer.Controls.Add(this.panel6);
            this.groupBoxCustomer.Controls.Add(this.panel7);
            this.groupBoxCustomer.Controls.Add(this.panel1);
            this.groupBoxCustomer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(473, 355);
            this.groupBoxCustomer.TabIndex = 10;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Account Update";
            // 
            // FormUpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SORA_Project.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 432);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.groupBoxCustomer);
            this.Name = "FormUpdateAdmin";
            this.Text = "FormUpdateAdmin";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonRegister;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxProvince;
        private ComboBox comboBoxCountry;
        private Panel panel8;
        private TextBox textBoxAddress;
        private TextBox textBox1;
        private Panel panel5;
        private TextBox textBoxPhoneNum;
        private Panel panel2;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPass;
        private TextBox textBoxLName;
        private Panel panel3;
        private TextBox textBoxEmail;
        private Panel panel6;
        private Panel panel7;
        private TextBox textBoxFName;
        private Panel panel1;
        private Panel panel4;
        private GroupBox groupBoxCustomer;
    }
}