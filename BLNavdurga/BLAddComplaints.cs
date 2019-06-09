using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;


namespace BLNavdurga
{
    public class BLAddComplaints
    {
        public static DataTable GetData()
        {
            return BLAddComplaints.GetData();
        }
        

        public static DataTable GetComplaintsType()
        {
            string sQuery = "Select 'All' complainttype Union SELECT distinct complainttype FROM db_navdurgahospital.tbl_complaints;";
            return DLNavdurga.DLAddComplaints.GetComplaintsType(sQuery);

        }

        public static DataTable GetComplaintsDetails(string sComplaintsType)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_complaints;";
            if (sComplaintsType == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_complaints;";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_complaints where complainttype = '" + sComplaintsType + "';";
            }
            return DLAddComplaints.GetComplaintsDetails(sQuery);
        }

        public static DataTable GetComplaints(string sComplaintsType)
        {
            string sQuery = "select Complaint from db_navdurgahospital.tbl_complaints;";
            if (sComplaintsType == "All")
            {
                sQuery = "select Complaint from db_navdurgahospital.tbl_complaints;";
            }
            else
            {
                sQuery = "select Complaint from db_navdurgahospital.tbl_complaints where complainttype= '" + sComplaintsType + "';";
            }
            return DLAddComplaints.GetComplaintsDetails(sQuery);
        }

            public static bool SaveComplaintsDetails(DataTable dtComplaints)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_complaints;";
            return DLAddComplaints.SaveComplaintsDetails(sQuery, dtComplaints);
        }
    }
}
