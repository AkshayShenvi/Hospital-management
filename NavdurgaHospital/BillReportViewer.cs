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
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace NavdurgaHospital
{
    public partial class ReportViewer : Form
    {
       // public string sPatientName1 { get; set; }
        public ReportViewer(BillDetails bd)
        {
            InitializeComponent();

            //ParameterFields paramFields = new ParameterFields();

            //ParameterField pAmtDressing = new ParameterField();
            //pAmtDressing.ParameterFieldName = "AmtDressing"; //year is Crystal Report Parameter name.
            //ParameterDiscreteValue dcAmtDressing = new ParameterDiscreteValue();
            //dcAmtDressing.Value = 1000.00;
            //pAmtDressing.CurrentValues.Add(dcAmtDressing);
            //paramFields.Add(pAmtDressing);

            //ParameterField pAmtEmrgencyVisit = new ParameterField();
            //pAmtEmrgencyVisit.ParameterFieldName = "AmtEmergencyVisit"; //year is Crystal Report Parameter name.
            //ParameterDiscreteValue dcAmtEmrgencyVisit = new ParameterDiscreteValue();
            //dcAmtEmrgencyVisit.Value = 2000.00;
            //pAmtEmrgencyVisit.CurrentValues.Add(dcAmtEmrgencyVisit);
            //paramFields.Add(pAmtEmrgencyVisit);

            //ParameterField pVisitAmt = new ParameterField();
            //pVisitAmt.ParameterFieldName = "VisitAmt"; //year is Crystal Report Parameter name.
            //ParameterDiscreteValue dcVisitAmt = new ParameterDiscreteValue();
            //dcVisitAmt.Value = 500.00;
            //pVisitAmt.CurrentValues.Add(dcVisitAmt);
            //paramFields.Add(pVisitAmt);

            //ParameterField pVisitType = new ParameterField();
            //pVisitType.ParameterFieldName = "VisitType"; //year is Crystal Report Parameter name.
            //ParameterDiscreteValue dcVisitType = new ParameterDiscreteValue();
            //dcVisitType.Value = "Consulting";
            //pVisitType.CurrentValues.Add(dcVisitType);
            //paramFields.Add(pVisitType);

            //ParameterField pPatientName = new ParameterField();
            //pPatientName.ParameterFieldName = "PatientName"; //year is Crystal Report Parameter name.
            //ParameterDiscreteValue dcPatientName = new ParameterDiscreteValue();
            //dcPatientName.Value = "Akshay Shenvi";
            //pPatientName.CurrentValues.Add(dcPatientName);
            //paramFields.Add(pPatientName);

            //crystalReportViewer1.ParameterFieldInfo = paramFields;
            ReportDocument cryRpt = new ReportDocument();
            string path = ConfigurationManager.AppSettings.Get("BillPath").ToString();
            //string path = @"D:\Reports\BillPrint.rpt";
            cryRpt.Load(path);
            cryRpt.SetParameterValue("PatientName", bd.PatientName);
            if(bd.RecievedWith != null && bd.RecievedWith.ToString()!= string.Empty)
            cryRpt.SetParameterValue("RecievedWith", bd.RecievedWith);
            else { cryRpt.SetParameterValue("RecievedWith", bd.PatientName); }

            if (bd.DressingAmt != null && bd.DressingAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("AmtDressing", bd.DressingAmt);
            else { cryRpt.SetParameterValue("AmtDressing", 0); }

            if (bd.EmergencyVisitAmt != null && bd.EmergencyVisitAmt.ToString() != string.Empty)
            cryRpt.SetParameterValue("AmtEmergencyVisit", bd.EmergencyVisitAmt);
            else { cryRpt.SetParameterValue("AmtEmergencyVisit", 0); }

            if (bd.VisitAmt != null && bd.VisitAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("VisitAmt", bd.VisitAmt);
            else { cryRpt.SetParameterValue("VisitAmt", 0); }

            if (bd.VisitType != null && bd.VisitType.ToString() != string.Empty)
                cryRpt.SetParameterValue("VisitType", bd.VisitType);
            else { MessageBox.Show("Please enter Visit Type"); }

            if (bd.XrayNumber != null && bd.XrayNumber.ToString() != string.Empty)
                cryRpt.SetParameterValue("XrayNumber", bd.XrayNumber);
            else { cryRpt.SetParameterValue("XrayNumber", 0); }

            if (bd.XrayAmt != null && bd.XrayAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("XrayAmt", bd.XrayAmt);
            else { cryRpt.SetParameterValue("XrayAmt", 0); }

            if (bd.PreviousBalance != null && bd.PreviousBalance.ToString() != string.Empty)
                cryRpt.SetParameterValue("PreviousBalance", bd.PreviousBalance);
            else { cryRpt.SetParameterValue("PreviousBalance", 0); }

            if (bd.PlasterAmt != null && bd.PlasterAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("PlasterAmt", bd.PlasterAmt);
            else { cryRpt.SetParameterValue("PlasterAmt", 0); }

            if (bd.InjectionAmt != null && bd.InjectionAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("InjectionAmt", bd.InjectionAmt);
            else { cryRpt.SetParameterValue("InjectionAmt", 0); }

            if (bd.AspirationAmt != null && bd.AspirationAmt != null && bd.AspirationAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("AspirationAmt", bd.AspirationAmt);
            else { cryRpt.SetParameterValue("AspirationAmt", 0); }

            if (bd.ManipulationAmt != null && bd.ManipulationAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("ManipulationAmt", bd.ManipulationAmt);
            else { cryRpt.SetParameterValue("ManipulationAmt", 0); }

            if (bd.OtherProcAmt != null && bd.OtherProcAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("OtherProAmt", bd.OtherProcAmt);
            else { cryRpt.SetParameterValue("OtherProAmt", 0); }

            if (bd.MiscAmt != null &&  bd.MiscAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("MiscAmt", bd.MiscAmt);
            else { cryRpt.SetParameterValue("MiscAmt", 0); }
            if (bd.TotalAmt != null && bd.TotalAmt.ToString() != string.Empty)
                cryRpt.SetParameterValue("TotalAmt", bd.TotalAmt);
            else { cryRpt.SetParameterValue("TotalAmt", 0); }
            if (bd.BillNo != null && bd.BillNo.ToString() != string.Empty)
                cryRpt.SetParameterValue("BillNo", bd.BillNo);
            else { cryRpt.SetParameterValue("BillNo", 0); }
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            String sFolderPath = ConfigurationManager.AppSettings.Get("BillsFolderPath").ToString();
            sFolderPath = sFolderPath + "\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMMM") + "\\" + DateTime.Now.ToString("dd");
            if (!Directory.Exists(sFolderPath))
                Directory.CreateDirectory(sFolderPath);
            cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sFolderPath + "\\" + bd.PatientName + ".pdf");

        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
