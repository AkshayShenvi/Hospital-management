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
    public partial class UndertreatmentDetails : Form
    {
        public UndertreatmentDetails()
        {
            InitializeComponent();
        }
        string sStartDate, sEndDate, sResumeDate;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                sStartDate = (DateTime.Parse(dtpStartDate.Text)).ToString("dd-MMM-yyyy");
                sEndDate = (DateTime.Parse(dtpEndDate.Text)).ToString("dd-MMM-yyyy");
                sResumeDate = (DateTime.Parse(dtpResumeDate.Text)).ToString("dd-MMM-yyyy");


                CertificateDetails cd = new CertificateDetails();
                if (txtName.Text != null)
                    cd.PatientName = txtName.Text;
                else
                { MessageBox.Show("Please Enter Patient Name"); }
                if (txtDiagnosis.Text != null)
                    cd.Diagnosis = txtDiagnosis.Text;
                else
                { MessageBox.Show("Please Enter Diagnosis"); }
                if (sStartDate.ToString() != String.Empty)
                    cd.StartDate = sStartDate.ToString();
                else
                { MessageBox.Show("Please Enter Start Date"); }
                if (sEndDate.ToString() != String.Empty)
                    cd.EndDate = sEndDate.ToString();
                else
                { MessageBox.Show("Please Enter End Date"); }
                if (sResumeDate.ToString() != String.Empty)
                    cd.ResumeDate = sResumeDate.ToString();
                else
                { MessageBox.Show("Please Enter Resume Date"); }

                UndertreatmentCertificateReportViewer undertreatmentCirtificateReport = new UndertreatmentCertificateReportViewer(cd);
                undertreatmentCirtificateReport.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            { }
        }
    }
}
