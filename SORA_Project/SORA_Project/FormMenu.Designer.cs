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
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonTopup = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
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
            // buttonAccount
            // 
            this.buttonAccount.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_Account;
            this.buttonAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Location = new System.Drawing.Point(38, 324);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(174, 108);
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
            this.buttonTransfer.Location = new System.Drawing.Point(256, 324);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(174, 108);
            this.buttonTransfer.TabIndex = 5;
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // buttonTopup
            // 
            this.buttonTopup.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_Top_Up;
            this.buttonTopup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTopup.ForeColor = System.Drawing.Color.White;
            this.buttonTopup.Location = new System.Drawing.Point(469, 324);
            this.buttonTopup.Name = "buttonTopup";
            this.buttonTopup.Size = new System.Drawing.Size(174, 108);
            this.buttonTopup.TabIndex = 6;
            this.buttonTopup.UseVisualStyleBackColor = true;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_History;
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(687, 324);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(174, 108);
            this.buttonHistory.TabIndex = 7;
            this.buttonHistory.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SORA_Project.Properties.Resources.BG_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonTopup);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBoxLogo;
        private Button buttonAccount;
        private Button buttonTransfer;
        private Button buttonTopup;
        private Button buttonHistory;
    }
}