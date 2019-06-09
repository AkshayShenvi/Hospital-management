using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace BLNavdurga
{
   public class BLAddPatientBillDetails
    {
        public static DataTable GetData()
        {
            return BLAddPatientBillDetails.GetData();
        }

        public static void InsertBillDetails(string sSrno, string sBillDetail,string sDetails, string sAmount)
        {
            string str = "Delete from `db_navdurgahospital`.`tbl_patientbilldescription` where BillDetail = 'VisitType' And patientSrno = " + sSrno + ";";
            DLCommon.ExecuteNonQuery(str);
            string sQuery = "INSERT INTO `db_navdurgahospital`.`tbl_patientbilldescription` (`patientSrno`, `BillDetail`,`Detail`, `Amount`) VALUES ('" + sSrno + "', '" + sBillDetail + "','"+sDetails+"', '" + sAmount + "');";
            DLCommon.ExecuteNonQuery(sQuery);
        }
        public static void InsertBillNoDetails(string sBillNo,string sPatientSrNo, string sVisitingDate, string sPatientName,string sbillAmt)
        {
            
            string sQuery = "INSERT INTO `db_navdurgahospital`.`tbl_printbill` (`billno`, `patientsrno`, `visitingdate`, `patientname`, `billtotalamt`) VALUES ('"+sBillNo+"', '"+sPatientSrNo+"', '"+sVisitingDate+"', '"+sPatientName+"', '"+sbillAmt+"');";
            DLCommon.ExecuteNonQuery(sQuery);
        }
        public static void UpdateBillNo (string sBillNo,string sPatientSrNo)
        {
            string sQuery = "Update db_navdurgahospital.tbl_patientdetails set BillNo= "+ sBillNo + " where SrNo="+ sPatientSrNo + ";";
            DLCommon.ExecuteNonQuery(sQuery);
        }
        public static string GetNewBillNo()
        {
            string sQuery="select max(billno) +1 as newbillno from db_navdurgahospital.tbl_printbill;";
            return DLCommon.ExecuteScalar(sQuery);
        }

        public static void InsertIntoBillDetails(string sSrno, string sBillDetail,string sDetails, string sAmount)
        {
            string sQueryDelete = "Delete from `db_navdurgahospital`.`tbl_patientbilldescription` where  `patientSrno` = " + sSrno + " and `BillDetail` = '"+ sBillDetail + "';";
            DLCommon.ExecuteNonQuery(sQueryDelete);
            string sQuery = "INSERT INTO `db_navdurgahospital`.`tbl_patientbilldescription` (`patientSrno`, `BillDetail`,`Detail`, `Amount`) VALUES ('" + sSrno + "', '" + sBillDetail + "','"+ sDetails + "', " + sAmount + ");";
            DLCommon.ExecuteNonQuery(sQuery);
        }
        public static DataTable GetBillDetailsFromDetails(string sSrno,string sMedicineDispensed)
        {
            string sQuery = "Select Detail from db_navdurgahospital.tbl_patientbilldescription Where patientSrno = "+sSrno+" and BillDetail = '"+sMedicineDispensed+"';";
            return DLAddPatientDetails.GetPatientDetails(sQuery); ;
        }
        public static DataTable GetBillVisitDetails(string sSrno)
        {
            string sQuery = "Select Detail from db_navdurgahospital.tbl_patientbilldescription Where patientSrno = " + sSrno + " and BillDetail = 'VisitType';";
            return DLAddPatientDetails.GetPatientDetails(sQuery); ;
        }
        public static DataTable GetBillDetailsFromAmount(string sSrno, string sMedicineDispensed)
        {
            string sQuery = "Select Amount from db_navdurgahospital.tbl_patientbilldescription Where patientSrno = " + sSrno + " and BillDetail = '" + sMedicineDispensed + "';";
            return DLAddPatientDetails.GetPatientDetails(sQuery); ;
        }
        public static DataTable GetBillVisitAmount(string sSrno)
        {
            string sQuery = "Select Amount from db_navdurgahospital.tbl_patientbilldescription Where patientSrno = " + sSrno + " and BillDetail = 'VisitType';";
            return DLAddPatientDetails.GetPatientDetails(sQuery);
        }
        public static string GetPatientBillTotal(String sSrno)
        {
            string sBillTotalAmout = DLCommon.ExecuteScalar("SELECT sum(Amount) FROM db_navdurgahospital.tbl_patientbilldescription where patientSrno = "+ sSrno + ";");
            return (sBillTotalAmout == string.Empty ? "0" : sBillTotalAmout);
        }
        public static string GetPreviousBalance(string sPatientId)
        {
            string sQuery = "SELECT PrevBalance FROM db_navdurgahospital.tbl_patientdetails where PrevBalance > 0 and patientID="+ sPatientId + " ORDER BY VisitingDate DESC LIMIT  1;";
            return DLCommon.ExecuteScalar(sQuery) == string.Empty ? "0": DLCommon.ExecuteScalar(sQuery);
        }

    }

}
