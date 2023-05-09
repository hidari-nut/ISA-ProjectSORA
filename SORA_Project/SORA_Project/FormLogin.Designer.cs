namespace SORA_Project
{
    partial class FormLogin
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
            pictureBoxLogo = new PictureBox();
            labelLogin = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogIn = new Button();
            label1 = new Label();
            buttonSignUp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.Logo_SORA1;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(163, 47);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(33, 44);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.Location = new Point(127, 109);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(121, 36);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "LOG IN";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(27, 177);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "E-mail";
            textBoxUsername.Size = new Size(311, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(27, 235);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(311, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.White;
            buttonLogIn.BackgroundImage = Properties.Resources.ButtonC;
            buttonLogIn.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.ForeColor = SystemColors.ButtonHighlight;
            buttonLogIn.Location = new Point(137, 311);
            buttonLogIn.Margin = new Padding(3, 4, 3, 4);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(86, 31);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(105, 345);
            label1.Name = "label1";
            label1.Size = new Size(167, 18);
            label1.TabIndex = 5;
            label1.Text = "--------------or---------------";
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.White;
            buttonSignUp.BackgroundImage = Properties.Resources.ButtonF;
            buttonSignUp.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSignUp.FlatAppearance.BorderSize = 0;
            buttonSignUp.FlatStyle = FlatStyle.Flat;
            buttonSignUp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.ForeColor = SystemColors.ControlText;
            buttonSignUp.Location = new Point(137, 369);
            buttonSignUp.Margin = new Padding(3, 4, 3, 4);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(86, 31);
            buttonSignUp.TabIndex = 6;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(375, 427);
            Controls.Add(buttonSignUp);
            Controls.Add(label1);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelLogin);
            Controls.Add(pictureBoxLogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelLogin;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogIn;
        private Label label1;
        private Button buttonSignUp;
    }
}