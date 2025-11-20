using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
            , ref string NationalNo, ref DateTime DateOfBirth, ref byte Gendor,ref string Address, ref string Phone, ref string Email
            , ref int NationalityCountryID, ref string ImagePath, ref Exception exception)
        {
            bool IsExist = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();

                    string Query = "Select * from People Where PersonID = @PersonID";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID", PersonID);

                        try
                        {
                            using (SqlDataReader Reader = Command.ExecuteReader())
                            {

                                if (Reader.Read())
                                {
                                    FirstName = (string)Reader["FirstName"];
                                    SecondName = (string)Reader["SecondName"];
                                    ThirdName = (string)Reader["ThirdName"];
                                    LastName = (string)Reader["LastName"];
                                    NationalNo = (string)Reader["NationalNo"];
                                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                                    Gendor = (byte)Reader["Gendor"];
                                    Address = (string)Reader["Address"];
                                    Phone = (string)Reader["Phone"];
                                    Email = Reader["Email"] == DBNull.Value ? "" : (string)Reader["Email"];
                                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                                    ImagePath = Reader["ImagePath"] == DBNull.Value ? "" : (string)Reader["ImagePath"];
                                    IsExist = true;
                                }
                                //Reader.Close();
                            }
                        }
                        catch (Exception ex) { exception = ex; }
                        //finally { Connection.Close(); }
                    }
                } 
            }
            catch (SqlException ex)
            {
                exception = ex;
            }
                    return IsExist;
            
            
        }
        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName
            , ref string SecondName, ref string ThirdName, ref string LastName
            , ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email
            , ref int NationalityCountryID, ref string ImagePath, ref Exception exception)
        {

            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from People Where NationalNo = @NationalNo";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    PersonID = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Gendor = (byte)Reader["Gendor"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = Reader["Email"] == DBNull.Value ? "" : (string)Reader["Email"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    ImagePath = Reader["ImagePath"] == DBNull.Value ? "" : (string)Reader["ImagePath"];
                    IsExist = true;
                }
                Reader.Close();
            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return IsExist;
        }
        public static int AddNewPerson( string FirstName, string SecondName, string ThirdName, string LastName
            , string NationalNo, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email
            , int NationalityCountryID, string ImagePath, ref Exception exception)
        {
            object Result = null;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into People (FirstName,SecondName,ThirdName,LastName,NationalNo,
                            DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) Values
                            (@FirstName,@SecondName,@ThirdName,@LastName,@NationalNo,
                            @DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath); Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName",FirstName);
            Command.Parameters.AddWithValue("@SecondName",SecondName);
            Command.Parameters.AddWithValue("@ThirdName",ThirdName);
            Command.Parameters.AddWithValue("@LastName",LastName);
            Command.Parameters.AddWithValue("@NationalNo",NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor",Gendor);
            Command.Parameters.AddWithValue("@Address",Address);
            Command.Parameters.AddWithValue("@Phone",Phone);
            if (!string.IsNullOrEmpty(Email))
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email",DBNull.Value);
            Command.Parameters.AddWithValue("@NationalityCountryID",NationalityCountryID);
            if (!string.IsNullOrEmpty(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath",DBNull.Value);
            try
            {
                Connection.Open();
                Result = Command.ExecuteScalar();
            }
            catch(Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return Result == null ? -1 : Convert.ToInt32(Result);
        }
        public static bool UpdatePerson(int? PersonID, string FirstName, string SecondName, string ThirdName, string LastName
            , string NationalNo, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email
            , int NationalityCountryID, string ImagePath, ref Exception exception)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update People Set FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName,
                            LastName = @LastName, NationalNo = @NationalNo, DateOfBirth = @DateOfBirth, Gendor = @Gendor,
                            Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID,
                            ImagePath = @ImagePath Where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            if (!string.IsNullOrEmpty(Email))
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (!string.IsNullOrEmpty(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch(Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return RowAffected > 0;

        }
        public static DataTable GetAllPeople(ref Exception exception)
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    Connection.Open();
                        string Query = @"SELECT        People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName
                                    , People.LastName, People.DateOfBirth, Gendor =
                                    case
                                    When People.Gendor = 0 then 'Male'
                                    When People.Gendor = 1 then 'Female'
                                    end
                                    , People.Address, People.Phone, People.Email
                                    , Countries.CountryName AS Nationality, People.ImagePath
                                    FROM          
                                    People INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {

                        try
                        {
                            using (SqlDataReader Reader = Command.ExecuteReader())
                            {

                                dt.Load(Reader);
                                //Reader.Close();
                            }
                        }
                        catch (Exception ex) { exception = ex; }
                        //finally { Connection.Close(); }
                    }
                }
            }
            catch(SqlException ex) { exception = ex; }
            return dt;
        }
        public static bool DeletePerson(int PersonID,ref Exception exception)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From People Where PersonID = @PersonID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID",PersonID);
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch(Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return RowAffected > 0;
        }
        public static bool IsPersonExist(int PersonID, ref Exception exception)
        {
            object result = null;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select x = 1 from People WHERE PersonID = @PersonID;";
            SqlCommand Command = new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                result = Command.ExecuteScalar();

            }
            catch (Exception ex) { exception = ex; }    finally { Connection.Close(); }
            return result != null;
        }
        public static bool IsPersonExist(string NationalNo,ref Exception exception)
        {

            object result = null;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select x = 1 from People WHERE NationalNo = @NationalNo;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();
                result = Command.ExecuteScalar();

            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return result != null;
        }
    }
}
