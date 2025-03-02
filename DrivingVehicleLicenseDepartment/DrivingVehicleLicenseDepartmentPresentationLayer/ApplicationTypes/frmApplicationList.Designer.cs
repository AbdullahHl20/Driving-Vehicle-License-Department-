namespace DrivingVehicleLicenseDepartmentPresentationLayer.ApplicationTypes
{
    partial class frmApplicationList
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
            this.components = new System.ComponentModel.Container();
            this.dgvApplicationType = new System.Windows.Forms.DataGridView();
            this.contextGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationType)).BeginInit();
            this.contextGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicationType
            // 
            this.dgvApplicationType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationType.ContextMenuStrip = this.contextGrid;
            this.dgvApplicationType.Location = new System.Drawing.Point(95, 342);
            this.dgvApplicationType.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApplicationType.Name = "dgvApplicationType";
            this.dgvApplicationType.RowHeadersWidth = 51;
            this.dgvApplicationType.Size = new System.Drawing.Size(815, 324);
            this.dgvApplicationType.TabIndex = 0;
            // 
            // contextGrid
            // 
            this.contextGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditApplicationType});
            this.contextGrid.Name = "contextGrid";
            this.contextGrid.Size = new System.Drawing.Size(225, 30);
            // 
            // toolStripEditApplicationType
            // 
            this.toolStripEditApplicationType.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.edit_321;
            this.toolStripEditApplicationType.Name = "toolStripEditApplicationType";
            this.toolStripEditApplicationType.Size = new System.Drawing.Size(224, 26);
            this.toolStripEditApplicationType.Text = "Edit Application Type";
            this.toolStripEditApplicationType.Click += new System.EventHandler(this.toolStripEditApplicationType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(237, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(499, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mange Application Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Application_Types_64;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmApplicationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvApplicationType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApplicationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationType)).EndInit();
            this.contextGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplicationType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditApplicationType;
    }
}