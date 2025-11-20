using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsUserData
    {
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,ref string Password, ref bool IsActive,ref Exception exception)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = ((bool) reader["IsActive"]);
                    result = true;
                }
                else result = false;
                reader.Close();
            }
            catch(Exception ex) {exception = ex; result = false; }
            finally { connection.Close(); }
            return result;
        }
        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive,ref Exception exception)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Users Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (byte)reader["IsActive"] == 1;
                    result = true;
                }
                else result = false;
                reader.Close();
            }
            catch (Exception ex) { exception = ex; result = false; }
            finally { connection.Close(); }
            return result;
        }
        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password, ref int PersonID, ref int UserID, ref bool IsActive,ref Exception exception)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Users Where UserName = @UserName AND Password = @Password";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = Convert.ToByte(reader["IsActive"]) == 1;
                    result = true;
                }
                else result = false;
                reader.Close();
            }
            catch (Exception ex) { exception = ex; result = false; }
            finally { connection.Close(); }
            return result;
        }
        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive,ref Exception exception)
        {
            int Result = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Users (PersonID,UserName,Password,IsActive)Values
                            (@PersonID,@UserName,@Password,@IsActive); SELECT SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                Connection.Open();
                Result = Convert.ToInt32(Command.ExecuteScalar());

            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return Result;
        }
        public static bool UpdateUser(int UserID, int PersonID, string UserName,string Password, bool IsActive, ref Exception exception)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Users Set PersonID = @PersonID,UserName = @UserName
                            ,Password = @Password,IsActive = @IsActive WHERE UserID = @UserID";
                            
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return RowAffected != 0;
        }
        public static DataTable GetAllUsers(ref Exception exception)
        {
            DataTable Result = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select Users.UserID,Users.PersonID,People.FirstName + ' ' +People.SecondName +
                            ' ' + People.ThirdName + ' ' + People.LastName as FullName,Users.UserName,Users.IsActive
                            from Users INNER JOIN People ON Users.PersonID = People.PersonID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                Result.Load(Reader);
                Reader.Close();
            }
            catch(Exception ex) { exception = ex; } 
            finally { Connection.Close(); }
            return Result;
        }
        public static bool DeleteUser(int UserID,ref Exception exception)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete from Users Where UserID = @UserID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID",UserID);
            try
            {
                Connection.Open();
                RowAffected  = Command.ExecuteNonQuery();
                
            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return RowAffected > 0;
        }
        public static bool IsUserExist(int UserID,ref Exception exception)
        {
            bool Result = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select Y = 1 From Users Where UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                Connection.Open();
                Result = Command.ExecuteScalar()!=null;
            }
            catch( Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return Result;

        }
        public static bool IsUserExist(string UserName,ref Exception exception)
        {
            bool Result = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select Y = 1 From Users Where UserName = @UserName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                Result = Command.ExecuteScalar() != null;
            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return Result;
        }
        public static bool IsUserExistForPersonID(int PersonID, ref Exception exception)
        {
            bool Result = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select Y = 1 From Users Where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                Result = Command.ExecuteScalar() != null;
            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return Result;
        }
        public static bool ChangePassword(int UserID,string NewPassword,ref Exception exception)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Update Users Set Password = @NewPassword Where UserID = @UserID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@NewPassword", NewPassword);
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex) { exception = ex; }
            finally { Connection.Close(); }
            return RowAffected>0;
        }
    }
}
