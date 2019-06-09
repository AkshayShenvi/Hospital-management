using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace DLNavdurga
{
   public class DLAddComplaints
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetComplaintsType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static DataTable GetComplaintsDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static bool SaveComplaintsDetails(string sQuery, DataTable dtComplaints)
        {
            return DLCommon.SaveDataTable(sQuery, dtComplaints);
        }
    }
}
