using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace NavdurgaHospital
{
    public partial class GenerateBill : Form
    {
        public GenerateBill()
        {
            InitializeComponent();
        }

        public string PatientName { get; set; }
        public string Srno { get; set; }
        public string VisitedDate { get; set; }
        public string PreviousTotal { get; set; }
        string sPatientName, sVisitingDate, sSrno;
        DataTable sInjection, sDressing, sXray, sMisc, sProcedure, sAspirations, sManipulations, sOtherPro;
        DataTable sInjectionAmt, sDressingAmt, sXrayAmt, sMiscAmt, sProcedureAmt, sVisitType, sVisitAmt, sAspirationAmt, sManipulationAmt, sOtherProAmt,sEmergencyVisitAmt;

        private void txt3shoot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiscAmt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtOtherProcAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtManipulationAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAspirationAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtEmergencyVisitAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtPatientName_Click(object sender, EventArgs e)
        {

        }

        //private void PrintDocument1_Printpage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawImage(memoryImage, 0, 0);
        //}
        //[System.Runtime.InteropServices.DllImport("gdi32.dll")]
        //public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        //private Bitmap memoryImage;

        //private void PrintScreen()
        //{
        //    Graphics mygraphics = this.CreateGraphics();
        //    Size s = this.Size;
        //    memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
        //    Graphics memoryGraphics = Graphics.FromImage(memoryImage);
        //    IntPtr dc1 = mygraphics.GetHdc();
        //    IntPtr dc2 = memoryGraphics.GetHdc();
        //    BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
        //    mygraphics.ReleaseHdc(dc1);
        //    memoryGraphics.ReleaseHdc(dc2);
        //}


        private void PrintBill_Load(object sender, EventArgs e)
        {

            try
            {
                

                sSrno = Srno.ToString();
                sPatientName = PatientName.ToString();
                sVisitingDate = VisitedDate.ToString();

                txtPatientName.Text = sPatientName.ToString();
                txtVisitingDate.Text = sVisitingDate.ToString();

                //Get Details
                sInjection = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Injection");
                if (sInjection != null && sInjection.Rows.Count > 0)
                    txtInjection.Text = sInjection.Rows[0]["Detail"].ToString();
                sDressing = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Dressing");
                if (sDressing != null && sDressing.Rows.Count > 0)
                    txtDressing.Text = sDressing.Rows[0]["Detail"].ToString();
                
                sXray = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "X-Ray Details");
                if (sXray != null && sXray.Rows.Count > 0)
                {
                    string sXrayDetails = sXray.Rows[0]["Detail"].ToString();
                    string[] sXrayShoots = sXrayDetails.Split('|');
                    txtSingleShoot.Text = sXrayShoots[0].Split('~')[1].ToString();
                    txtSingleNum.Text = sXrayShoots[0].Split('~')[2].ToString();

                    txtDoubleShoot.Text = sXrayShoots[1].Split('~')[1].ToString();
                    txtDoubleNum.Text = sXrayShoots[1].Split('~')[2].ToString();

                    txtThreeShoot.Text = sXrayShoots[2].Split('~')[1].ToString();
                    txtThreeNum.Text = sXrayShoots[2].Split('~')[2].ToString();

                    txtFourShoot.Text = sXrayShoots[3].Split('~')[1].ToString();
                    txtFourNum.Text = sXrayShoots[3].Split('~')[2].ToString();

                }
                    

                sMisc = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Miscellaneous");
                if (sMisc != null && sMisc.Rows.Count > 0)
                    txtMisc.Text = sMisc.Rows[0]["Detail"].ToString();
                sProcedure = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Plaster");
                if (sProcedure != null && sProcedure.Rows.Count > 0)
                    txtprocedure.Text = sProcedure.Rows[0]["Detail"].ToString();
                sAspirations = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Aspirations");
                if (sAspirations != null && sAspirations.Rows.Count > 0)
                    txtAspiration.Text = sAspirations.Rows[0]["Detail"].ToString();
                sManipulations = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Manipulations");
                if (sManipulations != null && sManipulations.Rows.Count > 0)
                    txtManipulation.Text = sManipulations.Rows[0]["Detail"].ToString();
                sOtherPro = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Other Procedures");
                if (sOtherPro != null && sOtherPro.Rows.Count > 0)
                    txtOtherPro.Text = sOtherPro.Rows[0]["Detail"].ToString();
                sVisitType = BLNavdurga.BLAddPatientBillDetails.GetBillVisitDetails(sSrno);
                if (sVisitType != null && sVisitType.Rows.Count > 0)
                    txtVisitType.Text = sVisitType.Rows[0]["Detail"].ToString();
                

                //Get Amounts
                sInjectionAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Injection");
                if (sInjectionAmt != null && sInjectionAmt.Rows.Count > 0)
                    txtInjectionAmt.Text = sInjectionAmt.Rows[0]["Amount"].ToString();
                sDressingAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Dressing");
                if (sDressingAmt != null && sDressingAmt.Rows.Count > 0)
                    txtDressAmt.Text = sDressingAmt.Rows[0]["Amount"].ToString();
                sXrayAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "X-Ray Details");
                if (sXrayAmt != null && sXrayAmt.Rows.Count > 0)
                    txtXrayAmt.Text = sXrayAmt.Rows[0]["Amount"].ToString();
                sMiscAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Miscellaneous");
                if (sMiscAmt != null && sMiscAmt.Rows.Count > 0)
                    txtMiscAmt.Text = sMiscAmt.Rows[0]["Amount"].ToString();
                sProcedureAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Plaster");
                if (sProcedureAmt != null && sProcedureAmt.Rows.Count > 0)
                    txtPlasterAmt.Text = sProcedureAmt.Rows[0]["Amount"].ToString();
                sVisitAmt = BLNavdurga.BLAddPatientBillDetails.GetBillVisitAmount(sSrno);
                if (sVisitAmt != null && sVisitAmt.Rows.Count > 0)
                    txtVisitAmt.Text = sVisitAmt.Rows[0]["Amount"].ToString();
                sAspirationAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Aspirations");
                if (sAspirationAmt != null && sAspirationAmt.Rows.Count > 0)
                    txtAspirationAmt.Text = sAspirationAmt.Rows[0]["Amount"].ToString();
                sManipulationAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Manipulations");
                if (sManipulationAmt != null && sManipulationAmt.Rows.Count > 0)
                    txtManipulationAmt.Text = sManipulationAmt.Rows[0]["Amount"].ToString();
                sOtherProAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Other Procedures");
                if (sOtherProAmt != null && sOtherProAmt.Rows.Count > 0)
                    txtOtherProcAmt.Text = sOtherProAmt.Rows[0]["Amount"].ToString();

                sEmergencyVisitAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Emergency Visit Charges");
                if (sEmergencyVisitAmt != null && sEmergencyVisitAmt.Rows.Count > 0)
                    txtEmergencyVisitAmt.Text = sEmergencyVisitAmt.Rows[0]["Amount"].ToString();

                //Get Total Bill Amount
                txtPreBalance.Text = this.PreviousTotal;
                txtTotalBillAmt.Text = BLNavdurga.BLAddPatientBillDetails.GetPatientBillTotal(sSrno);
                txtTotalBillAmt.Text = (Int32.Parse(txtTotalBillAmt.Text) + Int32.Parse(this.PreviousTotal)).ToString();
                string sBillno = BLNavdurga.BLAddPatientBillDetails.GetNewBillNo();
                txtBillNo.Text = sBillno;

            }

            catch (Exception Ex)
            {
                MessageBox.Show("Bill Details Are Empty");
                GenerateBill generatebill = new GenerateBill();
                generatebill.Hide();

            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtMedDispAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtDressAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtVisitAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtXrayAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtMiscAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtProcedureAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtTotalBillAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalBillAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            BillDetails bd = new BillDetails();
            if (txtPatientName.Text != null)
            {
                bd.PatientName = this.PatientName;
                if(txtRecievedWith.Text!= null)
                bd.RecievedWith = txtRecievedWith.Text;
                if (txtRecievedWith.Text != null)
                    bd.DressingAmt = txtDressAmt.Text;
                if (txtEmergencyVisitAmt.Text != null)
                    bd.EmergencyVisitAmt = txtEmergencyVisitAmt.Text;
                if (txtVisitType.Text != null)
                    bd.VisitType = txtVisitType.Text;
                if (txtVisitAmt.Text != null)
                    bd.VisitAmt = txtVisitAmt.Text;
                //bd.XrayNumber=
                if (txtXrayAmt.Text != null)
                    bd.XrayAmt = txtXrayAmt.Text;
                //bd.PreviousBalance=
                if (txtPlasterAmt.Text != null)
                    bd.PlasterAmt = txtPlasterAmt.Text;
                if (txtInjectionAmt.Text != null)
                    bd.InjectionAmt = txtInjectionAmt.Text;
                if (txtManipulationAmt.Text != null)
                    bd.ManipulationAmt = txtManipulationAmt.Text;
                if (txtOtherProcAmt.Text != null)
                    bd.OtherProcAmt = txtOtherProcAmt.Text;
                if (txtMiscAmt.Text != null)
                    bd.MiscAmt = txtMiscAmt.Text;
                if (txtPreBalance.Text != null)
                    bd.PreviousBalance = txtPreBalance.Text;
                if (txtTotalBillAmt.Text != null)
                    bd.TotalAmt = txtTotalBillAmt.Text;
                if (txtBillNo.Text != null)
                    bd.BillNo = txtBillNo.Text; 
                 ReportViewer rp = new ReportViewer(bd);
                string sbillNo, sbillTotalAmt;
                sbillNo = txtBillNo.Text;
                int Total = Int32.Parse(this.PreviousTotal);
                sbillTotalAmt = txtTotalBillAmt.Text;
                int TotalAmount = Int32.Parse(sbillTotalAmt) + Total;
                BLNavdurga.BLAddPatientDetails.UpdatePatientBilTotal(Srno, TotalAmount.ToString());
                BLNavdurga.BLAddPatientBillDetails.InsertBillNoDetails(sbillNo, Srno, DateTime.Parse(VisitedDate).ToString("yyyy-MM-dd"), PatientName, sbillTotalAmt);
                BLNavdurga.BLAddPatientBillDetails.UpdateBillNo(sbillNo,Srno);
                rp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter Patient Name First");
            }

        }
    }
}
