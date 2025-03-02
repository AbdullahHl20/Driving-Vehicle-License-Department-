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

        public double Fees { set; get; }

        public clsApplicationType(int id , string Title , double Fees)
        {
            this.Id = id;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static DataTable GetAllApplicationsType()
        {
            return clsApplicationTypeData.GetAllApplicationsType();
        }

        public static clsApplicationType FindById(int Id)
        {
            string Title = ""; double Fees = 0;
            bool isfound = clsApplicationTypeData.FindById(Id , ref Title , ref Fees);

            if ( isfound )
                return new clsApplicationType(Id , Title , Fees);
            else
                return null;
        }
        private bool Update()
        {
            bool isUpdated = clsApplicationTypeData.update(this.Id , this.Title , this.Fees);

            return isUpdated;

        }

        public bool Save()
        {
            return Update();

        }

    }
}
