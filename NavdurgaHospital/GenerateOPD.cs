using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavdurgaHospital
{
    public partial class GenerateOPD : Form
    {
        public GenerateOPD()
        {
            InitializeComponent();
        }
        public string PName { get; set; }
        public string Srno { get; set; }
        public string VisitedDate { get; set; }
        public string Age { get; set; }
        public string Complaints { get; set; }
        public string ExamNotes { get; set; }
        public string Comorbidities { get; set; }
        public string Diagnosis { get; set; }
        public string Investigation { get; set; }
        public string Treatment { get; set; }
        public string Prescription { get; set; }
        string sSrno, sName, sVisitedDate, sAge, sComplaints, sExamNotes, sComorbidities, sDiagnosis, sInvestigation, sTreatment, sPrescription;

        

        private void GenerateOPD_Load(object sender, EventArgs e)
        {
            try
            {
                sSrno = Srno.ToString();
                sName = PName.ToString();
                sVisitedDate = DateTime.Parse(VisitedDate).ToString("yyyy-MM-dd");
                if (Age != null && Age.ToString() != string.Empty)
                    sAge = Age.ToString();
                if (Complaints != null && Complaints.ToString() != string.Empty)
                    sComplaints = Complaints.ToString();
                if (ExamNotes != null && ExamNotes.ToString() != string.Empty)
                    sExamNotes = ExamNotes.ToString();
                if (Comorbidities != null && Comorbidities.ToString() != string.Empty)
                    sComorbidities = Comorbidities.ToString();
                if (Diagnosis != null && Diagnosis.ToString() != string.Empty)
                    sDiagnosis = Diagnosis.ToString();
                if (Investigation != null && Investigation.ToString() != string.Empty)
                    sInvestigation = Investigation.ToString();
                if (Treatment != null && Treatment.ToString() != string.Empty)
                    sTreatment = Treatment.ToString();
                if (Prescription != null && Prescription.ToString() != string.Empty)
                    sPrescription = Prescription.ToString();

                txtName.Text = sName.ToString();
                txtVisitedDate.Text = sVisitedDate.ToString();

                txtAge.Text = sAge.ToString();
                txtComplaints.Text = sComplaints.ToString();
                txtExamNotes.Text = sExamNotes.ToString();
                txtComorbidities.Text = sComorbidities.ToString();
                txtDiagnosis.Text = sDiagnosis.ToString();
                txtInvestigation.Text = sInvestigation.ToString();
                txtTreatment.Text = sTreatment.ToString();
                txtPrescription.Text = sPrescription.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Some or All Fields may be Empty");
                GenerateOPD generateOPD = new GenerateOPD();
                generateOPD.Hide();

            }
        }
        private void btnPrintOPD_Click(object sender, EventArgs e)
        {
            try
            { 
                OPDDetails od = new OPDDetails();
                od.SrNo = Srno;
                if (txtName.Text != null)
                    od.PatientName = txtName.Text;
                if (txtVisitedDate.Text != null)
                    od.VisitedDate = txtVisitedDate.Text;
                //if (sAge.ToString() != null && sAge.ToString() != string.Empty)
                //    od.Age = sAge.ToString();
                //else if (sAge.ToString() == null && sAge.ToString() == string.Empty)
                //    od.Age = txtAge.Text;
                //else
                //{
                //    sAge = "Not Given";
                //    od.Age = sAge.ToString();
                //}
                if (txtAge.Text != null)
                    od.Age = txtAge.Text;
                if (txtComplaints.Text != null)
                    od.Complaints = txtComplaints.Text;
                if (txtExamNotes.Text != null)
                    od.ExamNotes = txtExamNotes.Text;
                if (txtComorbidities.Text != null)
                    od.Comorbidity = txtComorbidities.Text;
                if (txtDiagnosis.Text != null)
                    od.Diagnosis = txtDiagnosis.Text;
                if (txtInvestigation.Text != null)
                    od.Investigation = txtInvestigation.Text;
                if (txtTreatment.Text != null)
                    od.Treatment = txtTreatment.Text;
                if (txtPrescription.Text != null)
                    od.Prescription = txtPrescription.Text;
                if (txtGender.Text != null)
                    od.Gender = txtGender.Text;

                

                OPDReportViewer oPDReport = new OPDReportViewer(od);
                oPDReport.ShowDialog();
            }
            catch (Exception ex)
            { }

        }
    }
}
