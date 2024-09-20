namespace InPay
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.openExeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openQBCompanyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openLogFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openMapFileDialogPayments = new System.Windows.Forms.OpenFileDialog();
            this.tabTransactionPro = new System.Windows.Forms.TabPage();
            this.gbReceivePayment = new System.Windows.Forms.GroupBox();
            this.btnTPBrowseMapFilePayments = new System.Windows.Forms.Button();
            this.txtTPDBTableNamePayments = new System.Windows.Forms.TextBox();
            this.txtTPMapFilePayments = new System.Windows.Forms.TextBox();
            this.lblDataSoucePay = new System.Windows.Forms.Label();
            this.lblMapFilePay = new System.Windows.Forms.Label();
            this.gbTPSettings = new System.Windows.Forms.GroupBox();
            this.btnTPBrowseLogFolder = new System.Windows.Forms.Button();
            this.txtTPLogFolder = new System.Windows.Forms.TextBox();
            this.lblTPLogFolder = new System.Windows.Forms.Label();
            this.gbTPLogError = new System.Windows.Forms.GroupBox();
            this.rbTPLogErrorNo = new System.Windows.Forms.RadioButton();
            this.rbTPLogErrorYes = new System.Windows.Forms.RadioButton();
            this.gbDebug = new System.Windows.Forms.GroupBox();
            this.rbTPDebugNo = new System.Windows.Forms.RadioButton();
            this.rbTPDebugYes = new System.Windows.Forms.RadioButton();
            this.btnBrowseAppPath = new System.Windows.Forms.Button();
            this.txtTPExeFileName = new System.Windows.Forms.TextBox();
            this.lblTPExeFileName = new System.Windows.Forms.Label();
            this.gbxTPSourceDSN = new System.Windows.Forms.GroupBox();
            this.rbTPSourceDSNNo = new System.Windows.Forms.RadioButton();
            this.rbTPSourceDSNYes = new System.Windows.Forms.RadioButton();
            this.gbxTPAutoRun = new System.Windows.Forms.GroupBox();
            this.rbTPAutoRunNo = new System.Windows.Forms.RadioButton();
            this.rbTPAutoRunYes = new System.Windows.Forms.RadioButton();
            this.gbTPAutoAssign = new System.Windows.Forms.GroupBox();
            this.rbTPAutoAssignNo = new System.Windows.Forms.RadioButton();
            this.rbTPAutoAssignYes = new System.Windows.Forms.RadioButton();
            this.cbxTPConnectRetry = new System.Windows.Forms.ComboBox();
            this.txtTPVersion = new System.Windows.Forms.TextBox();
            this.txtTPPath = new System.Windows.Forms.TextBox();
            this.lblConnectRetry = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.lblTPPath = new System.Windows.Forms.Label();
            this.lblTPSettingsHeader = new System.Windows.Forms.Label();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.gbMSSQL = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtDSN = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblDSN = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQuickBooks = new System.Windows.Forms.TabPage();
            this.lblQuickBooks = new System.Windows.Forms.Label();
            this.gbxQuickBooks = new System.Windows.Forms.GroupBox();
            this.lblQbDSN = new System.Windows.Forms.Label();
            this.txtQBDSN = new System.Windows.Forms.TextBox();
            this.btnTPBrowseQBFilePath = new System.Windows.Forms.Button();
            this.txtQBFilePath = new System.Windows.Forms.TextBox();
            this.lblQBFilePath = new System.Windows.Forms.Label();
            this.lblLookBack = new System.Windows.Forms.Label();
            this.cbxQBLookBack = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabTransactionPro.SuspendLayout();
            this.gbReceivePayment.SuspendLayout();
            this.gbTPSettings.SuspendLayout();
            this.gbTPLogError.SuspendLayout();
            this.gbDebug.SuspendLayout();
            this.gbxTPSourceDSN.SuspendLayout();
            this.gbxTPAutoRun.SuspendLayout();
            this.gbTPAutoAssign.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.gbMSSQL.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabQuickBooks.SuspendLayout();
            this.gbxQuickBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSave,
            this.mnCancel});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(484, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnSave
            // 
            this.mnSave.Name = "mnSave";
            this.mnSave.Size = new System.Drawing.Size(43, 20);
            this.mnSave.Text = "Save";
            this.mnSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // mnCancel
            // 
            this.mnCancel.Name = "mnCancel";
            this.mnCancel.Size = new System.Drawing.Size(55, 20);
            this.mnCancel.Text = "Cancel";
            this.mnCancel.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // openExeFileDialog
            // 
            this.openExeFileDialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            // 
            // openQBCompanyFileDialog
            // 
            this.openQBCompanyFileDialog.Filter = "QuickBooks Company file (*.qbw)|*.qbw|All files (*.*)|*.*";
            // 
            // openMapFileDialogPayments
            // 
            this.openMapFileDialogPayments.Filter = "Transaction Pro Map file (*.dat)|*.dat";
            // 
            // tabTransactionPro
            // 
            this.tabTransactionPro.Controls.Add(this.gbReceivePayment);
            this.tabTransactionPro.Controls.Add(this.gbTPSettings);
            this.tabTransactionPro.Controls.Add(this.lblTPSettingsHeader);
            this.tabTransactionPro.Location = new System.Drawing.Point(4, 22);
            this.tabTransactionPro.Name = "tabTransactionPro";
            this.tabTransactionPro.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransactionPro.Size = new System.Drawing.Size(476, 489);
            this.tabTransactionPro.TabIndex = 5;
            this.tabTransactionPro.Text = "Transaction Pro";
            this.tabTransactionPro.UseVisualStyleBackColor = true;
            // 
            // gbReceivePayment
            // 
            this.gbReceivePayment.Controls.Add(this.btnTPBrowseMapFilePayments);
            this.gbReceivePayment.Controls.Add(this.txtTPDBTableNamePayments);
            this.gbReceivePayment.Controls.Add(this.txtTPMapFilePayments);
            this.gbReceivePayment.Controls.Add(this.lblDataSoucePay);
            this.gbReceivePayment.Controls.Add(this.lblMapFilePay);
            this.gbReceivePayment.Location = new System.Drawing.Point(25, 370);
            this.gbReceivePayment.Name = "gbReceivePayment";
            this.gbReceivePayment.Size = new System.Drawing.Size(420, 90);
            this.gbReceivePayment.TabIndex = 3;
            this.gbReceivePayment.TabStop = false;
            this.gbReceivePayment.Text = "Receive Payment";
            // 
            // btnTPBrowseMapFilePayments
            // 
            this.btnTPBrowseMapFilePayments.Location = new System.Drawing.Point(340, 30);
            this.btnTPBrowseMapFilePayments.Name = "btnTPBrowseMapFilePayments";
            this.btnTPBrowseMapFilePayments.Size = new System.Drawing.Size(60, 22);
            this.btnTPBrowseMapFilePayments.TabIndex = 4;
            this.btnTPBrowseMapFilePayments.Text = "Browse";
            this.btnTPBrowseMapFilePayments.UseVisualStyleBackColor = true;
            this.btnTPBrowseMapFilePayments.Click += new System.EventHandler(this.btnTPBrowseMapFilePay_Click);
            // 
            // txtTPDBTableNamePayments
            // 
            this.txtTPDBTableNamePayments.Location = new System.Drawing.Point(100, 60);
            this.txtTPDBTableNamePayments.Name = "txtTPDBTableNamePayments";
            this.txtTPDBTableNamePayments.Size = new System.Drawing.Size(200, 20);
            this.txtTPDBTableNamePayments.TabIndex = 3;
            // 
            // txtTPMapFilePayments
            // 
            this.txtTPMapFilePayments.Location = new System.Drawing.Point(100, 30);
            this.txtTPMapFilePayments.Name = "txtTPMapFilePayments";
            this.txtTPMapFilePayments.Size = new System.Drawing.Size(230, 20);
            this.txtTPMapFilePayments.TabIndex = 2;
            // 
            // lblDataSoucePay
            // 
            this.lblDataSoucePay.AutoSize = true;
            this.lblDataSoucePay.Location = new System.Drawing.Point(20, 60);
            this.lblDataSoucePay.Name = "lblDataSoucePay";
            this.lblDataSoucePay.Size = new System.Drawing.Size(67, 13);
            this.lblDataSoucePay.TabIndex = 1;
            this.lblDataSoucePay.Text = "Data Source";
            // 
            // lblMapFilePay
            // 
            this.lblMapFilePay.AutoSize = true;
            this.lblMapFilePay.Location = new System.Drawing.Point(20, 30);
            this.lblMapFilePay.Name = "lblMapFilePay";
            this.lblMapFilePay.Size = new System.Drawing.Size(47, 13);
            this.lblMapFilePay.TabIndex = 0;
            this.lblMapFilePay.Text = "Map File";
            // 
            // gbTPSettings
            // 
            this.gbTPSettings.Controls.Add(this.btnTPBrowseLogFolder);
            this.gbTPSettings.Controls.Add(this.txtTPLogFolder);
            this.gbTPSettings.Controls.Add(this.lblTPLogFolder);
            this.gbTPSettings.Controls.Add(this.gbTPLogError);
            this.gbTPSettings.Controls.Add(this.gbDebug);
            this.gbTPSettings.Controls.Add(this.btnBrowseAppPath);
            this.gbTPSettings.Controls.Add(this.txtTPExeFileName);
            this.gbTPSettings.Controls.Add(this.lblTPExeFileName);
            this.gbTPSettings.Controls.Add(this.gbxTPSourceDSN);
            this.gbTPSettings.Controls.Add(this.gbxTPAutoRun);
            this.gbTPSettings.Controls.Add(this.gbTPAutoAssign);
            this.gbTPSettings.Controls.Add(this.cbxTPConnectRetry);
            this.gbTPSettings.Controls.Add(this.txtTPVersion);
            this.gbTPSettings.Controls.Add(this.txtTPPath);
            this.gbTPSettings.Controls.Add(this.lblConnectRetry);
            this.gbTPSettings.Controls.Add(this.lblAppVersion);
            this.gbTPSettings.Controls.Add(this.lblTPPath);
            this.gbTPSettings.Location = new System.Drawing.Point(25, 60);
            this.gbTPSettings.Name = "gbTPSettings";
            this.gbTPSettings.Size = new System.Drawing.Size(420, 300);
            this.gbTPSettings.TabIndex = 1;
            this.gbTPSettings.TabStop = false;
            this.gbTPSettings.Text = "Remote Procedure Call Settings";
            // 
            // btnTPBrowseLogFolder
            // 
            this.btnTPBrowseLogFolder.Location = new System.Drawing.Point(340, 260);
            this.btnTPBrowseLogFolder.Name = "btnTPBrowseLogFolder";
            this.btnTPBrowseLogFolder.Size = new System.Drawing.Size(60, 22);
            this.btnTPBrowseLogFolder.TabIndex = 27;
            this.btnTPBrowseLogFolder.Text = "Browse";
            this.btnTPBrowseLogFolder.UseVisualStyleBackColor = true;
            this.btnTPBrowseLogFolder.Click += new System.EventHandler(this.btnTPBrowseLogFolder_Click);
            // 
            // txtTPLogFolder
            // 
            this.txtTPLogFolder.Location = new System.Drawing.Point(100, 260);
            this.txtTPLogFolder.Name = "txtTPLogFolder";
            this.txtTPLogFolder.Size = new System.Drawing.Size(235, 20);
            this.txtTPLogFolder.TabIndex = 26;
            // 
            // lblTPLogFolder
            // 
            this.lblTPLogFolder.AutoSize = true;
            this.lblTPLogFolder.Location = new System.Drawing.Point(20, 260);
            this.lblTPLogFolder.Name = "lblTPLogFolder";
            this.lblTPLogFolder.Size = new System.Drawing.Size(57, 13);
            this.lblTPLogFolder.TabIndex = 25;
            this.lblTPLogFolder.Text = "Log Folder";
            // 
            // gbTPLogError
            // 
            this.gbTPLogError.Controls.Add(this.rbTPLogErrorNo);
            this.gbTPLogError.Controls.Add(this.rbTPLogErrorYes);
            this.gbTPLogError.Location = new System.Drawing.Point(150, 210);
            this.gbTPLogError.Name = "gbTPLogError";
            this.gbTPLogError.Size = new System.Drawing.Size(110, 40);
            this.gbTPLogError.TabIndex = 24;
            this.gbTPLogError.TabStop = false;
            this.gbTPLogError.Text = "Log Error?";
            // 
            // rbTPLogErrorNo
            // 
            this.rbTPLogErrorNo.AutoSize = true;
            this.rbTPLogErrorNo.Location = new System.Drawing.Point(60, 17);
            this.rbTPLogErrorNo.Name = "rbTPLogErrorNo";
            this.rbTPLogErrorNo.Size = new System.Drawing.Size(39, 17);
            this.rbTPLogErrorNo.TabIndex = 1;
            this.rbTPLogErrorNo.TabStop = true;
            this.rbTPLogErrorNo.Text = "No";
            this.rbTPLogErrorNo.UseVisualStyleBackColor = true;
            // 
            // rbTPLogErrorYes
            // 
            this.rbTPLogErrorYes.AutoSize = true;
            this.rbTPLogErrorYes.Location = new System.Drawing.Point(10, 17);
            this.rbTPLogErrorYes.Name = "rbTPLogErrorYes";
            this.rbTPLogErrorYes.Size = new System.Drawing.Size(43, 17);
            this.rbTPLogErrorYes.TabIndex = 0;
            this.rbTPLogErrorYes.TabStop = true;
            this.rbTPLogErrorYes.Text = "Yes";
            this.rbTPLogErrorYes.UseVisualStyleBackColor = true;
            // 
            // gbDebug
            // 
            this.gbDebug.Controls.Add(this.rbTPDebugNo);
            this.gbDebug.Controls.Add(this.rbTPDebugYes);
            this.gbDebug.Location = new System.Drawing.Point(20, 210);
            this.gbDebug.Name = "gbDebug";
            this.gbDebug.Size = new System.Drawing.Size(110, 40);
            this.gbDebug.TabIndex = 23;
            this.gbDebug.TabStop = false;
            this.gbDebug.Text = "Debug Mode?";
            // 
            // rbTPDebugNo
            // 
            this.rbTPDebugNo.AutoSize = true;
            this.rbTPDebugNo.Location = new System.Drawing.Point(60, 17);
            this.rbTPDebugNo.Name = "rbTPDebugNo";
            this.rbTPDebugNo.Size = new System.Drawing.Size(39, 17);
            this.rbTPDebugNo.TabIndex = 1;
            this.rbTPDebugNo.TabStop = true;
            this.rbTPDebugNo.Text = "No";
            this.rbTPDebugNo.UseVisualStyleBackColor = true;
            // 
            // rbTPDebugYes
            // 
            this.rbTPDebugYes.AutoSize = true;
            this.rbTPDebugYes.Location = new System.Drawing.Point(10, 17);
            this.rbTPDebugYes.Name = "rbTPDebugYes";
            this.rbTPDebugYes.Size = new System.Drawing.Size(43, 17);
            this.rbTPDebugYes.TabIndex = 0;
            this.rbTPDebugYes.TabStop = true;
            this.rbTPDebugYes.Text = "Yes";
            this.rbTPDebugYes.UseVisualStyleBackColor = true;
            // 
            // btnBrowseAppPath
            // 
            this.btnBrowseAppPath.Location = new System.Drawing.Point(340, 60);
            this.btnBrowseAppPath.Name = "btnBrowseAppPath";
            this.btnBrowseAppPath.Size = new System.Drawing.Size(60, 22);
            this.btnBrowseAppPath.TabIndex = 20;
            this.btnBrowseAppPath.Text = "Browse";
            this.btnBrowseAppPath.UseVisualStyleBackColor = true;
            this.btnBrowseAppPath.Click += new System.EventHandler(this.btnBrowseAppPath_Click);
            // 
            // txtTPExeFileName
            // 
            this.txtTPExeFileName.Location = new System.Drawing.Point(100, 60);
            this.txtTPExeFileName.Name = "txtTPExeFileName";
            this.txtTPExeFileName.Size = new System.Drawing.Size(235, 20);
            this.txtTPExeFileName.TabIndex = 19;
            // 
            // lblTPExeFileName
            // 
            this.lblTPExeFileName.AutoSize = true;
            this.lblTPExeFileName.Location = new System.Drawing.Point(20, 60);
            this.lblTPExeFileName.Name = "lblTPExeFileName";
            this.lblTPExeFileName.Size = new System.Drawing.Size(75, 13);
            this.lblTPExeFileName.TabIndex = 18;
            this.lblTPExeFileName.Text = "Exe File Name";
            // 
            // gbxTPSourceDSN
            // 
            this.gbxTPSourceDSN.Controls.Add(this.rbTPSourceDSNNo);
            this.gbxTPSourceDSN.Controls.Add(this.rbTPSourceDSNYes);
            this.gbxTPSourceDSN.Location = new System.Drawing.Point(280, 160);
            this.gbxTPSourceDSN.Name = "gbxTPSourceDSN";
            this.gbxTPSourceDSN.Size = new System.Drawing.Size(110, 40);
            this.gbxTPSourceDSN.TabIndex = 17;
            this.gbxTPSourceDSN.TabStop = false;
            this.gbxTPSourceDSN.Text = "Source is DSN?";
            // 
            // rbTPSourceDSNNo
            // 
            this.rbTPSourceDSNNo.AutoSize = true;
            this.rbTPSourceDSNNo.Location = new System.Drawing.Point(60, 17);
            this.rbTPSourceDSNNo.Name = "rbTPSourceDSNNo";
            this.rbTPSourceDSNNo.Size = new System.Drawing.Size(39, 17);
            this.rbTPSourceDSNNo.TabIndex = 1;
            this.rbTPSourceDSNNo.TabStop = true;
            this.rbTPSourceDSNNo.Text = "No";
            this.rbTPSourceDSNNo.UseVisualStyleBackColor = true;
            // 
            // rbTPSourceDSNYes
            // 
            this.rbTPSourceDSNYes.AutoSize = true;
            this.rbTPSourceDSNYes.Location = new System.Drawing.Point(10, 17);
            this.rbTPSourceDSNYes.Name = "rbTPSourceDSNYes";
            this.rbTPSourceDSNYes.Size = new System.Drawing.Size(43, 17);
            this.rbTPSourceDSNYes.TabIndex = 0;
            this.rbTPSourceDSNYes.TabStop = true;
            this.rbTPSourceDSNYes.Text = "Yes";
            this.rbTPSourceDSNYes.UseVisualStyleBackColor = true;
            // 
            // gbxTPAutoRun
            // 
            this.gbxTPAutoRun.Controls.Add(this.rbTPAutoRunNo);
            this.gbxTPAutoRun.Controls.Add(this.rbTPAutoRunYes);
            this.gbxTPAutoRun.Location = new System.Drawing.Point(150, 160);
            this.gbxTPAutoRun.Name = "gbxTPAutoRun";
            this.gbxTPAutoRun.Size = new System.Drawing.Size(110, 40);
            this.gbxTPAutoRun.TabIndex = 16;
            this.gbxTPAutoRun.TabStop = false;
            this.gbxTPAutoRun.Text = "Auto Run?";
            // 
            // rbTPAutoRunNo
            // 
            this.rbTPAutoRunNo.AutoSize = true;
            this.rbTPAutoRunNo.Location = new System.Drawing.Point(60, 17);
            this.rbTPAutoRunNo.Name = "rbTPAutoRunNo";
            this.rbTPAutoRunNo.Size = new System.Drawing.Size(39, 17);
            this.rbTPAutoRunNo.TabIndex = 1;
            this.rbTPAutoRunNo.TabStop = true;
            this.rbTPAutoRunNo.Text = "No";
            this.rbTPAutoRunNo.UseVisualStyleBackColor = true;
            // 
            // rbTPAutoRunYes
            // 
            this.rbTPAutoRunYes.AutoSize = true;
            this.rbTPAutoRunYes.Location = new System.Drawing.Point(10, 17);
            this.rbTPAutoRunYes.Name = "rbTPAutoRunYes";
            this.rbTPAutoRunYes.Size = new System.Drawing.Size(43, 17);
            this.rbTPAutoRunYes.TabIndex = 0;
            this.rbTPAutoRunYes.TabStop = true;
            this.rbTPAutoRunYes.Text = "Yes";
            this.rbTPAutoRunYes.UseVisualStyleBackColor = true;
            // 
            // gbTPAutoAssign
            // 
            this.gbTPAutoAssign.Controls.Add(this.rbTPAutoAssignNo);
            this.gbTPAutoAssign.Controls.Add(this.rbTPAutoAssignYes);
            this.gbTPAutoAssign.Location = new System.Drawing.Point(20, 160);
            this.gbTPAutoAssign.Name = "gbTPAutoAssign";
            this.gbTPAutoAssign.Size = new System.Drawing.Size(110, 40);
            this.gbTPAutoAssign.TabIndex = 15;
            this.gbTPAutoAssign.TabStop = false;
            this.gbTPAutoAssign.Text = "Auto Assign?";
            // 
            // rbTPAutoAssignNo
            // 
            this.rbTPAutoAssignNo.AutoSize = true;
            this.rbTPAutoAssignNo.Location = new System.Drawing.Point(60, 17);
            this.rbTPAutoAssignNo.Name = "rbTPAutoAssignNo";
            this.rbTPAutoAssignNo.Size = new System.Drawing.Size(39, 17);
            this.rbTPAutoAssignNo.TabIndex = 1;
            this.rbTPAutoAssignNo.TabStop = true;
            this.rbTPAutoAssignNo.Text = "No";
            this.rbTPAutoAssignNo.UseVisualStyleBackColor = true;
            // 
            // rbTPAutoAssignYes
            // 
            this.rbTPAutoAssignYes.AutoSize = true;
            this.rbTPAutoAssignYes.Location = new System.Drawing.Point(10, 17);
            this.rbTPAutoAssignYes.Name = "rbTPAutoAssignYes";
            this.rbTPAutoAssignYes.Size = new System.Drawing.Size(43, 17);
            this.rbTPAutoAssignYes.TabIndex = 0;
            this.rbTPAutoAssignYes.TabStop = true;
            this.rbTPAutoAssignYes.Text = "Yes";
            this.rbTPAutoAssignYes.UseVisualStyleBackColor = true;
            // 
            // cbxTPConnectRetry
            // 
            this.cbxTPConnectRetry.FormattingEnabled = true;
            this.cbxTPConnectRetry.Items.AddRange(new object[] {
            "",
            "1 min",
            "2 min",
            "3 min",
            "4 min",
            "5 min",
            "10 min",
            "15 min",
            "30 min",
            "60 min"});
            this.cbxTPConnectRetry.Location = new System.Drawing.Point(100, 120);
            this.cbxTPConnectRetry.Name = "cbxTPConnectRetry";
            this.cbxTPConnectRetry.Size = new System.Drawing.Size(80, 21);
            this.cbxTPConnectRetry.TabIndex = 14;
            // 
            // txtTPVersion
            // 
            this.txtTPVersion.Location = new System.Drawing.Point(100, 90);
            this.txtTPVersion.Name = "txtTPVersion";
            this.txtTPVersion.Size = new System.Drawing.Size(300, 20);
            this.txtTPVersion.TabIndex = 10;
            // 
            // txtTPPath
            // 
            this.txtTPPath.Location = new System.Drawing.Point(100, 30);
            this.txtTPPath.Name = "txtTPPath";
            this.txtTPPath.Size = new System.Drawing.Size(300, 20);
            this.txtTPPath.TabIndex = 9;
            // 
            // lblConnectRetry
            // 
            this.lblConnectRetry.AutoSize = true;
            this.lblConnectRetry.Location = new System.Drawing.Point(20, 120);
            this.lblConnectRetry.Name = "lblConnectRetry";
            this.lblConnectRetry.Size = new System.Drawing.Size(75, 13);
            this.lblConnectRetry.TabIndex = 5;
            this.lblConnectRetry.Text = "Connect Retry";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Location = new System.Drawing.Point(20, 90);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(64, 13);
            this.lblAppVersion.TabIndex = 1;
            this.lblAppVersion.Text = "App Version";
            // 
            // lblTPPath
            // 
            this.lblTPPath.AutoSize = true;
            this.lblTPPath.Location = new System.Drawing.Point(20, 30);
            this.lblTPPath.Name = "lblTPPath";
            this.lblTPPath.Size = new System.Drawing.Size(51, 13);
            this.lblTPPath.TabIndex = 0;
            this.lblTPPath.Text = "App Path";
            // 
            // lblTPSettingsHeader
            // 
            this.lblTPSettingsHeader.AutoSize = true;
            this.lblTPSettingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTPSettingsHeader.Location = new System.Drawing.Point(25, 25);
            this.lblTPSettingsHeader.Name = "lblTPSettingsHeader";
            this.lblTPSettingsHeader.Size = new System.Drawing.Size(120, 20);
            this.lblTPSettingsHeader.TabIndex = 0;
            this.lblTPSettingsHeader.Text = "Transaction Pro";
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.gbMSSQL);
            this.tabDatabase.Controls.Add(this.lblConnection);
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(476, 489);
            this.tabDatabase.TabIndex = 0;
            this.tabDatabase.Text = "Database";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // gbMSSQL
            // 
            this.gbMSSQL.Controls.Add(this.txtPassword);
            this.gbMSSQL.Controls.Add(this.txtUserID);
            this.gbMSSQL.Controls.Add(this.txtDSN);
            this.gbMSSQL.Controls.Add(this.txtDatabase);
            this.gbMSSQL.Controls.Add(this.txtServer);
            this.gbMSSQL.Controls.Add(this.lblPassword);
            this.gbMSSQL.Controls.Add(this.lblUserID);
            this.gbMSSQL.Controls.Add(this.lblDSN);
            this.gbMSSQL.Controls.Add(this.lblServer);
            this.gbMSSQL.Controls.Add(this.lblDatabase);
            this.gbMSSQL.Location = new System.Drawing.Point(25, 60);
            this.gbMSSQL.Name = "gbMSSQL";
            this.gbMSSQL.Size = new System.Drawing.Size(420, 180);
            this.gbMSSQL.TabIndex = 7;
            this.gbMSSQL.TabStop = false;
            this.gbMSSQL.Text = "MS SQL";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(80, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(80, 115);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(300, 20);
            this.txtUserID.TabIndex = 10;
            // 
            // txtDSN
            // 
            this.txtDSN.Location = new System.Drawing.Point(80, 85);
            this.txtDSN.Name = "txtDSN";
            this.txtDSN.Size = new System.Drawing.Size(300, 20);
            this.txtDSN.TabIndex = 9;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(80, 55);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(300, 20);
            this.txtDatabase.TabIndex = 8;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(80, 25);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(300, 20);
            this.txtServer.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(15, 120);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "User ID";
            // 
            // lblDSN
            // 
            this.lblDSN.AutoSize = true;
            this.lblDSN.Location = new System.Drawing.Point(15, 90);
            this.lblDSN.Name = "lblDSN";
            this.lblDSN.Size = new System.Drawing.Size(30, 13);
            this.lblDSN.TabIndex = 3;
            this.lblDSN.Text = "DSN";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(15, 30);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(15, 60);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 2;
            this.lblDatabase.Text = "Database";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(25, 25);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(164, 20);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "Database Connection";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDatabase);
            this.tabControl.Controls.Add(this.tabQuickBooks);
            this.tabControl.Controls.Add(this.tabTransactionPro);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(484, 515);
            this.tabControl.TabIndex = 1;
            // 
            // tabQuickBooks
            // 
            this.tabQuickBooks.Controls.Add(this.gbxQuickBooks);
            this.tabQuickBooks.Controls.Add(this.lblQuickBooks);
            this.tabQuickBooks.Location = new System.Drawing.Point(4, 22);
            this.tabQuickBooks.Name = "tabQuickBooks";
            this.tabQuickBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuickBooks.Size = new System.Drawing.Size(476, 489);
            this.tabQuickBooks.TabIndex = 6;
            this.tabQuickBooks.Text = "QuickBooks";
            this.tabQuickBooks.UseVisualStyleBackColor = true;
            // 
            // lblQuickBooks
            // 
            this.lblQuickBooks.AutoSize = true;
            this.lblQuickBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickBooks.Location = new System.Drawing.Point(25, 25);
            this.lblQuickBooks.Name = "lblQuickBooks";
            this.lblQuickBooks.Size = new System.Drawing.Size(179, 20);
            this.lblQuickBooks.TabIndex = 0;
            this.lblQuickBooks.Text = "QuickBooks Connection";
            // 
            // gbxQuickBooks
            // 
            this.gbxQuickBooks.Controls.Add(this.cbxQBLookBack);
            this.gbxQuickBooks.Controls.Add(this.lblLookBack);
            this.gbxQuickBooks.Controls.Add(this.btnTPBrowseQBFilePath);
            this.gbxQuickBooks.Controls.Add(this.txtQBFilePath);
            this.gbxQuickBooks.Controls.Add(this.lblQBFilePath);
            this.gbxQuickBooks.Controls.Add(this.txtQBDSN);
            this.gbxQuickBooks.Controls.Add(this.lblQbDSN);
            this.gbxQuickBooks.Location = new System.Drawing.Point(25, 60);
            this.gbxQuickBooks.Name = "gbxQuickBooks";
            this.gbxQuickBooks.Size = new System.Drawing.Size(420, 122);
            this.gbxQuickBooks.TabIndex = 1;
            this.gbxQuickBooks.TabStop = false;
            this.gbxQuickBooks.Text = "QuickBooks";
            // 
            // lblQbDSN
            // 
            this.lblQbDSN.AutoSize = true;
            this.lblQbDSN.Location = new System.Drawing.Point(15, 30);
            this.lblQbDSN.Name = "lblQbDSN";
            this.lblQbDSN.Size = new System.Drawing.Size(30, 13);
            this.lblQbDSN.TabIndex = 0;
            this.lblQbDSN.Text = "DSN";
            this.lblQbDSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQBDSN
            // 
            this.txtQBDSN.Location = new System.Drawing.Point(105, 25);
            this.txtQBDSN.Name = "txtQBDSN";
            this.txtQBDSN.Size = new System.Drawing.Size(100, 20);
            this.txtQBDSN.TabIndex = 1;
            // 
            // btnTPBrowseQBFilePath
            // 
            this.btnTPBrowseQBFilePath.Location = new System.Drawing.Point(340, 55);
            this.btnTPBrowseQBFilePath.Name = "btnTPBrowseQBFilePath";
            this.btnTPBrowseQBFilePath.Size = new System.Drawing.Size(60, 20);
            this.btnTPBrowseQBFilePath.TabIndex = 25;
            this.btnTPBrowseQBFilePath.Text = "Browse";
            this.btnTPBrowseQBFilePath.UseVisualStyleBackColor = true;
            this.btnTPBrowseQBFilePath.Click += new System.EventHandler(this.btnTPBrowseQBFilePath_Click_1);
            // 
            // txtQBFilePath
            // 
            this.txtQBFilePath.Location = new System.Drawing.Point(105, 55);
            this.txtQBFilePath.Name = "txtQBFilePath";
            this.txtQBFilePath.Size = new System.Drawing.Size(230, 20);
            this.txtQBFilePath.TabIndex = 24;
            // 
            // lblQBFilePath
            // 
            this.lblQBFilePath.AutoSize = true;
            this.lblQBFilePath.Location = new System.Drawing.Point(15, 60);
            this.lblQBFilePath.Name = "lblQBFilePath";
            this.lblQBFilePath.Size = new System.Drawing.Size(70, 13);
            this.lblQBFilePath.TabIndex = 23;
            this.lblQBFilePath.Text = "Company File";
            this.lblQBFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLookBack
            // 
            this.lblLookBack.AutoSize = true;
            this.lblLookBack.Location = new System.Drawing.Point(15, 90);
            this.lblLookBack.Name = "lblLookBack";
            this.lblLookBack.Size = new System.Drawing.Size(90, 13);
            this.lblLookBack.TabIndex = 26;
            this.lblLookBack.Text = "Look Back (days)";
            // 
            // cbxQBLookBack
            // 
            this.cbxQBLookBack.FormattingEnabled = true;
            this.cbxQBLookBack.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "14",
            "21",
            "28",
            "35"});
            this.cbxQBLookBack.Location = new System.Drawing.Point(105, 85);
            this.cbxQBLookBack.Name = "cbxQBLookBack";
            this.cbxQBLookBack.Size = new System.Drawing.Size(100, 21);
            this.cbxQBLookBack.TabIndex = 27;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormSettings";
            this.Text = "InPay - Settings";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabTransactionPro.ResumeLayout(false);
            this.tabTransactionPro.PerformLayout();
            this.gbReceivePayment.ResumeLayout(false);
            this.gbReceivePayment.PerformLayout();
            this.gbTPSettings.ResumeLayout(false);
            this.gbTPSettings.PerformLayout();
            this.gbTPLogError.ResumeLayout(false);
            this.gbTPLogError.PerformLayout();
            this.gbDebug.ResumeLayout(false);
            this.gbDebug.PerformLayout();
            this.gbxTPSourceDSN.ResumeLayout(false);
            this.gbxTPSourceDSN.PerformLayout();
            this.gbxTPAutoRun.ResumeLayout(false);
            this.gbxTPAutoRun.PerformLayout();
            this.gbTPAutoAssign.ResumeLayout(false);
            this.gbTPAutoAssign.PerformLayout();
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            this.gbMSSQL.ResumeLayout(false);
            this.gbMSSQL.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabQuickBooks.ResumeLayout(false);
            this.tabQuickBooks.PerformLayout();
            this.gbxQuickBooks.ResumeLayout(false);
            this.gbxQuickBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnSave;
        private System.Windows.Forms.ToolStripMenuItem mnCancel;
        private System.Windows.Forms.OpenFileDialog openExeFileDialog;
        private System.Windows.Forms.OpenFileDialog openQBCompanyFileDialog;
        private System.Windows.Forms.FolderBrowserDialog openLogFolderDialog;
        private System.Windows.Forms.OpenFileDialog openMapFileDialogPayments;
        private System.Windows.Forms.TabPage tabTransactionPro;
        private System.Windows.Forms.GroupBox gbReceivePayment;
        private System.Windows.Forms.Button btnTPBrowseMapFilePayments;
        private System.Windows.Forms.TextBox txtTPDBTableNamePayments;
        private System.Windows.Forms.TextBox txtTPMapFilePayments;
        private System.Windows.Forms.Label lblDataSoucePay;
        private System.Windows.Forms.Label lblMapFilePay;
        private System.Windows.Forms.GroupBox gbTPSettings;
        private System.Windows.Forms.Button btnTPBrowseLogFolder;
        private System.Windows.Forms.TextBox txtTPLogFolder;
        private System.Windows.Forms.Label lblTPLogFolder;
        private System.Windows.Forms.GroupBox gbTPLogError;
        private System.Windows.Forms.RadioButton rbTPLogErrorNo;
        private System.Windows.Forms.RadioButton rbTPLogErrorYes;
        private System.Windows.Forms.GroupBox gbDebug;
        private System.Windows.Forms.RadioButton rbTPDebugNo;
        private System.Windows.Forms.RadioButton rbTPDebugYes;
        private System.Windows.Forms.Button btnBrowseAppPath;
        private System.Windows.Forms.TextBox txtTPExeFileName;
        private System.Windows.Forms.Label lblTPExeFileName;
        private System.Windows.Forms.GroupBox gbxTPSourceDSN;
        private System.Windows.Forms.RadioButton rbTPSourceDSNNo;
        private System.Windows.Forms.RadioButton rbTPSourceDSNYes;
        private System.Windows.Forms.GroupBox gbxTPAutoRun;
        private System.Windows.Forms.RadioButton rbTPAutoRunNo;
        private System.Windows.Forms.RadioButton rbTPAutoRunYes;
        private System.Windows.Forms.GroupBox gbTPAutoAssign;
        private System.Windows.Forms.RadioButton rbTPAutoAssignNo;
        private System.Windows.Forms.RadioButton rbTPAutoAssignYes;
        private System.Windows.Forms.ComboBox cbxTPConnectRetry;
        private System.Windows.Forms.TextBox txtTPVersion;
        private System.Windows.Forms.TextBox txtTPPath;
        private System.Windows.Forms.Label lblConnectRetry;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label lblTPPath;
        private System.Windows.Forms.Label lblTPSettingsHeader;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.GroupBox gbMSSQL;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtDSN;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblDSN;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabQuickBooks;
        private System.Windows.Forms.GroupBox gbxQuickBooks;
        private System.Windows.Forms.TextBox txtQBDSN;
        private System.Windows.Forms.Label lblQbDSN;
        private System.Windows.Forms.Label lblQuickBooks;
        private System.Windows.Forms.Button btnTPBrowseQBFilePath;
        private System.Windows.Forms.TextBox txtQBFilePath;
        private System.Windows.Forms.Label lblQBFilePath;
        private System.Windows.Forms.ComboBox cbxQBLookBack;
        private System.Windows.Forms.Label lblLookBack;
    }
}