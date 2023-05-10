namespace SORA_Project
{
    partial class FormCreateCustomers
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
            groupBoxCustomer = new GroupBox();
            dateTimePickerDOB = new DateTimePicker();
            labelDateOfBirth = new Label();
            panel5 = new Panel();
            textBoxPhoneNum = new TextBox();
            panel3 = new Panel();
            textBoxEmail = new TextBox();
            panel4 = new Panel();
            textBoxLName = new TextBox();
            panel6 = new Panel();
            textBoxConfirmPass = new TextBox();
            panel7 = new Panel();
            textBoxPassword = new TextBox();
            panel2 = new Panel();
            textBoxFName = new TextBox();
            panel8 = new Panel();
            textBoxPIN = new TextBox();
            buttonRegister = new Button();
            groupBoxCustomer.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.BackColor = Color.Transparent;
            groupBoxCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxCustomer.Controls.Add(panel2);
            groupBoxCustomer.Controls.Add(dateTimePickerDOB);
            groupBoxCustomer.Controls.Add(labelDateOfBirth);
            groupBoxCustomer.Controls.Add(panel5);
            groupBoxCustomer.Controls.Add(panel3);
            groupBoxCustomer.Controls.Add(panel4);
            groupBoxCustomer.Controls.Add(panel6);
            groupBoxCustomer.Controls.Add(panel7);
            groupBoxCustomer.Controls.Add(panel8);
            groupBoxCustomer.Location = new Point(14, 15);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(473, 287);
            groupBoxCustomer.TabIndex = 8;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Customer Sign Up";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(106, 242);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(250, 27);
            dateTimePickerDOB.TabIndex = 7;
            dateTimePickerDOB.Value = new DateTime(2023, 4, 26, 0, 0, 0, 0);
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(6, 247);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(94, 20);
            labelDateOfBirth.TabIndex = 8;
            labelDateOfBirth.Text = "Date of Birth";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBoxPhoneNum);
            panel5.Location = new Point(7, 115);
            panel5.Name = "panel5";
            panel5.Size = new Size(215, 34);
            panel5.TabIndex = 6;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.BackColor = Color.White;
            textBoxPhoneNum.BorderStyle = BorderStyle.None;
            textBoxPhoneNum.Location = new Point(3, 7);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.PlaceholderText = "Phone Number";
            textBoxPhoneNum.Size = new Size(207, 20);
            textBoxPhoneNum.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBoxEmail);
            panel3.Location = new Point(7, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 34);
            panel3.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Location = new Point(3, 7);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "email@address";
            textBoxEmail.Size = new Size(207, 20);
            textBoxEmail.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBoxLName);
            panel4.Location = new Point(197, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 34);
            panel4.TabIndex = 2;
            // 
            // textBoxLName
            // 
            textBoxLName.BackColor = Color.White;
            textBoxLName.BorderStyle = BorderStyle.None;
            textBoxLName.Location = new Point(3, 5);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.PlaceholderText = "Last Name";
            textBoxLName.Size = new Size(176, 20);
            textBoxLName.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(textBoxConfirmPass);
            panel6.Location = new Point(197, 161);
            panel6.Name = "panel6";
            panel6.Size = new Size(184, 34);
            panel6.TabIndex = 2;
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.BackColor = Color.White;
            textBoxConfirmPass.BorderStyle = BorderStyle.None;
            textBoxConfirmPass.Location = new Point(3, 7);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.PlaceholderText = "Confirm Password";
            textBoxConfirmPass.Size = new Size(176, 20);
            textBoxConfirmPass.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(textBoxPassword);
            panel7.Location = new Point(6, 161);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 34);
            panel7.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(3, 7);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(176, 20);
            textBoxPassword.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxFName);
            panel2.Location = new Point(6, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 34);
            panel2.TabIndex = 2;
            // 
            // textBoxFName
            // 
            textBoxFName.BackColor = Color.White;
            textBoxFName.BorderStyle = BorderStyle.None;
            textBoxFName.Location = new Point(3, 5);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.PlaceholderText = "First Name";
            textBoxFName.Size = new Size(176, 20);
            textBoxFName.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(textBoxPIN);
            panel8.Location = new Point(7, 201);
            panel8.Name = "panel8";
            panel8.Size = new Size(98, 34);
            panel8.TabIndex = 5;
            // 
            // textBoxPIN
            // 
            textBoxPIN.BackColor = Color.White;
            textBoxPIN.BorderStyle = BorderStyle.None;
            textBoxPIN.Location = new Point(3, 4);
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.PlaceholderText = "Set PIN";
            textBoxPIN.Size = new Size(90, 20);
            textBoxPIN.TabIndex = 0;
            // 
            // buttonRegister
            // 
            buttonRegister.BackgroundImage = Properties.Resources.ButtonG;
            buttonRegister.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(359, 308);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(128, 51);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "REGISTER";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // FormCreateCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(563, 371);
            Controls.Add(groupBoxCustomer);
            Controls.Add(buttonRegister);
            Name = "FormCreateCustomers";
            Text = "FormCreateCustomers";
            Load += FormCreateCustomers_Load;
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCustomer;
        private Label labelDateOfBirth;
        private DateTimePicker dateTimePickerDOB;
        private Panel panel5;
        private TextBox textBoxPhoneNum;
        private Panel panel3;
        private TextBox textBoxEmail;
        private Panel panel4;
        private TextBox textBoxLName;
        private Panel panel6;
        private TextBox textBoxConfirmPass;
        private Panel panel7;
        private TextBox textBoxPassword;
        private Panel panel2;
        private TextBox textBoxFName;
        private Button buttonRegister;
        private Panel panel8;
        private TextBox textBoxPIN;
    }
}