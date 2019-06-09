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
    public partial class XRayRoom : Form
    {
        public XRayRoom()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Timer timer = new Timer();
        DataTable dTablePatientDetails;
        private void XRayRoom_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPatientDetails();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.WindowState = FormWindowState.Maximized;
            //Form Load
            try
            {

                timer.Interval = (5 * 1000); // 10 secs
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            LoadPatientDetails();
        }
        public void LoadPatientDetails()
        {
            try
            {
                string sDateType = (DateTime.Parse(dtpXray.Text)).ToString("yyyy-MM-dd");
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

                dgvXray.DataSource = dTablePatientDetails;
                dgvXray.Columns["Sr. No."].Visible = true;
                dgvXray.Columns["SrNo"].Visible = false;
                dgvXray.DataSource = dTablePatientDetails;
                //dgvXray.Columns[1].Visible = false;
                //dgvXray.Columns[2].Visible = false;
                dgvXray.Columns["VisitingDate"].Visible = true;
                LoadColour();
            }
            catch (Exception Ex)
            {

            }
        }

        public void LoadColour()
        {
            foreach (DataGridViewRow row in dgvXray.Rows)
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

        private void dgvXray_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sSrno, sName, sVisitedDate;
            //if (dgvXray.SelectedCells.ToString() != String.Empty)
            //{
            string sStatus;
            sStatus = this.dgvXray.CurrentRow.Cells["PatientStatus"].Value.ToString();
            if (sStatus == "OPD Done" || sStatus == "In OPD")
            {
                BillInput billInput = new BillInput();
                sSrno = this.dgvXray.CurrentRow.Cells["SrNo"].Value.ToString();
                sName = this.dgvXray.CurrentRow.Cells["PatientName"].Value.ToString();
                sVisitedDate = this.dgvXray.CurrentRow.Cells["VisitingDate"].Value.ToString();
                billInput.Status = sStatus;
                billInput.Srno = sSrno;
                billInput.PatientName = sName;
                billInput.VisitedDate = sVisitedDate;
                billInput.ShowDialog();
            }
            else
            {
                MessageBox.Show("Patient Status Should be In OPD Or OPD Done");
            }
            //BillInput billInput = new BillInput();
            //sSrno = this.dgvXray.CurrentRow.Cells["SrNo"].Value.ToString();
            //sName = this.dgvXray.CurrentRow.Cells["PatientName"].Value.ToString();
            //sVisitedDate = this.dgvXray.CurrentRow.Cells["VisitingDate"].Value.ToString();
            //billInput.Srno = sSrno;
            //billInput.PatientName = sName;
            //billInput.VisitedDate = sVisitedDate;
            //billInput.ShowDialog();
            //}
        }

        private void dgvXray_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpXray_ValueChanged(object sender, EventArgs e)
        {
            LoadPatientDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Owner = this.MdiParent;
            login.ShowDialog();
        }
    }
}
