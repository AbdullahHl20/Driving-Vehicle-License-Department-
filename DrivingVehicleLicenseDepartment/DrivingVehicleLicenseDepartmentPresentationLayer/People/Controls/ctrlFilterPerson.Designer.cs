namespace DrivingVehicleLicenseDepartmentPresentationLayer.People.Controls
{
    partial class ctrlFilterPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlCardPerson1 = new DrivingVehicleLicenseDepartmentPresentationLayer.ctrlCardPerson();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.txtFilteredValue = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilteredValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCardPerson1
            // 
            this.ctrlCardPerson1.Location = new System.Drawing.Point(37, 224);
            this.ctrlCardPerson1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlCardPerson1.Name = "ctrlCardPerson1";
            this.ctrlCardPerson1.Size = new System.Drawing.Size(995, 332);
            this.ctrlCardPerson1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewPerson);
            this.groupBox1.Controls.Add(this.btnSearchPerson);
            this.groupBox1.Controls.Add(this.txtFilteredValue);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(37, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(995, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.Add_Person_40;
            this.btnAddNewPerson.Location = new System.Drawing.Point(695, 49);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(75, 49);
            this.btnAddNewPerson.TabIndex = 3;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Image = global::DrivingVehicleLicenseDepartmentPresentationLayer.Properties.Resources.SearchPerson;
            this.btnSearchPerson.Location = new System.Drawing.Point(614, 49);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(75, 49);
            this.btnSearchPerson.TabIndex = 2;
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // txtFilteredValue
            // 
            this.txtFilteredValue.Location = new System.Drawing.Point(246, 51);
            this.txtFilteredValue.Name = "txtFilteredValue";
            this.txtFilteredValue.Size = new System.Drawing.Size(342, 22);
            this.txtFilteredValue.TabIndex = 1;
            // 
            // ctrlFilterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlCardPerson1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlFilterPerson";
            this.Size = new System.Drawing.Size(1063, 593);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFilteredValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCardPerson ctrlCardPerson1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.TextEdit txtFilteredValue;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnSearchPerson;
    }
}
