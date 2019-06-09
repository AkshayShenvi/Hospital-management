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
    public partial class InjuryDetails : Form
    {
        public InjuryDetails()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                
                CertificateDetails cd = new CertificateDetails();
                if (txtName.Text != null)
                    cd.PatientName = txtName.Text;
                else
                { MessageBox.Show("Please Enter Patient Name"); }
                if (txtInjuries.Text != null)
                    cd.Injury = txtInjuries.Text;
                else
                { MessageBox.Show("Please Enter Injuries"); }
                

                InjuryCertificateReportViewer InjuryCirtificateReport = new InjuryCertificateReportViewer(cd);
                InjuryCirtificateReport.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            { }
        }
    }
}
