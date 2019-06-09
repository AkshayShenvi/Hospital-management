namespace NavdurgaHospital
{
    partial class FitnessCertificateReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReporViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FitnessCirtificate1 = new NavdurgaHospital.FitnessCertificate();
            this.SuspendLayout();
            // 
            // crystalReporViewer
            // 
            this.crystalReporViewer.ActiveViewIndex = 0;
            this.crystalReporViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReporViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReporViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReporViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReporViewer.Name = "crystalReporViewer";
            this.crystalReporViewer.ReportSource = this.FitnessCirtificate1;
            this.crystalReporViewer.Size = new System.Drawing.Size(587, 455);
            this.crystalReporViewer.TabIndex = 0;
            this.crystalReporViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReporViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FitnessCirtificateReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 455);
            this.Controls.Add(this.crystalReporViewer);
            this.Name = "FitnessCirtificateReportViewer";
            this.Text = "FitnessCirtificateReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReporViewer;
        private FitnessCertificate FitnessCirtificate1;
    }
}