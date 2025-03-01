using DrivingVehicleLicenseDepartmentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDrivingVehicleLicenseDepartment
{
    public class clsUser
    {
        public enum enSaveMode { Add, Update }
        #region Fields
        public int UserId { set; get; }
        public int PersonId { set; get; }
        public string UserName { set; get; }
        public string PassWord { set; get; }
        public bool IsActive { set; get; }
        #endregion

        #region constructor
        public clsUser()
        {
            this.UserId = 0;
            this.PersonId = 0;
            this.UserName = "";
            this.PassWord = "";
            this.IsActive = true;

        }
        public clsUser(int UserId , int PersonId , string UserName , string PassWord , bool IsActive)
        {
            this.UserId = UserId;
            this.PersonId = PersonId;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.IsActive = IsActive;

        }
        #endregion

        #region Funactions
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static clsUser FindByUserNameAndPassword(string UserName, string PassWord)
        {
           
           int UserId = 0 , PersonId =  0; bool IsActive=false;

           bool isfound = clsUserData.FindByUserNameAndPassword(UserName, PassWord, ref UserId, ref PersonId,ref IsActive);

            if (isfound == true)
                return new clsUser(UserId, PersonId, UserName, PassWord, IsActive);
            else
               return null;
        }


        #endregion
    }
}
