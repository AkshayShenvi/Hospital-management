using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavdurgaHospital
{
    public class OPDDetails
    {
        private string _patientName;
        private string _visitedDate;
        private string _age;
        private string _gender;
        private string _complaints;
        private string _examNotes;
        private string _comorbidity;
        private string _investigation;
        private string _diagnosis;
        private string _treatment;
        private string _prescription;
        public string _srNo;
        


        public string SrNo
        {
            get;
            set;
        }
        public string PatientName
        {
            get;
            set;
        }
        public string VisitedDate
        {
            get;
            set;
        }
        public string Age
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public string Complaints
        {
            get;
            set;
        }
        public string ExamNotes
        {
            get;
            set;
        }
        public string Comorbidity
        {
            get;
            set;
        }
        public string Investigation
        {
            get;
            set;
        }
        public string Diagnosis
        {
            get;
            set;
        }
        public string Treatment
        {
            get;
            set;
        }
        public string Prescription
        {
            get;
            set;
        }

        
    }
}
