using BusinessLayerDrivingVehicleLicenseDepartment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace DrivingVehicleLicenseDepartmentPresentationLayer.User
{
    public partial class frmAddNewUser : Form
    {
        private enum TabIndex { TabPersonalinfo = 0, TabLogininfo = 1 }
        private clsUser _User;
        public frmAddNewUser()
        {
            InitializeComponent();
            _User = new clsUser();
        }

        private void tabPage1_Click(object sender , EventArgs e)
        {

        }

        private void _setSelectedTab(int index)
        {
            tabControl1.SelectTab(index);
        }

        private void btnNext_Click(object sender , EventArgs e)
        {
            _setSelectedTab((int) TabIndex.TabLogininfo);
        }

        private void btnBack_Click(object sender , EventArgs e)
        {
            _setSelectedTab((int) TabIndex.TabPersonalinfo);
        }

        private void btnClose_Click(object sender , EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender , EventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            if ( string.IsNullOrEmpty(textBox.Text) )
                errorProvider1.SetError(textBox , "Can't input empty string");
        }

        private void textBox3_Leave(object sender , EventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            if ( string.IsNullOrEmpty(textBox.Text) || txtPassword.Text != txtConfirmPassword.Text )
                errorProvider1.SetError(textBox , "Password Not Mathced ");

        }

        private void _FillUIFromData()
        {
            lblUserID.Text = _User.UserId.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.PassWord;
            txtConfirmPassword.Text = _User.PassWord;
            chIsActive.Checked = _User.IsActive;
        }
        private void _FillDataFromUI()
        {
            _User.UserName = txtUserName.Text;
            _User.PassWord = txtPassword.Text;
            _User.PassWord = txtConfirmPassword.Text;
            _User.IsActive = chIsActive.Checked;
            _User.PersonId = ctrlFilterPerson1.GetPersonId();
        }

        private void textBox2_Leave(object sender , EventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            if ( string.IsNullOrEmpty(textBox.Text) )
                errorProvider1.SetError(textBox , "Can't input blank Password");
        }

        private void btnSave_Click(object sender , EventArgs e)
        {
            _FillDataFromUI();
            if ( _User.Save() )
            {

                _FillUIFromData();
            }

        }
    }
}
