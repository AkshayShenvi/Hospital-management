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
    public partial class Certificate : Form
    {
        public Certificate()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FitnessDetails fitness = new FitnessDetails();
            fitness.ShowDialog();
            this.Close();
        }

        private void btnDisability_Click(object sender, EventArgs e)
        {
            DisabilityDetails disability = new DisabilityDetails();
            disability.ShowDialog();
            this.Close();
        }

        private void btnUndertreatment_Click(object sender, EventArgs e)
        {
            UndertreatmentDetails undertreatment = new UndertreatmentDetails();
            undertreatment.ShowDialog();
            this.Close();
            
        }

        private void btnInjury_Click(object sender, EventArgs e)
        {
            InjuryDetails injury = new InjuryDetails();
            injury.ShowDialog();
            this.Close();
        }
    }
}
