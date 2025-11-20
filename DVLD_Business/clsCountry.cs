using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsCountry
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
        public clsCountry()
        {
            this.ID = -1;
            this.CountryName = string.Empty;
        }
        private clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }
        public static clsCountry Find(int ID,ref Exception exception)
        {
            string CountryName = "";
            return clsCountryData.GetCountryInfoByID(ID, ref CountryName, ref exception) ?
            new clsCountry(ID, CountryName) : new clsCountry();
        }
        public static clsCountry Find(string CountryName, ref Exception exception)
        {
            int ID = -1;
            return clsCountryData.GetCountryInfoByName(CountryName, ref ID, ref exception) ?
             new clsCountry(ID, CountryName) : new clsCountry();
        }
        public static DataTable GetAllCountries(ref Exception exception)
        {
            return clsCountryData.GetAllCountries(ref exception);
        }
    }
}
