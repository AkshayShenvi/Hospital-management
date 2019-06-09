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
    public partial class UndertreatmentCertificateReportViewer : Form
    {
        public UndertreatmentCertificateReportViewer(CertificateDetails cd)
        {
            InitializeComponent();

            try
            {
                ReportDocument cryRpt = new ReportDocument();
                string path = ConfigurationManager.AppSettings.Get("UndertreatmentPath").ToString();
                //string path = @"D:\Reports\UndertreatmentCertificate.rpt";
                cryRpt.Load(path);
                cryRpt.SetParameterValue("PatientName", cd.PatientName);
                cryRpt.SetParameterValue("Diagnosis", cd.Diagnosis);
                cryRpt.SetParameterValue("From", cd.StartDate);
                cryRpt.SetParameterValue("To", cd.EndDate);
                cryRpt.SetParameterValue("DutiesFrom", cd.ResumeDate);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
                String sFolderPath = ConfigurationManager.AppSettings.Get("CertificatesFolderPath").ToString();
                sFolderPath = sFolderPath + "\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMMM") + "\\" + DateTime.Now.ToString("dd");
                if (!Directory.Exists(sFolderPath))
                    Directory.CreateDirectory(sFolderPath);
                cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sFolderPath + "\\" + cd.PatientName + ".pdf");
            }
            catch (Exception ex)
            { }
        }
    }
}
