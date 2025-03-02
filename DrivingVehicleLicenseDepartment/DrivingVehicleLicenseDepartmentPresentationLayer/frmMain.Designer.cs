namespace DrivingVehicleLicenseDepartmentPresentationLayer
{
    partial class frmMain
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
            if ( disposing && (components != null) )
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMangeApplicationtype = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMangeTestType = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MangeUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.peopleToolStripMenuItem,
            this.MangeUserMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1787, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.DVLD_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1763, 655);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemMangeApplicationtype,
            this.toolStripMangeTestType});
            this.toolStripMenuItem2.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.ApplicationType;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 24);
            this.toolStripMenuItem2.Text = "Application";
            // 
            // MenuItemMangeApplicationtype
            // 
            this.MenuItemMangeApplicationtype.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Manage_Applications_32;
            this.MenuItemMangeApplicationtype.Name = "MenuItemMangeApplicationtype";
            this.MenuItemMangeApplicationtype.Size = new System.Drawing.Size(254, 26);
            this.MenuItemMangeApplicationtype.Text = "Mange Application Type";
            this.MenuItemMangeApplicationtype.Click += new System.EventHandler(this.MenuItemMangeApplicationtype_Click);
            // 
            // toolStripMangeTestType
            // 
            this.toolStripMangeTestType.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.TestType_32;
            this.toolStripMangeTestType.Name = "toolStripMangeTestType";
            this.toolStripMangeTestType.Size = new System.Drawing.Size(254, 26);
            this.toolStripMangeTestType.Text = "Mange Test Type";
            this.toolStripMangeTestType.Click += new System.EventHandler(this.toolStripMangeTestType_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.People;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // MangeUserMenuItem
            // 
            this.MangeUserMenuItem.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Users_2_64;
            this.MangeUserMenuItem.Name = "MangeUserMenuItem";
            this.MangeUserMenuItem.Size = new System.Drawing.Size(128, 24);
            this.MangeUserMenuItem.Text = "Mange Users";
            this.MangeUserMenuItem.Click += new System.EventHandler(this.MangeUserMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.account_settings_64;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 715);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة تراخيص القيادة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MangeUserMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMangeApplicationtype;
        private System.Windows.Forms.ToolStripMenuItem toolStripMangeTestType;
    }
}

