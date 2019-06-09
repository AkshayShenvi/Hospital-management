using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace BLNavdurga
{
    public class BLAddAdminConfig
    {
        public static DataTable GetData()
        {
            return BLAddAdminConfig.GetData();
        }
        public static string GetConfigValue(string sKey)
        {
            string sQuery = "SELECT Value FROM db_navdurgahospital.tbl_admin_config t where t.Key = '" + sKey + "'; ";
            return DLCommon.ExecuteScalar(sQuery);
        }
        public static DataTable GetAdminConfigDetails()
        {
            string sQuery = "SELECT * FROM db_navdurgahospital.tbl_admin_config;";
            return DLNavdurga.DLAddAdminConfig.GetAdminConfigDetailsType(sQuery);

        }
        public static bool SaveAdminConfigDetails(DataTable dtkey)
        {
            string sQuery = "SELECT * FROM db_navdurgahospital.tbl_admin_config;";
            return DLAddAdminConfig.SaveAdminConfigDetails(sQuery, dtkey);
        }
        public static String GetXRayPrice(string sKey)
        {
            string sQuery = "Select Value from db_navdurgahospital.tbl_admin_config t where t.Key='"+ sKey + "';";
            return DLCommon.ExecuteScalar(sQuery);
        }
    }
}
