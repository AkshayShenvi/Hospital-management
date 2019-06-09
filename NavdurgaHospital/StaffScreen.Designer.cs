namespace NavdurgaHospital
{
    partial class Staff_Screen
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
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new MetroFramework.Controls.MetroPanel();
            this.panel2 = new MetroFramework.Controls.MetroPanel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnPaid = new MetroFramework.Controls.MetroButton();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrntOPD = new MetroFramework.Controls.MetroButton();
            this.btnPrntBill = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.panel3 = new MetroFramework.Controls.MetroPanel();
            this.dgvPatientDetails = new System.Windows.Forms.DataGridView();
            this.panel7 = new MetroFramework.Controls.MetroPanel();
            this.dtpOPD = new MetroFramework.Controls.MetroDateTime();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new MetroFramework.Controls.MetroPanel();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.panel6 = new MetroFramework.Controls.MetroPanel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnFill = new MetroFramework.Controls.MetroButton();
            this.btnSaveMDetails = new MetroFramework.Controls.MetroButton();
            this.panel5 = new MetroFramework.Controls.MetroPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel9 = new MetroFramework.Controls.MetroPanel();
            this.dgvPastDetails = new System.Windows.Forms.DataGridView();
            this.panel8 = new MetroFramework.Controls.MetroPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPastPhn = new System.Windows.Forms.TextBox();
            this.btnPastSearch = new MetroFramework.Controls.MetroButton();
            this.tabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.panel11 = new MetroFramework.Controls.MetroPanel();
            this.dgvBalanceDetails = new System.Windows.Forms.DataGridView();
            this.panel10 = new MetroFramework.Controls.MetroPanel();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStart = new MetroFramework.Controls.MetroDateTime();
            this.dtpEnd = new MetroFramework.Controls.MetroDateTime();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientDetails)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastDetails)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanceDetails)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 481);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OPD Screen";
            this.tabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.HorizontalScrollbarBarColor = true;
            this.panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1.HorizontalScrollbarSize = 10;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel1.VerticalScrollbarBarColor = true;
            this.panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnPaid);
            this.panel2.Controls.Add(this.txtPaid);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnPrntOPD);
            this.panel2.Controls.Add(this.btnPrntBill);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.HorizontalScrollbarBarColor = true;
            this.panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel2.HorizontalScrollbarSize = 10;
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 51);
            this.panel2.TabIndex = 1;
            this.panel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel2.VerticalScrollbarBarColor = true;
            this.panel2.VerticalScrollbarHighlightOnWheel = false;
            this.panel2.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Highlight = true;
            this.btnRefresh.Location = new System.Drawing.Point(300, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 34);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPaid.Highlight = true;
            this.btnPaid.Location = new System.Drawing.Point(177, 16);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(66, 23);
            this.btnPaid.TabIndex = 8;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseSelectable = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPaid.Location = new System.Drawing.Point(108, 16);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(63, 20);
            this.txtPaid.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotal.Location = new System.Drawing.Point(559, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "label11";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Desktop;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(497, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Daily total:";
            // 
            // btnPrntOPD
            // 
            this.btnPrntOPD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrntOPD.Highlight = true;
            this.btnPrntOPD.Location = new System.Drawing.Point(6, 6);
            this.btnPrntOPD.Name = "btnPrntOPD";
            this.btnPrntOPD.Size = new System.Drawing.Size(84, 34);
            this.btnPrntOPD.TabIndex = 1;
            this.btnPrntOPD.Text = "Print OPD List";
            this.btnPrntOPD.UseSelectable = true;
            this.btnPrntOPD.Click += new System.EventHandler(this.btnPrntOPD_Click);
            // 
            // btnPrntBill
            // 
            this.btnPrntBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrntBill.Highlight = true;
            this.btnPrntBill.Location = new System.Drawing.Point(713, 6);
            this.btnPrntBill.Name = "btnPrntBill";
            this.btnPrntBill.Size = new System.Drawing.Size(75, 34);
            this.btnPrntBill.TabIndex = 2;
            this.btnPrntBill.Text = "Generate Bill";
            this.btnPrntBill.UseSelectable = true;
            this.btnPrntBill.Click += new System.EventHandler(this.btnPrntBill_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(407, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save/Update Daily table";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dgvPatientDetails);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.HorizontalScrollbarBarColor = true;
            this.panel3.HorizontalScrollbarHighlightOnWheel = false;
            this.panel3.HorizontalScrollbarSize = 10;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 274);
            this.panel3.TabIndex = 12;
            this.panel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel3.VerticalScrollbarBarColor = true;
            this.panel3.VerticalScrollbarHighlightOnWheel = false;
            this.panel3.VerticalScrollbarSize = 10;
            // 
            // dgvPatientDetails
            // 
            this.dgvPatientDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientDetails.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvPatientDetails.Location = new System.Drawing.Point(0, 30);
            this.dgvPatientDetails.Name = "dgvPatientDetails";
            this.dgvPatientDetails.Size = new System.Drawing.Size(796, 244);
            this.dgvPatientDetails.TabIndex = 7;
            this.dgvPatientDetails.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dgvPatientDetails_AllowUserToDeleteRowsChanged);
            this.dgvPatientDetails.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPatientDetails_CellBeginEdit);
            this.dgvPatientDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientDetails_CellClick);
            this.dgvPatientDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientDetails_CellContentClick);
            this.dgvPatientDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientDetails_CellDoubleClick);
            this.dgvPatientDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvPatientDetails_CellValidating);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.CausesValidation = false;
            this.panel7.Controls.Add(this.dtpOPD);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.HorizontalScrollbarBarColor = true;
            this.panel7.HorizontalScrollbarHighlightOnWheel = false;
            this.panel7.HorizontalScrollbarSize = 10;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(796, 30);
            this.panel7.TabIndex = 13;
            this.panel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel7.VerticalScrollbarBarColor = true;
            this.panel7.VerticalScrollbarHighlightOnWheel = false;
            this.panel7.VerticalScrollbarSize = 10;
            // 
            // dtpOPD
            // 
            this.dtpOPD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpOPD.Location = new System.Drawing.Point(641, 3);
            this.dtpOPD.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpOPD.Name = "dtpOPD";
            this.dtpOPD.Size = new System.Drawing.Size(143, 29);
            this.dtpOPD.TabIndex = 2;
            this.dtpOPD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtpOPD.ValueChanged += new System.EventHandler(this.dtpOPD_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Desktop;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(563, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pick A Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Daily Patient List";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvMaster);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.HorizontalScrollbarBarColor = true;
            this.panel4.HorizontalScrollbarHighlightOnWheel = false;
            this.panel4.HorizontalScrollbarSize = 10;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(796, 159);
            this.panel4.TabIndex = 13;
            this.panel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel4.VerticalScrollbarBarColor = true;
            this.panel4.VerticalScrollbarHighlightOnWheel = false;
            this.panel4.VerticalScrollbarSize = 10;
            // 
            // dgvMaster
            // 
            this.dgvMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMaster.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvMaster.Location = new System.Drawing.Point(0, 52);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.Size = new System.Drawing.Size(707, 107);
            this.dgvMaster.TabIndex = 2;
            this.dgvMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaster_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Controls.Add(this.btnFill);
            this.panel6.Controls.Add(this.btnSaveMDetails);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.HorizontalScrollbarBarColor = true;
            this.panel6.HorizontalScrollbarHighlightOnWheel = false;
            this.panel6.HorizontalScrollbarSize = 10;
            this.panel6.Location = new System.Drawing.Point(707, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(89, 159);
            this.panel6.TabIndex = 12;
            this.panel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel6.VerticalScrollbarBarColor = true;
            this.panel6.VerticalScrollbarHighlightOnWheel = false;
            this.panel6.VerticalScrollbarSize = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLogout.Highlight = true;
            this.btnLogout.Location = new System.Drawing.Point(6, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFill.Highlight = true;
            this.btnFill.Location = new System.Drawing.Point(6, 36);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(80, 48);
            this.btnFill.TabIndex = 8;
            this.btnFill.Text = "Fill Daily Patient";
            this.btnFill.UseSelectable = true;
            this.btnFill.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveMDetails
            // 
            this.btnSaveMDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMDetails.Highlight = true;
            this.btnSaveMDetails.Location = new System.Drawing.Point(6, 90);
            this.btnSaveMDetails.Name = "btnSaveMDetails";
            this.btnSaveMDetails.Size = new System.Drawing.Size(80, 57);
            this.btnSaveMDetails.TabIndex = 11;
            this.btnSaveMDetails.Text = "Save/Update Master Table";
            this.btnSaveMDetails.UseSelectable = true;
            this.btnSaveMDetails.Click += new System.EventHandler(this.btnSaveMDetails_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.AliceBlue;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.txtSearchName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtSearchPhone);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.HorizontalScrollbarBarColor = true;
            this.panel5.HorizontalScrollbarHighlightOnWheel = false;
            this.panel5.HorizontalScrollbarSize = 10;
            this.panel5.Location = new System.Drawing.Point(-3, -3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(782, 74);
            this.panel5.TabIndex = 3;
            this.panel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel5.VerticalScrollbarBarColor = true;
            this.panel5.VerticalScrollbarHighlightOnWheel = false;
            this.panel5.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Master Details";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Name:";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Highlight = true;
            this.button3.Location = new System.Drawing.Point(639, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 20);
            this.button3.TabIndex = 12;
            this.button3.Text = "Fill Both List";
            this.button3.UseSelectable = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchName.Location = new System.Drawing.Point(119, 12);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(159, 20);
            this.txtSearchName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search By Mob No,:";
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchPhone.Location = new System.Drawing.Point(393, 12);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(159, 20);
            this.txtSearchPhone.TabIndex = 6;
            this.txtSearchPhone.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Highlight = true;
            this.btnSearch.Location = new System.Drawing.Point(558, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Previous Patient Search";
            this.tabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvPastDetails);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.HorizontalScrollbarBarColor = true;
            this.panel9.HorizontalScrollbarHighlightOnWheel = false;
            this.panel9.HorizontalScrollbarSize = 10;
            this.panel9.Location = new System.Drawing.Point(3, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(796, 376);
            this.panel9.TabIndex = 1;
            this.panel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel9.VerticalScrollbarBarColor = true;
            this.panel9.VerticalScrollbarHighlightOnWheel = false;
            this.panel9.VerticalScrollbarSize = 10;
            // 
            // dgvPastDetails
            // 
            this.dgvPastDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPastDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvPastDetails.Name = "dgvPastDetails";
            this.dgvPastDetails.Size = new System.Drawing.Size(796, 376);
            this.dgvPastDetails.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.txtPastName);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.txtPastPhn);
            this.panel8.Controls.Add(this.btnPastSearch);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.HorizontalScrollbarBarColor = true;
            this.panel8.HorizontalScrollbarHighlightOnWheel = false;
            this.panel8.HorizontalScrollbarSize = 10;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(796, 57);
            this.panel8.TabIndex = 0;
            this.panel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel8.VerticalScrollbarBarColor = true;
            this.panel8.VerticalScrollbarHighlightOnWheel = false;
            this.panel8.VerticalScrollbarSize = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Search By Name:";
            // 
            // txtPastName
            // 
            this.txtPastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPastName.Location = new System.Drawing.Point(137, 18);
            this.txtPastName.Name = "txtPastName";
            this.txtPastName.Size = new System.Drawing.Size(159, 20);
            this.txtPastName.TabIndex = 10;
            this.txtPastName.Click += new System.EventHandler(this.txtPastName_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(302, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Search By Mob No,:";
            // 
            // txtPastPhn
            // 
            this.txtPastPhn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPastPhn.Location = new System.Drawing.Point(411, 18);
            this.txtPastPhn.Name = "txtPastPhn";
            this.txtPastPhn.Size = new System.Drawing.Size(159, 20);
            this.txtPastPhn.TabIndex = 11;
            // 
            // btnPastSearch
            // 
            this.btnPastSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPastSearch.Highlight = true;
            this.btnPastSearch.Location = new System.Drawing.Point(576, 17);
            this.btnPastSearch.Name = "btnPastSearch";
            this.btnPastSearch.Size = new System.Drawing.Size(75, 20);
            this.btnPastSearch.TabIndex = 8;
            this.btnPastSearch.Text = "Search";
            this.btnPastSearch.UseSelectable = true;
            this.btnPastSearch.Click += new System.EventHandler(this.btnPastSearch_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel11);
            this.tabPage3.Controls.Add(this.panel10);
            this.tabPage3.HorizontalScrollbarBarColor = true;
            this.tabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage3.HorizontalScrollbarSize = 10;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(802, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Patient Balance List";
            this.tabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.VerticalScrollbarBarColor = true;
            this.tabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage3.VerticalScrollbarSize = 10;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvBalanceDetails);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.HorizontalScrollbarBarColor = true;
            this.panel11.HorizontalScrollbarHighlightOnWheel = false;
            this.panel11.HorizontalScrollbarSize = 10;
            this.panel11.Location = new System.Drawing.Point(3, 58);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(796, 378);
            this.panel11.TabIndex = 4;
            this.panel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel11.VerticalScrollbarBarColor = true;
            this.panel11.VerticalScrollbarHighlightOnWheel = false;
            this.panel11.VerticalScrollbarSize = 10;
            // 
            // dgvBalanceDetails
            // 
            this.dgvBalanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalanceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBalanceDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvBalanceDetails.Name = "dgvBalanceDetails";
            this.dgvBalanceDetails.Size = new System.Drawing.Size(796, 378);
            this.dgvBalanceDetails.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button2);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.dtpStart);
            this.panel10.Controls.Add(this.dtpEnd);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.HorizontalScrollbarBarColor = true;
            this.panel10.HorizontalScrollbarHighlightOnWheel = false;
            this.panel10.HorizontalScrollbarSize = 10;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(796, 55);
            this.panel10.TabIndex = 2;
            this.panel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel10.VerticalScrollbarBarColor = true;
            this.panel10.VerticalScrollbarHighlightOnWheel = false;
            this.panel10.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Highlight = true;
            this.button2.Location = new System.Drawing.Point(564, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search";
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(270, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "End Date:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Start Date:";
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStart.Location = new System.Drawing.Point(80, 20);
            this.dtpStart.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(135, 29);
            this.dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEnd.Location = new System.Drawing.Point(331, 20);
            this.dtpEnd.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(135, 29);
            this.dtpEnd.TabIndex = 1;
            // 
            // Staff_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Staff_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Staff_Screen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientDetails)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastDetails)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanceDetails)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage tabPage1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnPrntBill;
        private MetroFramework.Controls.MetroButton btnPrntOPD;
        private MetroFramework.Controls.MetroPanel panel1;
        private System.Windows.Forms.DataGridView dgvMaster;
        private MetroFramework.Controls.MetroPanel panel2;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnFill;
        private System.Windows.Forms.DataGridView dgvPatientDetails;
        private MetroFramework.Controls.MetroButton btnSaveMDetails;
        private MetroFramework.Controls.MetroPanel panel3;
        private MetroFramework.Controls.MetroPanel panel4;
        private MetroFramework.Controls.MetroPanel panel7;
        private MetroFramework.Controls.MetroPanel panel6;
        private MetroFramework.Controls.MetroPanel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTabPage tabPage2;
        private MetroFramework.Controls.MetroPanel panel9;
        private System.Windows.Forms.DataGridView dgvPastDetails;
        private MetroFramework.Controls.MetroPanel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPastPhn;
        private MetroFramework.Controls.MetroButton btnPastSearch;
        private MetroFramework.Controls.MetroTabPage tabPage3;
        private MetroFramework.Controls.MetroPanel panel11;
        private System.Windows.Forms.DataGridView dgvBalanceDetails;
        private MetroFramework.Controls.MetroPanel panel10;
        private MetroFramework.Controls.MetroButton button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroDateTime dtpStart;
        private MetroFramework.Controls.MetroDateTime dtpEnd;
        private MetroFramework.Controls.MetroButton button3;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroDateTime dtpOPD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroButton btnPaid;
        private System.Windows.Forms.TextBox txtPaid;
        private MetroFramework.Controls.MetroButton btnRefresh;
    }
}