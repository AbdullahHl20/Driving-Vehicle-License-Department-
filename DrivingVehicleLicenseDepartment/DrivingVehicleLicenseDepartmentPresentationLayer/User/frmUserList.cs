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

namespace DrivingVehicleLicenseDepartmentPresentationLayer.User
{
    public partial class frmUserList : Form
    {

        private DataView dvUser;

        public frmUserList()
        {
            InitializeComponent();
            dvUser = new DataView(clsUser.GetAllUsers());
        }

        private void frmUserList_Load(object sender , EventArgs e)
        {
            dgvUsers.DataSource = dvUser;
        }

        private void btnAddNewUser_Click(object sender , EventArgs e)
        {
            _showAddNewUserForm();
        }

        private void _showAddNewUserForm()

        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();

            frmAddNewUser.ShowDialog();
        }

        private void MenuItemAddUser_Click(object sender , EventArgs e)
        {
            _showAddNewUserForm();
        }

        private void MenuItemShowDetails_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser((int)dgvUsers.CurrentRow.Cells["UserId"].Value);
            frmAddNewUser.ShowDialog();
        }
    }
}
