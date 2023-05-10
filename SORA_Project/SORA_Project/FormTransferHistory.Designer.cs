namespace SORA_Project
{
    partial class FormTransferHistory
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
            buttonTransfer = new Button();
            dataGridViewInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Title_Read_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 62);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // buttonTransfer
            // 
            buttonTransfer.BackgroundImage = Properties.Resources.ButtonG;
            buttonTransfer.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTransfer.FlatStyle = FlatStyle.Flat;
            buttonTransfer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTransfer.ForeColor = Color.White;
            buttonTransfer.Location = new Point(754, 574);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(108, 42);
            buttonTransfer.TabIndex = 13;
            buttonTransfer.Text = "Close";
            buttonTransfer.UseVisualStyleBackColor = true;
            buttonTransfer.Click += buttonTransfer_Click;
            // 
            // dataGridViewInfo
            // 
            dataGridViewInfo.BackgroundColor = Color.White;
            dataGridViewInfo.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo.Location = new Point(12, 102);
            dataGridViewInfo.Name = "dataGridViewInfo";
            dataGridViewInfo.RowHeadersWidth = 51;
            dataGridViewInfo.RowTemplate.Height = 29;
            dataGridViewInfo.Size = new Size(850, 461);
            dataGridViewInfo.TabIndex = 12;
            // 
            // FormTransferHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(874, 628);
            Controls.Add(pictureBox1);
            Controls.Add(buttonTransfer);
            Controls.Add(dataGridViewInfo);
            Name = "FormTransferHistory";
            Text = "FormTransferHistory";
            Load += FormTransferHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button buttonTransfer;
        private DataGridView dataGridViewInfo;
    }
}