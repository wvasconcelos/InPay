using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace InPay
{
    static class Utils
    {
        public static ApiOrder LoadOrder(string oID)
        {
            /* LOADS ORDER INFORMATION FROM THE SQL DATABASE 
             * INTO ORDER OBJECT, INCLUDING CART ITEMS.
             */
            ApiOrder mOrder = new ApiOrder();
            MSSQLAccess db = new MSSQLAccess(); //DATA MANIPULATION OBJECT
            DataTable dt = db.LoadDBOrder(oID);
            if (dt.Rows.Count < 1) return mOrder; //EMPTY
            mOrder.orderID        = dt.Rows[0][0].ToString();
            mOrder.poNumber       = dt.Rows[0][1].ToString();
            mOrder.orderDate      = dt.Rows[0][2].ToString();
            mOrder.accountID      = dt.Rows[0][3].ToString();

            mOrder.qbListID         = dt.Rows[0][4].ToString();
            mOrder.qbFullName       = dt.Rows[0][5].ToString();

            mOrder.billToCompany  = dt.Rows[0][6].ToString();
            mOrder.billToName     = dt.Rows[0][7].ToString();
            mOrder.billToAddress1 = dt.Rows[0][8].ToString();
            mOrder.billToAddress2 = dt.Rows[0][9].ToString();
            mOrder.billToAddress3 = dt.Rows[0][10].ToString();
            mOrder.billToCity     = dt.Rows[0][11].ToString();
            mOrder.billToState    = dt.Rows[0][12].ToString();
            mOrder.billToCountry  = dt.Rows[0][13].ToString();
            mOrder.billToZipCode  = dt.Rows[0][14].ToString();
            mOrder.phone          = dt.Rows[0][15].ToString();
            mOrder.fax            = dt.Rows[0][16].ToString();
            mOrder.email          = dt.Rows[0][17].ToString();
            mOrder.shipToCompany  = dt.Rows[0][18].ToString();
            mOrder.shipToName     = dt.Rows[0][19].ToString();
            mOrder.shipToAddress1 = dt.Rows[0][20].ToString();
            mOrder.shipToAddress2 = dt.Rows[0][21].ToString();
            mOrder.shipToAddress3 = dt.Rows[0][22].ToString();
            mOrder.shipToCity     = dt.Rows[0][23].ToString();
            mOrder.shipToState    = dt.Rows[0][24].ToString();
            mOrder.shipToCountry  = dt.Rows[0][25].ToString();
            mOrder.shipToZipCode  = dt.Rows[0][26].ToString();
            mOrder.shipCost       = dt.Rows[0][27].ToString();
            mOrder.shipMethod     = dt.Rows[0][28].ToString();
            mOrder.shipCustomerAcct = dt.Rows[0][29].ToString();
            mOrder.taxCost        = dt.Rows[0][30].ToString();
            mOrder.giftCertificate= dt.Rows[0][31].ToString();
            mOrder.discount       = dt.Rows[0][32].ToString();
            mOrder.subtotal       = dt.Rows[0][33].ToString();
            mOrder.total          = dt.Rows[0][34].ToString();
            mOrder.currency       = dt.Rows[0][35].ToString();
            mOrder.coupon         = dt.Rows[0][36].ToString();
            mOrder.payMethod      = dt.Rows[0][37].ToString();
            mOrder.ccType         = dt.Rows[0][38].ToString();
            mOrder.createBy       = dt.Rows[0][39].ToString();
            mOrder.updateDate     = dt.Rows[0][40].ToString();
            mOrder.orderStatus    = dt.Rows[0][41].ToString();
            mOrder.ready          = Convert.ToBoolean(dt.Rows[0][42]);
            mOrder.memo           = dt.Rows[0][43].ToString();

            return mOrder;
        }

        public static String DBStr(String myString, int max_chars)
        {
            /* String sanitizer
             */
            if (myString == null)
                return "";

            myString = myString.Trim();
            myString = myString
                .Replace("\n", " ")
                .Replace("\r", " ")
                .Replace(Environment.NewLine, " ")
                .Replace("\0", " ")
                .Replace("  ", " ");

            //myString = ApostropheHandler(myString);

            if (myString.Length > max_chars)
            { //LIMIT STRING LENGTH
                myString = myString.Substring(0, max_chars - 1);
            }
            return myString;
        } //END DBStr() METHOD

        public static string LoadOrdersPaymentIntoQuickBooks()
        {
            string feedback = "";
            Init ini = Init.Instance();
            MSSQLAccess db = new MSSQLAccess();
            feedback = "";
            try
            {
                //CALL THE COMMAND LINE, EXECUTE IMPORT ORDER
                Process process = new Process(); //Provides access to local/remote processes, enables start/stop processes.
                ProcessStartInfo startInfo = new ProcessStartInfo(); //System.Diagnostics: Specifies values used on process start.
                startInfo.FileName = ini.tpExeFile;
                startInfo.WorkingDirectory = ini.tpPath;
                startInfo.Arguments = ini.TP_PAYMENTS_CALL_STRING;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                db.SetUploadedOrdersToPaid();
            }
            catch (Exception ex)
            {
                feedback = "Unable to process your request based on the following exception: " + ex.Message;
                //db.SetUpdatedOrdersToUpdated();
            }

            return feedback;
        }

        public static double DblValue(string numberString)
        {
            /* CHECKS IF THE INPUT STRING IS CONVERTIBLE INTO A DOUBLE TYPE NUMBER AND RETURN THAT NUMBER.
             * RETURN ZERO IF NOT CONVERTIBLE.
             */
            float numbr;
            double result;
            bool isNumeric = float.TryParse(numberString, out numbr);
            if (!isNumeric)
            {
                numbr = 0;
            }
            result = Convert.ToDouble(numbr);

            return result;
        }
    } //END: CLASS
} //END: NAMESPACE
