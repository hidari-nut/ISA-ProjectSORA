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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.buttonReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SORA_Project.Properties.Resources.Title_Read_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 62);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonG;
            this.buttonTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTransfer.ForeColor = System.Drawing.Color.White;
            this.buttonTransfer.Location = new System.Drawing.Point(754, 574);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(108, 42);
            this.buttonTransfer.TabIndex = 13;
            this.buttonTransfer.Text = "Close";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(12, 102);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.RowHeadersWidth = 51;
            this.dataGridViewInfo.RowTemplate.Height = 29;
            this.dataGridViewInfo.Size = new System.Drawing.Size(850, 461);
            this.dataGridViewInfo.TabIndex = 12;
            // 
            // buttonReport
            // 
            this.buttonReport.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonC;
            this.buttonReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Location = new System.Drawing.Point(12, 574);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(108, 42);
            this.buttonReport.TabIndex = 15;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // FormTransferHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 628);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.dataGridViewInfo);
            this.Name = "FormTransferHistory";
            this.Text = "FormTransferHistory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Button buttonTransfer;
        private DataGridView dataGridViewInfo;
        private Button buttonReport;
    }
}