﻿using BusinessLayerDrivingVehicleLicenseDepartment;
using System;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartmentPresentationLayer.People;

namespace DrivingVehicleLicenseDepartmentPresentationLayer
{
    public partial class ctrlCardPerson : UserControl
    {
        private clsPerson _Person;
        private clsCountry _Country;
        public ctrlCardPerson()
        {
            InitializeComponent();
            _ResetPersonInfo();
        }
        public ctrlCardPerson(string NationalNo)
        {
            InitializeComponent();
            LoadPersonInfo(NationalNo);
        }
        public void loadPersondata(clsPerson person)
        {
            _Person = person;
            _Country = clsCountry.Find(_Person.NationalityCountryID);
            FillPersonInfo();
        }

        public ctrlCardPerson(int Personid)
        {
            InitializeComponent();
            LoadPersonInfo(Personid);
        }

        public void _ResetPersonInfo()
        {
            string defultvalue = "[???]";
            lblNationalNo.Text = defultvalue;
            lblFullName.Text = defultvalue;
            lblEmail.Text = defultvalue;
            lblPhone.Text = defultvalue;
            lblAddress.Text = defultvalue;
            lblGendor.Text = defultvalue;
            lblDateOfBirth.Text = defultvalue;
            lblCountry.Text = defultvalue;
            llEditPersonInfo.Enabled = false;
        }
        public void FillPersonInfo()
        {
            lblNationalNo.Text = _Person.NationalNo;
            lblFullName.Text = _Person.FirstName + _Person.SecondName + _Person.ThirdName + _Person.LastName;
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblAddress.Text = _Person.Phone;
            lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblNationalNo.Text = _Person.NationalNo;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            lblPersonID.Text = Convert.ToString(_Person.PersonId);
            llEditPersonInfo.Enabled = true;
            lblCountry.Text = _Country.CountryName;
            if (!string.IsNullOrEmpty(_Person.ImagePath))
                pbPersonImage.Load(_Person.ImagePath);
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                _ResetPersonInfo();
                clsMessgaes.ShowError("No Person with National No. = " + NationalNo.ToString());
                return;
            }
            _Country = clsCountry.Find(_Person.NationalityCountryID);

            FillPersonInfo();
        }

        public void LoadPersonInfo(int Personid)
        {
            _Person = clsPerson.Find(Personid);
            if (_Person == null)
            {
                _ResetPersonInfo();
                clsMessgaes.ShowError("No Person with National No. = " + Personid.ToString());
                return;
            }
            _Country = clsCountry.Find(_Person.NationalityCountryID);

            FillPersonInfo();
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson(_Person.NationalNo);
            frmAddUpdatePerson.ShowDialog();
        }

        public int GetPersonid()
        {
            return _Person.PersonId;
        }
    }
}
