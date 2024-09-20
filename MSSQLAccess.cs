using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace InPay
{
    class MSSQLAccess
    {
        private Init ini = Init.Instance();

        //START: SINGLETON DESIGN PATTERN
        private static MSSQLAccess instance;

        public static MSSQLAccess Instance()
        {
            if (instance == null)
            {
                instance = new MSSQLAccess();
            }
            return instance;
        }
        //END: SINGLETON DESIGN PATTERN

        public DataTable LoadDBOrder(string orderID)
        {
            /* GETS AN ORDER ID AND RETURNS A DATATABLE TYPE CONTAINING 
             * ALL INFO AVAILABLE IN THE DB ON THAT ORDER (EXCEPT FOR CART ITEMS).
             */
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                String sql = @"SELECT [order_id]," +
                                " [po_number]," +
                                " [order_date]," +
                                " [web_customer_id]," +
                                " [qb_listID]," +
                                " [qb_full_name]," +
                                " [bill_company]," +
                                " [bill_name]," +
                                " [bill_address]," +
                                " [bill_address_2]," +
                                " [bill_address_3]," +
                                " [bill_city]," +
                                " [bill_state]," +
                                " [bill_country]," +
                                " [bill_zip]," +
                                " [phone]," +
                                " [fax]," +
                                " [email]," +
                                " [ship_company]," +
                                " [ship_name]," +
                                " [ship_address]," +
                                " [ship_address_2]," +
                                " [ship_address_3]," +
                                " [ship_city]," +
                                " [ship_state]," +
                                " [ship_country]," +
                                " [ship_zip]," +
                                " [ship_cost]," +
                                " [ship_method]," +
                                " [ship_customer_account]," +
                                " [tax]," +
                                " [gift_certificate]," +
                                " [discount]," +
                                " [subtotal]," +
                                " [total]," +
                                " [currency]," +
                                " [coupon]," +
                                " [pay_method]," +
                                " [credit_card_type]," +
                                " [created_by]," +
                                " [update_date]," +
                                " [order_status]," +
                                " [ready]," +
                                " [memo]" +
                            " FROM [" + ini.database + "].[dbo].[web_order]" +
                            " WHERE [order_id] = @orderID";

                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.Parameters.Add("@orderID", SqlDbType.VarChar).Value = Utils.DBStr(orderID, 64);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                sqlCon.Close();
            }

            return dt;
        }

        public List<ApiOrder> LoadAllPendingPayment()
        {
            /* RETRIEVES ALL ORDERS PROCESSED BUT PENDING PAYMENT FROM THE DATABASE
             * RETURN A DATATABLE STRUCTURE WITH INFORMATION NEEDED TO LOAD THE UI DATAGRID
             */
            List<ApiOrder> resultSet = new List<ApiOrder>();
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                String sql = @"SELECT [order_id]" +
                            " FROM [" + ini.database + "].[dbo].[web_order]" +
                            " WHERE uploaded = 1" +
                            " AND paid = 0" +
                            " AND skip = 0" +
                            " ORDER BY order_id ASC";
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    using (SqlDataReader rec = cmd.ExecuteReader())
                    {
                        ApiOrder mOrder;
                        string orderID;
                        while (rec.Read())
                        {
                            orderID = rec.GetString(0);
                            mOrder = Utils.LoadOrder(orderID);
                            resultSet.Add(mOrder);
                        }
                    }
                }
                sqlCon.Close();
            }
            return resultSet;
        }

        /* QUICK BOOKS DATA */
        public void SetUploadedOrdersToPaid()
        {
            /* SET ALL UPLOADED ORDERS TO PAID
             */
            string sql = @"UPDATE [" + ini.database + "].[dbo].[web_order] SET" +
                            " [paid] = 1" +
                            " WHERE [uploaded] = 1" +
                            " AND [paid] = 0";
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SetNet30ToUploaded()
        {
            /* SET ALL NET 30 ORDERS TO UPLOADED: SKIP ADDING PAYMENT INTO QB
             */
            string sql = @"UPDATE [" + ini.database + "].[dbo].[web_order] SET" +
                            " [paid] = 1" +
                            " WHERE [paid] = 0" +
                            " AND [uploaded] = 1" +
                            " AND [pay_method] = 'Net-30 Days'";
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SetAmazonOrdersToUploaded()
        {
            /* SET ALL AMAZON ORDERS TO UPLOADED: SKIP ADDING PAYMENT INTO QB
             */
            string sql = @"UPDATE [" + ini.database + "].[dbo].[web_order] SET" +
                            " [paid] = 1" +
                            " WHERE [paid] = 0" +
                            " AND [uploaded] = 1" +
                            " AND [created_by] LIKE 'Amazo%'";
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SetOrderAsPaid(string orderID)
        {
            /* SET A SPECIFIC ORDER AS PAID: SKIP ADDING PAYMENT INTO QB
             */
            string sql = @"UPDATE [" + ini.database + "].[dbo].[web_order] SET" +
                            " [paid] = 1" +
                            " WHERE [order_id] = '" + orderID + "'";
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SkipOrder(string orderID)
        {
            /* SKIP ORDER WHEN ADDING PAYMENT INTO QUICKBOOKS
             */
            string sql = @"UPDATE [" + ini.database + "].[dbo].[web_order] SET" +
                            " [skip] = 'true'" +
                            " WHERE [order_id] = '" + orderID + "'";
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UnSkipOrder(string orderID)
        {
            /* REVERSE SKIP ORDER
             */
            string sql = @"UPDATE [" + ini.database + "].[dbo].[web_order] SET" +
                            " [skip] = 'false'" +
                            " WHERE [order_id] = '" + orderID + "'";
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ApiOrder> LoadRecentlyPaidOrders()
        {
            /* RETRIEVES ALL RECENTLY PAID ORDERS AND RETURN A LIST OF API ORDER OBJECTS
             * WITH INFORMATION NEEDED TO LOAD THE DATAGRID IN THE INTERFACE.
             */
            List<ApiOrder> resultSet = new List<ApiOrder>();
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                String sql = @"SELECT [order_id]" +
                            " FROM [" + ini.database + "].[dbo].[web_order]" +
                            " WHERE uploaded = 1" +
                            " AND (paid = 1 OR skip = 1)" +
                            " AND [created_by] NOT LIKE 'Amazo%'" +
                            " AND [pay_method] NOT LIKE 'Net%'" +
                            " AND order_date >= '" + DateTime.Today.AddDays(-3).ToString("yyyy-MM-dd") + "'";
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    using (SqlDataReader rec = cmd.ExecuteReader())
                    {
                        ApiOrder mOrder;
                        string orderID;
                        while (rec.Read())
                        {
                            orderID = rec.GetString(0);
                            mOrder = Utils.LoadOrder(orderID);
                            resultSet.Add(mOrder);
                        }
                    }
                }
                sqlCon.Close();
            }
            return resultSet;
        } //END: 

        public void SetOrderPaidStatus(string orderID, bool paid)
        {
            /* RESET UPLOADED STATUS ON A PARTICULAR ORDER
             */
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                string sql = @"UPDATE [" + ini.database + "].[dbo].[web_order]" +
                            " SET [paid] = @paid" +
                            " WHERE [order_id] = @orderID";
                using (SqlCommand cmdUpdate = new SqlCommand(sql, sqlCon))
                {
                    cmdUpdate.Parameters.Add("@paid", SqlDbType.Bit).Value = paid;
                    cmdUpdate.Parameters.Add("@orderID", SqlDbType.VarChar).Value = Utils.DBStr(orderID, 64);
                    cmdUpdate.ExecuteNonQuery();
                }
            }
        } //END: SetOrderPaidStatus()

        public async Task FillOutQbFullName()
        {
            //INSTANTIATE VARIABLES
            string orderId;
            Task<Dictionary<string, string>> tDic;
            Dictionary<string, string> dicFullName;
            Init ini = Init.Instance();

            //CHECK IF THERE IS ANY ORDER IN THE DATABASE MISSING QB CUSTOMER FULL NAME
            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                String sql = @"SELECT [order_id]" +
                            " FROM [" + ini.database + "].[dbo].[web_order]" +
                            " WHERE [qb_full_name] = @emptyName" +
                            " AND paid = 0" +
                            " AND order_date >= '" + DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd") + "'";
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    //EMPTY QB FULL NAME
                    SqlParameter pQbFullName = cmd.CreateParameter();
                    pQbFullName.ParameterName = @"@emptyName";
                    pQbFullName.DbType = DbType.AnsiString;
                    pQbFullName.Direction = ParameterDirection.Input;
                    pQbFullName.Value = "";
                    pQbFullName.Size = 128;
                    cmd.Parameters.Add(pQbFullName);

                    SqlDataReader rec = cmd.ExecuteReader();
                    if (rec.HasRows)
                    {
                        //LOAD FULL NAMES FROM LATEST SALES ORDERS IN QUICKBOOKS
                        tDic = QBAccess.GetOrderIdToFullNameListDictionary();
                        tDic.Wait();
                        dicFullName = tDic.Result;

                        //FIX ALL WEB ORDERS MISSING FULL NAME IN THE SQL DATABASE
                        await Task.Run(() =>
                        {
                            while (rec.Read())
                            {
                                orderId = rec.GetString(0);
                                if (dicFullName.ContainsKey(orderId))
                                {
                                    if (dicFullName.TryGetValue(orderId, out string qbFullName))
                                    {
                                        if (qbFullName != null && qbFullName.Trim() != "")
                                        {
                                            UpdateQbFullName(orderId, qbFullName);
                                        }
                                    }
                                }
                            }
                        });
                    } //END: IF ROWS RETURNED
                } //END: SQL COMMAND
                sqlCon.Close();
            } //END: SQL CONNECTION
        } //END: FillOutQbFullName()

        private static void UpdateQbFullName(string orderId, string qbCustFullName)
        {
            Init ini = Init.Instance();

            using (SqlConnection sqlCon = new SqlConnection(ini.MSSQL_CONNECTION_STRING))
            {
                sqlCon.Open();
                string sql = @"UPDATE [" + ini.database + "].[dbo].[web_order]" +
                            " SET [qb_full_name] = @qbFullName" +
                            " WHERE [order_id] = @orderID";
                using (SqlCommand cmdUpdate = new SqlCommand(sql, sqlCon))
                {
                    SqlParameter pQbFullName = cmdUpdate.CreateParameter();
                    pQbFullName.ParameterName = @"@qbFullName";
                    pQbFullName.DbType = DbType.AnsiString;
                    pQbFullName.Direction = ParameterDirection.Input;
                    pQbFullName.Value = qbCustFullName;
                    pQbFullName.Size = 128;
                    cmdUpdate.Parameters.Add(pQbFullName);

                    cmdUpdate.Parameters.Add("@orderID", SqlDbType.VarChar).Value = Utils.DBStr(orderId, 64);
                    cmdUpdate.ExecuteNonQuery();
                }
            }
        } //END: UpdateQbFullName()

    } //END: CLASS
} //END: NAME SPACE
