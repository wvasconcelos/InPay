namespace InPay
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcZonecomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amazonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillToName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillToCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipToCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipToState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipToCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsIcons = new System.Windows.Forms.ToolStrip();
            this.btnLoadToQuickBooks = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrep = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.tsIcons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnEdit,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetPaymentToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetPaymentToolStripMenuItem
            // 
            this.resetPaymentToolStripMenuItem.Name = "resetPaymentToolStripMenuItem";
            this.resetPaymentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetPaymentToolStripMenuItem.Text = "Reset Payment";
            this.resetPaymentToolStripMenuItem.Click += new System.EventHandler(this.resetPaymentToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnEdit
            // 
            this.mnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSettings});
            this.mnEdit.Name = "mnEdit";
            this.mnEdit.Size = new System.Drawing.Size(39, 20);
            this.mnEdit.Text = "Edit";
            // 
            // mnSettings
            // 
            this.mnSettings.Name = "mnSettings";
            this.mnSettings.Size = new System.Drawing.Size(116, 22);
            this.mnSettings.Text = "Settings";
            this.mnSettings.Click += new System.EventHandler(this.mnSettings_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // arcZonecomToolStripMenuItem
            // 
            this.arcZonecomToolStripMenuItem.Name = "arcZonecomToolStripMenuItem";
            this.arcZonecomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arcZonecomToolStripMenuItem.Text = "Arc-Zone.com";
            // 
            // amazonToolStripMenuItem
            // 
            this.amazonToolStripMenuItem.Name = "amazonToolStripMenuItem";
            this.amazonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.amazonToolStripMenuItem.Text = "Amazon";
            // 
            // eBayToolStripMenuItem
            // 
            this.eBayToolStripMenuItem.Name = "eBayToolStripMenuItem";
            this.eBayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eBayToolStripMenuItem.Text = "eBay";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrigin,
            this.colOrderID,
            this.colDate,
            this.colBillToName,
            this.colBillToCompany,
            this.colShipToCity,
            this.colShipToState,
            this.colShipToCountry,
            this.colShipMethod,
            this.colShipCost,
            this.colSubtotal,
            this.colTax,
            this.colTotal,
            this.colPayMethod,
            this.colKey});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 65);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(1184, 474);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // colOrigin
            // 
            this.colOrigin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colOrigin.HeaderText = "Origin";
            this.colOrigin.MaxInputLength = 16;
            this.colOrigin.Name = "colOrigin";
            this.colOrigin.ReadOnly = true;
            this.colOrigin.Width = 59;
            // 
            // colOrderID
            // 
            this.colOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colOrderID.HeaderText = "OrderNo";
            this.colOrderID.MaxInputLength = 64;
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            this.colOrderID.Width = 72;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDate.HeaderText = "Date";
            this.colDate.MaxInputLength = 32;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.ToolTipText = "Order Date";
            this.colDate.Width = 55;
            // 
            // colBillToName
            // 
            this.colBillToName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBillToName.HeaderText = "Bill: Name";
            this.colBillToName.MaxInputLength = 256;
            this.colBillToName.Name = "colBillToName";
            this.colBillToName.ReadOnly = true;
            this.colBillToName.ToolTipText = "Name of the paying customer.";
            this.colBillToName.Width = 79;
            // 
            // colBillToCompany
            // 
            this.colBillToCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBillToCompany.HeaderText = "Bill: Company";
            this.colBillToCompany.Name = "colBillToCompany";
            this.colBillToCompany.ReadOnly = true;
            this.colBillToCompany.Width = 95;
            // 
            // colShipToCity
            // 
            this.colShipToCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colShipToCity.HeaderText = "Ship: City";
            this.colShipToCity.Name = "colShipToCity";
            this.colShipToCity.ReadOnly = true;
            this.colShipToCity.Width = 76;
            // 
            // colShipToState
            // 
            this.colShipToState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colShipToState.HeaderText = "Ship: State";
            this.colShipToState.Name = "colShipToState";
            this.colShipToState.ReadOnly = true;
            this.colShipToState.Width = 84;
            // 
            // colShipToCountry
            // 
            this.colShipToCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colShipToCountry.HeaderText = "Ship: Country";
            this.colShipToCountry.Name = "colShipToCountry";
            this.colShipToCountry.ReadOnly = true;
            this.colShipToCountry.Width = 95;
            // 
            // colShipMethod
            // 
            this.colShipMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colShipMethod.HeaderText = "Ship: Method";
            this.colShipMethod.Name = "colShipMethod";
            this.colShipMethod.ReadOnly = true;
            this.colShipMethod.Width = 95;
            // 
            // colShipCost
            // 
            this.colShipCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colShipCost.HeaderText = "Ship: Cost";
            this.colShipCost.Name = "colShipCost";
            this.colShipCost.ReadOnly = true;
            this.colShipCost.Width = 80;
            // 
            // colSubtotal
            // 
            this.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 71;
            // 
            // colTax
            // 
            this.colTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTax.HeaderText = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.ReadOnly = true;
            this.colTax.Width = 50;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 56;
            // 
            // colPayMethod
            // 
            this.colPayMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPayMethod.HeaderText = "Pay Method";
            this.colPayMethod.Name = "colPayMethod";
            this.colPayMethod.ReadOnly = true;
            this.colPayMethod.Width = 89;
            // 
            // colKey
            // 
            this.colKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colKey.HeaderText = "Key";
            this.colKey.MaxInputLength = 128;
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            this.colKey.Width = 50;
            // 
            // statusStrip
            // 
            this.statusStrip.AccessibleName = "statusStrip";
            this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.txtStatus,
            this.lblStatus,
            this.toolStripStatusLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 17);
            this.lblStatus.Text = "  ";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tsIcons
            // 
            this.tsIcons.AccessibleDescription = "Load available orders.";
            this.tsIcons.AccessibleName = "Load";
            this.tsIcons.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsIcons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadToQuickBooks,
            this.tsBtnRefresh,
            this.tsBtnPrep});
            this.tsIcons.Location = new System.Drawing.Point(0, 24);
            this.tsIcons.Name = "tsIcons";
            this.tsIcons.Size = new System.Drawing.Size(1184, 41);
            this.tsIcons.TabIndex = 3;
            this.tsIcons.Text = "Tool Strip Menu";
            // 
            // btnLoadToQuickBooks
            // 
            this.btnLoadToQuickBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadToQuickBooks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadToQuickBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadToQuickBooks.Image")));
            this.btnLoadToQuickBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadToQuickBooks.Name = "btnLoadToQuickBooks";
            this.btnLoadToQuickBooks.Padding = new System.Windows.Forms.Padding(5);
            this.btnLoadToQuickBooks.Size = new System.Drawing.Size(38, 38);
            this.btnLoadToQuickBooks.Text = "Send Ready Orders to QuickBooks";
            this.btnLoadToQuickBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadToQuickBooks.Click += new System.EventHandler(this.btnLoadToQuickBooks_Click);
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRefresh.Image")));
            this.tsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(28, 38);
            this.tsBtnRefresh.Text = "Refresh Grid";
            this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
            // 
            // tsBtnPrep
            // 
            this.tsBtnPrep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrep.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrep.Image")));
            this.tsBtnPrep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrep.Name = "tsBtnPrep";
            this.tsBtnPrep.Size = new System.Drawing.Size(28, 38);
            this.tsBtnPrep.Text = "Prepare Data";
            this.tsBtnPrep.Click += new System.EventHandler(this.tsBtnPrep_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tsIcons);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "InPay - Web Orders Payments Importer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tsIcons.ResumeLayout(false);
            this.tsIcons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arcZonecomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amazonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.ToolStripMenuItem mnEdit;
        private System.Windows.Forms.ToolStripMenuItem mnSettings;
        private System.Windows.Forms.ToolStrip tsIcons;
        private System.Windows.Forms.ToolStripButton btnLoadToQuickBooks;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem resetPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillToName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillToCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipToCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipToState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipToCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton tsBtnPrep;
    }
}

