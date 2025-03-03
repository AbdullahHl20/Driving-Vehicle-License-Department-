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
    public class clsTestTypeData
    {
        #region FindById
        public static bool FindById(int id, ref string TestTypeTitle, ref string TestTypeDescription, ref double TestTypeFees)
        {
            bool isfound = false;
            const string sqlQuery = " select TestTypeTitle ,TestTypeDescription, TestTypeFees from TestTypes  where TestTypeID =@TestTypeID ";

            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
                cmd.Parameters.AddWithValue("@TestTypeID", id);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    isfound = true;
                    TestTypeTitle = (string)sqlDataReader["TestTypeTitle"];
                    TestTypeDescription = (string)sqlDataReader["TestTypeDescription"];
                    TestTypeFees = Convert.ToDouble(sqlDataReader["TestTypeFees"]);
                }

                sqlConnection.Close();

                return isfound;

            }
            catch
            {
                return isfound;
            }

        }
        #endregion
        #region Update

        public static bool Update(int id,  string TestTypeTitle,  string TestTypeDescription,  double TestTypeFees)
        {
            bool isUpdated = false;
            const string sqlQuery = " UPDATE TestTypes SET  TestTypeTitle =@TestTypeTitle , TestTypeDescription =@TestTypeDescription,TestTypeFees=@TestTypeFees  WHERE  TestTypeID =@TestTypeID ";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
                cmd.Parameters.AddWithValue("@TestTypeID", id);
                cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
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

        #endregion
        #region GetAll
        public static DataTable GetAllTestType()
        {
            const string select = "select * from TestTypes";
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
        #endregion
    }

}