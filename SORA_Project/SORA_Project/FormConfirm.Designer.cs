namespace SORA_Project
{
    partial class FormConfirm
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
            buttonReturn = new Button();
            textBoxNominal = new TextBox();
            textBoxRecepient = new TextBox();
            textBoxSender = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.BackColor = Color.Transparent;
            buttonReturn.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReturn.FlatStyle = FlatStyle.Flat;
            buttonReturn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReturn.ForeColor = Color.Black;
            buttonReturn.Location = new Point(27, 397);
            buttonReturn.Margin = new Padding(3, 4, 3, 4);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(95, 38);
            buttonReturn.TabIndex = 29;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = false;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // textBoxNominal
            // 
            textBoxNominal.BackColor = Color.White;
            textBoxNominal.BorderStyle = BorderStyle.None;
            textBoxNominal.Enabled = false;
            textBoxNominal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNominal.Location = new Point(217, 322);
            textBoxNominal.Margin = new Padding(3, 4, 3, 4);
            textBoxNominal.MaxLength = 45;
            textBoxNominal.Name = "textBoxNominal";
            textBoxNominal.Size = new Size(303, 25);
            textBoxNominal.TabIndex = 25;
            textBoxNominal.Text = "000000";
            textBoxNominal.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxRecepient
            // 
            textBoxRecepient.BackColor = Color.White;
            textBoxRecepient.BorderStyle = BorderStyle.None;
            textBoxRecepient.Enabled = false;
            textBoxRecepient.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRecepient.Location = new Point(217, 274);
            textBoxRecepient.Margin = new Padding(3, 4, 3, 4);
            textBoxRecepient.MaxLength = 45;
            textBoxRecepient.Name = "textBoxRecepient";
            textBoxRecepient.Size = new Size(303, 25);
            textBoxRecepient.TabIndex = 24;
            textBoxRecepient.Text = "who";
            textBoxRecepient.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxSender
            // 
            textBoxSender.BackColor = Color.White;
            textBoxSender.BorderStyle = BorderStyle.None;
            textBoxSender.Enabled = false;
            textBoxSender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSender.Location = new Point(217, 226);
            textBoxSender.Margin = new Padding(3, 4, 3, 4);
            textBoxSender.MaxLength = 45;
            textBoxSender.Name = "textBoxSender";
            textBoxSender.Size = new Size(303, 25);
            textBoxSender.TabIndex = 23;
            textBoxSender.Text = "why";
            textBoxSender.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 318);
            label4.Name = "label4";
            label4.Size = new Size(112, 30);
            label4.TabIndex = 19;
            label4.Text = "Nominal :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 270);
            label3.Name = "label3";
            label3.Size = new Size(125, 30);
            label3.TabIndex = 18;
            label3.Text = "RECEIVER :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 222);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 17;
            label2.Text = "SENDER :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 145);
            label1.Name = "label1";
            label1.Size = new Size(382, 46);
            label1.TabIndex = 16;
            label1.Text = "TRANSACTION DETAIL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo_2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(142, 23);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 103);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackgroundImage = Properties.Resources.ButtonC;
            buttonConfirm.BackgroundImageLayout = ImageLayout.Stretch;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(415, 395);
            buttonConfirm.Margin = new Padding(3, 4, 3, 4);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(105, 38);
            buttonConfirm.TabIndex = 31;
            buttonConfirm.Text = "CONFIRM";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // FormConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.BG_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 448);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonReturn);
            Controls.Add(textBoxNominal);
            Controls.Add(textBoxRecepient);
            Controls.Add(textBoxSender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormConfirm";
            Text = "FormConfirm";
            Load += FormConfirm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private TextBox textBoxNominal;
        private TextBox textBoxRecepient;
        private TextBox textBoxSender;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonConfirm;
    }
}