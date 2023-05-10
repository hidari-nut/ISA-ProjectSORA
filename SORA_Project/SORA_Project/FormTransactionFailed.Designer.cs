namespace SORA_Project
{
    partial class FormTransactionFailed
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
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBoxLogo = new PictureBox();
            buttonReturn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(75, 83);
            label1.Name = "label1";
            label1.Size = new Size(261, 46);
            label1.TabIndex = 33;
            label1.Text = "TRANSACTION";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.Logo_SORA1;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(189, 19);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(33, 44);
            pictureBoxLogo.TabIndex = 36;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonReturn
            // 
            buttonReturn.BackgroundImage = Properties.Resources.ButtonC;
            buttonReturn.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReturn.FlatStyle = FlatStyle.Flat;
            buttonReturn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReturn.ForeColor = Color.White;
            buttonReturn.Location = new Point(152, 203);
            buttonReturn.Margin = new Padding(3, 4, 3, 4);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(95, 38);
            buttonReturn.TabIndex = 35;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(135, 129);
            label2.Name = "label2";
            label2.Size = new Size(131, 46);
            label2.TabIndex = 34;
            label2.Text = "FAILED";
            // 
            // FormTransactionFailed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(411, 261);
            Controls.Add(label1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonReturn);
            Controls.Add(label2);
            Name = "FormTransactionFailed";
            Text = "FormTransactionFailed";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBoxLogo;
        private Button buttonReturn;
        private Label label2;
    }
}