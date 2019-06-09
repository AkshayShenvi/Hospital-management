using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DLNavdurga
{
    public class DLAddInvestigation
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetInvestigationType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static DataTable GetInvestigationDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static bool SaveInvestigationDetails(string sQuery, DataTable dtInvestigation)
        {
            return DLCommon.SaveDataTable(sQuery, dtInvestigation);
        }
    }
}
