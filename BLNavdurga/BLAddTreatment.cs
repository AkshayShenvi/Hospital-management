using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace BLNavdurga
{
    public class BLAddTreatment
    {
        public static DataTable GetData()
        {
            return BLAddTreatment.GetData();
        }

        public static DataTable GetTreatmentType()
        {
            string sQuery = "Select 'All' TreatmentType Union SELECT distinct TreatmentType FROM db_navdurgahospital.tbl_treatment;";

            return DLNavdurga.DLAddTreatment.GetTreatmentType(sQuery);
        }

        public static DataTable GetTreatmentDetails(string sTreatmentType)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_treatment;";
            if (sTreatmentType == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_treatment;";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_treatment where TreatmentType = '" + sTreatmentType + "';";
            }
            return DLAddTreatment.GetTreatmentDetails(sQuery);
        }

        public static DataTable GetTreatment(string sTreatmentType)
        {
            string sQuery = "select Treatment from db_navdurgahospital.tbl_treatment;";
            if (sTreatmentType == "All")
            {
                sQuery = "select Treatment from db_navdurgahospital.tbl_treatment;";
            }
            else
            {
                sQuery = "select Treatment from db_navdurgahospital.tbl_treatment where TreatmentType= '" + sTreatmentType + "';";
            }
            return DLAddTreatment.GetTreatmentDetails(sQuery);
        }

        public static bool SaveTreatmentDetails(DataTable dtTreatment)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_treatment;";
            return DLAddTreatment.SaveTreatmentDetails(sQuery, dtTreatment);
        }
    }
}
