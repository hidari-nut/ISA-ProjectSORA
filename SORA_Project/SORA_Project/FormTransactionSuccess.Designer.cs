namespace SORA_Project
{
    partial class FormTransactionSuccess
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
            label2 = new Label();
            buttonReturn = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(77, 77);
            label1.Name = "label1";
            label1.Size = new Size(261, 46);
            label1.TabIndex = 17;
            label1.Text = "TRANSACTION";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(127, 131);
            label2.Name = "label2";
            label2.Size = new Size(161, 46);
            label2.TabIndex = 18;
            label2.Text = "SUCCESS";
            // 
            // buttonReturn
            // 
            buttonReturn.BackgroundImage = Properties.Resources.ButtonC;
            buttonReturn.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReturn.FlatStyle = FlatStyle.Flat;
            buttonReturn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReturn.ForeColor = Color.White;
            buttonReturn.Location = new Point(154, 197);
            buttonReturn.Margin = new Padding(3, 4, 3, 4);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(95, 38);
            buttonReturn.TabIndex = 31;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.Logo_SORA1;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(191, 13);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(33, 44);
            pictureBoxLogo.TabIndex = 32;
            pictureBoxLogo.TabStop = false;
            // 
            // FormTransactionSuccess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.BG_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(411, 261);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonReturn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTransactionSuccess";
            Text = "FormTransactionSuccess";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label2;
        private Button buttonReturn;
        private PictureBox pictureBoxLogo;
    }
}