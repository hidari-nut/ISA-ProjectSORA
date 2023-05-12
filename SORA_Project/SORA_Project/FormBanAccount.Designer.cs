namespace SORA_Project
{
    partial class FormBanAccount
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
            textBoxName = new TextBox();
            comboBoxAttribute = new ComboBox();
            labelFilter = new Label();
            pictureBox1 = new PictureBox();
            buttonBan = new Button();
            dataGridViewInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(284, 116);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(578, 27);
            textBoxName.TabIndex = 17;
            // 
            // comboBoxAttribute
            // 
            comboBoxAttribute.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAttribute.FormattingEnabled = true;
            comboBoxAttribute.Location = new Point(151, 116);
            comboBoxAttribute.Name = "comboBoxAttribute";
            comboBoxAttribute.Size = new Size(127, 28);
            comboBoxAttribute.TabIndex = 16;
            comboBoxAttribute.SelectedIndexChanged += comboBoxAttribute_SelectedIndexChanged;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelFilter.Location = new Point(12, 110);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(151, 36);
            labelFilter.TabIndex = 15;
            labelFilter.Text = "FILTER : ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Title_Read_5;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 62);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // buttonBan
            // 
            buttonBan.BackgroundImage = Properties.Resources.ButtonG;
            buttonBan.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBan.FlatStyle = FlatStyle.Flat;
            buttonBan.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBan.ForeColor = Color.White;
            buttonBan.Location = new Point(754, 569);
            buttonBan.Name = "buttonBan";
            buttonBan.Size = new Size(108, 42);
            buttonBan.TabIndex = 13;
            buttonBan.Text = "Close";
            buttonBan.UseVisualStyleBackColor = true;
            buttonBan.Click += buttonBan_Click;
            // 
            // dataGridViewInfo
            // 
            dataGridViewInfo.BackgroundColor = Color.White;
            dataGridViewInfo.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo.Location = new Point(12, 172);
            dataGridViewInfo.Name = "dataGridViewInfo";
            dataGridViewInfo.RowHeadersWidth = 51;
            dataGridViewInfo.RowTemplate.Height = 29;
            dataGridViewInfo.Size = new Size(850, 391);
            dataGridViewInfo.TabIndex = 12;
            dataGridViewInfo.CellContentClick += dataGridViewInfo_CellContentClick;
            // 
            // FormBanAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 628);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxAttribute);
            Controls.Add(labelFilter);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBan);
            Controls.Add(dataGridViewInfo);
            Name = "FormBanAccount";
            Text = "FormBanAccount";
            Load += FormBanAccount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private ComboBox comboBoxAttribute;
        private Label labelFilter;
        private PictureBox pictureBox1;
        private Button buttonBan;
        private DataGridView dataGridViewInfo;
    }
}