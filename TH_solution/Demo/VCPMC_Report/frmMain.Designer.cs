namespace TH.Demo.VCPMC_Report
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTool = new System.Windows.Forms.ToolStrip();
            this.tsbLogInOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSelectFile = new System.Windows.Forms.ToolStripButton();
            this.txtPathFile = new System.Windows.Forms.ToolStripTextBox();
            this.tsbLoadFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCreateReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbFile = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSaveReport = new System.Windows.Forms.ToolStripButton();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTimeSys = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssInfo1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCreateReportInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALBUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LABEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_ISWC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_WRITERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_CUSTOM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNxtPage = new System.Windows.Forms.Button();
            this.btnFirstPAge = new System.Windows.Forms.Button();
            this.txtPageCurrent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pcloader = new System.Windows.Forms.PictureBox();
            this.cheIsrcVi = new System.Windows.Forms.CheckBox();
            this.cheLabelVi = new System.Windows.Forms.CheckBox();
            this.cheTitleVi = new System.Windows.Forms.CheckBox();
            this.cboDetectAPI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetectLanguage = new System.Windows.Forms.Button();
            this.txtLanguageDetect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResultDeLag = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.mainTool.SuspendLayout();
            this.mainStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConfig,
            this.tmsAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1095, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tsmConfig
            // 
            this.tsmConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsmConfig.Image")));
            this.tsmConfig.Name = "tsmConfig";
            this.tsmConfig.Size = new System.Drawing.Size(71, 20);
            this.tsmConfig.Text = "Config";
            this.tsmConfig.Click += new System.EventHandler(this.tsmConfig_Click);
            // 
            // tmsAbout
            // 
            this.tmsAbout.Image = ((System.Drawing.Image)(resources.GetObject("tmsAbout.Image")));
            this.tmsAbout.Name = "tmsAbout";
            this.tmsAbout.Size = new System.Drawing.Size(68, 20);
            this.tmsAbout.Text = "About";
            this.tmsAbout.Click += new System.EventHandler(this.tmsAbout_Click);
            // 
            // mainTool
            // 
            this.mainTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogInOut,
            this.toolStripSeparator1,
            this.tsbSelectFile,
            this.txtPathFile,
            this.tsbLoadFile,
            this.toolStripSeparator2,
            this.tsbCreateReport,
            this.toolStripSeparator3,
            this.tscbFile,
            this.toolStripSeparator4,
            this.tsSaveReport});
            this.mainTool.Location = new System.Drawing.Point(0, 24);
            this.mainTool.Name = "mainTool";
            this.mainTool.Size = new System.Drawing.Size(1095, 25);
            this.mainTool.TabIndex = 1;
            this.mainTool.Text = "toolStrip1";
            // 
            // tsbLogInOut
            // 
            this.tsbLogInOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogInOut.Image")));
            this.tsbLogInOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogInOut.Name = "tsbLogInOut";
            this.tsbLogInOut.Size = new System.Drawing.Size(57, 22);
            this.tsbLogInOut.Text = "Login";
            this.tsbLogInOut.Click += new System.EventHandler(this.tsbLogInOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSelectFile
            // 
            this.tsbSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelectFile.Image")));
            this.tsbSelectFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectFile.Name = "tsbSelectFile";
            this.tsbSelectFile.Size = new System.Drawing.Size(77, 22);
            this.tsbSelectFile.Text = "Select file";
            this.tsbSelectFile.Click += new System.EventHandler(this.tsbSelectFile_Click);
            // 
            // txtPathFile
            // 
            this.txtPathFile.AutoSize = false;
            this.txtPathFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.ReadOnly = true;
            this.txtPathFile.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbLoadFile
            // 
            this.tsbLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadFile.Image")));
            this.tsbLoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadFile.Name = "tsbLoadFile";
            this.tsbLoadFile.Size = new System.Drawing.Size(72, 22);
            this.tsbLoadFile.Text = "Load file";
            this.tsbLoadFile.Click += new System.EventHandler(this.tsbLoadFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCreateReport
            // 
            this.tsbCreateReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreateReport.Image")));
            this.tsbCreateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreateReport.Name = "tsbCreateReport";
            this.tsbCreateReport.Size = new System.Drawing.Size(99, 22);
            this.tsbCreateReport.Text = "Create Report";
            this.tsbCreateReport.Click += new System.EventHandler(this.tsbCreateReport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tscbFile
            // 
            this.tscbFile.AutoCompleteCustomSource.AddRange(new string[] {
            "Orginal File",
            "File1",
            "File2",
            "File3",
            "File4-none-vi",
            "File4-vi",
            "File5-none-vi",
            "File5-vi"});
            this.tscbFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbFile.Items.AddRange(new object[] {
            "Orginal File",
            "File1",
            "File2",
            "File3",
            "File4-none-vi",
            "File4-vi",
            "File4-again-none-vi",
            "File5-none-vi",
            "File5-vi",
            "File5-again-none-vi"});
            this.tscbFile.Name = "tscbFile";
            this.tscbFile.Size = new System.Drawing.Size(121, 25);
            this.tscbFile.SelectedIndexChanged += new System.EventHandler(this.tscbFile_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSaveReport
            // 
            this.tsSaveReport.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveReport.Image")));
            this.tsSaveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveReport.Name = "tsSaveReport";
            this.tsSaveReport.Size = new System.Drawing.Size(124, 22);
            this.tsSaveReport.Text = "Save Report to File";
            this.tsSaveReport.Click += new System.EventHandler(this.tsSaveReport_Click);
            // 
            // mainStatus
            // 
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.tssTimeSys,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel1,
            this.tssUser,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4,
            this.tssInfo,
            this.tssInfo1,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.tssCreateReportInfo});
            this.mainStatus.Location = new System.Drawing.Point(0, 343);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(1095, 22);
            this.mainStatus.TabIndex = 2;
            this.mainStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel3.Text = "Time: ";
            // 
            // tssTimeSys
            // 
            this.tssTimeSys.AutoSize = false;
            this.tssTimeSys.Name = "tssTimeSys";
            this.tssTimeSys.Size = new System.Drawing.Size(150, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "User: ";
            // 
            // tssUser
            // 
            this.tssUser.AutoSize = false;
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(150, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel4.Text = "loading data: ";
            // 
            // tssInfo
            // 
            this.tssInfo.AutoSize = false;
            this.tssInfo.Name = "tssInfo";
            this.tssInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // tssInfo1
            // 
            this.tssInfo1.Name = "tssInfo1";
            this.tssInfo1.Size = new System.Drawing.Size(16, 17);
            this.tssInfo1.Text = "...";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel7.Text = "Creating Report: ";
            // 
            // tssCreateReportInfo
            // 
            this.tssCreateReportInfo.Name = "tssCreateReportInfo";
            this.tssCreateReportInfo.Size = new System.Drawing.Size(16, 17);
            this.tssCreateReportInfo.Text = "...";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // dgvMain
            // 
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.ID,
            this.TITLE,
            this.ARTIST,
            this.ALBUM,
            this.LABEL,
            this.ISRC,
            this.COMP_ID,
            this.COMP_TITLE,
            this.COMP_ISWC,
            this.COMP_WRITERS,
            this.COMP_CUSTOM_ID,
            this.QUANTILE});
            this.dgvMain.Location = new System.Drawing.Point(9, 52);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(1078, 233);
            this.dgvMain.TabIndex = 3;
            // 
            // no
            // 
            this.no.DataPropertyName = "NO";
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "TITLE";
            this.TITLE.HeaderText = "TITLE";
            this.TITLE.Name = "TITLE";
            this.TITLE.ReadOnly = true;
            // 
            // ARTIST
            // 
            this.ARTIST.DataPropertyName = "ARTIST";
            this.ARTIST.HeaderText = "ARTIST";
            this.ARTIST.Name = "ARTIST";
            this.ARTIST.ReadOnly = true;
            // 
            // ALBUM
            // 
            this.ALBUM.DataPropertyName = "ALBUM";
            this.ALBUM.HeaderText = "ALBUM";
            this.ALBUM.Name = "ALBUM";
            this.ALBUM.ReadOnly = true;
            // 
            // LABEL
            // 
            this.LABEL.DataPropertyName = "LABEL";
            this.LABEL.HeaderText = "LABEL";
            this.LABEL.Name = "LABEL";
            this.LABEL.ReadOnly = true;
            // 
            // ISRC
            // 
            this.ISRC.DataPropertyName = "ISRC";
            this.ISRC.HeaderText = "ISRC";
            this.ISRC.Name = "ISRC";
            this.ISRC.ReadOnly = true;
            // 
            // COMP_ID
            // 
            this.COMP_ID.DataPropertyName = "COMP_ID";
            this.COMP_ID.HeaderText = "COMP_ID";
            this.COMP_ID.Name = "COMP_ID";
            this.COMP_ID.ReadOnly = true;
            // 
            // COMP_TITLE
            // 
            this.COMP_TITLE.DataPropertyName = "COMP_TITLE";
            this.COMP_TITLE.HeaderText = "COMP_TITLE";
            this.COMP_TITLE.Name = "COMP_TITLE";
            this.COMP_TITLE.ReadOnly = true;
            // 
            // COMP_ISWC
            // 
            this.COMP_ISWC.DataPropertyName = "COMP_ISWC";
            this.COMP_ISWC.HeaderText = "COMP_ISWC";
            this.COMP_ISWC.Name = "COMP_ISWC";
            this.COMP_ISWC.ReadOnly = true;
            // 
            // COMP_WRITERS
            // 
            this.COMP_WRITERS.DataPropertyName = "COMP_WRITERS";
            this.COMP_WRITERS.HeaderText = "COMP_WRITERS";
            this.COMP_WRITERS.Name = "COMP_WRITERS";
            this.COMP_WRITERS.ReadOnly = true;
            // 
            // COMP_CUSTOM_ID
            // 
            this.COMP_CUSTOM_ID.DataPropertyName = "COMP_CUSTOM_ID";
            this.COMP_CUSTOM_ID.HeaderText = "COMP_CUSTOM_ID";
            this.COMP_CUSTOM_ID.Name = "COMP_CUSTOM_ID";
            this.COMP_CUSTOM_ID.ReadOnly = true;
            // 
            // QUANTILE
            // 
            this.QUANTILE.DataPropertyName = "QUANTILE";
            this.QUANTILE.HeaderText = "QUANTILE";
            this.QUANTILE.Name = "QUANTILE";
            this.QUANTILE.ReadOnly = true;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevPage.Location = new System.Drawing.Point(90, 291);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 23);
            this.btnPrevPage.TabIndex = 17;
            this.btnPrevPage.Text = "Previous Page";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLastPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLastPage.Location = new System.Drawing.Point(380, 291);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastPage.TabIndex = 18;
            this.btnLastPage.Text = "Last Page";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNxtPage
            // 
            this.btnNxtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNxtPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNxtPage.Location = new System.Drawing.Point(299, 291);
            this.btnNxtPage.Name = "btnNxtPage";
            this.btnNxtPage.Size = new System.Drawing.Size(75, 23);
            this.btnNxtPage.TabIndex = 15;
            this.btnNxtPage.Text = "Next page";
            this.btnNxtPage.UseVisualStyleBackColor = false;
            this.btnNxtPage.Click += new System.EventHandler(this.btnNxtPage_Click);
            // 
            // btnFirstPAge
            // 
            this.btnFirstPAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPAge.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFirstPAge.Location = new System.Drawing.Point(9, 291);
            this.btnFirstPAge.Name = "btnFirstPAge";
            this.btnFirstPAge.Size = new System.Drawing.Size(75, 23);
            this.btnFirstPAge.TabIndex = 16;
            this.btnFirstPAge.Text = "First Page";
            this.btnFirstPAge.UseVisualStyleBackColor = false;
            this.btnFirstPAge.Click += new System.EventHandler(this.btnFirstPAge_Click);
            // 
            // txtPageCurrent
            // 
            this.txtPageCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPageCurrent.Location = new System.Drawing.Point(171, 294);
            this.txtPageCurrent.Name = "txtPageCurrent";
            this.txtPageCurrent.Size = new System.Drawing.Size(62, 20);
            this.txtPageCurrent.TabIndex = 19;
            this.txtPageCurrent.ValueChanged += new System.EventHandler(this.txtPageCurrent_ValueChanged);
            this.txtPageCurrent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPageCurrent_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "/";
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Location = new System.Drawing.Point(251, 301);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(19, 13);
            this.lbTotalPage.TabIndex = 21;
            this.lbTotalPage.Text = "(0)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pcloader
            // 
            this.pcloader.Image = ((System.Drawing.Image)(resources.GetObject("pcloader.Image")));
            this.pcloader.Location = new System.Drawing.Point(455, 159);
            this.pcloader.Name = "pcloader";
            this.pcloader.Size = new System.Drawing.Size(64, 66);
            this.pcloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcloader.TabIndex = 22;
            this.pcloader.TabStop = false;
            this.pcloader.Visible = false;
            // 
            // cheIsrcVi
            // 
            this.cheIsrcVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cheIsrcVi.AutoSize = true;
            this.cheIsrcVi.Checked = true;
            this.cheIsrcVi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cheIsrcVi.Location = new System.Drawing.Point(485, 294);
            this.cheIsrcVi.Name = "cheIsrcVi";
            this.cheIsrcVi.Size = new System.Drawing.Size(60, 17);
            this.cheIsrcVi.TabIndex = 23;
            this.cheIsrcVi.Text = "1.ISRC";
            this.cheIsrcVi.UseVisualStyleBackColor = true;
            // 
            // cheLabelVi
            // 
            this.cheLabelVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cheLabelVi.AutoSize = true;
            this.cheLabelVi.Checked = true;
            this.cheLabelVi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cheLabelVi.Location = new System.Drawing.Point(551, 294);
            this.cheLabelVi.Name = "cheLabelVi";
            this.cheLabelVi.Size = new System.Drawing.Size(68, 17);
            this.cheLabelVi.TabIndex = 24;
            this.cheLabelVi.Text = "2.LABEL";
            this.cheLabelVi.UseVisualStyleBackColor = true;
            // 
            // cheTitleVi
            // 
            this.cheTitleVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cheTitleVi.AutoSize = true;
            this.cheTitleVi.Checked = true;
            this.cheTitleVi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cheTitleVi.Location = new System.Drawing.Point(625, 294);
            this.cheTitleVi.Name = "cheTitleVi";
            this.cheTitleVi.Size = new System.Drawing.Size(65, 17);
            this.cheTitleVi.TabIndex = 25;
            this.cheTitleVi.Text = "3.TITLE";
            this.cheTitleVi.UseVisualStyleBackColor = true;
            // 
            // cboDetectAPI
            // 
            this.cboDetectAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboDetectAPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetectAPI.FormattingEnabled = true;
            this.cboDetectAPI.Items.AddRange(new object[] {
            "Detectlanguage"});
            this.cboDetectAPI.Location = new System.Drawing.Point(69, 317);
            this.cboDetectAPI.Name = "cboDetectAPI";
            this.cboDetectAPI.Size = new System.Drawing.Size(120, 21);
            this.cboDetectAPI.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Using API";
            // 
            // btnDetectLanguage
            // 
            this.btnDetectLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetectLanguage.Location = new System.Drawing.Point(719, 318);
            this.btnDetectLanguage.Name = "btnDetectLanguage";
            this.btnDetectLanguage.Size = new System.Drawing.Size(158, 23);
            this.btnDetectLanguage.TabIndex = 28;
            this.btnDetectLanguage.Text = "Test Detect Vietnamese";
            this.btnDetectLanguage.UseVisualStyleBackColor = true;
            this.btnDetectLanguage.Click += new System.EventHandler(this.btnDetectLanguage_Click);
            // 
            // txtLanguageDetect
            // 
            this.txtLanguageDetect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLanguageDetect.Location = new System.Drawing.Point(493, 320);
            this.txtLanguageDetect.Name = "txtLanguageDetect";
            this.txtLanguageDetect.Size = new System.Drawing.Size(224, 20);
            this.txtLanguageDetect.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Result test: ";
            // 
            // lbResultDeLag
            // 
            this.lbResultDeLag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResultDeLag.AutoSize = true;
            this.lbResultDeLag.Location = new System.Drawing.Point(941, 325);
            this.lbResultDeLag.Name = "lbResultDeLag";
            this.lbResultDeLag.Size = new System.Drawing.Size(16, 13);
            this.lbResultDeLag.TabIndex = 31;
            this.lbResultDeLag.Text = "...";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKey.Location = new System.Drawing.Point(233, 320);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(209, 20);
            this.txtKey.TabIndex = 32;
            this.txtKey.Text = "fcb933cfa7d69ef6921f6c5fa6f44e35";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "key";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "str test";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lbResultDeLag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLanguageDetect);
            this.Controls.Add(this.btnDetectLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDetectAPI);
            this.Controls.Add(this.cheTitleVi);
            this.Controls.Add(this.cheLabelVi);
            this.Controls.Add(this.cheIsrcVi);
            this.Controls.Add(this.pcloader);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPageCurrent);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnNxtPage);
            this.Controls.Add(this.btnFirstPAge);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.mainTool);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VCPMC Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainTool.ResumeLayout(false);
            this.mainTool.PerformLayout();
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcloader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmConfig;
        private System.Windows.Forms.ToolStripMenuItem tmsAbout;
        private System.Windows.Forms.ToolStrip mainTool;
        private System.Windows.Forms.ToolStripButton tsbLogInOut;
        private System.Windows.Forms.ToolStripButton tsbLoadFile;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssTimeSys;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tssInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSelectFile;
        private System.Windows.Forms.ToolStripTextBox txtPathFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCreateReport;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALBUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn LABEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_ISWC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_WRITERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_CUSTOM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTILE;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNxtPage;
        private System.Windows.Forms.Button btnFirstPAge;
        private System.Windows.Forms.NumericUpDown txtPageCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.ToolStripStatusLabel tssInfo1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel tssCreateReportInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox tscbFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsSaveReport;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pcloader;
        private System.Windows.Forms.CheckBox cheIsrcVi;
        private System.Windows.Forms.CheckBox cheLabelVi;
        private System.Windows.Forms.CheckBox cheTitleVi;
        private System.Windows.Forms.ComboBox cboDetectAPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetectLanguage;
        private System.Windows.Forms.TextBox txtLanguageDetect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResultDeLag;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

