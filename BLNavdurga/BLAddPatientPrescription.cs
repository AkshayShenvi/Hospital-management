using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace BLNavdurga
{
   public class BLAddPatientPrescription
    {
        public static DataTable GetData()
        {
            return BLAddPatientPrescription.GetData();
        }

        public static DataTable GetPatientPrescriptionType()
        {
            string sQuery = "Select 'All' PrescriptionName Union SELECT distinct PrescriptionName FROM db_navdurgahospital.tbl_patientprescription;";
            return DLNavdurga.DLAddPatientPrescription.GetPatientPrescriptionType(sQuery);

        }

        public static DataTable GetPrescriptionReport(string sSrNo)
        {
            string sQuery = "SELECT PrescriptionName, Frequency as PerDay, Specification, TimesAWeek as PerWeek, TimePeriod as NoOfDays FROM db_navdurgahospital.tbl_patientprescription where srno ='" + sSrNo + "';";
            return DLCommon.GetDataTable(sQuery);
        }

        public static DataTable GetPatientPrescriptionDetails(string sSrNo)
        {
            
               string sQuery = "select * from db_navdurgahospital.tbl_patientprescription where SrNo = '" + sSrNo + "';";
           
            return DLAddPatientPrescription.GetPatientPrescriptionDetails(sQuery);
        }

       

        public static bool SavePatientPrescriptionDetails(DataTable dtPatientPrescription)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientprescription;";
            return DLAddPatientPrescription.SavePatientPrescriptionDetails(sQuery, dtPatientPrescription);
        }
    }
}
