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
    public partial class StaffSearchScreen : Form
    {
        public string PatientName { get; set; }
        public string PhnNo { get; set; }
        DataTable dTableName, dTablePhone, dTablePatientDetails;
        string strName, strPhn;

        public StaffSearchScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavePatientDetails();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffSearchScreen_Load(object sender, EventArgs e)
        {
            strName = PatientName.ToString();
            strPhn = PhnNo.ToString();
            if (strName != String.Empty && strPhn != String.Empty)
            {
                string sPatientName = strName;
                string sPatientPhone = strPhn;
                dTableName = BLNavdurga.BLAddPatientDetails.SearchPatientNameAndPhone(sPatientName, sPatientPhone);
                dgvStaffSearch.DataSource = dTableName;
            }
            else if (strName != String.Empty)
            {
                string sPatientName = strName;
                dTableName = BLNavdurga.BLAddPatientDetails.SearchPatientNameDetails(sPatientName);
                dgvStaffSearch.DataSource = dTableName;
            }
            else if (strPhn != String.Empty)
            {
                string sPatientPhone = strPhn;
                dTablePhone = BLNavdurga.BLAddPatientDetails.SearchPatientPhoneDetails(sPatientPhone);
                dgvStaffSearch.DataSource = dTablePhone;
            }

            else
            {
                MessageBox.Show("Search TextBox Cannot Be Empty");
            }
        }
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
        public void LoadPatientDetails()
        {
            strName = PatientName.ToString();
            strPhn = PhnNo.ToString();
            if (strName != String.Empty && strPhn != String.Empty)
            {
                string sPatientName = strName;
                string sPatientPhone = strPhn;
                dTableName = BLNavdurga.BLAddPatientDetails.SearchPatientNameAndPhone(sPatientName, sPatientPhone);
                dgvStaffSearch.DataSource = dTableName;
            }
            else if (strName != String.Empty)
            {
                string sPatientName = strName;
                dTableName = BLNavdurga.BLAddPatientDetails.SearchPatientNameDetails(sPatientName);
                dgvStaffSearch.DataSource = dTableName;
            }
            else if (strPhn != String.Empty)
            {
                string sPatientPhone = strPhn;
                dTablePhone = BLNavdurga.BLAddPatientDetails.SearchPatientPhoneDetails(sPatientPhone);
                dgvStaffSearch.DataSource = dTablePhone;
            }
        }
    }
}
