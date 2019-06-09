using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLNavdurga
{
   public class DLAddPatientDetails
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetDateType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static DataTable GetPatientDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static bool SavePatientDetails(string sQuery, DataTable dtPatientDetails)
        {
            return DLCommon.SaveDataTable(sQuery, dtPatientDetails);
        }
        public static DataTable SavePDetails(string sQuery)
        {
            return DLCommon.SaveDetails(sQuery);
        }

    }
}
