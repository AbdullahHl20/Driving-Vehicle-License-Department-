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
    public partial class frmUpdateTestType : Form
    {

        private clsApplicationType _ApplicationType;
        public frmUpdateTestType(int ApplivationTypeId)
        {
            InitializeComponent();
            _GetApplicationTypeInfo(ApplivationTypeId);
            _fillUiFromModel();
        }

        private void _GetApplicationTypeInfo(int ApplivationTypeId)
        { 
            _ApplicationType =clsApplicationType.FindById(ApplivationTypeId);
        }

        private void _fillUiFromModel()
        {
            if ( _ApplicationType == null )
                return;

            lblApplicationTypeId.Text = Convert.ToString( _ApplicationType.Id);
            txtApplicationName.Text =  _ApplicationType.Title;
            txtApplicationPrice.Text = Convert.ToString(_ApplicationType.Fees);
        }

        private void _fillModelFromModelUi()
        {
            _ApplicationType.Title = txtApplicationName.Text ;
            _ApplicationType.Fees = Convert.ToDouble(txtApplicationPrice.Text);
        }

        private void btnClose_Click(object sender , EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender , EventArgs e)
        {
            _fillModelFromModelUi();
            if ( _ApplicationType.Save() )
            {
                _fillUiFromModel();
            }
            else 
                {}

        }
    }
}
