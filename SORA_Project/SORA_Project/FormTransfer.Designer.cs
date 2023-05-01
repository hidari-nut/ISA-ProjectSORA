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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonFriendlist = new System.Windows.Forms.RadioButton();
            this.radioButtonOutsider = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFriendlist = new System.Windows.Forms.ComboBox();
            this.textBoxOutsider = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::SORA_Project.Properties.Resources.ButtonA;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transfer";
            // 
            // radioButtonFriendlist
            // 
            this.radioButtonFriendlist.AutoSize = true;
            this.radioButtonFriendlist.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFriendlist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonFriendlist.ForeColor = System.Drawing.Color.White;
            this.radioButtonFriendlist.Location = new System.Drawing.Point(113, 84);
            this.radioButtonFriendlist.Name = "radioButtonFriendlist";
            this.radioButtonFriendlist.Size = new System.Drawing.Size(111, 23);
            this.radioButtonFriendlist.TabIndex = 3;
            this.radioButtonFriendlist.TabStop = true;
            this.radioButtonFriendlist.Text = "Friendlists";
            this.radioButtonFriendlist.UseVisualStyleBackColor = false;
            // 
            // radioButtonOutsider
            // 
            this.radioButtonOutsider.AutoSize = true;
            this.radioButtonOutsider.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOutsider.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonOutsider.ForeColor = System.Drawing.Color.White;
            this.radioButtonOutsider.Location = new System.Drawing.Point(230, 84);
            this.radioButtonOutsider.Name = "radioButtonOutsider";
            this.radioButtonOutsider.Size = new System.Drawing.Size(104, 23);
            this.radioButtonOutsider.TabIndex = 4;
            this.radioButtonOutsider.TabStop = true;
            this.radioButtonOutsider.Text = "Outsiders";
            this.radioButtonOutsider.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose transfer destination:";
            // 
            // comboBoxFriendlist
            // 
            this.comboBoxFriendlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFriendlist.Enabled = false;
            this.comboBoxFriendlist.FormattingEnabled = true;
            this.comboBoxFriendlist.Location = new System.Drawing.Point(10, 157);
            this.comboBoxFriendlist.Name = "comboBoxFriendlist";
            this.comboBoxFriendlist.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFriendlist.TabIndex = 6;
            // 
            // textBoxOutsider
            // 
            this.textBoxOutsider.Enabled = false;
            this.textBoxOutsider.Location = new System.Drawing.Point(137, 157);
            this.textBoxOutsider.Name = "textBoxOutsider";
            this.textBoxOutsider.PlaceholderText = "Destignated E-Mail";
            this.textBoxOutsider.Size = new System.Drawing.Size(197, 23);
            this.textBoxOutsider.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose transfer account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount:";
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownValue.Location = new System.Drawing.Point(52, 228);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(282, 32);
            this.numericUpDownValue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rp";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonC;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(262, 287);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(72, 40);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.Text = "Send";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SORA_Project.Properties.Resources.BG_5;
            this.ClientSize = new System.Drawing.Size(345, 348);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOutsider);
            this.Controls.Add(this.comboBoxFriendlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonOutsider);
            this.Controls.Add(this.radioButtonFriendlist);
            this.Controls.Add(this.label1);
            this.Name = "FormTransfer";
            this.Text = "FormTransfer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton radioButtonFriendlist;
        private RadioButton radioButtonOutsider;
        private Label label2;
        private ComboBox comboBoxFriendlist;
        private TextBox textBoxOutsider;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownValue;
        private Label label5;
        private Button buttonReturn;
    }
}