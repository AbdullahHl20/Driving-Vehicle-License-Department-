namespace BusinessLayerDrivingVehicleLicenseDepartment
{
    public class clsPerson
    {

        public clsPerson()
        {
            
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
