using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestTypeData
    {
        public static DataTable GetAllTestTypes(ref Exception exception)
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT TestTypeID as ID, TestTypeTitle as Title,TestTypeDescription as Description, TestTypeFees as Fees FROM TestTypes";
            SqlCommand command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                dt.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return dt;
        }
        public static bool UpdateTestType(int ID, string Title,string Description, float Fees, ref Exception exception)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Update TestTypes Set TestTypeTitle = @Title,TestTypeDescription = @Description, TestTypeFees = @Fees Where TestTypeID = @ID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Description", Description);
            try
            {
                Connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return RowAffected != 0;
        }
    }
}
