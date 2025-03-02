using DrivingVehicleLicenseDepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDrivingVehicleLicenseDepartment
{
    public class clsApplicationType
    {
        public int Id { set; get; }

        public string Title { set; get; }

        public int Fees { set; get; }

        public static DataTable GetAllApplicationsType() 
        {
            return clsApplicationTypeData.GetAllApplicationsType();
        }

    }
}
