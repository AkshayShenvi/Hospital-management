using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DLNavdurga
{
    public class DLAddPrescription
    {
        public static DataTable GetData()
        {   
            DataTable dt = new DataTable();
            return dt;
        }

        public static DataTable GetMedicineType(string sQuery)
        {
                 return DLCommon.GetDataTable(sQuery);
        }

        public static DataTable GetPrescriptionDetails(string sQuery)
        {
            return DLCommon.GetDataTable(sQuery);
        }

        public static bool SavePrescriptionDetails(string sQuery, DataTable dtPrescription)
        {
            return DLCommon.SaveDataTable(sQuery,dtPrescription);
        }
    }
}
