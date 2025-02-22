namespace BusinessLayerDrivingVehicleLicenseDepartment
{
    public class clsPerson
    {

        public clsPerson()
        {
            
        } 
        public clsPerson(string NationalNo , string FirstName, string  SecondName, string ThirdName,
           string LastName, DateTime DateOfBirth, byte Gendor, string Phone ,
           string  Email, int NationalityCountryID, string? ImagePath)
        {
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Phone = Phone;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            
        }
        public int PersonId { get; set; }

        public string? NationalNo { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? ThirdName { get; set; }
        public string? LastName { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int? NationalityCountryID { get; set; }
        public string? ImagePath { get; set; }
        
        


    }
}
