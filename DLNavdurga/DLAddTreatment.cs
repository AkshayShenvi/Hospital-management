using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLNavdurga
{
    public class DLAddTreatment
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetTreatmentType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static DataTable GetTreatmentDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static bool SaveTreatmentDetails(string sQuery, DataTable dtTreatment)
        {
            return DLCommon.SaveDataTable(sQuery, dtTreatment);
        }
    }
}
