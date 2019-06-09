using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLNavdurga;
using MaterialSkin; 
using MaterialSkin.Controls;
using Excel = Microsoft.Office.Interop.Excel;

namespace NavdurgaHospital
{
    public partial class Staff_Screen : Form
    {
        DataTable dTableMasterDetails, dTablePatientDetails, dTableName, dTablePhone, dTableBalance;
        string strName, strPhnNo, strPatientID, strPName;
        Timer timer = new Timer();
        public Staff_Screen()
        {
            InitializeComponent();

            
        }

        private void Staff_Screen_Load(object sender, EventArgs e)
        {
            
            //Patient Master Details Load
            try
            {
                LoadPatientDetailsMasterData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Patient Details Load
            try
            {
                LoadPatientDetails();
                Timer_Load();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.WindowState = FormWindowState.Maximized;
            //Form Load


            //try
            //{
            //    if (dgvPatientDetails.SelectedCells.ToString() != String.Empty)
            //    {
            //        txtPaid.Text = this.dgvPatientDetails.CurrentRow.Cells["TotalAmt"].Value.ToString();
            //    }
            //}
            //catch(Exception ex)
            //{

            //}
        }


        private void Timer_Load()
        {
            try
            {

                timer.Interval = (3 * 1000); // 10 secs
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





//Search Btn Click
private void button3_Click(object sender, EventArgs e)
        {
            if (txtSearchName.Text != String.Empty && txtSearchPhone.Text != String.Empty)
            {
                string sPatientName = txtSearchName.Text;
                string sPatientPhone = txtSearchPhone.Text;
                dTableName = BLNavdurga.BLAddPatientDetailsMaster.SearchPatientNameAndPhoneMaster(sPatientName, sPatientPhone);
                dgvMaster.DataSource = dTableName;
            }
            else if (txtSearchName.Text != String.Empty)
            {
                string sPatientName = txtSearchName.Text;
                dTableName = BLNavdurga.BLAddPatientDetailsMaster.SearchPatientNameMasterDetails(sPatientName);
                dgvMaster.DataSource = dTableName;
            }
            else if (txtSearchPhone.Text != String.Empty)
            {
                string sPatientPhone = txtSearchPhone.Text;
                dTablePhone = BLNavdurga.BLAddPatientDetailsMaster.SearchPatientPhoneMasterDetails(sPatientPhone);
                dgvMaster.DataSource = dTablePhone;
            }

            else
            {
                MessageBox.Show("Search TextBox Cannot Be Empty");
            }
        }

        private void btnPastSearch_Click(object sender, EventArgs e)
        {
            if (txtPastName.Text != String.Empty && txtPastPhn.Text != String.Empty)
            {
                string sPatientName = txtPastName.Text;
                string sPatientPhone = txtPastPhn.Text;
                dTableName = BLNavdurga.BLAddPatientDetails.SearchPatientNameAndPhone(sPatientName, sPatientPhone);
                dgvPastDetails.DataSource = dTableName;
            }
            else if (txtPastName.Text != String.Empty)
            {
                string sPatientName = txtPastName.Text;
                dTableName = BLNavdurga.BLAddPatientDetails.SearchPatientNameDetails(sPatientName);
                dgvPastDetails.DataSource = dTableName;
            }
            else if (txtPastPhn.Text != String.Empty)
            {
                string sPatientPhone = txtPastPhn.Text;
                dTablePhone = BLNavdurga.BLAddPatientDetails.SearchPatientPhoneDetails(sPatientPhone);
                dgvPastDetails.DataSource = dTablePhone;
            }

            else
            {
                MessageBox.Show("Search TextBox Cannot Be Empty");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sStartDate = (DateTime.Parse(dtpStart.Text)).ToString("yyyy-MM-dd");
            string sEndDate = (DateTime.Parse(dtpEnd.Text)).ToString("yyyy-MM-dd");
            dTableBalance = BLNavdurga.BLAddPatientDetails.GetPatientBalanceDetails(sStartDate, sEndDate);
            dgvBalanceDetails.DataSource = dTableBalance;
            dgvBalanceDetails.Columns["ExamNotes"].Visible = false;
            dgvBalanceDetails.Columns["Complaints"].Visible = false;
            dgvBalanceDetails.Columns["Investigation"].Visible = false;
            dgvBalanceDetails.Columns["Comorbidities"].Visible = false;
            dgvBalanceDetails.Columns["Diagnosis"].Visible = false;
            dgvBalanceDetails.Columns["Treatment"].Visible = false;
            dgvBalanceDetails.Columns["Prescription"].Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        //Fill Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaster.SelectedCells.ToString() != String.Empty)
                {
                    timer.Stop();
                    //strEmailID = this.dgvMaster.CurrentRow.Cells[3].Value.ToString();
                    //strGender = this.dgvMaster.CurrentRow.Cells[4].Value.ToString();

                    string sPatiendID;
                    strPatientID = this.dgvMaster.CurrentRow.Cells[0].Value.ToString();
                    strName = this.dgvMaster.CurrentRow.Cells[1].Value.ToString();
                    strPhnNo = this.dgvMaster.CurrentRow.Cells[2].Value.ToString();
                    DataTable dt = (DataTable)dgvPatientDetails.DataSource;
                    DataRow dr = dt.NewRow();
                    dr["patientID"] = strPatientID.ToString();
                    sPatiendID = strPatientID.ToString();
                    dr["PatientName"] = strName.ToString();
                    dr["PhoneNo"] = strPhnNo.ToString();


                    dr["VisitingDate"] = DateTime.Now.Date;//.ToString("dd-mmm-yyyy");
                    dr["PatientStatus"] = "Registered";


                    int pendingBillAmount = int.Parse(BLAddPatientDetails.GetPatielUnpaidBill(sPatiendID));

                    //int pendingBillAmount = Int32.Parse(BLNavdurga.BLAddPatientBillDetails.GetPreviousBalance(strPatientID.ToString()));
                    if (pendingBillAmount != 0)
                    {
                        //dr["Balance"] = pendingBillAmount.ToString();
                        MessageBox.Show("Pending Bill Amount for this Patient : " + pendingBillAmount);
                        dr["PrevBalance"] = pendingBillAmount.ToString();

                    }
                    dt.Rows.Add(dr);
                    dgvPatientDetails.DataSource = dt;

                    SavePatientDetails();
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Please Select an Entry");
                }
            }
            catch
            {
                MessageBox.Show("Please Select an Entry");
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchName.Text != String.Empty || txtSearchPhone.Text != String.Empty)
                {
                    strName = txtSearchName.Text;
                    strPhnNo = txtSearchPhone.Text;
                    dTableMasterDetails = (DataTable)dgvMaster.DataSource;
                    DataRow drmaster = dTableMasterDetails.NewRow();
                    drmaster["PatientName"] = strName.ToString();
                    drmaster["PhoneNo"] = strPhnNo.ToString();
                    dTableMasterDetails.Rows.Add(drmaster);
                    dgvMaster.DataSource = dTableMasterDetails;

                    SavePatientMasterDetails();

                    int patientID = GetPatientID();

                    DataTable dtdetails = (DataTable)dgvPatientDetails.DataSource;
                    DataRow drdetails = dtdetails.NewRow();
                    drdetails["patientID"] = patientID;

                    drdetails["PatientName"] = strName.ToString();
                    drdetails["PhoneNo"] = strPhnNo.ToString();


                    drdetails["VisitingDate"] = DateTime.Now.Date;//.ToString("dd-mmm-yyyy");
                    drdetails["PatientStatus"] = "Registered";


                    //int pendingBillAmount = int.Parse(BLAddPatientDetails.GetPatielUnpaidBill(patientID.ToString()));
                    //if (pendingBillAmount != 0)
                    //{
                    //    drdetails["Balance"] = pendingBillAmount.ToString();
                    //    MessageBox.Show("Pending Bill Amount for this Patient : " + pendingBillAmount);
                    //}
                    dtdetails.Rows.Add(drdetails);
                    dgvPatientDetails.DataSource = dtdetails;

                    SavePatientDetails();

                    txtSearchName.Text = String.Empty;
                    txtSearchPhone.Text = String.Empty;
                }
                txtSearchName.Focus();
            }
            catch (Exception ex)
            {
                //DialogResult dialogResult= MessageBox.Show("Name or Phone No. cannot Be Empty");
                if (MessageBox.Show("Name or Phone No. cannot Be Empty", "Invalid Entry", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    MessageBox.Show("Please put atleast one digit in the Phone no.", "Suggestion");
                }
                txtSearchName.Focus();
            }
            
        }

        private int GetPatientID()
        {
            return BLAddPatientDetailsMaster.GetPatientID();
        }

        //DataGridView Load
        private void dgvPatientDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dgvPatientDetails.CurrentRow.Index;
            string StopId_var = dgvPatientDetails[0, Row].Value.ToString();
            //label2.Text = StopId_var;
        }

        

        private void dgvMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = dgvMaster.CurrentRow.Index;
            string StopId_var = dgvMaster[0, Row].Value.ToString();

        }


        //Save Button 
        private void btnSaveMDetails_Click(object sender, EventArgs e)
        {

            DataTable dtPatientMaster = (DataTable)dgvMaster.DataSource;
            foreach (DataRow dr in dtPatientMaster.Rows)
            {
                if (dr.RowState == DataRowState.Modified)
                {
                    string sPatientID = dr["patientIDMaster"].ToString();
                    string sPatientName = dr["PatientName"].ToString();
                    string sPhoneNumber = dr["PhoneNo"].ToString();
                    BLAddPatientDetails.UpdatePatientDetailTable(sPatientID, sPatientName, sPhoneNumber);
                    LoadPatientDetails();
                } 
            }

            SavePatientMasterDetails();
        }

        private void dgvPatientDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dgvPatientDetails.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the CompanyName column.
            if (!headerText.Equals("Age") || e.FormattedValue.ToString() == string.Empty) return;

            // Confirm that the cell is not empty.
            int x;
            if (!int.TryParse(e.FormattedValue.ToString(), out x))
            {
                //dgvPatientDetails.Rows[e.RowIndex].ErrorText =
                //    "Value should be integer";
                //e.Cancel = true;
                MessageBox.Show("Age should be Number", "Staff Page", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void dgvPatientDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            timer.Stop();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }

        private void btnPrntBill_Click(object sender, EventArgs e)
        {
            //PrintBill printbill = new PrintBill();
            //printbill.Show();
            try
            {
                string sSrno, sName, sVisitedDate,sPrevTotalAmt;
                if (dgvPatientDetails.SelectedCells.ToString() != String.Empty)
                {
                    string Status;
                    Status = this.dgvPatientDetails.CurrentRow.Cells["PatientStatus"].Value.ToString();
                    if (Status == "OPD Done" || Status == "In OPD")
                    {
                        GenerateBill printbill = new GenerateBill();
                        sSrno = this.dgvPatientDetails.CurrentRow.Cells["SrNo"].Value.ToString();
                        sName = this.dgvPatientDetails.CurrentRow.Cells["PatientName"].Value.ToString();
                        sVisitedDate = this.dgvPatientDetails.CurrentRow.Cells["VisitingDate"].Value.ToString();
                        sPrevTotalAmt = this.dgvPatientDetails.CurrentRow.Cells["PrevBalance"].Value.ToString();
                        printbill.Srno = sSrno;
                        printbill.PatientName = sName;
                        printbill.VisitedDate = sVisitedDate;
                        printbill.PreviousTotal = sPrevTotalAmt==string.Empty?"0": sPrevTotalAmt;
                        printbill.ShowDialog();
                        //int totalAmt = pendingBillAmount;
                        //dr["TotalAmt"] = totalAmt;
                        //dr["PrevBalance"] = "0";
                    }
                    else
                    {
                        MessageBox.Show("Status Should Be 'OPD Done' Or 'In OPD'");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Name");
                }
            }
            catch (Exception ex) { }
            timer.Start();
        }

        private void dgvPatientDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string headerText = dgvPatientDetails.Columns[e.ColumnIndex].HeaderText;
            if (headerText == "PatientStatus")
            {
                timer.Stop();
                string value = dgvPatientDetails.Rows[e.RowIndex].Cells[headerText].Value.ToString();
                dTablePatientDetails.Rows[e.RowIndex][e.ColumnIndex] = value == "Registered" ? "Waiting" : "Registered";
                SavePatientDetails();
                timer.Start();
            }
        }

        private void dtpOPD_ValueChanged(object sender, EventArgs e)
        {
            LoadPatientDetails();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrintBill pb = new PrintBill();
            pb.Show();
        }

        private void txtPastName_Click(object sender, EventArgs e)
        {

        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPatientDetails.SelectedCells.ToString() != String.Empty)
                {
                    timer.Stop();
                    string sPaidAmt = txtPaid.Text.ToString();
                    string sSrno = this.dgvPatientDetails.CurrentRow.Cells["SrNo"].Value.ToString();
                    string sPatientId = this.dgvPatientDetails.CurrentRow.Cells["patientID"].Value.ToString();
                    BLNavdurga.BLAddPatientDetails.UpdatePatientBillBalance(sPaidAmt, sSrno,sPatientId);

                    txtPaid.Text = String.Empty;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Not updated"); }
            timer.Start();

            //if (dgvPatientDetails.SelectedCells.ToString() != String.Empty)
            //{
            //    String strPaid;
            //    strPaid =txtPaid.Text;
            //    DataTable dtdetails = (DataTable)dgvPatientDetails.DataSource;
            //    DataRow drdetails = dtdetails.NewRow();
            //    drdetails["Paid"] = strPaid.ToString();
            //    int paidAmt = Int32.Parse(strPaid);
            //    string srNo= this.dgvPatientDetails.CurrentRow.Cells["SrNo"].Value.ToString();
            //    int TotalAmt= Int32.Parse(BLNavdurga.BLAddPatientBillDetails.GetPatientBillTotal(srNo));
            //    int balanceAmt = TotalAmt -paidAmt;
            //    drdetails["Balance"] = balanceAmt;
            //    drdetails["PrevBalance"] = balanceAmt;
            //        dtdetails.Rows.Add(drdetails);
            //    dgvPatientDetails.DataSource = dtdetails;

            //    SavePatientDetails();
            //}
            //else
            //{
            //    MessageBox.Show("Status Should Be 'OPD Done' Or 'In OPD'");
            //}
        }

        private void btnPrntOPD_Click(object sender, EventArgs e)
        {
            DateTime dtOPD = (DateTime.Parse(dtpOPD.Text));
            string sFolderPath = ConfigurationManager.AppSettings.Get("ExcelFileExportPath").ToString();
            string sFilePath = sFolderPath+"\\PatientDetails_"+ dtOPD.ToString("ddMMMyyyy")+".xlsx";
            DataTable dtPrintPatientDetails = BLAddPatientDetails.GetPatientDetailsPrintData(dtOPD);
            exportToExcel(dtPrintPatientDetails, sFilePath);
            MessageBox.Show("The file have been saved in the Path : "+ sFilePath);
            timer.Start();
        }

        private void exportToExcel(DataTable dt, string sFilePath)
        {

            /*Set up work book, work sheets, and excel application*/
            Microsoft.Office.Interop.Excel.Application oexcel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                object misValue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Workbook obook = oexcel.Workbooks.Add(misValue);
                Microsoft.Office.Interop.Excel.Worksheet osheet = new Microsoft.Office.Interop.Excel.Worksheet();


                //  obook.Worksheets.Add(misValue);

                osheet = (Microsoft.Office.Interop.Excel.Worksheet)obook.Sheets["Sheet1"];
                int colIndex = 0;
                int rowIndex = 1;

                foreach (DataColumn dc in dt.Columns)
                {
                    colIndex++;
                    osheet.Cells[1, colIndex] = dc.ColumnName;
                }
                foreach (DataRow dr in dt.Rows)
                {
                    rowIndex++;
                    colIndex = 0;

                    foreach (DataColumn dc in dt.Columns)
                    {
                        colIndex++;
                        osheet.Cells[rowIndex, colIndex] = dr[dc.ColumnName];
                    }
                }

                osheet.Columns.AutoFit();                

                //Release and terminate excel

                obook.SaveAs(sFilePath);
                obook.Close();
                oexcel.Quit();
                releaseObject(osheet);

                releaseObject(obook);

                releaseObject(oexcel);
                GC.Collect();
            }
            catch (Exception ex)
            {
                oexcel.Quit();                
            }
        }

        private void dgvPatientDetails_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dgvPatientDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePatientDetails();

           
            timer.Start();
        }



        // Load Events
        public void LoadPatientDetailsMasterData()
        {
            dTableMasterDetails = BLNavdurga.BLAddPatientDetailsMaster.GetPatientDetailsMaster("All");
            dgvMaster.DataSource = dTableMasterDetails;
        }
        public void LoadPatientDetails()
        {
            try
            {
                string sDateType = (DateTime.Parse(dtpOPD.Text)).ToString("yyyy-MM-dd");
                dTablePatientDetails = BLNavdurga.BLAddPatientDetails.GetPatientDetailsForStaff(sDateType);
                DataColumn col1 = new DataColumn();
                col1.ColumnName = "Sr. No.";
                col1.AutoIncrement = true;
                col1.AutoIncrementSeed = 1;
                col1.AutoIncrementStep = 1;

                dTablePatientDetails.Columns.Add(col1);
                dTablePatientDetails.Columns["Sr. No."].SetOrdinal(0);
                for (int i = 0; i < dTablePatientDetails.Rows.Count; i++)
                {
                    dTablePatientDetails.Rows[i]["Sr. No."] = i + 1;
                }

                dgvPatientDetails.DataSource = dTablePatientDetails;
                dgvPatientDetails.Columns["Sr. No."].Visible = true;
                dgvPatientDetails.Columns["SrNo"].Visible = false;
                dgvPatientDetails.DataSource = dTablePatientDetails;
                //dgvPatientDetails.Columns[1].Visible = false;
                //dgvPatientDetails.Columns[2].Visible = false;
                dgvPatientDetails.Columns["patientID"].Visible = false;
               
                dgvPatientDetails.Columns["VisitingDate"].Visible = true;
                DisplayDailyTotal();
                LoadColour();
                
            }
            catch (Exception Ex) 
            {
               
            }
        }
        public void DisplayDailyTotal()
        {
            string sDateType = (DateTime.Parse(dtpOPD.Text)).ToString("yyyy-MM-dd");
            lblTotal.Text = BLNavdurga.BLAddPatientDetails.GetDailyPatientTotal(sDateType);
        }
        public void LoadColour()
        {
            foreach (DataGridViewRow row in dgvPatientDetails.Rows)
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
        private void timer_Tick(object sender, EventArgs e)
        {

            LoadPatientDetails();
        }


        //Save Functions
        public void SavePatientDetails()
        {
            try
            {
                BLNavdurga.BLAddPatientDetails.SavePatientDetails(dTablePatientDetails);
                LoadPatientDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SavePatientMasterDetails()
        {
            try
            {
                BLNavdurga.BLAddPatientDetailsMaster.SavePatientDetailsMaster(dTableMasterDetails);
                LoadPatientDetailsMasterData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
