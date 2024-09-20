using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InPay
{
    public partial class FormEditOrder : Form
    {
        private Init ini = Init.Instance(); //INSTANCE VARIABLE

        public FormEditOrder(string orderNumber)
        {
            InitializeComponent();
            loadEditOrder(orderNumber);
        }

        //instantiate all possible order types
        private void loadEditOrder(string oID)
        {
            /* THIS METHOD WILL LOAD THE USER INTERFACE ALLOWING THE USER TO
             * CHANGE ANY DATA IN THE ORDER BEFORE IT IS SENT OUT TO QUICKBOOKS
             */
            ApiOrder mOrder = new ApiOrder();
            MSSQLAccess db = new MSSQLAccess();

            //LOAD ORDERS FROM MSSQL DATABASE
            mOrder = Utils.LoadOrder( oID );
            if (mOrder.orderID != null && mOrder.orderID != "")
            {
                txtOrderNumber.Text     = mOrder.orderID.ToString();
                txtPONumber.Text        = mOrder.poNumber;
                txtPurchaseDate.Text    = Convert.ToDateTime(mOrder.orderDate).ToString("MM/dd/yy");

                if (mOrder.qbListID != "")
                {
                    txtCustomerFullName.Text = mOrder.qbFullName;
                }

                txtBillCompany.Text     = mOrder.billToCompany;
                txtBillName.Text        = mOrder.billToName;
                txtBillAddress1.Text    = mOrder.billToAddress1;
                txtBillAddress2.Text    = mOrder.billToAddress2;
                txtBillAddress3.Text    = mOrder.billToAddress3;
                txtBillCity.Text        = mOrder.billToCity;
                txtBillState.Text       = mOrder.billToState;
                txtBillCountry.Text     = mOrder.billToCountry;
                txtBillPostalCode.Text  = mOrder.billToZipCode;
                txtPhone.Text           = mOrder.phone;
                txtFax.Text             = mOrder.fax;
                txtEmail.Text           = mOrder.email;
                txtShipCompany.Text     = mOrder.shipToCompany;
                txtShipName.Text        = mOrder.shipToName;
                txtShipAddress1.Text    = mOrder.shipToAddress1;
                txtShipAddress2.Text    = mOrder.shipToAddress2;
                txtShipAddress3.Text    = mOrder.shipToAddress3;
                txtShipCity.Text        = mOrder.shipToCity;
                txtShipState.Text       = mOrder.shipToState;
                txtShipCountry.Text     = mOrder.shipToCountry;
                txtShipPostalCode.Text  = mOrder.shipToZipCode;
                txtShipCost.Text        = (Convert.ToDouble(mOrder.shipCost) > 0 ? string.Format("{0:#,##0.00}", Convert.ToDouble(mOrder.shipCost)) : "-");
                txtShipMethod.Text      = mOrder.shipMethod;
                txtTax.Text             = (Convert.ToDouble(mOrder.taxCost) > 0.009 ? string.Format("{0:#,##0.00}", Convert.ToDouble(mOrder.taxCost)) : "-");
                txtSubtotal.Text        = string.Format("{0:#,##0.00}", Convert.ToDouble(mOrder.subtotal));
                txtTotal.Text           = string.Format("{0:#,##0.00}", Convert.ToDouble(mOrder.total));
                txtGiftCertificate.Text = (Convert.ToDouble(mOrder.giftCertificate) > 0.00 ? string.Format("{0:#,##0.00}", Convert.ToDouble(mOrder.giftCertificate)) : "-");
                txtCurrency.Text        = mOrder.currency;
                mOrder.discount       = (mOrder.discount[mOrder.discount.Length - 1] == '%' ? mOrder.discount.TrimEnd('%') : mOrder.discount);
                txtDiscount.Text        = (Convert.ToDouble(mOrder.discount) > 0 ? string.Format("{0:#,##0.00}", Convert.ToDouble(mOrder.discount)) + "%" : "-");
                txtBillMethod.Text      = mOrder.payMethod;
                txtCreatedBy.Text       = mOrder.createBy;
                txtMemo.Text            = mOrder.memo;
            } //IF ORDER ID EXISTS
        }

        private void skipOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSSQLAccess db = new MSSQLAccess();
            FormMain parentForm = (FormMain)Owner; //REFERENCE TO THE PARENT FORM
            string orderID = txtOrderNumber.Text;
            var confirm = MessageBox.Show("Are you sure you want to skip creating a payment entry for this order?",
                                     "Confirm Skip Payment",
                                     MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                lblStatus.Text = "";
                db.SkipOrder(orderID);
                parentForm.RefreshList();
                this.Close();
            }
        }

        private void closeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain parentForm = (FormMain)Owner; //REFERENCE TO THE PARENT FORM
            if (parentForm != null)
            {
                parentForm.RefreshList();
                this.Close();
            }
        }
    } //END: CLASS
} //END: NAMESPACE
