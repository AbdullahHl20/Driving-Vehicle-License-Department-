using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartmentPresentationLayer.User;

namespace DrivingVehicleLicenseDepartmentPresentationLayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
