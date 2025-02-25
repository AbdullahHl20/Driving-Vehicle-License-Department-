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
        public clsCountry() { }

        public int CountryId { set; get; }
        public string CountryName { set; get; }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

    }
}
