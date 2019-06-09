using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace BLNavdurga
{
    public class BLAddLoginDetails
    {
        
            public static DataTable GetData()
            {
                return BLAddLoginDetails.GetData();
            }

            public static DataTable GetLoginType()
            {
                string sQuery = "SELECT distinct Rights FROM db_navdurgahospital.tbl_logindetails;";
                return DLNavdurga.DLAddLoginDetails.GetLoginType(sQuery);

            }

            public static DataTable CheckLoginType(string sUsername, string sPassword)
            {
            //string sRights = DLCommon.ExecuteScalar("SELECT Rights FROM db_navdurgahospital.tbl_logindetails where Username='" + sUsername + "'&& Password='" + sPassword + "';").ToString();
            string sQuery = "SELECT Rights FROM db_navdurgahospital.tbl_logindetails where Username='" + sUsername + "'&& Password='" + sPassword + "';";
            return DLNavdurga.DLAddLoginDetails.GetLoginDetails(sQuery);
            //return (sRights == string.Empty ? String.Empty : sRights);
        }

            public static DataTable GetLogin()
            {
                string sQuery = "SELECT * FROM db_navdurgahospital.tbl_logindetails;";
                
                return DLAddLoginDetails.GetLoginDetails(sQuery);
            }

            public static bool SaveLoginDetails(DataTable dtLogin)
            {
                string sQuery = "SELECT * FROM db_navdurgahospital.tbl_logindetails;";
                return DLAddLoginDetails.SaveLoginDetails(sQuery, dtLogin);
            }

    }
}
