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
            SqlCommand cmd = new SqlCommand(insertQuery , sqlConnection);

            try
            {
                sqlConnection.Open();

                object result = cmd.ExecuteScalar();


                if ( result != null && int.TryParse(result.ToString() , out int insertedID) )
                {
                    return insertedID;
                }
                sqlConnection.Close();
                return -1;

            }
            catch ( Exception ex )
            {
                return -1;

            }
        }
        #endregion
        #region GetAllUsers
        public static DataTable GetAllUsers()
        {
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string selectQuery = "select * from Users";
            SqlCommand cmd = new SqlCommand(selectQuery , sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                sqlConnection.Close();
                return dt;

            }
            catch ( Exception ex )
            {
                return null;
            }

        }
        #endregion
    }
}
