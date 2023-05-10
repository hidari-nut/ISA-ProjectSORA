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
            buttonClose = new Button();
            dataGridViewInfo = new DataGridView();
            buttonReport = new Button();
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
            // buttonClose
            // 
            buttonClose.BackgroundImage = Properties.Resources.ButtonG;
            buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(754, 574);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(108, 42);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
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
            // buttonReport
            // 
            buttonReport.BackgroundImage = Properties.Resources.ButtonC;
            buttonReport.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReport.ForeColor = Color.White;
            buttonReport.Location = new Point(12, 574);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(108, 42);
            buttonReport.TabIndex = 15;
            buttonReport.Text = "Report";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // FormTransferHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(874, 628);
            Controls.Add(buttonReport);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClose);
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
        private Button buttonClose;
        private DataGridView dataGridViewInfo;
        private Button buttonReport;
    }
}