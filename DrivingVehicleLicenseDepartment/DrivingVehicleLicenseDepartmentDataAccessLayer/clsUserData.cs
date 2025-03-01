using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingVehicleLicenseDepartmentDataAccessLayer
{
    public class clsUserData
    {
        #region AddNewUser
        public static int addNewUser()
        {
            string insertQuery = "INSERT INTO [Users](" +
                "[UserId],[UserName],[Password],[IsActive]" +
                "Values(@UserId,@UserName,@Password,@IsActive);" +
                "select SCOPE_IDENTITY() ;";

            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand cmd = new SqlCommand(insertQuery, sqlConnection);

            try
            {
                sqlConnection.Open();

                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID;
                }
                sqlConnection.Close();
                return -1;

            }
            catch (Exception ex)
            {
                return -1;

            }
        }
        #endregion
        #region GetAllUsers

        public int UserId { set; get; }
        public int PersonId { set; get; }
        public string UserName { set; get; }
        public string PassWord { set; get; }
        public bool IsActive { set; get; }
        public static bool FindByUserNameAndPassword(string UserName, string PassWord, ref int UserId, ref int PersonId, ref bool IsActive)
        {

            bool isFound = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);


                const string cmd = "select * from Users where UserName=@UserName and PassWord=@PassWord ";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.Add("@UserName", UserName);
                sqlCommand.Parameters.Add("@PassWord", PassWord);
                sqlConnection.Open();
                
                SqlDataReader DataReader = sqlCommand.ExecuteReader();
               

                if (DataReader.Read()) 
                {
                    isFound = true;
                    UserId =(int) DataReader["UserId"];
                    PersonId = (int) DataReader["PersonId"];
                    IsActive = (bool) DataReader["IsActive"];


                }
                sqlConnection.Close();


                return isFound;

            }
            catch (Exception ex)
            {
                return isFound;
            }

        }
        public static DataTable GetAllUsers()
        {
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string selectQuery = "select UserID , PersonID, UserName,IsActive from Users";
            SqlCommand cmd = new SqlCommand(selectQuery, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                sqlConnection.Close();
                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion
    }
}
