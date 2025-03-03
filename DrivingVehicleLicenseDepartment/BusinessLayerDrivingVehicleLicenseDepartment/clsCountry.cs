using DrivingVehicleLicenseDepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDrivingVehicleLicenseDepartment
{
    public class clsCountry
    {

        #region Fields
        public int CountryId { set; get; }
        public string CountryName { set; get; }
        #endregion 

        public clsCountry() { }
        public clsCountry(int CountryId, string CountryName) 
        { 
            this.CountryId = CountryId;
            this.CountryName = CountryName;
        }
        
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

        public static clsCountry Find(int CountryID)
        {
            string  CountryName = "";
            bool IsFound = clsCountryData.Find(CountryID , ref CountryName);
            if (IsFound) 
            {
                return new clsCountry(CountryID , CountryName);
            }
            return null;
        }

    }
}
