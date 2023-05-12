namespace SORA_Project
{
    partial class FormCreateAdmin
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
            buttonRegister = new Button();
            textBoxFirstName = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            textBoxFName = new TextBox();
            textBoxPassword = new TextBox();
            panel7 = new Panel();
            textBoxConfirmPass = new TextBox();
            panel6 = new Panel();
            textBoxLName = new TextBox();
            panel4 = new Panel();
            textBoxEmail = new TextBox();
            panel3 = new Panel();
            textBoxPhoneNum = new TextBox();
            labelDateOfBirth = new Label();
            dateTimePickerDOB = new DateTimePicker();
            panel5 = new Panel();
            groupBoxCustomer = new GroupBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            groupBoxCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.BackgroundImage = Properties.Resources.ButtonG;
            buttonRegister.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(359, 273);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(128, 51);
            buttonRegister.TabIndex = 11;
            buttonRegister.Text = "REGISTER";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.White;
            textBoxFirstName.BorderStyle = BorderStyle.None;
            textBoxFirstName.Location = new Point(3, 5);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First Name";
            textBoxFirstName.Size = new Size(176, 20);
            textBoxFirstName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxFirstName);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 34);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxFName);
            panel1.Location = new Point(6, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 34);
            panel1.TabIndex = 1;
            // 
            // textBoxFName
            // 
            textBoxFName.BackColor = Color.White;
            textBoxFName.Location = new Point(0, 5);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(179, 27);
            textBoxFName.TabIndex = 0;
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
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(textBoxPassword);
            panel7.Location = new Point(6, 161);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 34);
            panel7.TabIndex = 4;
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
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(textBoxConfirmPass);
            panel6.Location = new Point(197, 161);
            panel6.Name = "panel6";
            panel6.Size = new Size(184, 34);
            panel6.TabIndex = 2;
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
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBoxLName);
            panel4.Location = new Point(197, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 34);
            panel4.TabIndex = 2;
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBoxEmail);
            panel3.Location = new Point(7, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 34);
            panel3.TabIndex = 5;
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
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(10, 203);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(94, 20);
            labelDateOfBirth.TabIndex = 8;
            labelDateOfBirth.Text = "Date of Birth";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(110, 201);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(250, 27);
            dateTimePickerDOB.TabIndex = 7;
            dateTimePickerDOB.Value = new DateTime(2023, 4, 26, 0, 0, 0, 0);
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
            // groupBoxCustomer
            // 
            groupBoxCustomer.BackColor = Color.Transparent;
            groupBoxCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxCustomer.Controls.Add(labelDateOfBirth);
            groupBoxCustomer.Controls.Add(dateTimePickerDOB);
            groupBoxCustomer.Controls.Add(panel5);
            groupBoxCustomer.Controls.Add(panel3);
            groupBoxCustomer.Controls.Add(panel4);
            groupBoxCustomer.Controls.Add(panel6);
            groupBoxCustomer.Controls.Add(panel7);
            groupBoxCustomer.Controls.Add(panel1);
            groupBoxCustomer.Location = new Point(14, 15);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(473, 253);
            groupBoxCustomer.TabIndex = 10;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Customer Sign Up";
            // 
            // FormCreateAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(563, 340);
            Controls.Add(buttonRegister);
            Controls.Add(groupBoxCustomer);
            Name = "FormCreateAdmin";
            Text = "FormCreateAdmin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegister;
        private TextBox textBoxFirstName;
        private Panel panel2;
        private Panel panel1;
        private TextBox textBoxFName;
        private TextBox textBoxPassword;
        private Panel panel7;
        private TextBox textBoxConfirmPass;
        private Panel panel6;
        private TextBox textBoxLName;
        private Panel panel4;
        private TextBox textBoxEmail;
        private Panel panel3;
        private TextBox textBoxPhoneNum;
        private Label labelDateOfBirth;
        private DateTimePicker dateTimePickerDOB;
        private Panel panel5;
        private GroupBox groupBoxCustomer;
    }
}