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

        public static DataTable GetAllCountries()
        {
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string selectQuery = "select * from Countries";
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
