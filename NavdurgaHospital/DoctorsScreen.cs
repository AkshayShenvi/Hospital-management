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
    public partial class DoctorsScreen : Form
    {
        string strName, strSrno, strPhn, strExamNotes, strComplaints, strInvestigation, strComorbidities, strDiagnosis, strTreatment, strPrescription, sTotalAmt, sVisitType;
        DataTable dTable, dtPatientDetails;
        Timer timer = new Timer();

        public DoctorsScreen()
        {
            InitializeComponent();


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();

        }

        private void DoctorsScreen_Load(object sender, EventArgs e)
        {

            try
            {
                LoadPatientDetailsData();

                Timer_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sSrno, sName, sVisitedDate;
            //if (dgvXray.SelectedCells.ToString() != String.Empty)
            //{
            string Status;
            Status = this.dataGridView1.CurrentRow.Cells["PatientStatus"].Value.ToString();
            //if (Status == "Registered" || Status == "Waiting")
            //{
            BillInput billInput = new BillInput();
            sSrno = this.dataGridView1.CurrentRow.Cells["SrNo"].Value.ToString();
            sName = this.dataGridView1.CurrentRow.Cells["PatientName"].Value.ToString();
            sVisitedDate = this.dataGridView1.CurrentRow.Cells["VisitingDate"].Value.ToString();
            billInput.Srno = sSrno;
            billInput.Status = Status;
            billInput.PatientName = sName;
            billInput.VisitedDate = sVisitedDate;
            billInput.ShowDialog();
            timer.Start();
            //}
            //else
            //{
            //    MessageBox.Show("Patient Status Should be Registered Or Waiting");
            //}
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            timer.Stop();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string sSrno, sName, sVisitedDate,sAge,sComplaints,sExamNotes,sComorbidities,sDiagnosis,sInvestigation,sTreatment,sGender,sPrescription;
            //    if (dataGridView1.SelectedCells.ToString() != String.Empty)
            //    {
            //        string Status;
            //        Status = this.dataGridView1.CurrentRow.Cells["PatientStatus"].Value.ToString();
            //        if (Status == "OPD Done" || Status == "In OPD")
            //        {
            //            GenerateBill printbill = new GenerateBill();
            //            OPDDetails od = new OPDDetails();
            //            sName = this.dataGridView1.CurrentRow.Cells["PatientName"].Value.ToString();
            //            if (sName.ToString() != null && sName.ToString() != string.Empty)
            //            {
            //                od.PatientName = sName.ToString();

            //                sSrno = this.dataGridView1.CurrentRow.Cells["SrNo"].Value.ToString();
            //                od.SrNo = sSrno.ToString();
            //                sVisitedDate = this.dataGridView1.CurrentRow.Cells["VisitingDate"].Value.ToString();
            //                if (sVisitedDate.ToString() != null && sVisitedDate.ToString() != string.Empty)
            //                    od.VisitedDate= sVisitedDate.ToString();
            //                else { od.VisitedDate = "null".ToString(); }

            //                sAge = this.dataGridView1.CurrentRow.Cells["VisitingDate"].Value.ToString();
            //                if (sAge.ToString() != null && sAge.ToString() != string.Empty)
            //                    od.Age = sAge.ToString();
            //                else { od.Age = "null".ToString(); }

            //                sComplaints = this.dataGridView1.CurrentRow.Cells["Complaints"].Value.ToString();
            //                if (sComplaints.ToString() != null && sComplaints.ToString() != string.Empty)
            //                    od.Complaints = sComplaints.ToString();
            //                else { od.Complaints = "null".ToString(); }

            //                sExamNotes = this.dataGridView1.CurrentRow.Cells["ExamNotes"].Value.ToString();
            //                if (sExamNotes.ToString() != null && sExamNotes.ToString() != string.Empty)
            //                    od.ExamNotes = sExamNotes.ToString();
            //                else { od.ExamNotes = "null".ToString(); }

            //                sComorbidities = this.dataGridView1.CurrentRow.Cells["Comorbidities"].Value.ToString();
            //                if (sComorbidities.ToString() != null && sComorbidities.ToString() != string.Empty)
            //                    od.Comorbidity = sComorbidities.ToString();
            //                else { od.Comorbidity = "null".ToString(); }

            //                sDiagnosis = this.dataGridView1.CurrentRow.Cells["Diagnosis"].Value.ToString();
            //                if (sDiagnosis.ToString() != null && sDiagnosis.ToString() != string.Empty)
            //                    od.Diagnosis = sDiagnosis.ToString();
            //                else { od.Diagnosis = "null".ToString(); }

            //                sInvestigation = this.dataGridView1.CurrentRow.Cells["Investigation"].Value.ToString();
            //                if (sInvestigation.ToString() != null && sInvestigation.ToString() != string.Empty)
            //                    od.Investigation = sInvestigation.ToString();
            //                else { od.Investigation = "null".ToString(); }

            //                sTreatment = this.dataGridView1.CurrentRow.Cells["Treatment"].Value.ToString();
            //                if (sTreatment.ToString() != null && sTreatment.ToString() != string.Empty)
            //                    od.Treatment = sTreatment.ToString();
            //                else { od.Treatment = "null".ToString(); }

            //                sGender = "Male";
            //                sPrescription = "ABC";
            //                od.Gender = sGender.ToString();
            //                od.Prescription = sPrescription.ToString();
            //                OPDReportViewer opd = new OPDReportViewer(od);
            //                opd.ShowDialog();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Status Should Be 'OPD Done' Or 'In OPD'");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Select a Name");
            //    }
            //}
            //catch (Exception ex) { }
            try
            {
                string sSrno, sName, sVisitedDate, sAge, sComplaints, sExamNotes, sComorbidities, sDiagnosis, sInvestigation, sTreatment, sPrescription, sDefault;
                if (dataGridView1.SelectedCells.ToString() != String.Empty)
                {
                    string Status;
                    Status = this.dataGridView1.CurrentRow.Cells["PatientStatus"].Value.ToString();
                    if (Status == "OPD Done" || Status == "In OPD")
                    {
                        sDefault = "--";
                        GenerateOPD generate = new GenerateOPD();
                        sSrno = this.dataGridView1.CurrentRow.Cells["SrNo"].Value.ToString();
                        generate.Srno = sSrno;
                        sName = this.dataGridView1.CurrentRow.Cells["PatientName"].Value.ToString();
                        generate.PName = sName;
                        sVisitedDate = this.dataGridView1.CurrentRow.Cells["VisitingDate"].Value.ToString();
                        generate.VisitedDate = sVisitedDate;
                        sAge = this.dataGridView1.CurrentRow.Cells["Age"].Value.ToString();
                        if (sAge.ToString() != null && sAge.ToString() != string.Empty)
                            generate.Age = sAge;
                        else
                            generate.Age = sDefault;
                        sComplaints = this.dataGridView1.CurrentRow.Cells["Complaints"].Value.ToString();
                        if (sComplaints.ToString() != null && sComplaints.ToString() != string.Empty)
                            generate.Complaints = sComplaints;
                        else
                            generate.Complaints = sDefault;
                        sExamNotes = this.dataGridView1.CurrentRow.Cells["ExamNotes"].Value.ToString();
                        if (sExamNotes.ToString() != null && sExamNotes.ToString() != string.Empty)
                            generate.ExamNotes = sExamNotes;
                        else
                            generate.ExamNotes = sDefault;
                        sComorbidities = this.dataGridView1.CurrentRow.Cells["Comorbidities"].Value.ToString();
                        if (sComorbidities.ToString() != null && sComorbidities.ToString() != string.Empty)
                            generate.Comorbidities = sComorbidities;
                        else
                            generate.Comorbidities = sDefault;
                        sDiagnosis = this.dataGridView1.CurrentRow.Cells["Diagnosis"].Value.ToString();
                        if (sDiagnosis.ToString() != null && sDiagnosis.ToString() != string.Empty)
                            generate.Diagnosis = sDiagnosis;
                        else
                            generate.Diagnosis = sDefault;
                        sInvestigation = this.dataGridView1.CurrentRow.Cells["Investigation"].Value.ToString();
                        if (sInvestigation.ToString() != null && sInvestigation.ToString() != string.Empty)
                            generate.Investigation = sInvestigation;
                        else
                            generate.Investigation = sDefault;
                        sTreatment = this.dataGridView1.CurrentRow.Cells["Treatment"].Value.ToString();
                        if (sTreatment.ToString() != null && sTreatment.ToString() != string.Empty)
                            generate.Treatment = sTreatment;
                        else
                            generate.Treatment = sDefault;
                        sPrescription = this.dataGridView1.CurrentRow.Cells["Prescription"].Value.ToString();
                        if (sPrescription.ToString() != null && sPrescription.ToString() != string.Empty)
                            generate.Prescription = sPrescription;
                        else
                            generate.Prescription = sDefault;

                        generate.ShowDialog();
                        timer.Start();

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Certificate certificate = new Certificate();
            certificate.ShowDialog();
            timer.Start();
        }

        private void Timer_Load()
        {
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            LoadPatientDetailsData();
        }

        private void btnOpdSave_Click(object sender, EventArgs e)
        {
            try
            {
                BLNavdurga.BLAddPatientDetails.SavePatientDetails(dTable);

                LoadPatientDetailsData();
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //DataRowView drv = (DataRowView)cmbDate.SelectedItem;
        //    string sDateType = (DateTime.Parse(dtpVisitingDate.Text)).ToString("yyyy-MMM-dd");
        //    dTable = BLNavdurga.BLAddPatientDetails.GetPatientDetails(sDateType);
        //    dataGridView1.DataSource = dTable;
        //}





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dtpVisitingDate_ValueChanged(object sender, EventArgs e)
        {
            //string sDateType = (DateTime.Parse(dtpVisitingDate.Text)).ToString("yyyy-MM-dd");
            //dTable = BLNavdurga.BLAddPatientDetails.GetPatientDetails(sDateType);
            //dataGridView1.DataSource = dTable;
            //dataGridView1.Columns["Sr. No."].DisplayIndex = 0;
            LoadPatientDetailsData();


        }



        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            strName = this.dataGridView1.CurrentRow.Cells["PatientName"].Value.ToString();
            strSrno = this.dataGridView1.CurrentRow.Cells["SrNo"].Value.ToString();
            if (this.dataGridView1.CurrentRow.Cells["ExamNotes"].ToString() != String.Empty)
            {
                strExamNotes = this.dataGridView1.CurrentRow.Cells["ExamNotes"].Value.ToString();
            }
            if (this.dataGridView1.CurrentRow.Cells["Complaints"].ToString() != String.Empty)
            {
                strComplaints = this.dataGridView1.CurrentRow.Cells["Complaints"].Value.ToString();
            }
            if (this.dataGridView1.CurrentRow.Cells["Investigation"].ToString() != String.Empty)
            {
                strInvestigation = this.dataGridView1.CurrentRow.Cells["Investigation"].Value.ToString();
            }
            if (this.dataGridView1.CurrentRow.Cells["Comorbidities"].ToString() != String.Empty)
            {
                strComorbidities = this.dataGridView1.CurrentRow.Cells["Comorbidities"].Value.ToString();
            }
            if (this.dataGridView1.CurrentRow.Cells["Diagnosis"].ToString() != String.Empty)
            {
                strDiagnosis = this.dataGridView1.CurrentRow.Cells["Diagnosis"].Value.ToString();
            }
            if (this.dataGridView1.CurrentRow.Cells["Treatment"].ToString() != String.Empty)
            {
                strTreatment = this.dataGridView1.CurrentRow.Cells["Treatment"].Value.ToString();
            }
            if (this.dataGridView1.CurrentRow.Cells["Prescription"].ToString() != String.Empty)
            {
                strPrescription = this.dataGridView1.CurrentRow.Cells["Prescription"].Value.ToString();
            }
            if (this.dataGridView1.CurrentRow.Cells["TotalAmt"].Value != null && this.dataGridView1.CurrentRow.Cells["TotalAmt"].Value.ToString() != String.Empty)
            {
                sTotalAmt = this.dataGridView1.CurrentRow.Cells["TotalAmt"].Value.ToString();
            }
            else
            {
                sTotalAmt = "0";
            }
            if (this.dataGridView1.CurrentRow.Cells["VisitType"].ToString() != String.Empty)
            {
                sVisitType = this.dataGridView1.CurrentRow.Cells["VisitType"].Value.ToString();
            }

            OpdInputScreen opdscreen = new OpdInputScreen();
            opdscreen.PatientName = strName;
            opdscreen.SrNo = strSrno;
            opdscreen.ExamNote = strExamNotes;
            opdscreen.Complaint = strComplaints;
            opdscreen.Investigation = strInvestigation;
            opdscreen.Comorbidity = strComorbidities;
            opdscreen.Diagnosis = strDiagnosis;
            opdscreen.Treatment = strTreatment;
            opdscreen.Prescription = strPrescription;
            opdscreen.TotalAmt = sTotalAmt;
            opdscreen.VisitType = sVisitType;

            //string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            //if (headerText == "PatientStatus")
            //{
            timer.Stop();
            string value = dataGridView1.Rows[e.RowIndex].Cells["PatientStatus"].Value.ToString();
            if (value != "OPD Done")
            {
                dTable.Rows[e.RowIndex]["PatientStatus"] = (value == "Waiting" || value == "Registered") ? "In OPD" : "Waiting";
            }




            //else if(value== "Registered")
            //    dTable.Rows[e.RowIndex]["PatientStatus"] = value == "Registered" ? "In OPD" : "Registered";

            //else
            //    dTable.Rows[e.RowIndex]["PatientStatus"] = value == "In OPD" ? "Registered" : "In OPD";
            SavePatientDetails();
            if (value == "In OPD")
                return;
            timer.Start();
            //}

            opdscreen.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadPatientDetailsData()
        {
            try
            {
                string sDateType = (DateTime.Parse(dtpVisitingDate.Text)).ToString("yyyy-MM-dd");
                dTable = BLNavdurga.BLAddPatientDetails.GetPatientDetails(sDateType);
                DataColumn col1 = new DataColumn();
                col1.ColumnName = "Sr. No.";
                col1.AutoIncrement = true;
                col1.AutoIncrementSeed = 1;
                col1.AutoIncrementStep = 1;

                dTable.Columns.Add(col1);
                dTable.Columns["Sr. No."].SetOrdinal(0);
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    dTable.Rows[i]["Sr. No."] = i + 1;
                }

                dataGridView1.DataSource = dTable;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns["VisitingDate"].Visible = true;
                LoadColour();
            }
            catch (Exception Ex) { }
        }

        public void LoadColour()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(row.Cells["PatientStatus"].Value) == "Registered")
                {
                    row.Cells["PatientStatus"].Style.BackColor = Color.Red;
                }
                else if (Convert.ToString(row.Cells["PatientStatus"].Value) == "Waiting")
                {
                    row.Cells["PatientStatus"].Style.BackColor = Color.Orange;
                }
                else if (Convert.ToString(row.Cells["PatientStatus"].Value) == "In OPD")
                {
                    row.Cells["PatientStatus"].Style.BackColor = Color.Aqua;
                }
                else if (Convert.ToString(row.Cells["PatientStatus"].Value) == "OPD Done")
                {
                    row.Cells["PatientStatus"].Style.BackColor = Color.Yellow;
                }
            }
        }
        public void SavePatientDetails()
        {
            try
            {
                BLNavdurga.BLAddPatientDetails.SavePatientDetailsForDoctor(dTable);
                LoadPatientDetailsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
