using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavdurgaHospital
{
    public class CertificateDetails
    {
        private string _patientName;
        private string _diagnosis;
        private string _startDate;
        private string _endDate;
        private string _resumeDate;
        private string _injury;
        private string _disability;

        public string PatientName
        {
            get;
            set;
        }
        public string Diagnosis
        {
            get;
            set;
        }
        public string StartDate
        {
            get;
            set;
        }
        public string EndDate
        {
            get;
            set;
        }
        public string ResumeDate
        {
            get;
            set;
        }
        public string Injury
        {
            get;
            set;
        }
        public string Disability
        {
            get;
            set;
        }
        public string DisabilityPercentage
        {
            get;
            set;
        }
    }
}
