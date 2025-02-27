using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingVehicleLicenseDepartmentDataAccessLayer
{
    public class clsCountryData
    {
        public static bool Find( int CountryId , ref string CountryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string selectquery = "SELECT * FROM Countries WHERE CountryId = @CountryId";

            SqlCommand command = new SqlCommand(selectquery , connection);

            command.Parameters.AddWithValue("@CountryId" , CountryId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = reader["CountryName"].ToString();
                    return true;
                }
              return isFound;

            }
            catch 
            {
                return isFound;
            }
        }
        public static DataTable GetAllCountries()
        {
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string selectQuery = "select * from Countries";
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
    }
}
