using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace InPay
{
    class QBAccess
    {
        private static Init ini = Init.Instance();

        public static async Task<Dictionary<string, string>> GetOrderIdToFullNameListDictionary()
        {
            //VARIABLE DECLARATIONS
            DataTable dt = new DataTable();
            string qbSql, webOrderId, qbCustomerFullName;

            Dictionary<string, string> dicMain = new Dictionary<string, string>();
            Task<Dictionary<string, string>> tDic;
            OdbcConnection QBConnection;

            //LOAD CONNECTION
            QBConnection = new OdbcConnection(ini.QB_CONNECTION_STRING);
            await QBConnection.OpenAsync().ConfigureAwait(false);
            //LOAD DICTIONARY
            qbSql = "SELECT CustomFieldOther, CustomerRefFullName" +
                    " FROM SalesOrder" +
                    " WHERE CustomFieldOther IS NOT NULL" +
                    " AND {fn TIMESTAMPDIFF(SQL_TSI_DAY, TimeCreated, {fn CURDATE()})} < " + ini.daysBack +
                    " ORDER BY CustomFieldOther DESC";
            OdbcDataAdapter adapter = new OdbcDataAdapter(qbSql, QBConnection);
            adapter.Fill(dt);
            QBConnection.Close();
            //LOAD DICTIONARY
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                webOrderId = dt.Rows[i].Field<string>("CustomFieldOther") ?? "";
                qbCustomerFullName = dt.Rows[i].Field<string>("CustomerRefFullName") ?? "";

                if(qbCustomerFullName.Trim() != "")
                {
                    if (!dicMain.ContainsKey(webOrderId))
                    {
                        dicMain.Add(webOrderId, qbCustomerFullName);
                    }
                }
            }
            //CLOSE CONNECTION WITH QUICKBOOKS
            QBConnection.Close();

            return dicMain;
        } //END: GetOrderIdToFullNameListDictionary()
    }
}
