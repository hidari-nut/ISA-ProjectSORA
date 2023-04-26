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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxWave = new System.Windows.Forms.PictureBox();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonMerchant = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::SORA_Project.Properties.Resources.Logo_2;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(179, 13);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(562, 247);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxWave
            // 
            this.pictureBoxWave.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWave.BackgroundImage = global::SORA_Project.Properties.Resources.wave1;
            this.pictureBoxWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWave.Location = new System.Drawing.Point(-133, 460);
            this.pictureBoxWave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxWave.Name = "pictureBoxWave";
            this.pictureBoxWave.Size = new System.Drawing.Size(1239, 156);
            this.pictureBoxWave.TabIndex = 2;
            this.pictureBoxWave.TabStop = false;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonG;
            this.buttonAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Location = new System.Drawing.Point(38, 324);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(174, 75);
            this.buttonAccount.TabIndex = 4;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = true;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonG;
            this.buttonTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTransfer.ForeColor = System.Drawing.Color.White;
            this.buttonTransfer.Location = new System.Drawing.Point(256, 324);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(174, 75);
            this.buttonTransfer.TabIndex = 5;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // buttonMerchant
            // 
            this.buttonMerchant.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonG;
            this.buttonMerchant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMerchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMerchant.ForeColor = System.Drawing.Color.White;
            this.buttonMerchant.Location = new System.Drawing.Point(469, 324);
            this.buttonMerchant.Name = "buttonMerchant";
            this.buttonMerchant.Size = new System.Drawing.Size(174, 75);
            this.buttonMerchant.TabIndex = 6;
            this.buttonMerchant.Text = "Merchant";
            this.buttonMerchant.UseVisualStyleBackColor = true;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonG;
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(687, 324);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(174, 75);
            this.buttonHistory.TabIndex = 7;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonMerchant);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.pictureBoxWave);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxWave;
        private Button buttonAccount;
        private Button buttonTransfer;
        private Button buttonMerchant;
        private Button buttonHistory;
    }
}