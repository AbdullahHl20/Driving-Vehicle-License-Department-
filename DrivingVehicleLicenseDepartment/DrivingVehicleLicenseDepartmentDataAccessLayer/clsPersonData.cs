using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingVehicleLicenseDepartmentDataAccessLayer
{
    public class clsPersonData
    {
        public static bool UpdatePerson(int PersonID , string NationalNo,
            string FirstName,string LastName,string SecondName,string ThirdName,
            DateTime DateOfBirth, short Gendor ,string Address,string Phone, string Email, int NationalityCountryID, string ImagePath
            )
        {
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string selectQuery = "UPDATE [dbo].[People] SET [NationalNo] = @NationalNo,[FirstName] =@FirstName ," +
                "[SecondName] =@SecondName,[ThirdName] =@ThirdName ,[LastName] =@LastName ," +
                "[DateOfBirth] =@DateOfBirth ,[Gendor] =@Gendor ,[Address] =@Address," +
                "[Phone] =@Phone ,[Email] =@Email ," +
                "[NationalityCountryID] =@NationalityCountryID,[ImagePath] =@ImagePath  WHERE [PersonID] =@PersonID ";
            SqlCommand cmd = new SqlCommand(selectQuery , sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID" , PersonID);
            cmd.Parameters.AddWithValue("@NationalNo" , NationalNo);
            cmd.Parameters.AddWithValue("@FirstName" , FirstName);
            cmd.Parameters.AddWithValue("@SecondName" , SecondName);
            cmd.Parameters.AddWithValue("@ThirdName" , ThirdName);
            cmd.Parameters.AddWithValue("@LastName" , LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth" , DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor" , Gendor);
            cmd.Parameters.AddWithValue("@Address" , Address);
            cmd.Parameters.AddWithValue("@Phone" , Phone);
            cmd.Parameters.AddWithValue("@Email" , Email);
            cmd.Parameters.AddWithValue("@NationalityCountryID" , NationalityCountryID);
            cmd.Parameters.AddWithValue("@ImagePath" , ImagePath);

            try
            {
                sqlConnection.Open();
                bool isUpdated = cmd.ExecuteNonQuery() != 0;
                sqlConnection.Close();
                return isUpdated;

            }
            catch ( Exception ex )
            {
                return false;
            }

        }  public static int AddNewPerson(string NationalNo,
            string FirstName,string LastName,string SecondName,string ThirdName,
            DateTime DateOfBirth, short Gendor ,string Address,string Phone, string Email, int NationalityCountryID, string ImagePath
            )
        {
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string selectQuery = "INSERT INTO [People](" +
                "[NationalNo],[FirstName],[SecondName],[ThirdName],[LastName]" +
                ",[DateOfBirth],[Gendor],[Address],[Phone],[Email],[NationalityCountryID],[ImagePath]) " +
                "Values(@NationalNo,@FirstName,@SecondName,@ThirdName," +
                "@LastName,@DateOfBirth,@Gendor,@Address," +
                "@Phone,@Email,@NationalityCountryID,@ImagePath);" +
                "select SCOPE_IDENTITY() ;";
            SqlCommand cmd = new SqlCommand(selectQuery , sqlConnection);
            cmd.Parameters.AddWithValue("@NationalNo" , NationalNo);
            cmd.Parameters.AddWithValue("@FirstName" , FirstName);
            cmd.Parameters.AddWithValue("@SecondName" , SecondName);
            cmd.Parameters.AddWithValue("@ThirdName" , ThirdName);
            cmd.Parameters.AddWithValue("@LastName" , LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth" , DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor" , Gendor);
            cmd.Parameters.AddWithValue("@Address" , Address);
            cmd.Parameters.AddWithValue("@Phone" , Phone);
            cmd.Parameters.AddWithValue("@Email" , Email);
            cmd.Parameters.AddWithValue("@NationalityCountryID" , NationalityCountryID);
            cmd.Parameters.AddWithValue("@ImagePath" , ImagePath);

            try
            {
                sqlConnection.Open();

                object result = cmd.ExecuteScalar();


                if ( result != null && int.TryParse(result.ToString() , out int insertedID) )
                {
                    return insertedID;
                }
                sqlConnection.Close();
                return - 1 ;

            }
            catch ( Exception ex )
            {
                return -1;
            }

        }

        public static bool GetPersonInfoByNationalNo(string NationalNo , ref int PersonID , ref string FirstName , ref string SecondName ,
       ref string ThirdName , ref string LastName , ref DateTime DateOfBirth ,
        ref short Gendor , ref string Address , ref string Phone , ref string Email ,
        ref int NationalityCountryID , ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query , connection);

            command.Parameters.AddWithValue("@NationalNo" , NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if ( reader.Read() )
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int) reader["PersonID"];
                    FirstName = (string) reader["FirstName"];
                    SecondName = (string) reader["SecondName"];

                    //ThirdName: allows null in database so we should handle null
                    if ( reader["ThirdName"] != DBNull.Value )
                    {
                        ThirdName = (string) reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string) reader["LastName"];
                    DateOfBirth = (DateTime) reader["DateOfBirth"];
                    Gendor = (byte) reader["Gendor"];
                    Address = (string) reader["Address"];
                    Phone = (string) reader["Phone"];

                    //Email: allows null in database so we should handle null
                    if ( reader["Email"] != DBNull.Value )
                    {
                        Email = (string) reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountryID = (int) reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if ( reader["ImagePath"] != DBNull.Value )
                    {
                        ImagePath = (string) reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch ( Exception ex )
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static DataTable GetAllPerson()
        {
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string selectQuery = "select * from People";
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

    }
}
