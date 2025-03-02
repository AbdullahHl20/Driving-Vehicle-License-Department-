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
        public enSaveMode SaveMode { set; get; }
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
            this.SaveMode = enSaveMode.Add;
            this.IsActive = true;

        }
        public clsUser(int UserId , int PersonId , string UserName , string PassWord , bool IsActive)
        {
            this.UserId = UserId;
            this.PersonId = PersonId;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.IsActive = IsActive;
            this.SaveMode = enSaveMode.Update;
        }
        #endregion

        #region Funactions

        public bool Save()
        {
            switch ( SaveMode )
            {
                case enSaveMode.Add:
                {
                    if ( _AddNewUser() )
                    {

                        SaveMode = enSaveMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                case enSaveMode.Update:

                    return _UpdateUser();
            }
            return false;
        }
        private bool _AddNewUser()
        {
            this.UserId = clsUserData.AddNewUser(this.PersonId , this.UserName , this.PassWord , this.IsActive);

            return this.PersonId != -1;

        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.PersonId , this.UserId,this.UserName, this.PassWord, this.IsActive);
            

        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static clsUser FindByUserNameAndPassword(string UserName, string PassWord)
        {
           
           int UserId = 0 , PersonId =  0; bool IsActive = false;

           bool isfound = clsUserData.FindByUserNameAndPassword(UserName, PassWord, ref UserId, ref PersonId,ref IsActive);

            if (isfound == true)
                return new clsUser(UserId, PersonId, UserName, PassWord, IsActive);
            else
               return null;
        }

        public static clsUser FindByUserId(int UserId)
        {
            int  PersonId = 0; bool IsActive = false;
            string UserName = "", PassWord = "";    
            bool isfound = clsUserData.FindByUserId(UserName, PassWord, UserId, ref PersonId, ref IsActive);

            if (isfound == true)
                return new clsUser(UserId, PersonId, UserName, PassWord, IsActive);
            else
                return null;
        }


        #endregion
    }
}
