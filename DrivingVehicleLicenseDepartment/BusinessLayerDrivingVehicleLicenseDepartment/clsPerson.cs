using DrivingVehicleLicenseDepartmentDataAccessLayer;
using System;
using System.Data;
using System.Net;

namespace BusinessLayerDrivingVehicleLicenseDepartment
{

    public enum enSaveMode { Add, Update }
    public class clsPerson
    {

        public clsPerson()
        {
            this.NationalNo = "";
            this.FirstName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = 0;
            this.ImagePath = "";
            SaveMode = enSaveMode.Add;

        }

        public clsPerson(int PersonId  , string FirstName , string SecondName , string ThirdName ,
           string LastName ,string NationalNo, DateTime DateOfBirth , short Gendor , string Address , string Phone ,
           string Email , int NationalityCountryID , string ImagePath)
        {
            this.PersonId = PersonId;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName  = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            SaveMode = enSaveMode.Update;

        }
        public int PersonId { get; set; }
        public enSaveMode SaveMode { get; set; }

        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }


        public static clsPerson Find(string NationalNo )
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int PersonID = -1, NationalityCountryID = -1;
            short Gendor = 0;

            bool IsFound = clsPersonData.GetPersonInfoByNationalNo
                                (
                                    NationalNo , ref PersonID , ref FirstName , ref SecondName ,
                                    ref ThirdName , ref LastName , ref DateOfBirth ,
                                    ref Gendor , ref Address , ref Phone , ref Email ,
                                    ref NationalityCountryID , ref ImagePath
                                );

            if ( IsFound )

                return new clsPerson(PersonID , FirstName , SecondName , ThirdName , LastName ,
                          NationalNo , DateOfBirth , Gendor , Address , Phone , Email , NationalityCountryID , ImagePath);
            else
                return null;

        }

        public static DataTable GetAllPerson()
        {
            return clsPersonData.GetAllPerson();
        }
        public bool Save()
        {
            switch ( SaveMode )
            {
                case enSaveMode.Add:{
                    if ( _AddNewPerson() )
                    {

                        SaveMode = enSaveMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    } 
                }

                case enSaveMode.Update:

                    return _UpdatePerson();
            }
            return false;
        }
        private bool _AddNewPerson()
        {
            this.PersonId = clsPersonData.AddNewPerson(this.NationalNo , this.FirstName , this.LastName , this.SecondName , this.ThirdName ,
                            this.DateOfBirth , this.Gendor , this.Address , this.Phone , this.Email , this.NationalityCountryID , this.ImagePath);

            return this.PersonId != -1;

        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonId,this.NationalNo , this.FirstName , this.LastName , this.SecondName , this.ThirdName ,
                            this.DateOfBirth , this.Gendor , this.Address , this.Phone , this.Email , this.NationalityCountryID , this.ImagePath);


        }

    }
}
