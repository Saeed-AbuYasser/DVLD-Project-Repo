using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        public static DataTable GetAllApplicationTypes( Exception exception)
        {
            return clsApplicationTypeData.GetAllApplicationTypes( exception);
        }
        public static bool UpdateApplicationType(int ID, string Title, float Fees, Exception exception)
        {
            return clsApplicationTypeData.UpdateApplicationType(ID, Title, Fees, exception);
        }
    }
}
