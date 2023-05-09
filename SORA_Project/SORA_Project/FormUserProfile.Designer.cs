namespace SORA_Project
{
    partial class FormUserProfile
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
            pictureBox1 = new PictureBox();
            textBoxAccountDate = new TextBox();
            textBoxDoB = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo_2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(141, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxAccountDate
            // 
            textBoxAccountDate.BackColor = Color.White;
            textBoxAccountDate.BorderStyle = BorderStyle.None;
            textBoxAccountDate.Enabled = false;
            textBoxAccountDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccountDate.Location = new Point(216, 459);
            textBoxAccountDate.Margin = new Padding(3, 4, 3, 4);
            textBoxAccountDate.Name = "textBoxAccountDate";
            textBoxAccountDate.Size = new Size(303, 25);
            textBoxAccountDate.TabIndex = 13;
            textBoxAccountDate.Text = "01/01/2022";
            textBoxAccountDate.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxDoB
            // 
            textBoxDoB.BackColor = Color.White;
            textBoxDoB.BorderStyle = BorderStyle.None;
            textBoxDoB.Enabled = false;
            textBoxDoB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDoB.Location = new Point(216, 411);
            textBoxDoB.Margin = new Padding(3, 4, 3, 4);
            textBoxDoB.Name = "textBoxDoB";
            textBoxDoB.Size = new Size(303, 25);
            textBoxDoB.TabIndex = 12;
            textBoxDoB.Text = "01/01/2000";
            textBoxDoB.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.White;
            textBoxPhone.BorderStyle = BorderStyle.None;
            textBoxPhone.Enabled = false;
            textBoxPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(216, 363);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.MaxLength = 45;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(303, 25);
            textBoxPhone.TabIndex = 11;
            textBoxPhone.Text = "081916129294";
            textBoxPhone.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(216, 315);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.MaxLength = 45;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(303, 25);
            textBoxEmail.TabIndex = 10;
            textBoxEmail.Text = "darekasan@gmail.com";
            textBoxEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.White;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(216, 267);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.MaxLength = 45;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(303, 25);
            textBoxName.TabIndex = 9;
            textBoxName.Text = "darekasan";
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.White;
            textBoxID.BorderStyle = BorderStyle.None;
            textBoxID.Enabled = false;
            textBoxID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxID.Location = new Point(216, 219);
            textBoxID.Margin = new Padding(3, 4, 3, 4);
            textBoxID.MaxLength = 45;
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(303, 25);
            textBoxID.TabIndex = 8;
            textBoxID.Text = "C-69420";
            textBoxID.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 455);
            label7.Name = "label7";
            label7.Size = new Size(116, 30);
            label7.TabIndex = 7;
            label7.Text = "Made on :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 407);
            label6.Name = "label6";
            label6.Size = new Size(159, 30);
            label6.TabIndex = 6;
            label6.Text = "Date of Birth :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 359);
            label5.Name = "label5";
            label5.Size = new Size(181, 30);
            label5.TabIndex = 5;
            label5.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 311);
            label4.Name = "label4";
            label4.Size = new Size(174, 30);
            label4.TabIndex = 4;
            label4.Text = "E-mail Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 263);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 3;
            label3.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 215);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 2;
            label2.Text = "ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 159);
            label1.Name = "label1";
            label1.Size = new Size(207, 46);
            label1.TabIndex = 1;
            label1.Text = "User Profile";
            // 
            // buttonReturn
            // 
            buttonReturn.BackgroundImage = Properties.Resources.ButtonC;
            buttonReturn.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReturn.FlatStyle = FlatStyle.Flat;
            buttonReturn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReturn.ForeColor = Color.White;
            buttonReturn.Location = new Point(424, 615);
            buttonReturn.Margin = new Padding(3, 4, 3, 4);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(95, 38);
            buttonReturn.TabIndex = 30;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // FormUserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.BG_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 676);
            Controls.Add(buttonReturn);
            Controls.Add(textBoxAccountDate);
            Controls.Add(textBoxDoB);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUserProfile";
            Text = "FormUserProfile";
            Load += FormUserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxAccountDate;
        private TextBox textBoxDoB;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonReturn;
    }
}