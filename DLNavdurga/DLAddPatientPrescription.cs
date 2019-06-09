using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
 

namespace DLNavdurga
{
    public class DLAddPatientPrescription
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetPatientPrescriptionType(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static DataTable GetPatientPrescriptionDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }
        public static bool SavePatientPrescriptionDetails(string sQuery, DataTable dtPatientPrescription)
        {
            return DLCommon.SaveDataTable(sQuery, dtPatientPrescription);
        }
    }
}
