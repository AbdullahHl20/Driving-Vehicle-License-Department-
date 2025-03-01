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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMangeUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMangeUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMangeUsers;
            this.dgvUsers.Location = new System.Drawing.Point(139, 319);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(811, 250);
            this.dgvUsers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(345, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(383, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mange Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMangeUsers
            // 
            this.contextMangeUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMangeUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemShowDetails,
            this.MenuItemAddUser});
            this.contextMangeUsers.Name = "contextMangeUsers";
            this.contextMangeUsers.Size = new System.Drawing.Size(215, 84);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.user;
            this.btnAddNewUser.Location = new System.Drawing.Point(883, 266);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(67, 47);
            this.btnAddNewUser.TabIndex = 3;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(17, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuItemAddUser
            // 
            this.MenuItemAddUser.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Add_New_User_32;
            this.MenuItemAddUser.Name = "MenuItemAddUser";
            this.MenuItemAddUser.Size = new System.Drawing.Size(214, 26);
            this.MenuItemAddUser.Text = "Add New User";
            this.MenuItemAddUser.Click += new System.EventHandler(this.MenuItemAddUser_Click);
            // 
            // MenuItemShowDetails
            // 
            this.MenuItemShowDetails.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.PersonDetails_32;
            this.MenuItemShowDetails.Name = "MenuItemShowDetails";
            this.MenuItemShowDetails.Size = new System.Drawing.Size(214, 26);
            this.MenuItemShowDetails.Text = "Show Details";
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 594);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUserList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMangeUsers.ResumeLayout(false);
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
    }
}