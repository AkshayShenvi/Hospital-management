using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;


namespace BLNavdurga
{
    public class BLAddDiagnosis
    {
        public static DataTable GetData()
        {
            return BLAddDiagnosis.GetData();
        }

        public static DataTable GetDiagnosisType()
        {
            string sQuery = "Select 'All' DiagnosisType Union SELECT distinct DiagnosisType FROM db_navdurgahospital.tbl_diagnosis;";
            return DLNavdurga.DLAddDiagnosis.GetDiagnosisType(sQuery);

        }

        public static DataTable GetDiagnosisDetails(string sDiagnosisType)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_diagnosis;";
            if (sDiagnosisType == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_diagnosis;";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_diagnosis where DiagnosisType = '" + sDiagnosisType + "';";
            }
            return DLAddDiagnosis.GetDiagnosisDetails(sQuery);
        }

        public static DataTable GetDiagnosis(string sDiagnosisType)
        {
            string sQuery = "select Diagnosis from db_navdurgahospital.tbl_diagnosis;";
            if (sDiagnosisType == "All")
            {
                sQuery = "select Diagnosis from db_navdurgahospital.tbl_diagnosis;";
            }
            else
            {
                sQuery = "select Diagnosis from db_navdurgahospital.tbl_diagnosis where DiagnosisType= '" + sDiagnosisType + "';";
            }
            return DLAddDiagnosis.GetDiagnosisDetails(sQuery);
        }

        public static bool SaveDiagnosisDetails(DataTable dtDiagnosis)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_diagnosis;";
            return DLAddDiagnosis.SaveDiagnosisDetails(sQuery, dtDiagnosis);
        }
    }
}
