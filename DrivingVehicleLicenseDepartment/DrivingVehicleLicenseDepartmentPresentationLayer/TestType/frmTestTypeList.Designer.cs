namespace DrivingVehicleLicenseDepartmentPresentationLayer.TestType
{
    partial class frmTestTypeList
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
            this.dvgTestType = new System.Windows.Forms.DataGridView();
            this.contextGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEditTestType = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTestType)).BeginInit();
            this.contextGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTestType
            // 
            this.dvgTestType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTestType.ContextMenuStrip = this.contextGrid;
            this.dvgTestType.Location = new System.Drawing.Point(21, 278);
            this.dvgTestType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgTestType.Name = "dvgTestType";
            this.dvgTestType.RowHeadersWidth = 51;
            this.dvgTestType.RowTemplate.Height = 24;
            this.dvgTestType.Size = new System.Drawing.Size(643, 224);
            this.dvgTestType.TabIndex = 0;
            // 
            // contextGrid
            // 
            this.contextGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditTestType});
            this.contextGrid.Name = "contextGrid";
            this.contextGrid.Size = new System.Drawing.Size(149, 30);
            // 
            // toolStripEditTestType
            // 
            this.toolStripEditTestType.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.edit_32;
            this.toolStripEditTestType.Name = "toolStripEditTestType";
            this.toolStripEditTestType.Size = new System.Drawing.Size(148, 26);
            this.toolStripEditTestType.Text = "Edit Test Type";
            this.toolStripEditTestType.Click += new System.EventHandler(this.toolStripEditTestType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(144, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(80, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mange Test Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(542, 508);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTestTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgTestType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestTypeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Type List";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTestType)).EndInit();
            this.contextGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTestType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditTestType;
    }
}