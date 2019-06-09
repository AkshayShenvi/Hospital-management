using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;


namespace BLNavdurga
{
    public class BLAddInvestigation
    {
        public static DataTable GetData()
        {
            return BLAddInvestigation.GetData();
        }

        public static DataTable GetInvestigationType()
        {
            string sQuery = "Select 'All' Investigationtype Union SELECT distinct Investigationtype FROM db_navdurgahospital.tbl_investigation;";
            return DLNavdurga.DLAddInvestigation.GetInvestigationType(sQuery);

        }

        public static DataTable GetInvestigationDetails(string sInvestigationType)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_investigation;";
            if (sInvestigationType == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_investigation;";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_investigation where Investigationtype = '" + sInvestigationType + "';";
            }
            return DLAddInvestigation.GetInvestigationDetails(sQuery);
        }

        public static DataTable GetInvestigation(string sInvestigationType)
        {
            string sQuery = "select Investigations from db_navdurgahospital.tbl_investigation;";
            if (sInvestigationType == "All")
            {
                sQuery = "select Investigations from db_navdurgahospital.tbl_investigation;";
            }
            else
            {
                sQuery = "select Investigations from db_navdurgahospital.tbl_investigation where Investigationtype= '" + sInvestigationType + "';";
            }
            return DLAddInvestigation.GetInvestigationDetails(sQuery);
        }

        public static bool SaveInvestigationDetails(DataTable dtInvestigation)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_investigation;";
            return DLAddInvestigation.SaveInvestigationDetails(sQuery, dtInvestigation);
        }
    }
}
