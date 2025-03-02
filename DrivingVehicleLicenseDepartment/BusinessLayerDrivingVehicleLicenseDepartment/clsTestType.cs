using DrivingVehicleLicenseDepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDrivingVehicleLicenseDepartment
{
    public class clsTestType
    {

        public int Id { get; set; }

        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }

        public static DataTable GetAllTestType()
        {
            return clsTestTypeData.GetAllTestType();

        
        }
    }
}
