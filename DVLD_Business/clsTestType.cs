using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestType
    {
        public static DataTable GetAllTestTypes(ref Exception exception)
        {
            return clsTestTypeData.GetAllTestTypes(ref exception);
        }
        public static bool UpdateTestType(int ID, string Title,string Description, float Fees, ref Exception exception)
        {
            return clsTestTypeData.UpdateTestType(ID, Title, Description, Fees, ref exception);
        }
    }
}
