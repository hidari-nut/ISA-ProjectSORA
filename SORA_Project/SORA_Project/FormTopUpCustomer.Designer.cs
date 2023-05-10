namespace SORA_Project
{
    partial class FormTopUpCustomer
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
            panel1 = new Panel();
            numericUpDownValue = new NumericUpDown();
            buttonEnter = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBoxMethod = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(numericUpDownValue);
            panel1.Location = new Point(74, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 61);
            panel1.TabIndex = 13;
            // 
            // numericUpDownValue
            // 
            numericUpDownValue.DecimalPlaces = 2;
            numericUpDownValue.Font = new Font("Nirmala UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownValue.Location = new Point(7, 10);
            numericUpDownValue.Margin = new Padding(3, 4, 3, 4);
            numericUpDownValue.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownValue.Name = "numericUpDownValue";
            numericUpDownValue.Size = new Size(322, 39);
            numericUpDownValue.TabIndex = 19;
            numericUpDownValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.Transparent;
            buttonEnter.BackgroundImage = Properties.Resources.ButtonC;
            buttonEnter.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(168, 252);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(128, 51);
            buttonEnter.TabIndex = 15;
            buttonEnter.Text = "ENTER";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 32);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 14;
            label1.Text = "TOP UP PAGE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 98);
            label2.Name = "label2";
            label2.Size = new Size(52, 37);
            label2.TabIndex = 16;
            label2.Text = "Rp";
            // 
            // comboBoxMethod
            // 
            comboBoxMethod.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMethod.FormattingEnabled = true;
            comboBoxMethod.Location = new Point(200, 181);
            comboBoxMethod.Name = "comboBoxMethod";
            comboBoxMethod.Size = new Size(212, 28);
            comboBoxMethod.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 181);
            label3.Name = "label3";
            label3.Size = new Size(178, 28);
            label3.TabIndex = 18;
            label3.Text = "Payment method:";
            // 
            // FormTopUpCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 336);
            Controls.Add(label3);
            Controls.Add(comboBoxMethod);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(buttonEnter);
            Controls.Add(label1);
            Name = "FormTopUpCustomer";
            Text = "FormTopUpCustomer";
            Load += FormTopUpCustomer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button buttonEnter;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxMethod;
        private Label label3;
        private NumericUpDown numericUpDownValue;
    }
}