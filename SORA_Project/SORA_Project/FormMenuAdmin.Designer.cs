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
            this.buttonBan = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBan
            // 
            this.buttonBan.BackColor = System.Drawing.Color.Transparent;
            this.buttonBan.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_Ban;
            this.buttonBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBan.ForeColor = System.Drawing.Color.White;
            this.buttonBan.Location = new System.Drawing.Point(572, 415);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(174, 108);
            this.buttonBan.TabIndex = 10;
            this.buttonBan.UseVisualStyleBackColor = false;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccount.BackgroundImage = global::SORA_Project.Properties.Resources.Buttons_Account;
            this.buttonAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Location = new System.Drawing.Point(184, 415);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(174, 108);
            this.buttonAccount.TabIndex = 9;
            this.buttonAccount.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::SORA_Project.Properties.Resources.Logo_2;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(197, 53);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(562, 247);
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(12, 316);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(890, 49);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.Text = "Welcome admin Who! : who@adminSORA.id";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SORA_Project.Properties.Resources.BG_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonBan);
            this.Controls.Add(this.buttonAccount);
            this.Controls.Add(this.pictureBoxLogo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FormMenuAdmin";
            this.Text = "FormMenuAdmin";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonBan;
        private Button buttonAccount;
        private PictureBox pictureBoxLogo;
        private TextBox textBoxName;
    }
}