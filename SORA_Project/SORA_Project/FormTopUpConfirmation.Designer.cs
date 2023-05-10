namespace SORA_Project
{
    partial class FormTopUpConfirmation
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
            buttonConfirm = new Button();
            textBoxMethod = new TextBox();
            textBoxAmount = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackgroundImage = Properties.Resources.ButtonC;
            buttonConfirm.BackgroundImageLayout = ImageLayout.Stretch;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(436, 425);
            buttonConfirm.Margin = new Padding(3, 4, 3, 4);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(95, 38);
            buttonConfirm.TabIndex = 45;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxMethod
            // 
            textBoxMethod.BackColor = Color.White;
            textBoxMethod.BorderStyle = BorderStyle.None;
            textBoxMethod.Enabled = false;
            textBoxMethod.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMethod.Location = new Point(228, 342);
            textBoxMethod.Margin = new Padding(3, 4, 3, 4);
            textBoxMethod.MaxLength = 45;
            textBoxMethod.Name = "textBoxMethod";
            textBoxMethod.Size = new Size(303, 25);
            textBoxMethod.TabIndex = 42;
            textBoxMethod.Text = "Cashier";
            textBoxMethod.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = Color.White;
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Enabled = false;
            textBoxAmount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmount.Location = new Point(228, 294);
            textBoxAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxAmount.MaxLength = 45;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(303, 25);
            textBoxAmount.TabIndex = 41;
            textBoxAmount.Text = "Rp 82191892";
            textBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.White;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(228, 246);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.MaxLength = 45;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(303, 25);
            textBoxName.TabIndex = 40;
            textBoxName.Text = "darekasan";
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(228, 198);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.MaxLength = 45;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(303, 25);
            textBoxEmail.TabIndex = 39;
            textBoxEmail.Text = "C-69420";
            textBoxEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(38, 338);
            label5.Name = "label5";
            label5.Size = new Size(197, 30);
            label5.TabIndex = 36;
            label5.Text = "Payment method:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 290);
            label4.Name = "label4";
            label4.Size = new Size(176, 30);
            label4.TabIndex = 35;
            label4.Text = "Top up amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 242);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 34;
            label3.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 194);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 33;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 128);
            label1.Name = "label1";
            label1.Size = new Size(234, 46);
            label1.TabIndex = 32;
            label1.Text = "Confirmation";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo_2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(153, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 103);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // buttonReturn
            // 
            buttonReturn.BackgroundImage = Properties.Resources.ButtonF;
            buttonReturn.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReturn.FlatStyle = FlatStyle.Flat;
            buttonReturn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReturn.ForeColor = Color.Black;
            buttonReturn.Location = new Point(29, 425);
            buttonReturn.Margin = new Padding(3, 4, 3, 4);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(95, 38);
            buttonReturn.TabIndex = 46;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // FormTopUpConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(569, 495);
            Controls.Add(buttonReturn);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxMethod);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormTopUpConfirmation";
            Text = "FormTopUpConfirmation";
            Load += FormTopUpConfirmation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private TextBox textBoxMethod;
        private TextBox textBoxAmount;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonReturn;
    }
}