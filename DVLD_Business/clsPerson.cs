using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew , Update};
        public enMode Mode = enMode.AddNew;

        public int PersonID {  get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get 
            {
                return (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(SecondName) &&
                    string.IsNullOrEmpty(ThirdName) && string.IsNullOrEmpty(LastName)) ?
                    string.Empty: FirstName +" "+ SecondName +" "+ ThirdName +" "+ LastName; 
            }
        }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor {  get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        private clsCountry _CountryInfo = new clsCountry();
        public int NationalityCountryID
        {
            get { return _CountryInfo.ID; }
            set
            {

                if (_CountryInfo.ID != value)
                {
                    Exception exception = null;
                    _CountryInfo = clsCountry.Find(value, ref exception);

                }

            }
        }
        /// <summary>
        /// Assign ID to integer (NationalityCountryID), and the value of this instance will be changed automatically.
        /// </summary>
        public clsCountry CountryInfo { get { return _CountryInfo; } }

        private string _ImagePath;

        public string ImagePath { get; set; }

        public clsPerson Clone()
        {
            return new clsPerson
            {
                PersonID = this.PersonID
                ,
                FirstName = this.FirstName
                ,
                SecondName = this.SecondName
                ,
                ThirdName = this.ThirdName
                ,
                LastName = this.LastName
                ,
                NationalNo = this.NationalNo
                ,
                DateOfBirth = this.DateOfBirth
                ,
                Gendor = this.Gendor
                ,
                Address = this.Address
                ,
                Phone = this.Phone
                ,
                Email = this.Email
                ,
                NationalityCountryID = this.NationalityCountryID
                ,
                ImagePath = this.ImagePath
                ,
                Mode = this.Mode

            };
        }
        public bool Equals(clsPerson other,bool ConsiderMode = false)
        {
            return
                other.PersonID != this.PersonID ? false :
                other.NationalNo != this.NationalNo ? false :
                other.FullName != this.FullName ? false :
                other.Email != this.Email ? false :
                other.Phone != this.Phone ? false :
                other.Address != this.Address ? false :
                other.ImagePath != this.ImagePath ? false :
                other.Gendor != this.Gendor ? false :
                other.DateOfBirth != this.DateOfBirth ? false :
                other.NationalityCountryID != this.NationalityCountryID ? false :
                ConsiderMode? this.Mode != other.Mode?false:true:
                true;


        }

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.DateOfBirth = new DateTime(DateTime.Now.Year - 18,DateTime.Now.Month,DateTime.Now.Day);
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalNo = string.Empty;
            this.NationalityCountryID = -1;
            this.ImagePath = string.Empty;
            this.Gendor = 2;
            this.Mode = enMode.AddNew;
        }
        private clsPerson(int PersonID,string FirstName,string SecondName,string ThirdName,string LastName
            ,string NationalNo,DateTime DateOfBirth,byte Gendor, string Address, string Phone, string Email
            , int NationalityCountryID,string ImagePath,ref Exception exception)
        {
            this.PersonID=PersonID;
            this.FirstName=FirstName;
            this.SecondName=SecondName;
            this.ThirdName=ThirdName;
            this.LastName=LastName;
            this.NationalNo=NationalNo;
            this.DateOfBirth=DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.Mode = enMode.Update;
        }

        private bool _AddNewPerson(ref Exception exception)
        {
            this.PersonID = clsPersonData.AddNewPerson(this.FirstName,this.SecondName,this.ThirdName,this.LastName,this.NationalNo,this.DateOfBirth
                ,this.Gendor,this.Address,this.Phone,this.Email,this.NationalityCountryID,this.ImagePath, ref exception);
            return this.PersonID != -1;
        }
        private bool _UpdatePerson(ref Exception exception)
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo,
                this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath, ref exception);
        }
        public static clsPerson Find(int PersonID,ref Exception exception)
        {
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string NationalNo = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";
            if(clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo,
                ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath, ref exception))
            {
                return new clsPerson(PersonID,FirstName,SecondName,ThirdName,LastName,NationalNo,DateOfBirth,Gendor,
                    Address,Phone,Email,NationalityCountryID,ImagePath,ref exception);

            }
            return new clsPerson();

        }
        public static clsPerson Find(string NationalNo,ref Exception exception)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";
            if (clsPersonData.GetPersonInfoByNationalNo(NationalNo,ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath, ref exception))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, 
                    DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath,ref exception);

            }
            return new clsPerson();
        }
        public bool Save(ref Exception exception)
        {
            bool result = false;
            if(Mode == enMode.AddNew)
            {
                if(_AddNewPerson(ref exception))
                {
                    result = true;
                    Mode = enMode.Update;
                }

            }
            else
            {
                if(_UpdatePerson(ref exception))
                    result = true;
            }
            return result;
        }
        public static DataTable GetAllPeople(ref Exception exception)
        {
            return clsPersonData.GetAllPeople(ref exception);
        }
        public static bool DeletePerson(int PersonID,ref Exception exception)
        {
            return clsPersonData.DeletePerson(PersonID,ref exception);
        }
        public static bool IsPersonExist(int PersonID,ref Exception exception)
        {
            return clsPersonData.IsPersonExist(PersonID,ref exception);
        }
        public static bool IsPersonExist(string NationalNo,ref Exception exception)
        {
            return clsPersonData.IsPersonExist(NationalNo, ref exception);
        }
    }
}
