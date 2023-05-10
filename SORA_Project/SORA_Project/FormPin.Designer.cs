namespace SORA_Project
{
    partial class FormPin
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
            textBoxPIN = new TextBox();
            label1 = new Label();
            buttonEnter = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxPIN);
            panel1.Location = new Point(46, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 61);
            panel1.TabIndex = 7;
            // 
            // textBoxPIN
            // 
            textBoxPIN.BackColor = Color.White;
            textBoxPIN.BorderStyle = BorderStyle.None;
            textBoxPIN.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPIN.Location = new Point(3, 7);
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.PasswordChar = '*';
            textBoxPIN.Size = new Size(246, 40);
            textBoxPIN.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 51);
            label1.Name = "label1";
            label1.Size = new Size(64, 37);
            label1.TabIndex = 8;
            label1.Text = "PIN";
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.Transparent;
            buttonEnter.BackgroundImage = Properties.Resources.ButtonC;
            buttonEnter.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(113, 191);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(128, 51);
            buttonEnter.TabIndex = 12;
            buttonEnter.Text = "ENTER";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // FormPin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.wave;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(343, 332);
            Controls.Add(buttonEnter);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPin";
            Text = "FormPin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxPIN;
        private Label label1;
        private Button buttonEnter;
    }
}