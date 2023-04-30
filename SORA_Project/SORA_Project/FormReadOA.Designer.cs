namespace SORA_Project
{
    partial class FormReadOA
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxAttribute = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(248, 86);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(506, 23);
            this.textBoxName.TabIndex = 23;
            // 
            // comboBoxAttribute
            // 
            this.comboBoxAttribute.FormattingEnabled = true;
            this.comboBoxAttribute.Location = new System.Drawing.Point(132, 86);
            this.comboBoxAttribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAttribute.Name = "comboBoxAttribute";
            this.comboBoxAttribute.Size = new System.Drawing.Size(112, 23);
            this.comboBoxAttribute.TabIndex = 22;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilter.Location = new System.Drawing.Point(10, 81);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(123, 29);
            this.labelFilter.TabIndex = 21;
            this.labelFilter.Text = "FILTER : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SORA_Project.Properties.Resources.Title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 46);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackgroundImage = global::SORA_Project.Properties.Resources.ButtonG;
            this.buttonTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTransfer.ForeColor = System.Drawing.Color.White;
            this.buttonTransfer.Location = new System.Drawing.Point(660, 426);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(94, 32);
            this.buttonTransfer.TabIndex = 19;
            this.buttonTransfer.Text = "Close";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(10, 128);
            this.dataGridViewInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.RowHeadersWidth = 51;
            this.dataGridViewInfo.RowTemplate.Height = 29;
            this.dataGridViewInfo.Size = new System.Drawing.Size(744, 293);
            this.dataGridViewInfo.TabIndex = 18;
            // 
            // FormReadOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 471);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxAttribute);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.dataGridViewInfo);
            this.Name = "FormReadOA";
            this.Text = "FormReadOA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private ComboBox comboBoxAttribute;
        private Label labelFilter;
        private PictureBox pictureBox1;
        private Button buttonTransfer;
        private DataGridView dataGridViewInfo;
    }
}