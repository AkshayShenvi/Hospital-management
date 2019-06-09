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
    public partial class DisabilityDetails : Form
    {
        public DisabilityDetails()
        {
            InitializeComponent();
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
                if (txtDiagnosis.Text != null)
                    cd.Diagnosis = txtDiagnosis.Text;
                else
                { MessageBox.Show("Please Enter Diagnosis"); }
                if (txtDisability.Text != null)
                    cd.Disability = txtDisability.Text;
                else
                { MessageBox.Show("Please Enter Disability"); }
                if (txtPercentage.Text != null)
                    cd.DisabilityPercentage = txtPercentage.Text;
                else
                { MessageBox.Show("Please Enter Disability"); }

                DisabilityReportViewer disability = new DisabilityReportViewer(cd);
                disability.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            { }
        }
    }
}
