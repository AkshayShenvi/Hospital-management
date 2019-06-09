using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace DLNavdurga
{
    public class DLAddAdminConfig
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetAdminConfigDetailsType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        
        public static bool SaveAdminConfigDetails(string sQuery, DataTable dtkey)
        {
            return DLCommon.SaveDataTable(sQuery, dtkey);
        }
    }
}
