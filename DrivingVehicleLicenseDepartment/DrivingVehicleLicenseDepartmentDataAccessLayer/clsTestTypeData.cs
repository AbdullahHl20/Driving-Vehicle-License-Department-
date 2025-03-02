using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingVehicleLicenseDepartmentDataAccessLayer
{
    public class clsTestTypeData
    {

        public static DataTable GetAllTestType()
        {
            const string select = "select * from TestTypes";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                SqlCommand sqlCommand = new SqlCommand(select , sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(sqlDataReader);

                sqlConnection.Close();
                return dataTable;
            }
            catch ( Exception ex )
            {
                return null;
            }

        }
    }
}
