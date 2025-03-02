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
        public static bool UpdateUser(int PersonId ,int UserId, string UserName , string PassWord , bool IsActive)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);


                const string cmd = "UPDATE [dbo].[Users]   SET [PersonID] =@PersonId,[UserName] =@UserName " +
                    "  ,[Password] =@Password    ,[IsActive] = @IsActive WHERE UserID =@UserId ";
                SqlCommand sqlCommand = new SqlCommand(cmd , sqlConnection);
                sqlCommand.Parameters.Add("@UserName" , UserName);
                sqlCommand.Parameters.Add("@PassWord" , PassWord);
                sqlCommand.Parameters.Add("@PersonId" , PersonId);
                sqlCommand.Parameters.Add("@UserId" , UserId);
                sqlCommand.Parameters.Add("@IsActive" , IsActive);
                sqlConnection.Open();

                bool isUpdated = sqlCommand.ExecuteNonQuery() > 0;
                sqlConnection.Close();
                return isUpdated;

            }
            catch ( Exception e )
            {

                return false ;
            }

        }
        public static int AddNewUser(int PersonId , string UserName , string Password , bool IsActive)
        {
            string insertQuery = "INSERT INTO [Users]([PersonID],[UserName],[Password],[IsActive] )" +
                "Values(@PersonID,@UserName,@Password,@IsActive);" +
                "select SCOPE_IDENTITY() ;";

            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand cmd = new SqlCommand(insertQuery, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID" , PersonId);
            cmd.Parameters.AddWithValue("@UserName" , UserName);
            cmd.Parameters.AddWithValue("@Password" , Password);
            cmd.Parameters.AddWithValue("@IsActive" , IsActive);

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
        public static bool FindByUserId(string UserName, string PassWord, int UserId, ref int PersonId, ref bool IsActive) 
        {

            bool isFound = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);


                const string cmd = "select * from Users where UserId=@UserId";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@UserId", UserId);
              
                sqlConnection.Open();

                SqlDataReader DataReader = sqlCommand.ExecuteReader();


                if (DataReader.Read())
                {
                    isFound  =  true;
                    UserId   =  (int)DataReader["UserId"];
                    PersonId =  (int)DataReader["PersonId"];
                    IsActive =  (bool)DataReader["IsActive"];
                    PassWord =  (string)DataReader["Password"];
                    UserName =  (string)DataReader["UserName"];

                }
                sqlConnection.Close();


                return isFound;

            }
            catch (Exception ex)
            {
                return isFound;
            }
        }
        public static bool FindByUserNameAndPassword(string UserName, string PassWord, ref int UserId, ref int PersonId, ref bool IsActive)
        {

            bool isFound = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);


                const string cmd = "select * from Users where UserName=@UserName and PassWord=@PassWord ";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@UserName", UserName);
                sqlCommand.Parameters.AddWithValue("@PassWord", PassWord);
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

            string selectQuery = " select UserID , users.PersonID, person.FirstName + person.SecondName + person.ThirdName + person.LastName  FullName  ,  UserName,IsActive from Users users\r\nINNER JOIN People person on person.PersonID = users.PersonID";
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
