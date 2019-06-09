using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLNavdurga;

namespace BLNavdurga
{
    public class BLAddPatientDetails
    {

        public static DataTable GetData()
        {
            return BLAddPatientDetails.GetData();
        }

        public static DataTable GetDateType()
        {
            string sQuery = "Select 'All' Date Union SELECT distinct Date FROM db_navdurgahospital.tbl_patientdetails;";

            return DLNavdurga.DLAddPatientDetails.GetDateType(sQuery);
        }

        public static DataTable GetPatientDetails(string sDateType)
        {
            string sQuery = string.Empty;
            if (sDateType == "All")
            {
                sQuery = "select * from db_navdurgahospital.tbl_patientdetails where  VisitingDate = '" + sDateType + "';";
            }
            else
            {
                sQuery = "select * from db_navdurgahospital.tbl_patientdetails where  VisitingDate = '" + sDateType + "';";
            }
            return DLAddPatientDetails.GetPatientDetails(sQuery);
        }
        public static DataTable GetPatientDetailsForStaff(string sDateType)
        {
            string sQuery = "SELECT SrNo,patientID,BillNo,PatientName,PhoneNo,Age,VisitType,Treatment,Investigation,TotalAmt,Paid,Balance,PrevBalance,PatientStatus,VisitingDate FROM db_navdurgahospital.tbl_patientdetails where VisitingDate = '" + sDateType + "';";
            return DLAddPatientDetails.GetPatientDetails(sQuery);
        }

        public static bool SavePatientDetails(DataTable dtPatientDetails)
        {
            string sQuery = "SELECT SrNo,patientID,BillNo,PatientName,PhoneNo,Age,VisitType,Treatment,TotalAmt,Paid,Balance,PrevBalance,PatientStatus,VisitingDate from db_navdurgahospital.tbl_patientdetails;";
            return DLAddPatientDetails.SavePatientDetails(sQuery, dtPatientDetails);
        }
        public static bool SavePatientDetailsForDoctor(DataTable dtPatientDetails)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientdetails;";
            return DLAddPatientDetails.SavePatientDetails(sQuery, dtPatientDetails);
        }

        public static DataTable SaveOPDResult(string sOPDType, string sOPDEntry, string sPKSrno)
        {
            string sQuery = "UPDATE `db_navdurgahospital`.`tbl_patientdetails` SET `" + sOPDType + "`='" + sOPDEntry + "' WHERE `SrNo`='" + sPKSrno + "';";
            return DLAddPatientDetails.SavePDetails(sQuery);
        }
        public static void UpdateStatus(string sStatus, string sPKSrno)
        {
            string sQuery = "UPDATE db_navdurgahospital.tbl_patientdetails SET PatientStatus = '" + sStatus + "' WHERE SrNo = " + sPKSrno + ";";
             DLCommon.ExecuteNonQuery(sQuery);
            
        }

        public static DataTable SearchPatientPhoneDetails(string sPatientPhone)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientdetails where PhoneNo like '%" + sPatientPhone + "%';";
            return DLAddPatientDetails.GetPatientDetails(sQuery);

        }
        public static DataTable SearchPatientNameDetails(string sPatientName)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientdetails where PatientName like '%" + sPatientName + "%';";
            return DLAddPatientDetails.GetPatientDetails(sQuery);

        }
        public static DataTable SearchPatientNameAndPhone(string sPatientName, string sPatientPhone)
        {
            string sQuery = "SELECT * FROM db_navdurgahospital.tbl_patientdetails where PatientName like'%" + sPatientName + "%' && PhoneNo like'%" + sPatientPhone + "%';";
            return DLAddPatientDetails.GetPatientDetails(sQuery);
        }

        public static string GetPatielUnpaidBill(String iPatientID)
        {
            string sBillAmout = DLCommon.ExecuteScalar("SELECT Sum(Balance) FROM db_navdurgahospital.tbl_patientdetails where patientID = " + iPatientID + "; ");
            return (sBillAmout == string.Empty ? "0" : sBillAmout);
        }
        public static DataTable GetPatientBalanceDetails(string sStartDate, string sEndDate)
        {
            string sQuery = "select * from db_navdurgahospital.tbl_patientdetails  where Balance!= 0 and  VisitingDate between '" + sStartDate + "' and '" + sEndDate + "';";
            return DLAddPatientDetails.GetPatientDetails(sQuery);
        }
        
        public static void UpdatePatientDetailTable(string sPatientID, string sName, string sPhoneNumber)
        {
            string sQuery = "update db_navdurgahospital.tbl_patientdetails set PatientName = '" + sName + "', PhoneNo = '" + sPhoneNumber + "' where patientID = " + sPatientID + " ;";
            DLCommon.ExecuteNonQuery(sQuery);
        }
        public static void UpdateTotalAmount(string sPatientID,int totalAmt)
        {
            string sQuery = "";
        }

        public static string GetDailyPatientTotal(String sDate)
        {
            string sBillTotalAmout = DLCommon.ExecuteScalar("SELECT sum(TotalAmt) FROM db_navdurgahospital.tbl_patientdetails where VisitingDate = '"+ sDate + "';");
            return (sBillTotalAmout == string.Empty ? "0" : sBillTotalAmout);
        }
        public static void UpdatePatientBilTotal(string sSrno,string sTotalAmt)
        {
            string sQuery = "Update db_navdurgahospital.tbl_patientdetails set TotalAmt="+ sTotalAmt + " where SrNo="+ sSrno + " ;";
            DLCommon.ExecuteNonQuery(sQuery);
        }

        public static void UpdatePatientBillBalance(string sPaid, string sSrno,string sPatientId)
        {
            string sQuery = "update `db_navdurgahospital`.`tbl_patientdetails` set Balance = 0 where patientid =" + sPatientId  ;
            DLCommon.ExecuteNonQuery(sQuery);

            sQuery = "Update `db_navdurgahospital`.`tbl_patientdetails` set Balance = TotalAmt + IfNull(PrevBalance,0) -(IFNULL(Paid,0) + " + sPaid + ") ,Paid = IFNULL(Paid,0) + " + sPaid + " where srno = " + sSrno + ";";
            DLCommon.ExecuteNonQuery(sQuery);


        }
        public static void UpdateTotalAmount(string sSrno, string sTotalAmt)
        {
            string sQuery = "update `db_navdurgahospital`.`tbl_patientdetails` set TotalAmt = " + sTotalAmt + " where srno = " + sSrno + ";";
            DLCommon.ExecuteNonQuery(sQuery);
        }

        public static DataTable GetPatientDetailsPrintData(DateTime dtOPDDate)
        {
            string sQuery = "select BillNo,PatientName,PhoneNo,PatientStatus,TotalAmt,Paid,Balance from `db_navdurgahospital`.`tbl_patientdetails`  where visitingdate = '" + dtOPDDate.ToString("yyyy-MM-dd") + "' order by visitingdate ";
            return DLCommon.GetDataTable(sQuery);
        }

    }
}
