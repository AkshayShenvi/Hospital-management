using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavdurgaHospital
{
    public class BillDetails
    {
        private string _patientName;
        private string _recievedWith;
        private string _dressingAmt;
        private string _emergencyVisitAmt;
        private string _visitType;
        private string _visitAmt;
        private string _xrayNo;
        private string _xrayAmt;
        private string _previousBalance;
        private string _plasterAmt;
        private string _injectionAmt;
        private string _aspirationAmt;
        private string _manipulationAmt;
        private string _otherProcAmt;
        private string _miscAmt;
        private string _totalAmt;
        private string _billno;


        public string PatientName
        {
            get;
            set;
        }
        public string RecievedWith
        {
            get;
            set;
        }
        public string DressingAmt
        {
            get;
            set;
        }
        public string EmergencyVisitAmt
        {
            get;
            set;
        }
        public string VisitType
        {
            get;
            set;
        }
        public string VisitAmt
        {
            get;
            set;
        }
        public string XrayNumber
        {
            get;
            set;
        }
        public string XrayAmt
        {
            get;
            set;
        }
        public string PreviousBalance
        {
            get;
            set;
        }
        public string PlasterAmt
        {
            get;
            set;
        }
        public string InjectionAmt
        {
            get;
            set;
        }
        public string AspirationAmt
        {
            get;
            set;
        }
        public string ManipulationAmt
        {
            get;
            set;
        }
        public string OtherProcAmt
        {
            get;
            set;
        }
        public string MiscAmt
        {
            get;
            set;
        }
        public string TotalAmt
        {
            get;
            set;
        }
        public string BillNo
        {
            get;
            set;
        }
    }
}
