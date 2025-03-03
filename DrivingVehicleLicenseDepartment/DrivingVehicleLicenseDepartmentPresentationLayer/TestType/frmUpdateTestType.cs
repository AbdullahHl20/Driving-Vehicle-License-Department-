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
    public partial class frmUpdateTestType : Form
    {
        private clsTestType _TestType;
        public frmUpdateTestType(int id)
        {
            InitializeComponent();
            _TestType = clsTestType.FindById(id);
            if (_TestType != null)
            {
                _fillUiFromData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _fillDataFromUi()
        {
            _TestType.TestTypeTitle = txtTestName.Text;
            _TestType.TestTypeDescription = txtDescription.Text;
            _TestType.TestTypeFees = Convert.ToDouble(txttestPrice.Text);
        }

        private void _fillUiFromData()
        {
            lblTestTypeId.Text = Convert.ToString(_TestType.Id);
            txtTestName.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txttestPrice.Text = Convert.ToString(_TestType.TestTypeFees);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _fillDataFromUi();

            if (_TestType.Save())
            {
                _fillUiFromData();
                clsMessgaes.Showinfo("Edit Successfully");
            }
        }
    }
}
