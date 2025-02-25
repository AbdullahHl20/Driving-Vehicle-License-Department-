namespace DrivingVehicleLicenseDepartmentPresentationLayer.People
{
    partial class frmShowPersonInfo
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
            this.ctrlCardPerson1 = new DrivingVehicleLicenseDepartmentPresentationLayer.ctrlCardPerson();
            this.SuspendLayout();
            // 
            // ctrlCardPerson1
            // 
            this.ctrlCardPerson1.Location = new System.Drawing.Point(12, 35);
            this.ctrlCardPerson1.Name = "ctrlCardPerson1";
            this.ctrlCardPerson1.Size = new System.Drawing.Size(1010, 330);
            this.ctrlCardPerson1.TabIndex = 0;
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 366);
            this.Controls.Add(this.ctrlCardPerson1);
            this.Name = "frmShowPersonInfo";
            this.Text = "frmShowPersonInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCardPerson ctrlCardPerson1;
    }
}