using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace NavdurgaHospital
{
    public partial class OPDReportViewer : Form
    {
        
        public OPDReportViewer(OPDDetails od)
        {
            InitializeComponent();
            
            try
            {
                
                DataTable dtPrescription = BLNavdurga.BLAddPatientPrescription.GetPrescriptionReport(od.SrNo);

                ReportDocument OpdReport = new ReportDocument();
                string path = ConfigurationManager.AppSettings.Get("OPDPath").ToString();
                //string path = @"D:\Reports\PrintOPD.rpt";
                OpdReport.Load(path);
                OpdReport.Subreports[0].SetDataSource(dtPrescription);
                OpdReport.SetParameterValue("PatientName", od.PatientName);
                if (od.Age != null && od.Age.ToString() != string.Empty)
                    OpdReport.SetParameterValue("Age", od.Age);
                else { OpdReport.SetParameterValue("Age", "--"); }
                if (od.Gender != null && od.Gender.ToString() != string.Empty)
                    OpdReport.SetParameterValue("Gender", od.Gender);
                else { OpdReport.SetParameterValue("Gender", od.Gender); }
                //if (od.VisitedDate != null && od.VisitedDate.ToString() != string.Empty)
                //    OpdReport.SetParameterValue("VisitingDate", od.VisitedDate);
                //else { OpdReport.SetParameterValue("VisitingDate", od.VisitedDate); }
                if (od.Complaints != null && od.Complaints.ToString() != string.Empty)
                    OpdReport.SetParameterValue("Complaints", od.Complaints);
                else { OpdReport.SetParameterValue("Complaints", "--"); }
                if (od.ExamNotes != null && od.ExamNotes.ToString() != string.Empty)
                    OpdReport.SetParameterValue("ExamNotes", od.ExamNotes);
                else { OpdReport.SetParameterValue("ExamNotes", "--"); }
                if (od.Comorbidity != null && od.Comorbidity.ToString() != string.Empty)
                    OpdReport.SetParameterValue("Comorbidity", od.Comorbidity);
                else { OpdReport.SetParameterValue("Comorbidity", "--"); }
                if (od.Investigation != null && od.Investigation.ToString() != string.Empty)
                    OpdReport.SetParameterValue("Investigation", od.Investigation);
                else { OpdReport.SetParameterValue("Investigation", "--"); }
                if (od.Diagnosis != null && od.Diagnosis.ToString() != string.Empty)
                    OpdReport.SetParameterValue("Diagnosis", od.Diagnosis);
                else { OpdReport.SetParameterValue("Diagnosis", "--"); }
                if (od.Treatment != null && od.Treatment.ToString() != string.Empty)
                    OpdReport.SetParameterValue("Treatment", od.Treatment);
                else { OpdReport.SetParameterValue("Treatment", "--"); }

                crystalReportViewer1.ReportSource = OpdReport;
                
                crystalReportViewer1.Refresh();
                String sFolderPath = ConfigurationManager.AppSettings.Get("OPDPapersFolderPath").ToString();
                sFolderPath = sFolderPath + "\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMMM") + "\\" + DateTime.Now.ToString("dd");
                if (!Directory.Exists(sFolderPath))
                    Directory.CreateDirectory(sFolderPath);
                OpdReport.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sFolderPath + "\\" + od.PatientName + ".pdf");
            }
            catch(Exception ex)
            { }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
