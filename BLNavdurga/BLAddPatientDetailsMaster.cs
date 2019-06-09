using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;


namespace BLNavdurga
{
   public class BLAddPatientDetailsMaster
    {
        public static DataTable GetData()
        {
            return BLAddPatientDetailsMaster.GetData();
        }

        public static DataTable GetPatientName()
        {
            string sQuery = "Select 'All' PatientName Union SELECT distinct PatientName FROM db_navdurgahospital.tbl_patientmasterdetails;";

            return DLNavdurga.DLAddPatientDetailsMaster.GetPatientName(sQuery);
        }

        public static DataTable GetPatientDetailsMaster(string sPatientName)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientmasterdetails;";
            if (sPatientName == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_patientmasterdetails;";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_patientmasterdetails where PatientName = '" + sPatientName + "';";
            }
            return DLAddPatientDetailsMaster.GetPatientDetailsMaster(sQuery);
        }
        public static DataTable SearchPatientPhoneMasterDetails(string sPatientPhone)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientmasterdetails where PhoneNo like '%"+ sPatientPhone +"%';";
            return DLAddPatientDetailsMaster.GetPatientDetailsMaster(sQuery);

        }
        public static DataTable SearchPatientNameMasterDetails(string sPatientName)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientmasterdetails where PatientName like '%" + sPatientName + "%';";
            return DLAddPatientDetailsMaster.GetPatientDetailsMaster(sQuery);

        }
        public static DataTable SearchPatientNameAndPhoneMaster(string sPatientName, string sPatientPhone)
        {
            string sQuery = "SELECT * FROM db_navdurgahospital.tbl_patientmasterdetails where PatientName like'%" + sPatientName + "%' && PhoneNo like'%"+ sPatientPhone + "%';";
            return DLAddPatientDetailsMaster.GetPatientDetailsMaster(sQuery);
        }

        public static bool SavePatientDetailsMaster(DataTable dtPatientDetailsMaster)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientmasterdetails;";
            return DLAddPatientDetailsMaster.SavePatientDetailsMaster(sQuery, dtPatientDetailsMaster);
        }

        public static int GetPatientID()
        {
            string sQuery = "select Max(PatientIDMaster) from db_navdurgahospital.tbl_patientmasterdetails;";
            string str = DLCommon.ExecuteScalar(sQuery);
            return int.Parse(str);
        }
    }
}
