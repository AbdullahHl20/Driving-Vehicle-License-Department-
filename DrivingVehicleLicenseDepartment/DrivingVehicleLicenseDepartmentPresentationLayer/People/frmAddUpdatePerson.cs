using BusinessLayerDrivingVehicleLicenseDepartment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            _FillAllCountries();
            _Person = new clsPerson();
        }
        public frmAddUpdatePerson(string NationalNo)
        {
            InitializeComponent();

            _FillAllCountries();
            _Person = clsPerson.Find(NationalNo);
            if ( _Person != null )
            {
                _FillUIFromData();
            }
        }

        private void _FillAllCountries()
        {
            DataView dv = clsCountry.GetAllCountries().DefaultView;
            foreach ( DataRow dataRow in dv.Table.Rows )
                cbCountry.Items.Add(dataRow["CountryName"].ToString());
        }


        private void _FillDataFromUI()
        {
            _Person.NationalNo = txtNationalNo.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.NationalityCountryID = cbCountry.SelectedIndex;
            pbPersonImage.Load (_Person.ImagePath);

        }

        private void _FillUIFromData()
        {
            txtNationalNo.Text = _Person.NationalNo;
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Phone;
            cbCountry.SelectedIndex = _Person.NationalityCountryID;
           
        }

        private void btnSave_Click(object sender , EventArgs e)
        {

            _FillDataFromUI();
            if (_Person.Save())
            {
                _FillUIFromData();
            }
        }

        private void handelImagePerson() 
        {
            Guid imagename = Guid.NewGuid();

            if (File.Exists(_Person.ImagePath))
                    File.Delete(_Person.ImagePath);

            string path = _Person.ImagePath;
            path = path.Replace(_Person.ImagePath, @"C:\CDVLD-People-Images\" + imagename + openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 4, 4));
            File.Copy(openFileDialog1.FileName, path);
            _Person.ImagePath = path;
        }

        private void llSetImage_LinkClicked(object sender , LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bm";
            openFileDialog1.Title = " Choics Image";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                
                pbPersonImage.Load(openFileDialog1.FileName);
                handelImagePerson();


            }
        }

        private void handelTextValid_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                errorProvider1.SetError(textBox, "this filed Requerd");

                textBox.Focus();
            }

        }
    }
}
