using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingVehicleLicenseDepartmentPresentationLayer.User
{
    public partial class frmAddNewUser : Form
    {
        private enum TabIndex { TabPersonalinfo= 0, TabLogininfo = 1 }
        public frmAddNewUser()
        {
            InitializeComponent();
            ctrlCardPerson1.LoadPersonInfo(1);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void _setSelectedTab(int index) 
        {
            tabControl1.SelectTab(index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _setSelectedTab((int)TabIndex.TabLogininfo);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _setSelectedTab((int)TabIndex.TabPersonalinfo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
                errorProvider1.SetError(textBox, "Can't input empty string");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text) || textBox2.Text != textBox3.Text)
                errorProvider1.SetError(textBox, "Password Not Mathced ");

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
                errorProvider1.SetError(textBox, "Can't input blank Password");
        }
    }
}
