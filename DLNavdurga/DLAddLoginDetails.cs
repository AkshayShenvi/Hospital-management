using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLNavdurga
{
    public class DLAddLoginDetails
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetLoginType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static DataTable GetLoginDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static bool SaveLoginDetails(string sQuery, DataTable dtLogin)
        {
            return DLCommon.SaveDataTable(sQuery, dtLogin);
        }
    }
}
