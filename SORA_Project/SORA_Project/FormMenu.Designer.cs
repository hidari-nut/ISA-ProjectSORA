namespace SORA_Project
{
    partial class FormMenu
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
            buttonAccount = new Button();
            buttonTransfer = new Button();
            buttonTopup = new Button();
            buttonHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = Properties.Resources.Logo_2;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(179, 13);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(562, 247);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonAccount
            // 
            buttonAccount.BackgroundImage = Properties.Resources.Buttons_Account;
            buttonAccount.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAccount.ForeColor = Color.White;
            buttonAccount.Location = new Point(38, 324);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(174, 108);
            buttonAccount.TabIndex = 4;
            buttonAccount.UseVisualStyleBackColor = true;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // buttonTransfer
            // 
            buttonTransfer.BackgroundImage = Properties.Resources.Buttons_Transfer;
            buttonTransfer.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTransfer.FlatStyle = FlatStyle.Flat;
            buttonTransfer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTransfer.ForeColor = Color.White;
            buttonTransfer.Location = new Point(256, 324);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(174, 108);
            buttonTransfer.TabIndex = 5;
            buttonTransfer.UseVisualStyleBackColor = true;
            buttonTransfer.Click += buttonTransfer_Click;
            // 
            // buttonTopup
            // 
            buttonTopup.BackgroundImage = Properties.Resources.Buttons_Top_Up;
            buttonTopup.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTopup.FlatStyle = FlatStyle.Flat;
            buttonTopup.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTopup.ForeColor = Color.White;
            buttonTopup.Location = new Point(469, 324);
            buttonTopup.Name = "buttonTopup";
            buttonTopup.Size = new Size(174, 108);
            buttonTopup.TabIndex = 6;
            buttonTopup.UseVisualStyleBackColor = true;
            buttonTopup.Click += buttonTopup_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.BackgroundImage = Properties.Resources.Buttons_History;
            buttonHistory.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHistory.ForeColor = Color.White;
            buttonHistory.Location = new Point(687, 324);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(174, 108);
            buttonHistory.TabIndex = 7;
            buttonHistory.UseVisualStyleBackColor = true;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonHistory);
            Controls.Add(buttonTopup);
            Controls.Add(buttonTransfer);
            Controls.Add(buttonAccount);
            Controls.Add(pictureBoxLogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxLogo;
        private Button buttonAccount;
        private Button buttonTransfer;
        private Button buttonTopup;
        private Button buttonHistory;
    }
}