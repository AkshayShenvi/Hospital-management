namespace NavdurgaHospital
{
    partial class Certificate
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
            this.btnInjury = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnDisability = new MetroFramework.Controls.MetroButton();
            this.btnUndertreatment = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnInjury
            // 
            this.btnInjury.Highlight = true;
            this.btnInjury.Location = new System.Drawing.Point(195, 339);
            this.btnInjury.Name = "btnInjury";
            this.btnInjury.Size = new System.Drawing.Size(115, 23);
            this.btnInjury.TabIndex = 8;
            this.btnInjury.Text = "Injury Certificate";
            this.btnInjury.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnInjury.UseSelectable = true;
            this.btnInjury.Click += new System.EventHandler(this.btnInjury_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(195, 112);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Fitness Certificate";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnDisability
            // 
            this.btnDisability.Highlight = true;
            this.btnDisability.Location = new System.Drawing.Point(195, 186);
            this.btnDisability.Name = "btnDisability";
            this.btnDisability.Size = new System.Drawing.Size(115, 23);
            this.btnDisability.TabIndex = 10;
            this.btnDisability.Text = "Disability Certificate";
            this.btnDisability.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDisability.UseSelectable = true;
            this.btnDisability.Click += new System.EventHandler(this.btnDisability_Click);
            // 
            // btnUndertreatment
            // 
            this.btnUndertreatment.Highlight = true;
            this.btnUndertreatment.Location = new System.Drawing.Point(195, 267);
            this.btnUndertreatment.Name = "btnUndertreatment";
            this.btnUndertreatment.Size = new System.Drawing.Size(115, 23);
            this.btnUndertreatment.TabIndex = 11;
            this.btnUndertreatment.Text = "Undertreatment";
            this.btnUndertreatment.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUndertreatment.UseSelectable = true;
            this.btnUndertreatment.Click += new System.EventHandler(this.btnUndertreatment_Click);
            // 
            // Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 449);
            this.Controls.Add(this.btnUndertreatment);
            this.Controls.Add(this.btnDisability);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnInjury);
            this.Name = "Certificate";
            this.Text = "Certificate";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnInjury;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnDisability;
        private MetroFramework.Controls.MetroButton btnUndertreatment;
    }
}