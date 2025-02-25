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

            DataView dv = clsCountry.GetAllCountries().DefaultView;
            foreach (DataRow dataRow in dv.Table.Rows)
                cbCountry.Items.Add(dataRow["CountryName"].ToString());
         
        }


        private void FillDataFromUI() 
        {
            _Person.NationalNo = txtNationalNo.Text; 
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text ; 
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.Gendor =  Convert.ToInt16(rbFemale.Checked);

            _Person.NationalityCountryID = cbCountry.SelectedIndex;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
