using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DrivingVehicleLicenseDepartmentDataAccessLayer
{
    public class clsApplicationTypeData
    {
        public static bool FindById(int Applicationid, ref string ApplicationTypeTitle, ref double ApplicationTypePrice)
        {
            bool isfound = false;
            const string sqlQuery = " select ApplicationTypeTitle ,ApplicationFees from ApplicationTypes where ApplicationTypeID =@ApplicationTypeID";

            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", Applicationid);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    isfound = true;
                    ApplicationTypeTitle = (string)sqlDataReader["ApplicationTypeTitle"];
                    ApplicationTypePrice = Convert.ToDouble(sqlDataReader["ApplicationFees"]);
                }

                sqlConnection.Close();

                return isfound;

            }
            catch
            {
                return isfound;
            }
        }

        public static bool update(int ApplicationTypeId, string ApplicationTypeTitle, double ApplicationTypePrice)
        {
            bool isUpdated = false;
            const string sqlQuery = " UPDATE ApplicationTypes SET  ApplicationTypeTitle =@ApplicationTypeTitle , ApplicationFees =@ApplicationTypePrice WHERE  ApplicationTypeID =@ApplicationTypeID ";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeId);
                cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                cmd.Parameters.AddWithValue("@ApplicationTypePrice", ApplicationTypePrice);
                sqlConnection.Open();
                isUpdated = cmd.ExecuteNonQuery() > 0;


                sqlConnection.Close();

                return isUpdated;
            }
            catch
            {
                return isUpdated;
            }
        }
        public static DataTable GetAllApplicationsType()
        {
            const string select = "select * from ApplicationTypes";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(sqlDataReader);

                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
