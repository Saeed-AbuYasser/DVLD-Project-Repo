using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsUser
    {
        public enum enMode { AddNew, Update };
        public enMode Mode {  get; set; }
        public int UserID { get; set; }
        private clsPerson _PersonInfo = new clsPerson();
        public clsPerson PersonInfo
        {
            get
            {
                return _PersonInfo;
            }
            set
            {
                if(value.PersonID != _PersonInfo.PersonID)
                {
                    _PersonInfo.PersonID = value.PersonID;
                }
                if (value.NationalNo != _PersonInfo.NationalNo)
                {
                    _PersonInfo.NationalNo = value.NationalNo;
                }
                if (value.FullName != _PersonInfo.FullName)
                {
                    _PersonInfo.FirstName = value.FirstName;
                    _PersonInfo.SecondName = value.SecondName;
                    _PersonInfo.ThirdName = value.ThirdName;
                    _PersonInfo.LastName = value.LastName;
                }
                if (value.Email != _PersonInfo.Email)
                {
                    _PersonInfo.Email = value.Email;
                }
                if (value.Phone != _PersonInfo.Phone)
                {
                    _PersonInfo.Phone = value.Phone;
                }
                if(value.NationalityCountryID != _PersonInfo.NationalityCountryID)
                {
                    _PersonInfo.NationalityCountryID = value.NationalityCountryID;
                }
                if (value.Address != _PersonInfo.Address)
                {
                    _PersonInfo.Address = value.Address;
                }
                if (value.DateOfBirth != _PersonInfo.DateOfBirth)
                {
                    _PersonInfo.DateOfBirth = value.DateOfBirth;
                }
                if (value.Gendor != _PersonInfo.Gendor)
                {
                    _PersonInfo.Gendor = value.Gendor;
                }
                if (value.ImagePath != _PersonInfo.ImagePath)
                {
                    _PersonInfo.ImagePath = value.ImagePath;
                }
                if (value.Mode != _PersonInfo.Mode)
                {
                    _PersonInfo.Mode = value.Mode;
                }
            }
            
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser Clone()
        {
            return new clsUser
            {
                Mode = this.Mode,
                UserID = this.UserID,
                PersonInfo = this.PersonInfo,
                UserName = this.UserName,
                Password = this.Password,
                IsActive = this.IsActive

            };
        }
        public bool Equals(clsUser other)
        {
            return other.UserID != this.UserID ? false :
                other.UserName != this.UserName ? false :
                other.Password != this.Password ? false :
                other.IsActive != this.IsActive ? false :
                !other.PersonInfo.Equals(this.PersonInfo) ? false :
                true;
        }
        public clsUser()
        {
            Mode = enMode.AddNew;
            UserID = -1;
            PersonInfo = new clsPerson();
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
        }
        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive,ref Exception exception)
        {
            Mode = enMode.Update;
            this.UserID = UserID ;
            this.PersonInfo = clsPerson.Find(PersonID, ref exception );
            this.UserName = UserName ;
            this.Password = Password ;
            this.IsActive = IsActive ;
        }

        private bool _AddNewUser(ref Exception exception)
        {
            return clsUserData.AddNewUser(PersonInfo.PersonID,UserName,Password,IsActive,ref exception) != -1;
        }
        private bool _UpdateUser(ref Exception exception)
        {
            return clsUserData.UpdateUser(UserID, PersonInfo.PersonID, UserName, Password, IsActive, ref exception);
        }
        public static clsUser FindByUserID(int UserID ,ref Exception exception)
        {
            int PersonID = -1; string UserName= string.Empty;string Password = string.Empty; bool IsActive = false;
            if (!clsUserData.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive, ref exception))
            {
                UserID = -1;
                return new clsUser();
            }
            return new clsUser(UserID,PersonID,UserName,Password,IsActive ,ref exception);

        }
        public static clsUser FindByPersonID(int PersonID ,ref Exception exception)
        {
            int UserID = -1; string UserName = string.Empty; string Password = string.Empty; bool IsActive = false;
            if(!clsUserData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive, ref exception))
            {
                PersonID = -1;
                return new clsUser();
            }
            return new clsUser(UserID, PersonID, UserName, Password, IsActive, ref exception);
        }
        public static clsUser FindByUsernameAndPassword(string Username, string Password ,ref Exception exception)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false;
            if(!clsUserData.GetUserInfoByUsernameAndPassword(Username,Password,ref PersonID, ref UserID,ref IsActive, ref exception))
            {
                Username = ""; Password = "";
                return new clsUser();
            }
            return new clsUser(UserID,PersonID,Username, Password, IsActive, ref exception);
        }

        public bool Save(ref Exception exception)
        {
            bool isSaved = false;
            switch (Mode)
            {
                case enMode.Update:
                    isSaved = _UpdateUser(ref exception);
                    break;
                case enMode.AddNew:
                    isSaved = _AddNewUser(ref exception);
                    if (isSaved)
                        Mode = enMode.Update;
                    break;
            }
            return isSaved;
        }

        public static DataTable GetAllUsers(ref Exception exception)
        {
            return clsUserData.GetAllUsers(ref exception);
        }
        public static bool DeleteUser(int UserID ,ref Exception exception)
        {
            return clsUserData.DeleteUser(UserID ,ref exception);
        }
        public static bool isUserExist(int UserID ,ref Exception exception)
        {
            return clsUserData.IsUserExist(UserID ,ref exception);
        }
        public static bool isUserExist(string Username ,ref Exception exception)
        {
            return clsUserData.IsUserExist(Username ,ref exception);
        }
        public static bool isUserExistForPersonID(int PersonID ,ref Exception exception)
        {
            return clsUserData.IsUserExistForPersonID (PersonID ,ref exception);
        }

    }
}
