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

namespace DrivingVehicleLicenseDepartmentPresentationLayer.TestType
{
    public partial class frmTestTypeList : Form
    {

        private DataView _dataViewTestType;
      
        public frmTestTypeList()
        {
            InitializeComponent();
           
            _FillGrid();
        }

        private void _FillGrid()
        {
            _dataViewTestType = new DataView(clsTestType.GetAllTestType());
            dvgTestType.DataSource = _dataViewTestType;
            dvgTestType.Columns[0].Width = 30;
            dvgTestType.Columns[1].Width = 130;
            dvgTestType.Columns[2].Width = 350;
            dvgTestType.Columns[3].Width = 80;

        }

        private void btnClose_Click(object sender , EventArgs e)
        {
            this.Close();
        }

        private void toolStripEditTestType_Click(object sender , EventArgs e)
        {
            frmUpdateTestType frmUpdateTestType = new frmUpdateTestType(Convert.ToInt32(dvgTestType.CurrentRow.Cells["TestTypeID"].Value));

            frmUpdateTestType.ShowDialog();
            _FillGrid();
        }
    }
}
