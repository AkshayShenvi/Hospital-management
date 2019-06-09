using System;
using System.Data;
using System.Windows.Forms;

namespace NavdurgaHospital
{
    public partial class Administrator : Form
    {
        DataTable  dtExamNotes,dtComplaints,dtInvestigation,dtPrescription,dtDiagnosis,dtComorbidities,dtTreatment,dtLogin,dTable,dTableComplaints,dTableInvestigation,dTablePrescription,dTableDiagnosis,dTableComorbidities,dTableTreatment,dTableLogin, dTableAdminConfig;
        

        

        public Administrator()
        {
            InitializeComponent();
        }
        //Load Events
        private void DoctorsScreen_Load(object sender, EventArgs e)
        {
            //Load Full ExamNotes Data & Specified ExamNotes Data
            try
            {
                LoadExamnotesData();
                LoadExamNotesType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Load Full Complaints Data & Specified Complaints Data
            try
            {
                LoadComplaintsData();
                LoadComplaintsType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Load Full Investigation Data & Specified Investigation Data
            try
            {
                LoadInvestigationData();
                LoadInvestigationType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Load Full Prescription Data & Specified Prescription Data
            try
            {
                LoadPrescriptionData();
                LoadMedicineType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadDiagnosisData();
                LoadDiagnosisType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                LoadComorbiditiesData();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                LoadTreatmentData();
                LoadTreatmentType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                LoadLoginData();
                LoadLoginType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                LoadAdminConfigData();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            this.WindowState = FormWindowState.Maximized;
        }

        


        //dataGridView
        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dataGridView1.CurrentRow.Index;
            string StopId_var = dataGridView1[0, Row].Value.ToString();
            //label1.Text = StopId_var;

        }

        private void dataGridView2_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dataGridView2.CurrentRow.Index;
            string StopId_var = dataGridView2[0, Row].Value.ToString();
            //label2.Text = StopId_var;

        }

        private void dataGridView3_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dataGridView3.CurrentRow.Index;
            string StopId_var = dataGridView3[0, Row].Value.ToString();
            //label3.Text = StopId_var;

        }
        private void dataGridView4_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dataGridView4.CurrentRow.Index;
            string StopId_var = dataGridView4[0, Row].Value.ToString();
            //label4.Text = StopId_var;

        }
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dataGridView5.CurrentRow.Index;
            string StopId_var = dataGridView5[0, Row].Value.ToString();
            //label5.Text = StopId_var;
        }
        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dataGridView6.CurrentRow.Index;
            string StopId_var = dataGridView6[0, Row].Value.ToString();
            //label5.Text = StopId_var;
        }
        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dataGridView7.CurrentRow.Index;
            string StopId_var = dataGridView7[0, Row].Value.ToString();
        }
        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row= dataGridView8.CurrentRow.Index;
            string StopId_var = dataGridView8[0, Row].Value.ToString();
        }
        private void dgvAdminConfig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dgvAdminConfig.CurrentRow.Index;
            string StopId_var = dgvAdminConfig[0, Row].Value.ToString();
        }








        //Save Button Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BLNavdurga.BLAddExamNotes.SaveExamNotesDetails(dTable);
                LoadExamnotesData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void btnSaveComp_Click(object sender, EventArgs e)
        {
            try
            {
                BLNavdurga.BLAddComplaints.SaveComplaintsDetails(dTableComplaints);
                LoadComplaintsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSaveInvst_Click(object sender, EventArgs e)
        {
            try
            {
                BLNavdurga.BLAddInvestigation.SaveInvestigationDetails(dTableInvestigation);
                LoadInvestigationData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSavePresc_Click(object sender, EventArgs e)
        {
            try
            {

               
                BLNavdurga.BLAddPresciption.SavePrescriptionDetails(dTablePrescription);
                LoadPrescriptionData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                BLNavdurga.BLAddDiagnosis.SaveDiagnosisDetails(dTableDiagnosis);
                LoadDiagnosisData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                BLNavdurga.BLAddComorbidities.SaveComorbiditiesDetails(dTableComorbidities);
                LoadComorbiditiesData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTreatSave_Click(object sender, EventArgs e)
        {
            try
            {


                BLNavdurga.BLAddTreatment.SaveTreatmentDetails(dTableTreatment);
                LoadTreatmentData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView8.DataSource;
                if (txtusername.Text!=String.Empty&& txtpassword.Text!=String.Empty)
                {
                     //dt = (DataTable)dataGridView8.DataSource;
                    DataRow dr = dt.NewRow();
                    dr["Username"] = txtusername.Text;
                    dr["Password"] = txtpassword.Text;
                    dr["Rights"] = cmbLogin.SelectedValue.ToString();
                    dt.Rows.Add(dr);
                    dataGridView8.DataSource = dt;
                }
                

                BLNavdurga.BLAddLoginDetails.SaveLoginDetails(dt);
                LoadLoginData();
                txtusername.Text = String.Empty;
                txtpassword.Text = String.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveAdmin_Click(object sender, EventArgs e)
        {
            try
            {


                BLNavdurga.BLAddAdminConfig.SaveAdminConfigDetails(dTableAdminConfig);
                LoadAdminConfigData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        
        //Combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboBox1.SelectedItem;
            string sExamNotesType = drv.Row.ItemArray[0].ToString();
            dTable = BLNavdurga.BLAddExamNotes.GetExamNotesDetails(sExamNotesType);
            dataGridView1.DataSource = dTable;
        }
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboBox2.SelectedItem;
            string sComplaintsType = drv.Row.ItemArray[0].ToString();
            dTableComplaints = BLNavdurga.BLAddComplaints.GetComplaintsDetails(sComplaintsType);
            dataGridView2.DataSource = dTableComplaints;

        }
        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboBox3.SelectedItem;
            string sInvestigationType = drv.Row.ItemArray[0].ToString();
            dTableInvestigation = BLNavdurga.BLAddInvestigation.GetInvestigationDetails(sInvestigationType);
            dataGridView3.DataSource = dTableInvestigation;
        }
        private void cmbPrescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbPrescription.SelectedItem;
            string sMedicineType = drv.Row.ItemArray[0].ToString();
            dTablePrescription = BLNavdurga.BLAddPresciption.GetPrescriptionDetails(sMedicineType);
            dataGridView4.DataSource = dTablePrescription;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboBox4.SelectedItem;
            string sDiagnosisType = drv.Row.ItemArray[0].ToString();
            dTableDiagnosis = BLNavdurga.BLAddDiagnosis.GetDiagnosisDetails(sDiagnosisType);
            dataGridView5.DataSource = dTableDiagnosis; 

        }
        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbTreatment.SelectedItem;
            string sTreatmentType = drv.Row.ItemArray[0].ToString();
            dTableTreatment = BLNavdurga.BLAddTreatment.GetTreatmentDetails(sTreatmentType);
            dataGridView7.DataSource = dTableTreatment;
        }











        //Back Button event
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }

        private void btnBackInvst_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }

        private void btnBackPresc_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }
        private void btnTreatBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }
        private void btnBackAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }





        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }




        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        














        //Load Full Data & Load specific Type Data
        public void LoadExamnotesData()
        {
            dTable = BLNavdurga.BLAddExamNotes.GetExamNotesDetails("All");
            dataGridView1.DataSource = dTable;
        }

        

        public void LoadExamNotesType()
        {
            dtExamNotes = BLNavdurga.BLAddExamNotes.GetExamNotesType();
            comboBox1.DataSource = dtExamNotes;
            comboBox1.ValueMember = "examnotestype";
            comboBox1.DisplayMember = "examnotestype";

        }

        

        public void LoadComplaintsData()
        {
            dTableComplaints = BLNavdurga.BLAddComplaints.GetComplaintsDetails("All");
            dataGridView2.DataSource = dTableComplaints;
        }

        public void LoadComplaintsType()
        {
            dtComplaints = BLNavdurga.BLAddComplaints.GetComplaintsType();
            comboBox2.DataSource = dtComplaints;
            comboBox2.ValueMember = "complainttype";
            comboBox2.DisplayMember = "complainttype";
        }




        public void LoadInvestigationData()
        {
            dTableInvestigation = BLNavdurga.BLAddInvestigation.GetInvestigationDetails("All");
            dataGridView3.DataSource = dTableInvestigation;
        }

        public void LoadInvestigationType()
        {
            dtInvestigation = BLNavdurga.BLAddInvestigation.GetInvestigationType();
            comboBox3.DataSource = dtInvestigation;
            comboBox3.ValueMember = "Investigationtype";
            comboBox3.DisplayMember = "Investigationtype";

        }




        public void LoadPrescriptionData()
        {
            dTablePrescription = BLNavdurga.BLAddPresciption.GetPrescriptionDetails("All");
            dataGridView4.DataSource = dTablePrescription;
        }

        public void LoadMedicineType()
        {
            dtPrescription = BLNavdurga.BLAddPresciption.GetMedicineType();
            cmbPrescription.DataSource = dtPrescription;
            cmbPrescription.ValueMember = "MedicineType";
            cmbPrescription.DisplayMember = "MedicineType";
        }





        public void LoadDiagnosisData()
        {
            dTableDiagnosis = BLNavdurga.BLAddDiagnosis.GetDiagnosisDetails("All");
            dataGridView5.DataSource = dTableDiagnosis;
        }

        public void LoadDiagnosisType()
        {
            dtDiagnosis = BLNavdurga.BLAddDiagnosis.GetDiagnosisType();
            comboBox4.DataSource = dtDiagnosis;
            comboBox4.ValueMember = "DiagnosisType";
            comboBox4.DisplayMember = "DiagnosisType";
        }



        public void LoadTreatmentData()
        {
            dTableTreatment = BLNavdurga.BLAddTreatment.GetTreatmentDetails("All");
            dataGridView7.DataSource = dTableTreatment;
        }

        public void LoadTreatmentType()
        {
            dtTreatment = BLNavdurga.BLAddTreatment.GetTreatmentType();
            cmbTreatment.DataSource = dtTreatment;
            cmbTreatment.ValueMember = "TreatmentType";
            cmbTreatment.DisplayMember = "TreatmentType";
        }





        public void LoadComorbiditiesData()
        {
            dTableComorbidities = BLNavdurga.BLAddComorbidities.GetComorbiditiesDetails("All");
            dataGridView6.DataSource = dTableComorbidities;
        }

        public void LoadLoginData()
        {
            dTableLogin = BLNavdurga.BLAddLoginDetails.GetLogin();
            dataGridView8.DataSource = dTableLogin;
        }

        public void LoadLoginType()
        {
            dtLogin = BLNavdurga.BLAddLoginDetails.GetLoginType();
            cmbLogin.DataSource = dtLogin;
            cmbLogin.ValueMember = "Rights";
            cmbLogin.DisplayMember = "Rights";
        }
        public void LoadAdminConfigData()
        {
            dTableAdminConfig = BLNavdurga.BLAddAdminConfig.GetAdminConfigDetails();
            dgvAdminConfig.DataSource = dTableAdminConfig;
        }

    }
}
