using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace InPay
{
    public class Init
    {
        //START: SINGLETON DESIGN PATTERN
        private static Init instance;
        public static Init Instance()
        {
            if (instance == null)
            {
                instance = new Init();
            }
            return instance;
        }
        //END: SINGLETON DESIGN PATTERN

        //DATABASE SETTINGS
        public string server = "";
        public string database = "";
        public string DSN = "";   // ODBC Data Source Name (or Deep Space Network)
        public string uID = "";   // ODBC User ID
        public string PWD = "";   // ODBC Password
        public string MSSQL_CONNECTION_STRING = "";
        public string TP_PAYMENTS_CALL_STRING = "";

        //QUICKBOOKS
        public string QBDSN = ""; // QuickBooks Data Source Name
        public string QB_CONNECTION_STRING = "";
        public string daysBack = "0";

        //TRANSACTION PRO
        public string tpPath            = "";
        public string tpExeFile         = "";
        public string tpAppVersion      = "";
        public string tpMapFileOrders   = "";
        public string tpMapFilePayments = "";
        public string tpDBSourceOrders  = "";
        public string tpDBSourcePayments= "";
        public string tpQBFilePath = "";
        public string tpConnectRetryMins= "";
        public string tpAutoAssign      = "";
        public string tpAutoRun         = "";
        public string tpFileSource      = "";
        public string tpDebug           = "";
        public string tpLogError        = "";
        public string tpLogFile         = "";

        //CONSTRUCTOR
        public Init()
        {
            //LOCAL VARIABLE
            string temp = "";
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            //DATABASE SETTINGS
            DSN         = config.AppSettings.Settings["DSN"].Value;
            server      = config.AppSettings.Settings["Server"].Value;
            database    = config.AppSettings.Settings["Database"].Value;
            uID         = config.AppSettings.Settings["UserID"].Value;
            PWD         = config.AppSettings.Settings["Password"].Value;

            //QUICKBOOKS
            QBDSN = config.AppSettings.Settings["qbDSN"].Value;
            QB_CONNECTION_STRING = "DSN=" + QBDSN;
            daysBack = config.AppSettings.Settings["daysBack"].Value;

            //TRANSACTION PRO
            tpPath          = config.AppSettings.Settings["TPPath"].Value;
            tpPath = tpPath.Trim('/').Trim('\\') + "\\";
            tpExeFile       = config.AppSettings.Settings["TPExeFile"].Value;
            tpAppVersion    = config.AppSettings.Settings["TPAppVersion"].Value;
            tpMapFilePayments = config.AppSettings.Settings["TPMapFilePayments"].Value;
            tpDBSourcePayments = config.AppSettings.Settings["TPDBTableSourcePayments"].Value;
            tpQBFilePath    = config.AppSettings.Settings["TPQBFilePath"].Value;
            tpConnectRetryMins = config.AppSettings.Settings["TPConnectRetryInterval"].Value;
            tpAutoAssign    = config.AppSettings.Settings["TPAutoAssign"].Value;
            tpAutoRun       = config.AppSettings.Settings["TPAutoRun"].Value;
            tpFileSource    = config.AppSettings.Settings["TPFileSource"].Value;
            tpDebug         = config.AppSettings.Settings["TPDebug"].Value;
            tpLogError      = config.AppSettings.Settings["TPLogError"].Value;
            tpLogFile       = config.AppSettings.Settings["TPLogFile"].Value;

            //BUILDING DATABASE CONNECTION STRINGS
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = server;
            strCon.InitialCatalog = database;
            strCon.UserID = uID;
            strCon.Password = PWD;
            strCon.ColumnEncryptionSetting = SqlConnectionColumnEncryptionSetting.Enabled;

            MSSQL_CONNECTION_STRING = strCon.ConnectionString;
            //MSSQL_CONNECTION_STRING = "Server=" + server + ";Database=" + database + ";User Id=" + uID + "; Password=" + PWD + ";";
            //MSSQL_CONNECTION_STRING = "DSN=" + DSN + ";Uid=" + uID + ";Pwd=" + PWD + ";";

            //TRANSACTION PRO
            /*** START: LOAD TRANSACTION PRO CALL STRING ***/
            if (tpAutoAssign == "1")
            {
                temp += " /AUTO_ASSIGN=1";
            }
            else
            {
                temp += " /AUTO_ASSIGN=0";
            }
            if (tpAutoRun == "1")
            {
                temp += " /AUTORUN";
            }
            if (tpFileSource == "1")
            {
                temp += " /FILE_SOURCE=DSN/TEXT_FILE=DSN=" + DSN + "; UID=" + uID + "; PWD=" + PWD + ";";
            }
            if (tpAppVersion != "")
            {
                temp += " APP=" + tpAppVersion + ";";
            }
            if (database != "")
            {
                temp += " DATABASE=" + database + ";";
            }
            temp += " ApplicationIntent=READONLY;";
            if (tpConnectRetryMins != "")
            {
                temp += " ConnectRetryInterval=" + tpConnectRetryMins.Replace(" Min", "") + "; ";
            }
            if (tpQBFilePath != "")
            {
                temp += " /QB_COMPANY_PATH=" + tpQBFilePath;
            }
            if (tpDebug == "1")
            {
                temp += " /DEBUG=1";
            }
            if (tpLogError == "1")
            {
                temp += " /LOG_ERROR";
                if (tpLogFile != "")
                {
                    temp += " /LOG_FILE=" + tpLogFile;
                }
            }

            //PAYMENTS
            TP_PAYMENTS_CALL_STRING = temp;
            if (tpDBSourcePayments != "")
            {
                TP_PAYMENTS_CALL_STRING += " /XL_SHEET=" + tpDBSourcePayments + " ";
            }
            if (tpMapFilePayments != "")
            {
                TP_PAYMENTS_CALL_STRING += " /MAP_FILE=" + tpMapFilePayments + " ";
            }
            TP_PAYMENTS_CALL_STRING += " /TXN_TYPE=Receive Payment";
            /*** END: LOAD TRANSACTION PRO CALL STRING ***/
        } //END: initVars()

        public void Reload()
        {
            instance = new Init();
        }
    } //end class
}
