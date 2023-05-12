namespace SORA_Project
{
    partial class FormMenuAdmin
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
            buttonBan = new Button();
            buttonAccount = new Button();
            pictureBoxLogo = new PictureBox();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonBan
            // 
            buttonBan.BackColor = Color.Transparent;
            buttonBan.BackgroundImage = Properties.Resources.Buttons_Ban;
            buttonBan.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBan.FlatStyle = FlatStyle.Flat;
            buttonBan.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBan.ForeColor = Color.White;
            buttonBan.Location = new Point(572, 415);
            buttonBan.Name = "buttonBan";
            buttonBan.Size = new Size(174, 108);
            buttonBan.TabIndex = 10;
            buttonBan.UseVisualStyleBackColor = false;
            buttonBan.Click += buttonBan_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.BackColor = Color.Transparent;
            buttonAccount.BackgroundImage = Properties.Resources.Buttons_Account;
            buttonAccount.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAccount.ForeColor = Color.White;
            buttonAccount.Location = new Point(184, 415);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(174, 108);
            buttonAccount.TabIndex = 9;
            buttonAccount.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.Logo_2;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(197, 53);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(562, 247);
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(12, 316);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(890, 49);
            textBoxName.TabIndex = 11;
            textBoxName.Text = "Welcome admin Who! : who@adminSORA.id";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // FormMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.BG_4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(textBoxName);
            Controls.Add(buttonBan);
            Controls.Add(buttonAccount);
            Controls.Add(pictureBoxLogo);
            DoubleBuffered = true;
            ForeColor = SystemColors.Desktop;
            Name = "FormMenuAdmin";
            Text = "FormMenuAdmin";
            Load += FormMenuAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonBan;
        private Button buttonAccount;
        private PictureBox pictureBoxLogo;
        private TextBox textBoxName;
    }
}