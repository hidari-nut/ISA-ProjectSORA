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
            buttonMerchant = new Button();
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
            // buttonMerchant
            // 
            buttonMerchant.BackgroundImage = Properties.Resources.Buttons_OA;
            buttonMerchant.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMerchant.FlatStyle = FlatStyle.Flat;
            buttonMerchant.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMerchant.ForeColor = Color.White;
            buttonMerchant.Location = new Point(469, 324);
            buttonMerchant.Name = "buttonMerchant";
            buttonMerchant.Size = new Size(174, 108);
            buttonMerchant.TabIndex = 6;
            buttonMerchant.UseVisualStyleBackColor = true;
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
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonHistory);
            Controls.Add(buttonMerchant);
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
        private Button buttonMerchant;
        private Button buttonHistory;
    }
}