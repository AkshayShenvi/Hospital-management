namespace NavdurgaHospital
{
    partial class XRayRoom
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
            this.panel1 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpXray = new MetroFramework.Controls.MetroDateTime();
            this.panel2 = new MetroFramework.Controls.MetroPanel();
            this.dgvXray = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXray)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpXray);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.HorizontalScrollbarBarColor = true;
            this.panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1.HorizontalScrollbarSize = 10;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 62);
            this.panel1.TabIndex = 3;
            this.panel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel1.VerticalScrollbarBarColor = true;
            this.panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel1.VerticalScrollbarSize = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Highlight = true;
            this.button1.Location = new System.Drawing.Point(599, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date:";
            // 
            // dtpXray
            // 
            this.dtpXray.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpXray.Location = new System.Drawing.Point(249, 16);
            this.dtpXray.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpXray.Name = "dtpXray";
            this.dtpXray.Size = new System.Drawing.Size(169, 29);
            this.dtpXray.TabIndex = 3;
            this.dtpXray.ValueChanged += new System.EventHandler(this.dtpXray_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvXray);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.HorizontalScrollbarBarColor = true;
            this.panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel2.HorizontalScrollbarSize = 10;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 424);
            this.panel2.TabIndex = 4;
            this.panel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel2.VerticalScrollbarBarColor = true;
            this.panel2.VerticalScrollbarHighlightOnWheel = false;
            this.panel2.VerticalScrollbarSize = 10;
            // 
            // dgvXray
            // 
            this.dgvXray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXray.Location = new System.Drawing.Point(0, 0);
            this.dgvXray.Name = "dgvXray";
            this.dgvXray.Size = new System.Drawing.Size(726, 424);
            this.dgvXray.TabIndex = 2;
            this.dgvXray.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXray_CellContentClick);
            this.dgvXray.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvXray_CellMouseDoubleClick);
            // 
            // XRayRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "XRayRoom";
            this.Text = "XRayRoom";
            this.Load += new System.EventHandler(this.XRayRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dtpXray;
        private MetroFramework.Controls.MetroPanel panel2;
        private System.Windows.Forms.DataGridView dgvXray;
        private MetroFramework.Controls.MetroButton button1;
    }
}