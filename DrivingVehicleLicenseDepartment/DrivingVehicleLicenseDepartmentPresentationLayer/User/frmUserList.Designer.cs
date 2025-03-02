namespace DrivingVehicleLicenseDepartmentPresentationLayer.User
{
    partial class frmUserList
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
            this.components = new System.ComponentModel.Container();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMangeUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripcall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSendMail = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMangeUsers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMangeUsers;
            this.dgvUsers.Location = new System.Drawing.Point(104, 259);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(608, 203);
            this.dgvUsers.TabIndex = 0;
            // 
            // contextMangeUsers
            // 
            this.contextMangeUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMangeUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemShowDetails,
            this.toolStripSeparator1,
            this.MenuItemAddUser,
            this.toolStripEditUser,
            this.toolStripDeleteUser,
            this.toolStripChangePassword,
            this.toolStripSeparator2,
            this.toolStripcall,
            this.toolStripSendMail});
            this.contextMangeUsers.Name = "contextMangeUsers";
            this.contextMangeUsers.Size = new System.Drawing.Size(185, 220);
            // 
            // MenuItemShowDetails
            // 
            this.MenuItemShowDetails.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.PersonDetails_32;
            this.MenuItemShowDetails.Name = "MenuItemShowDetails";
            this.MenuItemShowDetails.Size = new System.Drawing.Size(184, 26);
            this.MenuItemShowDetails.Text = "Show Details";
            this.MenuItemShowDetails.Click += new System.EventHandler(this.MenuItemShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // MenuItemAddUser
            // 
            this.MenuItemAddUser.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Add_New_User_32;
            this.MenuItemAddUser.Name = "MenuItemAddUser";
            this.MenuItemAddUser.Size = new System.Drawing.Size(184, 26);
            this.MenuItemAddUser.Text = "Add New User";
            this.MenuItemAddUser.Click += new System.EventHandler(this.MenuItemAddUser_Click);
            // 
            // toolStripEditUser
            // 
            this.toolStripEditUser.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.edit;
            this.toolStripEditUser.Name = "toolStripEditUser";
            this.toolStripEditUser.Size = new System.Drawing.Size(184, 26);
            this.toolStripEditUser.Text = "Edit User";
            // 
            // toolStripDeleteUser
            // 
            this.toolStripDeleteUser.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.delete_friend;
            this.toolStripDeleteUser.Name = "toolStripDeleteUser";
            this.toolStripDeleteUser.Size = new System.Drawing.Size(184, 26);
            this.toolStripDeleteUser.Text = "Delete User";
            // 
            // toolStripChangePassword
            // 
            this.toolStripChangePassword.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.key;
            this.toolStripChangePassword.Name = "toolStripChangePassword";
            this.toolStripChangePassword.Size = new System.Drawing.Size(184, 26);
            this.toolStripChangePassword.Text = "Change Password";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripcall
            // 
            this.toolStripcall.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.call_32;
            this.toolStripcall.Name = "toolStripcall";
            this.toolStripcall.Size = new System.Drawing.Size(184, 26);
            this.toolStripcall.Text = "Call";
            // 
            // toolStripSendMail
            // 
            this.toolStripSendMail.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.send_email_32;
            this.toolStripSendMail.Name = "toolStripSendMail";
            this.toolStripSendMail.Size = new System.Drawing.Size(184, 26);
            this.toolStripSendMail.Text = "Send Mail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(259, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(287, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mange Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewUser.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.user;
            this.btnAddNewUser.Location = new System.Drawing.Point(662, 216);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(50, 38);
            this.btnAddNewUser.TabIndex = 3;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 483);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserList";
            this.Load += new System.EventHandler(this.frmUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMangeUsers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.ContextMenuStrip contextMangeUsers;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripcall;
        private System.Windows.Forms.ToolStripMenuItem toolStripSendMail;
    }
}