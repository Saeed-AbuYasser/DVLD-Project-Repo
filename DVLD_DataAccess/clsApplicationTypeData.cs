using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationTypeData
    {
        public static DataTable GetAllApplicationTypes( Exception exception)
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT ApplicationTypeID as ID, ApplicationTypeTitle as Title, ApplicationFees as Fees FROM ApplicationTypes";
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
        public static bool UpdateApplicationType(int ID,string Title,float Fees,Exception exception)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Update ApplicationTypes Set ApplicationTypeTitle = @Title, ApplicationFees = @Fees Where ApplicationTypeID = @ID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@Title",Title);
            command.Parameters.AddWithValue("@Fees",Fees);
            command.Parameters.AddWithValue("@ID",ID);
            try
            {
                Connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }catch (Exception ex) { exception = ex; } finally { Connection.Close(); }
            return RowAffected != 0;
        }

    }
}
