using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InPay
{
    public partial class FormResetPaidOrders : Form
    {
        private Init ini = new Init(); //INSTANCE VARIABLE
        public FormResetPaidOrders()
        {
            InitializeComponent();
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            lblStatus.Text = ""; //RESET STATUS LABEL
            MSSQLAccess db = new MSSQLAccess();
            List<ApiOrder> recOrders = db.LoadRecentlyPaidOrders();
            //EXIT IF NO ORDERS TO LOAD
            if (recOrders.Count == 0)
                return;

            int unitOfProgress = Convert.ToInt16(100 / recOrders.Count);
            int percLoaded = 0;
            string name;
            string company;

            foreach (ApiOrder ord in recOrders)
            {
                name = ord.billToName;
                if (name.Trim().Equals(""))
                {
                    name = ord.shipToName;
                }

                company = ord.billToCompany;
                if (company.Trim().Equals(""))
                {
                    company = ord.shipToCompany;
                }
                //ADD ROW TO DATA TABLE
                dgvResetPayment.Rows.Add(
                    false,
                    ord.orderID,
                    name,
                    company,
                    ord.total,
                    Convert.ToDateTime(ord.orderDate).ToString("MM/dd/yy"));

                //UPDATE PROGRESS ON STATUS BAR
                percLoaded += unitOfProgress;
                lblStatus.Text = "Loading: " + percLoaded + "%";
                ProgressBar.Value = percLoaded;
            }
            lblStatus.Text = "";
            ProgressBar.Value = 0;
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            MSSQLAccess db = new MSSQLAccess();
            string orderID;
            bool paid = false;

            this.dgvResetPayment.CurrentCell = null;
            foreach (DataGridViewRow row in dgvResetPayment.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cell.Value) == true)
                {
                    orderID = row.Cells[1].Value.ToString();
                    db.SetOrderPaidStatus(orderID, paid);
                    db.UnSkipOrder(orderID);
                }
            }
            
            FormMain parentForm = (FormMain)Owner; //REFERENCE TO THE PARENT FORM
            if(parentForm != null)
            {
                parentForm.RefreshList();
            }
            this.Close();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
