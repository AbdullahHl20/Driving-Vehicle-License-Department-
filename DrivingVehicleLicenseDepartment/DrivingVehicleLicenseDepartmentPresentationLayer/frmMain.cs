using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartmentPresentationLayer.ApplicationTypes;
using DrivingVehicleLicenseDepartmentPresentationLayer.Login;
using DrivingVehicleLicenseDepartmentPresentationLayer.User;

namespace DrivingVehicleLicenseDepartmentPresentationLayer
{
    public partial class frmMain : Form
    {

        private frmLogin _frmLogin;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;   

        }

        private void peopleToolStripMenuItem_Click(object sender , EventArgs e)
        {
            frmMangePeople frmMangePeople = new frmMangePeople();

            frmMangePeople.ShowDialog();
        }

        private void MangeUserMenuItem_Click(object sender , EventArgs e)
        {
            frmUserList frmuserlist = new frmUserList();
            frmuserlist.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLogin.Show();
            this.Close();
        }

        private void MenuItemMangeApplicationtype_Click(object sender, EventArgs e)
        {
            frmApplicationList frmApplicationList = new frmApplicationList();
            frmApplicationList.ShowDialog();
        }
    }
}
