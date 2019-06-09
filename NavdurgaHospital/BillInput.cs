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
    public partial class BillInput : Form
    {
        public string PatientName { get; set; }
        public string Srno { get; set; }
        public string VisitedDate { get; set; }
        public string Status { get; set; }


        public BillInput()
        {
            InitializeComponent();
        }

        private void BillInput_Load(object sender, EventArgs e)
        {
            DataTable sVisitType, sVisitAmt;
            string sSrno, sStatus;
            sSrno = Srno.ToString();
            sStatus = Status.ToString();
            txtPatientName.Text = PatientName.ToString();
            txtVisitedDate.Text = VisitedDate.ToString();
            txtAmtCons.Enabled = false;
            if (Status != "Registered" || Status != "Waiting")
            {
                try
                {
                    DataTable sXray;
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


                    sVisitType = BLNavdurga.BLAddPatientBillDetails.GetBillVisitDetails(sSrno);
                    lableCons.Text = sVisitType.Rows[0]["Detail"].ToString();
                    sVisitAmt = BLNavdurga.BLAddPatientBillDetails.GetBillVisitAmount(sSrno);
                    txtAmtCons.Text = sVisitAmt.Rows[0]["Amount"].ToString();
                    txtSingleShoot.Text = BLNavdurga.BLAddAdminConfig.GetXRayPrice("Single Shoot");
                    txtDoubleShoot.Text = BLNavdurga.BLAddAdminConfig.GetXRayPrice("2-Shoot");
                    txtThreeShoot.Text = BLNavdurga.BLAddAdminConfig.GetXRayPrice("3-Shoot");
                    txtFourShoot.Text = BLNavdurga.BLAddAdminConfig.GetXRayPrice("4-Shoot");
                    LoadBillDetails();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Visit Type is Empty & Status Should Be OPD Done ");
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sDetail = string.Empty, sBillDetail = string.Empty, sAmount = string.Empty, sSrno;
            sSrno = Srno.ToString();

            if (!string.IsNullOrEmpty(txtAmtDressing.Text))
            {
                sDetail = txtDressing.Text;
                sBillDetail = "Dressing";
                sAmount = txtAmtDressing.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            }
            if (!string.IsNullOrEmpty(txtXrayAmt.Text))
            {
                sDetail = "SingleShoot~"+txtSingleShoot.Text+"~"+txtSingleNum.Text + "|"+ "2Shoot~" + txtDoubleShoot.Text + "~" + txtDoubleNum.Text + "|" + "3Shoot~" + txtThreeShoot.Text + "~" + txtThreeNum.Text + "|" + "4Shoot~" + txtFourShoot.Text + "~" + txtFourNum.Text;
                sBillDetail = "X-Ray Details";
                sAmount = txtXrayAmt.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);


            }

            if (!string.IsNullOrEmpty(txtPlasterAmt.Text))
            {
                sDetail = txtPlaster.Text;
                sBillDetail = "Plaster";
                sAmount = txtPlasterAmt.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            }
            if (!string.IsNullOrEmpty(txtInjAmt.Text))
            {
                sDetail = txtInjection.Text;
                sBillDetail = "Injection";
                sAmount = txtInjAmt.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            }

            if (!string.IsNullOrEmpty(txtAspAmt.Text))
            {
                sDetail = txtAspiration.Text;
                sBillDetail = "Aspirations";
                sAmount = txtAspAmt.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            }
            if (!string.IsNullOrEmpty(txtManiAmt.Text))
            {
                sDetail = txtmanipulation.Text;
                sBillDetail = "Manipulations";
                sAmount = txtManiAmt.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            }
            if (!string.IsNullOrEmpty(txtOtherAmt.Text))
            {
                sDetail = txtOtherPro.Text;
                sBillDetail = "Other Procedures";
                sAmount = txtOtherAmt.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            }
            if (!string.IsNullOrEmpty(txtMiscAmt.Text))
            {
                sDetail = txtMisc.Text;
                sBillDetail = "Miscellaneous";
                sAmount = txtMiscAmt.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            }
            if (!string.IsNullOrEmpty(txtEmergency.Text))
            {
                sDetail = "Emergency Visit Charges";
                sBillDetail = "Emergency Visit Charges";
                sAmount = txtEmergency.Text;
                BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            }
            //BLNavdurga.BLAddPatientBillDetails.InsertIntoBillDetails(sSrno, sBillDetail, sDetail, sAmount);
            BLNavdurga.BLAddPatientDetails.UpdateTotalAmount(sSrno, txtTotalBillAmt.Text);
            this.Hide();
            
        }
        

        private void txtmedAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAmtDressing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtAmtCons_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtAspAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
        private void txtManiAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
        private void txtOtherAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
        private void txtEmergency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }


        public void LoadBillDetails()
        {
            try
            {
                string sPatientName, sVisitingDate, sSrno;
                DataTable sInjection, sDressing, sXray, sMisc, sPlaster, sAspirations, sManipulations, sOtherPro;
                DataTable sAspirationAmt, sManipulationAmt, sOtherProAmt, sInjectionAmt, sDressingAmt, sXrayAmt, sMiscAmt, sPlasterAmt, sVisitType, sVisitAmt;

                sSrno = Srno.ToString();
                sPatientName = PatientName.ToString();
                sVisitingDate = VisitedDate.ToString();

                txtPatientName.Text = sPatientName.ToString();
                txtVisitedDate.Text = sVisitingDate.ToString();

                //Get Details
                sInjection = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Injection");
                if (sInjection != null && sInjection.Rows.Count > 0)
                    txtInjection.Text = sInjection.Rows[0]["Detail"].ToString();
                sDressing = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Dressing");
                if (sDressing != null && sDressing.Rows.Count > 0)
                    txtDressing.Text = sDressing.Rows[0]["Detail"].ToString();
                sXray = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "X-Ray Details");
               // if (sXray != null && sXray.Rows.Count > 0)
                    //txtXray.Text = sXray.Rows[0]["Detail"].ToString();
                sMisc = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Miscellaneous");
                if (sMisc != null && sMisc.Rows.Count > 0)
                    txtMisc.Text = sMisc.Rows[0]["Detail"].ToString();
                sPlaster = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Plaster");
                if (sPlaster != null && sPlaster.Rows.Count > 0)
                    txtPlaster.Text = sPlaster.Rows[0]["Detail"].ToString();
                sAspirations = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Aspirations");
                if (sAspirations != null && sAspirations.Rows.Count > 0)
                    txtAspiration.Text = sAspirations.Rows[0]["Detail"].ToString();
                sManipulations = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Manipulations");
                if (sManipulations != null && sManipulations.Rows.Count > 0)
                    txtmanipulation.Text = sManipulations.Rows[0]["Detail"].ToString();
                sOtherPro = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromDetails(sSrno, "Other Procedures");
                if (sOtherPro != null && sOtherPro.Rows.Count > 0)
                    txtOtherPro.Text = sOtherPro.Rows[0]["Detail"].ToString();


                //Get Amounts
                sInjectionAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Injection");
                if (sInjectionAmt != null && sInjectionAmt.Rows.Count > 0)
                    txtInjAmt.Text = sInjectionAmt.Rows[0]["Amount"].ToString();
                sDressingAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Dressing");
                if (sDressingAmt != null && sDressingAmt.Rows.Count > 0)
                    txtAmtDressing.Text = sDressingAmt.Rows[0]["Amount"].ToString();
                sXrayAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "X-Ray Details");
                if (sXrayAmt != null && sXrayAmt.Rows.Count > 0)
                    txtXrayAmt.Text = sXrayAmt.Rows[0]["Amount"].ToString();
                sMiscAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Miscellaneous");
                if (sMiscAmt != null && sMiscAmt.Rows.Count > 0)
                    txtMiscAmt.Text = sMiscAmt.Rows[0]["Amount"].ToString();
                sPlasterAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Plaster");
                if (sPlasterAmt != null && sPlasterAmt.Rows.Count > 0)
                    txtPlasterAmt.Text = sPlasterAmt.Rows[0]["Amount"].ToString();
                sAspirationAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Aspirations");
                if (sAspirationAmt != null && sAspirationAmt.Rows.Count > 0)
                    txtAspAmt.Text = sAspirationAmt.Rows[0]["Amount"].ToString();
                sManipulationAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Manipulations");
                if (sManipulationAmt != null && sManipulationAmt.Rows.Count > 0)
                    txtManiAmt.Text = sManipulationAmt.Rows[0]["Amount"].ToString();
                sOtherProAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Other Procedures");
                if (sOtherProAmt != null && sOtherProAmt.Rows.Count > 0)
                    txtOtherAmt.Text = sOtherProAmt.Rows[0]["Amount"].ToString();
                sVisitAmt = BLNavdurga.BLAddPatientBillDetails.GetBillDetailsFromAmount(sSrno, "Emergency Visit Charges");
                if (sVisitAmt != null && sVisitAmt.Rows.Count > 0)
                    txtEmergency.Text = sVisitAmt.Rows[0]["Amount"].ToString();


                //Get Total Bill Amount
                CalculateTotalBillAmount();


            }

            catch (Exception Ex)
            {
                MessageBox.Show("Bill Details Are Empty");


            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtAspAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
        }

        private void txtAmtDressing_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (!string.IsNullOrEmpty(txtTotalBillAmt.Text) && !string.IsNullOrEmpty(txtTotalBillAmt.Text))
                //    txtTotalBillAmt.Text = (Convert.ToInt32(txtTotalBillAmt.Text) + Convert.ToInt32(txtAmtDressing.Text)).ToString();
                //else if (!string.IsNullOrEmpty(txtAmtDressing.Text) && string.IsNullOrEmpty(txtTotalBillAmt.Text))
                //    txtTotalBillAmt.Text = txtTotalBillAmt.Text;
                //else if (string.IsNullOrEmpty(txtTotalBillAmt.Text) && !string.IsNullOrEmpty(txtTotalBillAmt.Text))
                //    txtTotalBillAmt.Text = txtTotalBillAmt.Text;
                //else
                //    txtTotalBillAmt.Text = "0";
                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }

        }
        public void CalculateTotalBillAmount()
        {
            int amtDressing, amtXRAY, amtConsultingCharges, amtEmergency, amtPlaster, amtInjection, amtAspiration, amtManipulation, amtOtherProcedures, amtMiscellaneous, amtTotalBill;
            //amtDressing = int.Parse(txtAmtDressing.Text);
            //amtXRAY = int.Parse(txtXrayAmt.Text);

            //Dressing Amount
            if (!string.IsNullOrEmpty(txtAmtDressing.Text))
                amtDressing = int.Parse(txtAmtDressing.Text);
           else
                amtDressing = 0;
            
            //Emergency Visit
            if (!string.IsNullOrEmpty(txtEmergency.Text))
                amtEmergency = int.Parse(txtEmergency.Text);
            else
                amtEmergency = 0;

            //Visiting Type
            if (!string.IsNullOrEmpty(txtAmtCons.Text))
                amtConsultingCharges = int.Parse(txtAmtCons.Text);
            else
                amtConsultingCharges = 0;

            //Xray Amount
            if (!string.IsNullOrEmpty(txtXrayAmt.Text))
                amtXRAY = int.Parse(txtXrayAmt.Text);
            else
                amtXRAY = 0;

            //Plaster Amount
            if (!string.IsNullOrEmpty(txtPlasterAmt.Text))
                amtPlaster = int.Parse(txtPlasterAmt.Text);
            else
                amtPlaster = 0;

            //Injection Amount
            if (!string.IsNullOrEmpty(txtInjAmt.Text))
                amtInjection = int.Parse(txtInjAmt.Text);
            else
                amtInjection = 0;

            //Aspiration Amount
            if (!string.IsNullOrEmpty(txtAspAmt.Text))
                amtAspiration = int.Parse(txtAspAmt.Text);
            else
                amtAspiration = 0;

            //Manipulation Amount
            if (!string.IsNullOrEmpty(txtManiAmt.Text))
                amtManipulation = int.Parse(txtManiAmt.Text);
            else
                amtManipulation = 0;

            //Other Procedures Amount
            if (!string.IsNullOrEmpty(txtOtherAmt.Text))
                amtOtherProcedures = int.Parse(txtOtherAmt.Text);
            else
                amtOtherProcedures = 0;

            //Misc Amount
            if (!string.IsNullOrEmpty(txtMiscAmt.Text))
                amtMiscellaneous = int.Parse(txtMiscAmt.Text);
            else
                amtMiscellaneous = 0;

            amtTotalBill = amtDressing + amtEmergency + amtConsultingCharges + amtXRAY + amtPlaster + amtInjection + amtAspiration + amtManipulation + amtOtherProcedures + amtMiscellaneous;
            txtTotalBillAmt.Text = amtTotalBill.ToString();
        }

        private void txtTotalBillAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmergency_TextChanged(object sender, EventArgs e)
        {
            try
            { 

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
}

        private void txtAmtCons_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
        }

        private void txtXrayAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
        }

        private void txtPlasterAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
        }

        private void txtInjAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
        }

        private void txtManiAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
        }

        private void txtOtherAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
        }

        private void txtMiscAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CalculateTotalBillAmount();
            }
            catch (Exception ex)
            { }
        }

        private void CalculateXRayAmt()
        {
            int Shoot1Price=0, Shoot2Price=0, Shoot3Price=0, Shoot4Price=0, Shoot1Unit=0, Shoot2Unit=0, Shoot3Unit=0, Shoot4Unti=0;
            if(txtSingleShoot.Text!=null&&txtSingleShoot.Text.ToString()!=String.Empty)
                Shoot1Price =Int32.Parse(txtSingleShoot.Text);
            if (txtDoubleShoot.Text != null && txtDoubleShoot.Text.ToString() != String.Empty)
                Shoot2Price = Int32.Parse(txtDoubleShoot.Text);
            if (txtThreeShoot.Text != null && txtThreeShoot.Text.ToString() != String.Empty)
                Shoot3Price = Int32.Parse(txtThreeShoot.Text);
            if (txtFourShoot.Text != null && txtFourShoot.Text.ToString() != String.Empty)
                Shoot4Price = Int32.Parse(txtFourShoot.Text);
            if (txtSingleNum.Text != null && txtSingleNum.Text.ToString() != String.Empty)
                Shoot1Unit = Int32.Parse(txtSingleNum.Text);
            if (txtDoubleNum.Text != null && txtDoubleNum.Text.ToString() != String.Empty)
                Shoot2Unit = Int32.Parse(txtDoubleNum.Text);
            if (txtThreeNum.Text != null && txtThreeNum.Text.ToString() != String.Empty)
                Shoot3Unit = Int32.Parse(txtThreeNum.Text);
            if (txtFourNum.Text != null && txtFourNum.Text.ToString() != String.Empty)
                Shoot4Unti = Int32.Parse(txtFourNum.Text);

            txtXrayAmt.Text=(Shoot1Price * Shoot1Unit+Shoot2Price * Shoot2Unit + Shoot3Price * Shoot3Unit + Shoot4Price * Shoot4Unti).ToString();

        }

        private void txtSingleNum_TextChanged(object sender, EventArgs e)
        {
            CalculateXRayAmt();
        
        }
    }
}
