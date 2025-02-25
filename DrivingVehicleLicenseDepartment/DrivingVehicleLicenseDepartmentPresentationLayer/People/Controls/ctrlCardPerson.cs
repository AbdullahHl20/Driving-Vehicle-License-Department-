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

namespace DrivingVehicleLicenseDepartmentPresentationLayer
{
    public partial class ctrlCardPerson : UserControl
    {

        private clsPerson _Person;
        public ctrlCardPerson()
        {
            InitializeComponent();
        }

        public void ResetPersonInfo()
        {
        
        }
        public void _FillPersonInfo()
        {
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if ( _Person == null )
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString() , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }



    }
}
