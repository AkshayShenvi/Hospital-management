using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLNavdurga
{
    public class DLAddDiagnosis
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetDiagnosisType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static DataTable GetDiagnosisDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static bool SaveDiagnosisDetails(string sQuery, DataTable dtDiagnosis)
        {
            return DLCommon.SaveDataTable(sQuery, dtDiagnosis);
        }
    }
}
