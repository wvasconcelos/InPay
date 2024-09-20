using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace InPay
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            try
            {
                listLoader();
            }
            catch (Exception ex)
            {
                SetStatusLabelText("Unable to load list. Please, check the database configuration settings. More info: " + ex.Message);
            }

            /* CREATE SKIP BUTTON */
            DataGridViewButtonColumn btnSkip = new DataGridViewButtonColumn();
            btnSkip.Name = "colSkip";
            btnSkip.HeaderText = "Skip";
            btnSkip.Text = "Skip";
            btnSkip.ToolTipText ="Skip order on create payment in QuickBooks.";
            btnSkip.Width = 35;
            btnSkip.UseColumnTextForButtonValue = true;
            dgvMain.Columns.Insert(0, btnSkip);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message;
            string caption;

            SetStatusLabelText(""); //RESET STATUS LABEL
            message = "In Pay - Web Orders Accounting Information Importer\n" +
            "Version: 1.0\n" +
            "Arc-Zone.com, Inc.\n" +
            "Created on: June, 2018";
            caption = "About the Importer";

            MessageBox.Show(this, message, caption,MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool listLoader()
        {
            //DECLARE VARIABLES
            MSSQLAccess db = MSSQLAccess.Instance();

            SetStatusLabelText(""); //RESET STATUS LABEL

            db.SetNet30ToUploaded(); //IGNORE NET 30 ORDERS
            db.SetAmazonOrdersToUploaded(); //IGNORE AMAZON ORDERS

            //LOAD ORDERS INTO DATA GRID
            List<ApiOrder> pendingPay = db.LoadAllPendingPayment();
            if (pendingPay.Count == 0)
                return false; //EXIT IF NO ORDERS TO LOAD

            int unitOfProgress      = Convert.ToInt16(100 / pendingPay.Count);
            int percLoaded          = 0;
            foreach (ApiOrder ord in pendingPay)
            {
                if (ord.payMethod.Substring(0, 3) == "Net")
                {
                    ord.qbFullName = "# Web Orders #";
                    ord.qbListID = "0";
                }

                //ADD ROW TO DATA TABLE
                dgvMain.Rows.Add(
                    ord.createBy, 
                    ord.orderID,
                    Convert.ToDateTime(ord.orderDate).ToString("MM/dd/yy"),
                    ord.billToName,
                    ord.billToCompany,
                    ord.shipToCity,
                    ord.shipToState,
                    ord.shipToCountry,
                    ord.shipMethod,
                    ord.shipCost,
                    ord.subtotal,
                    ord.taxCost,
                    ord.total,
                    ord.payMethod,
                    ord.qbFullName);

                //UPDATE PROGRESS ON STATUS BAR
                percLoaded += unitOfProgress;
                SetStatusLabelText("Loading: " + percLoaded + "%");
                ProgressBar.Value = percLoaded;
            }
            SetStatusLabelText("There are " + dgvMain.RowCount + " orders pending payment.");
            ProgressBar.Value = 0;
            return true;
        } //END: listLoader

        private void mnSettings_Click(object sender, EventArgs e)
        {
            SetStatusLabelText(""); //RESET STATUS LABEL
            FormSettings settings = new FormSettings();
            settings.Show();
        }

        private void btnLoadToQuickBooks_Click(object sender, EventArgs e)
        {
            Task t;
            Init ini = Init.Instance();
            MSSQLAccess db = MSSQLAccess.Instance();

            //CHECK IF TRANSACTION PRO IS AVAILABLE
            if (!File.Exists(ini.tpPath + ini.tpExeFile))
            {
                btnLoadToQuickBooks.Enabled = false;
                MessageBox.Show("Transaction Pro not available. This option is not accessible from this computer.");
                return;
            }

            //CHECK IF THERE ARE ANY PAYMENT PENDING
            if (dgvMain.RowCount < 1)
            {
                MessageBox.Show("No orders pending.");
                return;
            }

            //CONFIRMATION BOX
            DialogResult myConfirm = MessageBox.Show("Add payments to QuickBooks?", "Confirmation", MessageBoxButtons.YesNo);
            if (myConfirm.Equals(DialogResult.No)) { return; }

            //ENSURE ALL ORDERS HAVE A QUICK BOOKS FULL NAME
            for( int i = 0; i < dgvMain.RowCount; i++ )
            {
                if (dgvMain.Rows[i].Cells[15] == null || dgvMain.Rows[i].Cells[15].Value.ToString() == "")
                {
                    MessageBox.Show("QuickBooks Customer Full Name reference missing. Click the [Prepare Data] button to fill out missing values.");
                    return;
                }
            }

            //EXECUTE LOAD
            this.Enabled = false; //DISABLE APP UNTIL UPDATE IS COMPLETED
            string feedback = "Calling Transaction Pro...";
            SetStatusLabelText(feedback);
            feedback = Utils.LoadOrdersPaymentIntoQuickBooks();
            SetStatusLabelText(feedback);

            //REFRESH DATA GRID
            this.RefreshList();
        } //END: METHOD

        public void RefreshList()
        {
            dgvMain.Rows.Clear();
            listLoader();
            this.Enabled = true; //UPDATE COMPLETED: ENABLE APP
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderID = "";
            MSSQLAccess db = MSSQLAccess.Instance();

            if (e.RowIndex >= 0)
            {
                orderID = dgvMain.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            if (orderID != "")
            {
                if (e.ColumnIndex == 0)
                { //Skip Button
                    db.SkipOrder(orderID);
                    RefreshList();
                }
                else
                {
                    //Edit Order
                    FormEditOrder frmOrder = new FormEditOrder(orderID);
                    frmOrder.Show(this);
                }
            }
        }

        private void resetPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResetPaidOrders frmLastUploads = new FormResetPaidOrders();
            frmLastUploads.Show(this);
        }

        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshList();
        }

        public void SetStatusLabelText(string newLabel)
        {
            lblStatus.Text = newLabel;
            statusStrip.Update();
        }

        private void tsBtnPrep_Click(object sender, EventArgs e)
        {
            Task t;
            MSSQLAccess db = MSSQLAccess.Instance();

            SetStatusLabelText("Start loading any missing QuickBooks Customer Full Name into the database...");
            t = db.FillOutQbFullName();
            t.Wait();
            SetStatusLabelText("Customer Full Names loaded! Refreshing list...");
            RefreshList();
            SetStatusLabelText("Done!");
        }
    } //END: CLASS
} //END: NAME SPACE
