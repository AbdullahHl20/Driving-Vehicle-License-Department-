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

namespace DrivingVehicleLicenseDepartmentPresentationLayer.People
{
    public partial class frmAddUpdatePerson : Form
    {

        private clsPerson _Person;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }


        private void FillDataFromUI() 
        {
            _Person.NationalNo = txtNationalNo.Text ; 
            _Person.FirstName = txtFirstName.Text ;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text ; 
            _Person.Email = txtEmail.Text ;
            _Person.Phone = txtPhone.Text ;
             
            
        
        }


    }
}
