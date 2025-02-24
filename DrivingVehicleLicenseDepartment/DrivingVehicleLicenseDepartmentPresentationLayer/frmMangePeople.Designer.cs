namespace DrivingVehicleLicenseDepartmentPresentationLayer
{
    partial class frmMangePeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFilteredValue = new System.Windows.Forms.TextBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.gridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripsp = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripShowdetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.gridContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif" , 12F , System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point , ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(15 , 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132 , 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.gridContextMenu;
            this.dataGridView1.Location = new System.Drawing.Point(20 , 298);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3 , 2 , 3 , 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1615 , 308);
            this.dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117 , 266);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3 , 2 , 3 , 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151 , 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFilteredValue
            // 
            this.txtFilteredValue.Location = new System.Drawing.Point(275 , 267);
            this.txtFilteredValue.Margin = new System.Windows.Forms.Padding(3 , 2 , 3 , 2);
            this.txtFilteredValue.Name = "txtFilteredValue";
            this.txtFilteredValue.Size = new System.Drawing.Size(169 , 22);
            this.txtFilteredValue.TabIndex = 5;
            this.txtFilteredValue.TextChanged += new System.EventHandler(this.txtFilteredValue_TextChanged);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Location = new System.Drawing.Point(20 , 618);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(99 , 18);
            this.lblRecordCount.TabIndex = 6;
            this.lblRecordCount.Text = "label2";
            // 
            // gridContextMenu
            // 
            this.gridContextMenu.ImageScalingSize = new System.Drawing.Size(20 , 20);
            this.gridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripShowdetails,
            this.toolStripsp,
            this.toolStripAddNewPerson});
            this.gridContextMenu.Name = "gridContextMenu";
            this.gridContextMenu.Size = new System.Drawing.Size(215 , 90);
            // 
            // toolStripsp
            // 
            this.toolStripsp.Name = "toolStripsp";
            this.toolStripsp.Size = new System.Drawing.Size(180 , 6);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.new_1;
            this.btnAddNewPerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddNewPerson.Location = new System.Drawing.Point(1525 , 231);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(3 , 2 , 3 , 2);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(91 , 46);
            this.btnAddNewPerson.TabIndex = 3;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.management;
            this.pictureBox1.Location = new System.Drawing.Point(525 , 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459 , 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripShowdetails
            // 
            this.toolStripShowdetails.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.PersonDetails_32;
            this.toolStripShowdetails.Name = "toolStripShowdetails";
            this.toolStripShowdetails.Size = new System.Drawing.Size(214 , 26);
            this.toolStripShowdetails.Text = "Showdetails";
            this.toolStripShowdetails.Click += new System.EventHandler(this.toolStripShowdetails_Click);
            // 
            // toolStripAddNewPerson
            // 
            this.toolStripAddNewPerson.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Person_321;
            this.toolStripAddNewPerson.Name = "toolStripAddNewPerson";
            this.toolStripAddNewPerson.Size = new System.Drawing.Size(214 , 26);
            this.toolStripAddNewPerson.Text = "AddNewPerson";
            this.toolStripAddNewPerson.Click += new System.EventHandler(this.toolStripAddNewPerson_Click);
            // 
            // frmMangePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F , 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767 , 676);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.txtFilteredValue);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3 , 2 , 3 , 2);
            this.Name = "frmMangePeople";
            this.Text = "frmMangePeople";
            this.Load += new System.EventHandler(this.frmMangePeople_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.gridContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFilteredValue;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip gridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowdetails;
        private System.Windows.Forms.ToolStripSeparator toolStripsp;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddNewPerson;
    }
}