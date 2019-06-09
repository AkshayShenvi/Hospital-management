using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLNavdurga
{
    public class DLAddComorbidities
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetComorbiditiesType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static DataTable GetComorbiditiesDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static bool SaveComorbiditiesDetails(string sQuery, DataTable dtComorbidities)
        {
            return DLCommon.SaveDataTable(sQuery, dtComorbidities);
        }
    }
}
