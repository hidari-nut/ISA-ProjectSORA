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
            this.pictureBoxLogo.Location = new System.Drawing.Point(157, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(492, 185);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;

            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(161, 26);
            adminToolStripMenuItem.Text = "Admin";
            // 

            // buttonAccount
            // 
            this.buttonAccount.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_Account;
            this.buttonAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Location = new System.Drawing.Point(33, 243);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(152, 81);
            this.buttonAccount.TabIndex = 4;
            this.buttonAccount.UseVisualStyleBackColor = true;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_Transfer;
            this.buttonTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTransfer.ForeColor = System.Drawing.Color.White;
            this.buttonTransfer.Location = new System.Drawing.Point(224, 243);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(152, 81);
            this.buttonTransfer.TabIndex = 5;
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // buttonMerchant
            // 
            this.buttonMerchant.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_OA;
            this.buttonMerchant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMerchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMerchant.ForeColor = System.Drawing.Color.White;
            this.buttonMerchant.Location = new System.Drawing.Point(410, 243);
            this.buttonMerchant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMerchant.Name = "buttonMerchant";
            this.buttonMerchant.Size = new System.Drawing.Size(152, 81);
            this.buttonMerchant.TabIndex = 6;
            this.buttonMerchant.UseVisualStyleBackColor = true;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_History;
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(601, 243);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(152, 81);
            this.buttonHistory.TabIndex = 7;
            this.buttonHistory.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonMerchant);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.pictureBoxWave);
            this.Controls.Add(this.pictureBoxLogo);
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