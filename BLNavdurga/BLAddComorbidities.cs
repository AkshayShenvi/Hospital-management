using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace BLNavdurga
{
    public class BLAddComorbidities
    {
        public static DataTable GetData()
        {
            return BLAddComorbidities.GetData();
        }

        public static DataTable GetComorbiditiesType()
        {
            string sQuery = "Select 'All' comorbidity Union SELECT distinct comorbidity FROM db_navdurgahospital.tbl_comorbidities;";
            return DLNavdurga.DLAddComorbidities.GetComorbiditiesType(sQuery);

        }

        public static DataTable GetComorbiditiesDetails(string sComorbiditiesType)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_comorbidities;";
            if (sComorbiditiesType == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_comorbidities;";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_comorbidities where comorbidity = '" + sComorbiditiesType + "';";
            }
            return DLAddComorbidities.GetComorbiditiesDetails(sQuery);
        }

        public static bool SaveComorbiditiesDetails(DataTable dtComorbidities)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_comorbidities;";
            return DLAddComorbidities.SaveComorbiditiesDetails(sQuery, dtComorbidities);
        }
    }
}
