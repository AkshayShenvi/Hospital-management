using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NavdurgaHospital
{
    public partial class OpdInputScreen : Form
    {
        DataTable dtDiagnosis, dtTreatment, dtComorbidities, dtPrescription, dtInvestigation, dtComplaints, dtExamNotes, dTablePrescription, dTableDiagnosis, dTableComorbidities, dTableTreatment, dTableInvestigation, dTableComplaints, dTableExamNotes, dtPatientPrescription;

        public OpdInputScreen()
        {
            InitializeComponent();


        }

        public string PatientName { get; set; }
        public string SrNo { get; set; }
        public string ExamNote { get; set; }
        public string Complaint { get; set; }
        public string Investigation { get; set; }
        public string Comorbidity { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Prescription { get; set; }
        public string TotalAmt { get; set; }
        public string VisitType { get; set; }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OpdInputScreen_Load(object sender, EventArgs e)
        {
            lableName.Text = PatientName.ToString();
            txtExamNotes.Text = ExamNote.ToString();
            txtComplaints.Text = Complaint.ToString();
            txtInvestigation.Text = Investigation.ToString();
            txtComorbidities.Text = Comorbidity.ToString();
            txtDiagnosis.Text = Diagnosis.ToString();
            txtTreatment.Text = Treatment.ToString();
            txtPrescription.Text = Prescription.ToString();
            if (VisitType.ToString() != String.Empty)
            {
                if (VisitType.ToString() == "Consulting Charges")
                    rdbConsulting.Checked = true;
                else if (VisitType.ToString() == "Follow Up Charges")
                    rdbFollowUp.Checked = true;
                else
                {
                    rdbConsulting.Checked = false;
                    rdbFollowUp.Checked = false;
                }

            }
            //On Load
            try
            {
                LoadExamNotesType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadComplaintsType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadInvestigationType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadMedicineType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadDiagnosisType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadComorbidities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                LoadTreatmentType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadPatientPrescription();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void cmbPrescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbPrescription.SelectedItem;
            string sMedicineType = drv.Row.ItemArray[0].ToString();
            dTablePrescription = BLNavdurga.BLAddPresciption.GetPrescription(sMedicineType);
            cmbPrescription1.DataSource = dTablePrescription;
            cmbPrescription1.ValueMember = "MedicineName";
            cmbPrescription1.DisplayMember = "MedicineName";
        }

        private void cmbExamnotes1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbTreatment.SelectedItem;
            string sTreatmentType = drv.Row.ItemArray[0].ToString();
            dTableTreatment = BLNavdurga.BLAddTreatment.GetTreatment(sTreatmentType);
            cmbTreatment1.DataSource = dTableTreatment;
            cmbTreatment1.ValueMember = "Treatment";
            cmbTreatment1.DisplayMember = "Treatment";
        }




        private void cmbComplaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbComplaints.SelectedItem;
            string sComplaintsType = drv.Row.ItemArray[0].ToString();
            dTableComplaints = BLNavdurga.BLAddComplaints.GetComplaints(sComplaintsType);
            cmbcomplaint1.DataSource = dTableComplaints;
            cmbcomplaint1.ValueMember = "Complaint";
            cmbcomplaint1.DisplayMember = "Complaint";
        }

        private void cmbExamNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbExamNotes.SelectedItem;
            string sExamNotesType = drv.Row.ItemArray[0].ToString();
            dTableExamNotes = BLNavdurga.BLAddExamNotes.GetExamNotes(sExamNotesType);
            cmbExamnotes1.DataSource = dTableExamNotes;
            cmbExamnotes1.ValueMember = "Examnotes";
            cmbExamnotes1.DisplayMember = "Examnotes";
        }

        private void cmbInvestigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbInvestigation.SelectedItem;
            string sInvestigationType = drv.Row.ItemArray[0].ToString();
            dTableInvestigation = BLNavdurga.BLAddInvestigation.GetInvestigation(sInvestigationType);
            cmbInvestigation1.DataSource = dTableInvestigation;
            cmbInvestigation1.ValueMember = "Investigations";
            cmbInvestigation1.DisplayMember = "Investigations";
        }

        private void cmbDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbDiagnosis.SelectedItem;
            string sDiagnosisType = drv.Row.ItemArray[0].ToString();
            dTableDiagnosis = BLNavdurga.BLAddDiagnosis.GetDiagnosis(sDiagnosisType);
            cmbDiagnosis1.DataSource = dTableDiagnosis;
            cmbDiagnosis1.ValueMember = "Diagnosis";
            cmbDiagnosis1.DisplayMember = "Diagnosis";
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Add From combobox to Textbox
        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbcomplaint1.SelectedItem;
            string sComplaint = drv.Row.ItemArray[0].ToString();
            if (txtNewComplaints.Text != String.Empty && txtComplaints.Text == String.Empty)
            {
                txtComplaints.Text = txtNewComplaints.Text;
                txtNewComplaints.Clear();
            }
            else if (txtNewComplaints.Text != String.Empty && txtComplaints.Text != String.Empty)
            {
                if (!txtComplaints.Text.Contains(txtNewComplaints.Text))
                    txtComplaints.Text += "," + txtNewComplaints.Text;
                txtNewComplaints.Clear();
            }
            else if (txtComplaints.Text == String.Empty)
            {
                txtComplaints.Text += sComplaint.ToString();
            }
            else if (txtComplaints.Text != String.Empty)
            {
                if (!txtComplaints.Text.Contains(sComplaint))
                    txtComplaints.Text += "," + sComplaint.ToString();

            }
            else
            {
                MessageBox.Show("Select a Complaint");
            }

        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbExamnotes1.SelectedItem;
            string sExamNotes = drv.Row.ItemArray[0].ToString();
            if (txtNewExam.Text != String.Empty && txtExamNotes.Text == String.Empty)
            {
                txtExamNotes.Text = txtNewExam.Text;
                txtNewExam.Clear();
            }
            else if (txtNewExam.Text != String.Empty && txtExamNotes.Text != String.Empty)
            {
                txtExamNotes.Text += "," + txtNewExam.Text;
                txtNewExam.Clear();
            }
            else if (txtExamNotes.Text == String.Empty)
            {
                txtExamNotes.Text += sExamNotes.ToString();

            }
            else if (txtExamNotes.Text != String.Empty)
            {
                if (!txtExamNotes.Text.Contains(sExamNotes))
                    txtExamNotes.Text += "," + sExamNotes.ToString();

            }
            else
            {
                MessageBox.Show("Select an Exam Note");
            }

        }

        private void btnSaveInvest_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbInvestigation1.SelectedItem;
            string sInvestigation = drv.Row.ItemArray[0].ToString();
            if (txtNewInvesti.Text != String.Empty && txtInvestigation.Text == String.Empty)
            {
                txtInvestigation.Text = txtNewInvesti.Text;
                txtNewInvesti.Clear();
            }
            else if (txtNewInvesti.Text != String.Empty && txtInvestigation.Text != String.Empty)
            {
                txtInvestigation.Text += "," + txtNewInvesti.Text;
                txtNewInvesti.Clear();
            }
            else if (txtInvestigation.Text == String.Empty)
            {
                txtInvestigation.Text += sInvestigation.ToString();

            }
            else if (txtInvestigation.Text != String.Empty)
            {
                if (!txtInvestigation.Text.Contains(sInvestigation))
                    txtInvestigation.Text += "," + sInvestigation.ToString();

            }
            else
            {
                MessageBox.Show("Select an Investigation");
            }
        }
        private void btnSaveComorbid_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbComorbidities.SelectedItem;
            string sComorbidities = drv.Row.ItemArray[0].ToString();
            if (txtNewComorbidity.Text != String.Empty && txtComorbidities.Text == String.Empty)
            {
                txtComorbidities.Text = txtNewComorbidity.Text;
                txtNewComorbidity.Clear();
            }
            else if (txtNewComorbidity.Text != String.Empty && txtComorbidities.Text != String.Empty)
            {
                txtComorbidities.Text += "," + txtNewComorbidity.Text;
                txtNewComorbidity.Clear();
            }
            else if (txtComorbidities.Text == String.Empty)
            {
                txtComorbidities.Text += sComorbidities.ToString();

            }
            else if (txtComorbidities.Text != String.Empty)
            {
                if (!txtComorbidities.Text.Contains(sComorbidities))
                    txtComorbidities.Text += "," + sComorbidities.ToString();

            }
            else
            {
                MessageBox.Show("Select a Comorbidity");
            }
        }
        private void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbDiagnosis1.SelectedItem;
            string sDiagnosis = drv.Row.ItemArray[0].ToString();
            if (txtNewDiagnosis.Text != String.Empty && txtDiagnosis.Text == String.Empty)
            {
                txtDiagnosis.Text = txtNewDiagnosis.Text;
                txtNewDiagnosis.Clear();
            }
            else if (txtNewDiagnosis.Text != String.Empty && txtDiagnosis.Text != String.Empty)
            {
                txtDiagnosis.Text += "," + txtNewDiagnosis.Text;
                txtNewDiagnosis.Clear();
            }
            else if (txtDiagnosis.Text == String.Empty)
            {
                txtDiagnosis.Text += sDiagnosis.ToString();

            }
            else if (txtDiagnosis.Text != String.Empty)
            {
                if (!txtDiagnosis.Text.Contains(sDiagnosis))
                    txtDiagnosis.Text += "," + sDiagnosis.ToString();

            }
            else
            {
                MessageBox.Show("Select a Diagnosis");
            }
        }
        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbTreatment1.SelectedItem;
            string sTreatment = drv.Row.ItemArray[0].ToString();
            if (txtNewTreatment.Text != String.Empty && txtTreatment.Text == String.Empty)
            {
                txtTreatment.Text = txtNewTreatment.Text;
                txtNewTreatment.Clear();
            }
            else if (txtNewTreatment.Text != String.Empty && txtTreatment.Text != String.Empty)
            {
                txtTreatment.Text += "," + txtNewTreatment.Text;
                txtNewTreatment.Clear();
            }
            else if (txtTreatment.Text == String.Empty)
            {
                txtTreatment.Text += sTreatment.ToString();

            }
            else if (txtTreatment.Text != String.Empty)
            {
                if (!txtTreatment.Text.Contains(sTreatment))
                    txtTreatment.Text += "," + sTreatment.ToString();

            }
            else
            {
                MessageBox.Show("Select a Treatment");
            }
        }
        private void btnSavePrescription_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbPrescription1.SelectedItem;
            string sPrescription = drv.Row.ItemArray[0].ToString();
            if (txtNewPrescription.Text != String.Empty && txtPrescription.Text == String.Empty)
            {
                txtPrescription.Text = txtNewPrescription.Text;
                sPrescription = txtNewPrescription.Text;
                txtNewPrescription.Clear();

            }
            else if (txtNewPrescription.Text != String.Empty && txtPrescription.Text != String.Empty)
            {
                txtPrescription.Text += "," + txtNewPrescription.Text;
                sPrescription = txtNewPrescription.Text;
                txtNewPrescription.Clear();
            }
            else if (txtPrescription.Text == String.Empty)
            {
                txtPrescription.Text += sPrescription.ToString();

            }
            else if (txtPrescription.Text != String.Empty)
            {
                if (!txtPrescription.Text.Contains(sPrescription))
                    txtPrescription.Text += "," + sPrescription.ToString();

            }
            else
            {
                MessageBox.Show("Select a Prescription");
            }
            // sPrescription
            //  INSERT INTO `db_navdurgahospital`.`tbl_patientprescription` (`SrNo`, `PrescriptionName`, `Frequency`, `TimePeriod`, `Specification`) VALUES('7', 'dfgfb', '1ce', '2months', 'after meals');
            try
            {
                DataTable dtPrescription = (DataTable)dgvPrescription.DataSource;
                DataRow dr = dtPrescription.NewRow();
                string sFrequency, sSpecification, slstitems, sWeek;
                dr["SrNo"] = SrNo.ToString();
                dr["PrescriptionName"] = sPrescription.ToString();
                if (cblist.SelectedItem.ToString() != String.Empty)
                {
                    slstitems = cblist.SelectedItem.ToString();
                }
                else
                {
                    slstitems = "Two-Weeks";
                }
                dr["TimePeriod"] = slstitems.ToString();
                if (rdbonce.Checked)
                {
                    sFrequency = "Once-a-Day";
                }
                else if (rdbtwice.Checked)
                {
                    sFrequency = "Twice-a-Day";
                }
                else if (rdbthrice.Checked)
                {
                    sFrequency = "Thrice-a-Day";
                }
                else if (rdbfourtimes.Checked)
                {
                    sFrequency = "Four-Times-a-Day";
                }
                else
                {
                    sFrequency = "Twice-a-Day";
                }
                dr["Frequency"] = sFrequency.ToString();
                if (rdbbefore.Checked)
                {
                    sSpecification = "Before Meals";
                }
                else
                {
                    sSpecification = "After Meals";
                }
                dr["Specification"] = sSpecification.ToString();


                if (rdbcklstWeek.SelectedItem.ToString() != String.Empty)
                {
                    sWeek = rdbcklstWeek.SelectedItem.ToString();
                }
                else
                {
                    sWeek = "Daily";
                }
                dr["TimesAWeek"] = sWeek.ToString();
                dtPrescription.Rows.Add(dr);
                dgvPrescription.DataSource = dtPrescription;
                SavePatientPrescription();

                rdbonce.Checked = false;
                rdbtwice.Checked = false;
                rdbthrice.Checked = false;
                rdbfourtimes.Checked = false;
                cblist.ClearSelected();
                rdbcklstWeek.ClearSelected();
                rdbbefore.Checked = false;
                rdbAfter.Checked = false;
            }
            catch (Exception Ex)
            { }

        }







        private void btnSaveOPD_Click(object sender, EventArgs e)
        {

            string sOPDEntry;
            string sOPDType;
            string sPKSrno;
            string sAmount;

            sPKSrno = SrNo.ToString();


            if (txtComplaints.Text != String.Empty)
            {
                sOPDEntry = txtComplaints.Text;
                sOPDType = "Complaints";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
            }
            if (txtExamNotes.Text != String.Empty)
            {
                sOPDEntry = txtExamNotes.Text;
                sOPDType = "ExamNotes";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
            }
            if (txtInvestigation.Text != String.Empty)
            {
                sOPDEntry = txtInvestigation.Text;
                sOPDType = "Investigation";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
            }
            if (txtComorbidities.Text != String.Empty)
            {
                sOPDEntry = txtComorbidities.Text;
                sOPDType = "Comorbidities";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
            }
            if (txtDiagnosis.Text != String.Empty)
            {
                sOPDEntry = txtDiagnosis.Text;
                sOPDType = "Diagnosis";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
            }
            if (txtTreatment.Text != String.Empty)
            {
                sOPDEntry = txtTreatment.Text;
                sOPDType = "Treatment";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
            }
            if (txtPrescription.Text != String.Empty)
            {
                sOPDEntry = txtPrescription.Text;
                sOPDType = "Prescription";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
            }
            CalculateBillAmtAndSave();
            //else
            //{
            //    MessageBox.Show("Please Select a Visit Type");
            //}
            if (rdbConsulting.Checked == true)
            {
                sAmount = txtCustom.Text;
                sOPDType = "TotalAmt";

                sOPDEntry = "Consulting Charges";
                sOPDType = "VisitType";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
                BLNavdurga.BLAddPatientBillDetails.InsertBillDetails(sPKSrno, sOPDType, sOPDEntry, sAmount);
            }
            else if (rdbFollowUp.Checked == true)
            {
                sAmount = txtCustom.Text;
                sOPDType = "TotalAmt";

                sOPDEntry = "Follow Up Charges";
                sOPDType = "VisitType";
                BLNavdurga.BLAddPatientDetails.SaveOPDResult(sOPDType, sOPDEntry, sPKSrno);
                BLNavdurga.BLAddPatientBillDetails.InsertBillDetails(sPKSrno, sOPDType, sOPDEntry, sAmount);
            }


            BLNavdurga.BLAddPatientDetails.UpdateStatus("OPD Done", sPKSrno);
            this.Hide();
        }

        private void CalculateBillAmt()
        {

            if (rdbConsulting.Checked == true || rdbFollowUp.Checked == true)
            {
                if (rdbConsulting.Checked == true && cbkNoCharge.Checked == true)
                {
                    txtCustom.Text = "0";
                    txtCustom.Enabled = false;

                }
                else if (rdbConsulting.Checked == true && cbkCustom.Checked == true)
                {
                    txtCustom.Text = "0";
                    txtCustom.Enabled = true;



                }
                else if (rdbConsulting.Checked == true && (cbkCustom.Checked == false && cbkNoCharge.Checked == false))
                {
                    txtCustom.Text = BLNavdurga.BLAddAdminConfig.GetConfigValue("Consulting Charges");
                    txtCustom.Enabled = false;

                }
                else if (rdbFollowUp.Checked == true && cbkNoCharge.Checked == true)
                {
                    txtCustom.Text = "0";
                    txtCustom.Enabled = false;

                }
                else if (rdbFollowUp.Checked == true && cbkCustom.Checked == true)
                {
                    txtCustom.Text = "0";
                    txtCustom.Enabled = true;

                }
                else if (rdbFollowUp.Checked == true && (cbkCustom.Checked == false && cbkNoCharge.Checked == false))
                {
                    txtCustom.Text = BLNavdurga.BLAddAdminConfig.GetConfigValue("Follow Up Charges"); //"300";
                    txtCustom.Enabled = false;

                }



            }
        }
        private void CalculateBillAmtAndSave()
        {

            if (rdbConsulting.Checked == true || rdbFollowUp.Checked == true)
            {
                if (rdbConsulting.Checked == true && cbkNoCharge.Checked == true)
                {
                    txtCustom.Text = "0";
                    txtCustom.Enabled = false;
                    int Amt = Int32.Parse(txtCustom.Text);
                    BLNavdurga.BLAddPatientDetails.UpdatePatientBilTotal(SrNo, Amt.ToString());
                }
                else if (rdbConsulting.Checked == true && cbkCustom.Checked == true)
                {

                    txtCustom.Text = txtCustom.Text == String.Empty ? "0" : txtCustom.Text;
                    txtCustom.Enabled = true;
                    int Amt = Int32.Parse(txtCustom.Text);
                    BLNavdurga.BLAddPatientDetails.UpdatePatientBilTotal(SrNo, Amt.ToString());


                }
                else if (rdbConsulting.Checked == true && (cbkCustom.Checked == false && cbkNoCharge.Checked == false))
                {
                    txtCustom.Text = BLNavdurga.BLAddAdminConfig.GetConfigValue("Consulting Charges");
                    txtCustom.Enabled = false;

                    int Amt = Int32.Parse(txtCustom.Text);
                    BLNavdurga.BLAddPatientDetails.UpdatePatientBilTotal(SrNo, Amt.ToString());

                }
                else if (rdbFollowUp.Checked == true && cbkNoCharge.Checked == true)
                {
                    txtCustom.Text = "0";
                    txtCustom.Enabled = false;
                    int Amt = Int32.Parse(txtCustom.Text);
                    BLNavdurga.BLAddPatientDetails.UpdatePatientBilTotal(SrNo, Amt.ToString());
                }
                else if (rdbFollowUp.Checked == true && cbkCustom.Checked == true)
                {
                    //txtCustom.Text = "0";
                    txtCustom.Enabled = true;
                    int Amt = Int32.Parse(txtCustom.Text);
                    BLNavdurga.BLAddPatientDetails.UpdatePatientBilTotal(SrNo, Amt.ToString());
                }
                else if (rdbFollowUp.Checked == true && (cbkCustom.Checked == false && cbkNoCharge.Checked == false))
                {
                    txtCustom.Text = BLNavdurga.BLAddAdminConfig.GetConfigValue("Follow Up Charges"); //"300";
                    txtCustom.Enabled = false;

                    int Amt1 = Int32.Parse(txtCustom.Text);
                    BLNavdurga.BLAddPatientDetails.UpdatePatientBilTotal(SrNo, Amt1.ToString());


                }



            }
        }


        //Calculate Bill Amount
        private void rdbConsulting_CheckedChanged(object sender, EventArgs e)
        {
            CalculateBillAmt();
        }

        private void rdbFollowUp_CheckedChanged(object sender, EventArgs e)
        {
            CalculateBillAmt();
        }

        private void cbkNoCharge_CheckedChanged(object sender, EventArgs e)
        {
            CalculateBillAmt();
        }

        private void cbkCustom_CheckedChanged(object sender, EventArgs e)
        {
            CalculateBillAmt();
        }



        private void OpdInputScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnSavepreTable_Click(object sender, EventArgs e)
        {
            BLNavdurga.BLAddPatientPrescription.SavePatientPrescriptionDetails(dtPatientPrescription);
            LoadPatientPrescription();
        }

        private void lableName_Click(object sender, EventArgs e)
        {

        }

        private void txtPrescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cmbcomplaint1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Load Type
        public void LoadExamNotesType()
        {
            dtExamNotes = BLNavdurga.BLAddExamNotes.GetExamNotesType();
            cmbExamNotes.DataSource = dtExamNotes;
            cmbExamNotes.ValueMember = "examnotestype";
            cmbExamNotes.DisplayMember = "examnotestype";

        }

        public void LoadComplaintsType()
        {
            dtComplaints = BLNavdurga.BLAddComplaints.GetComplaintsType();
            cmbComplaints.DataSource = dtComplaints;
            cmbComplaints.ValueMember = "complainttype";
            cmbComplaints.DisplayMember = "complainttype";
        }

        public void LoadInvestigationType()
        {
            dtInvestigation = BLNavdurga.BLAddInvestigation.GetInvestigationType();
            cmbInvestigation.DataSource = dtInvestigation;
            cmbInvestigation.ValueMember = "Investigationtype";
            cmbInvestigation.DisplayMember = "Investigationtype";

        }

        public void LoadMedicineType()
        {
            dtPrescription = BLNavdurga.BLAddPresciption.GetMedicineType();
            cmbPrescription.DataSource = dtPrescription;
            cmbPrescription.ValueMember = "MedicineType";
            cmbPrescription.DisplayMember = "MedicineType";
        }

        public void LoadDiagnosisType()
        {
            dtDiagnosis = BLNavdurga.BLAddDiagnosis.GetDiagnosisType();
            cmbDiagnosis.DataSource = dtDiagnosis;
            cmbDiagnosis.ValueMember = "DiagnosisType";
            cmbDiagnosis.DisplayMember = "DiagnosisType";
        }

        public void LoadComorbidities()
        {
            dtComorbidities = BLNavdurga.BLAddComorbidities.GetComorbiditiesType();
            cmbComorbidities.DataSource = dtComorbidities;
            cmbComorbidities.ValueMember = "comorbidity";
            cmbComorbidities.DisplayMember = "comorbidity";
        }
        public void LoadTreatmentType()
        {
            dtTreatment = BLNavdurga.BLAddTreatment.GetTreatmentType();
            cmbTreatment.DataSource = dtTreatment;
            cmbTreatment.ValueMember = "TreatmentType";
            cmbTreatment.DisplayMember = "TreatmentType";
        }

        public void LoadPatientPrescription()
        {
            string sPKSrno = SrNo.ToString();
            dtPatientPrescription = BLNavdurga.BLAddPatientPrescription.GetPatientPrescriptionDetails(sPKSrno);
            dgvPrescription.DataSource = dtPatientPrescription;
        }
        public void SavePatientPrescription()
        {
            try
            {
                BLNavdurga.BLAddPatientPrescription.SavePatientPrescriptionDetails(dtPatientPrescription);
                LoadPatientPrescription();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
