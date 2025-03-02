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

namespace DrivingVehicleLicenseDepartmentPresentationLayer.ApplicationTypes
{
    public partial class frmApplicationList : Form
    {

        private DataView _DataView;
        public frmApplicationList()
        {
            InitializeComponent();
            _FillGridview();
        }

        private void _FillGridview() 
        {
            _DataView = new DataView(clsApplicationType.GetAllApplicationsType());
          
            dgvApplicationType.DataSource = _DataView;

            dgvApplicationType.Columns[0].HeaderText = "ID";
            dgvApplicationType.Columns[0].Width = 80;

            dgvApplicationType.Columns[1].HeaderText = "Title";
            dgvApplicationType.Columns[1].Width = 400;

            dgvApplicationType.Columns[2].HeaderText = "Fees";
            dgvApplicationType.Columns[2].Width = 85;
        }

        private void toolStripEditApplicationType_Click(object sender , EventArgs e)
        {
            frmUpdateTestType frmUpdateApplictionType = new frmUpdateApplictionType(Convert.ToInt32( dgvApplicationType.CurrentRow.Cells["ApplicationTypeID"].Value));
            frmUpdateApplictionType.ShowDialog();
            _FillGridview();
        }
    }
}
