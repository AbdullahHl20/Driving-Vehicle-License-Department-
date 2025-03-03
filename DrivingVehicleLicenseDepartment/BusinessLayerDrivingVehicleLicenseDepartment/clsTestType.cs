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
        #region Fields
        public int Id { get; set; }

        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public double TestTypeFees { get; set; }
        #endregion

        #region Private 
        private bool _Update()
        {
            return clsTestTypeData.Update(this.Id, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
        #endregion

        #region Public
        public bool Save()
        {
            return _Update();
        }
      

        public clsTestType(int Id, string TestTypeTitle, string TestTypeDescription, double TestTypeFees)
        {
            this.Id = Id;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }

        public static DataTable GetAllTestType()
        {
            return clsTestTypeData.GetAllTestType();
        }

        public static clsTestType FindById(int id)
        {

            string TestTypeTitle = "", TestTypeDescription = ""; double TestTypeFees = 0.0;
            bool isfound = clsTestTypeData.FindById(id, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);
            if (isfound)
                return new clsTestType(id, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;
        }
        #endregion
    }
}
