using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int ID,ref string CountryName,ref Exception exception)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select CountryName from Countries WHERE CountryID = @ID;";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    result = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally { connection.Close(); }
            return result;
        }
        public static bool GetCountryInfoByName(string CountryName,ref int ID,ref Exception exception)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select CountryID from Countries WHERE CountryName = @CountryName;";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["CountryID"];
                    result = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally { connection.Close(); }
            return result;
        }
        public static DataTable GetAllCountries(ref Exception exception)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CountryID");
            dt.Columns.Add("CountryName");
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Countries ORDER BY CountryName;";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                //connection.Open();
                //SqlDataReader reader = command.ExecuteReader();
                ////if (reader.Read())
                ////{

                ////    dt.Load(reader);
                ////}
                //while (reader.Read())
                //{
                //    dt.Rows.Add( reader["CountryID"] , reader["CountryName"]);
                //}
                //reader.Close();
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                dt.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally { connection.Close(); }
            return dt;
        }
    }
}
