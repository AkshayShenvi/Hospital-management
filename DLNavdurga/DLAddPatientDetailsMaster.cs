using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLNavdurga
{
    public class DLAddPatientDetailsMaster
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetPatientName(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static DataTable GetPatientDetailsMaster(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static bool SavePatientDetailsMaster(string sQuery, DataTable dtPatientDetailsMaster)
        {
            return DLCommon.SaveDataTable(sQuery, dtPatientDetailsMaster);
        }
    }
}
