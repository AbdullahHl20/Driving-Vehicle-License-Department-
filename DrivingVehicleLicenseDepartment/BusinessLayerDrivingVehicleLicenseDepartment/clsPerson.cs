using System;

namespace BusinessLayerDrivingVehicleLicenseDepartment
{

     public enum enSaveMode { Add , Update }
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
        public clsPerson(string NationalNo , string FirstName, string  SecondName, string ThirdName,
           string LastName, DateTime DateOfBirth, byte Gendor, string Phone ,
           string  Email, int NationalityCountryID, string ImagePath)
        {
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
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
        public DateTime  DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        


    }
}
