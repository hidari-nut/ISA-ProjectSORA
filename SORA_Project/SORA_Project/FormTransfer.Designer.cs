namespace SORA_Project
{
    partial class FormTransfer
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
            radioButtonFriendlist = new RadioButton();
            radioButtonOutsider = new RadioButton();
            label2 = new Label();
            comboBoxFriendlist = new ComboBox();
            textBoxOutsider = new TextBox();
            label3 = new Label();
            numericUpDownValue = new NumericUpDown();
            label5 = new Label();
            buttonSend = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.ButtonA;
            label1.Location = new Point(129, 12);
            label1.Name = "label1";
            label1.Size = new Size(150, 46);
            label1.TabIndex = 2;
            label1.Text = "Transfer";
            // 
            // radioButtonFriendlist
            // 
            radioButtonFriendlist.AutoSize = true;
            radioButtonFriendlist.BackColor = Color.Transparent;
            radioButtonFriendlist.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonFriendlist.ForeColor = Color.White;
            radioButtonFriendlist.Location = new Point(46, 102);
            radioButtonFriendlist.Margin = new Padding(3, 4, 3, 4);
            radioButtonFriendlist.Name = "radioButtonFriendlist";
            radioButtonFriendlist.Size = new Size(136, 28);
            radioButtonFriendlist.TabIndex = 3;
            radioButtonFriendlist.TabStop = true;
            radioButtonFriendlist.Text = "Friendlists";
            radioButtonFriendlist.UseVisualStyleBackColor = false;
            // 
            // radioButtonOutsider
            // 
            radioButtonOutsider.AutoSize = true;
            radioButtonOutsider.BackColor = Color.Transparent;
            radioButtonOutsider.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonOutsider.ForeColor = Color.White;
            radioButtonOutsider.Location = new Point(222, 102);
            radioButtonOutsider.Margin = new Padding(3, 4, 3, 4);
            radioButtonOutsider.Name = "radioButtonOutsider";
            radioButtonOutsider.Size = new Size(127, 28);
            radioButtonOutsider.TabIndex = 4;
            radioButtonOutsider.TabStop = true;
            radioButtonOutsider.Text = "Outsiders";
            radioButtonOutsider.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(279, 28);
            label2.TabIndex = 5;
            label2.Text = "Choose transfer destination:";
            // 
            // comboBoxFriendlist
            // 
            comboBoxFriendlist.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFriendlist.Enabled = false;
            comboBoxFriendlist.FormattingEnabled = true;
            comboBoxFriendlist.Location = new Point(12, 188);
            comboBoxFriendlist.Margin = new Padding(3, 4, 3, 4);
            comboBoxFriendlist.Name = "comboBoxFriendlist";
            comboBoxFriendlist.Size = new Size(138, 28);
            comboBoxFriendlist.TabIndex = 6;
            // 
            // textBoxOutsider
            // 
            textBoxOutsider.Enabled = false;
            textBoxOutsider.Location = new Point(158, 188);
            textBoxOutsider.Margin = new Padding(3, 4, 3, 4);
            textBoxOutsider.Name = "textBoxOutsider";
            textBoxOutsider.PlaceholderText = "Destignated E-Mail";
            textBoxOutsider.Size = new Size(225, 27);
            textBoxOutsider.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 144);
            label3.Name = "label3";
            label3.Size = new Size(247, 28);
            label3.TabIndex = 8;
            label3.Text = "Choose transfer account:";
            // 
            // numericUpDownValue
            // 
            numericUpDownValue.Font = new Font("Nirmala UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownValue.Location = new Point(59, 275);
            numericUpDownValue.Margin = new Padding(3, 4, 3, 4);
            numericUpDownValue.Name = "numericUpDownValue";
            numericUpDownValue.Size = new Size(322, 39);
            numericUpDownValue.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(20, 279);
            label5.Name = "label5";
            label5.Size = new Size(37, 28);
            label5.TabIndex = 11;
            label5.Text = "Rp";
            // 
            // buttonSend
            // 
            buttonSend.BackgroundImage = Properties.Resources.ButtonC;
            buttonSend.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSend.FlatStyle = FlatStyle.Flat;
            buttonSend.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSend.ForeColor = Color.White;
            buttonSend.Location = new Point(299, 354);
            buttonSend.Margin = new Padding(3, 4, 3, 4);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(82, 53);
            buttonSend.TabIndex = 15;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 240);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 9;
            label4.Text = "Amount:";
            // 
            // FormTransfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.BG_5;
            ClientSize = new Size(394, 418);
            Controls.Add(buttonSend);
            Controls.Add(label5);
            Controls.Add(numericUpDownValue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxOutsider);
            Controls.Add(comboBoxFriendlist);
            Controls.Add(label2);
            Controls.Add(radioButtonOutsider);
            Controls.Add(radioButtonFriendlist);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTransfer";
            Text = "FormTransfer";
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButtonFriendlist;
        private RadioButton radioButtonOutsider;
        private Label label2;
        private ComboBox comboBoxFriendlist;
        private TextBox textBoxOutsider;
        private Label label3;
        private NumericUpDown numericUpDownValue;
        private Label label5;
        private Button buttonSend;
        private Label label4;
    }
}