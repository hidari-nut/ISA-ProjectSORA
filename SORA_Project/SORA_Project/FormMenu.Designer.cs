namespace SORA_Project
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxLogo = new PictureBox();
            pictureBoxWave = new PictureBox();
            pictureBoxDeskripsi = new PictureBox();
            labelUser = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeskripsi).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, transactionToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem, customersToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(161, 26);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(161, 26);
            customersToolStripMenuItem.Text = "Customers";
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(98, 24);
            transactionToolStripMenuItem.Text = "Transaction";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = Properties.Resources.Logo_2;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(179, 76);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(562, 247);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxWave
            // 
            pictureBoxWave.BackColor = Color.Transparent;
            pictureBoxWave.BackgroundImage = Properties.Resources.wave1;
            pictureBoxWave.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxWave.Location = new Point(-133, 460);
            pictureBoxWave.Margin = new Padding(3, 4, 3, 4);
            pictureBoxWave.Name = "pictureBoxWave";
            pictureBoxWave.Size = new Size(1239, 156);
            pictureBoxWave.TabIndex = 2;
            pictureBoxWave.TabStop = false;
            // 
            // pictureBoxDeskripsi
            // 
            pictureBoxDeskripsi.BackgroundImage = Properties.Resources.Desc;
            pictureBoxDeskripsi.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxDeskripsi.Location = new Point(19, 343);
            pictureBoxDeskripsi.Margin = new Padding(3, 4, 3, 4);
            pictureBoxDeskripsi.Name = "pictureBoxDeskripsi";
            pictureBoxDeskripsi.Size = new Size(880, 67);
            pictureBoxDeskripsi.TabIndex = 3;
            pictureBoxDeskripsi.TabStop = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(866, 47);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(38, 20);
            labelUser.TabIndex = 4;
            labelUser.Text = "User";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(labelUser);
            Controls.Add(pictureBoxDeskripsi);
            Controls.Add(pictureBoxWave);
            Controls.Add(pictureBoxLogo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeskripsi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxWave;
        private PictureBox pictureBoxDeskripsi;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private Label labelUser;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
    }
}