using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using KFGCMS.Base;
using System.Data;
using KFGCMS.BLL;
using System.Web;
using System.Configuration;
using KFGCMS.DAL;

namespace CheckOut_Module
{
    public class CheckOut_BLL
    {
        // int Voucher_Number = 0;

        #region Members

        DataTable dataTable = new DataTable();
        #endregion

        public bool SaveOrdersToWeb(ref CheckOut_Info info, List<CheckOut_Info> listInfo)
        {
            try
            {
             //   info.Voucher_Number = selectCurrentVoucherNumber();

                HttpCookie userCookie = HttpContext.Current.Request.Cookies["CustomerInfo"];
                int SalesTxnID;
               // Voucher_Number = selectCurrentVoucherNumber()
                


                using (SqlConnection Connection = Global_BLL.GetConnection())
                {
                    SqlCommand command = new SqlCommand("KFGSP_SALESTXN_INSERT", Connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@SalesTXN_CustomerID", SqlDbType.BigInt).Value = Convert.ToInt64(userCookie["Customer_ID"]);
                    command.Parameters.Add("@SalesTXN_VoucherDate", SqlDbType.DateTime).Value = DateTime.Now.AddHours(Convert.ToDouble(ConfigurationManager.AppSettings["Timedifference"]));
                    command.Parameters.Add("@SalesTXN_CompanyID", SqlDbType.BigInt).Value = Convert.ToInt64(info.companyID);
                    command.Parameters.Add("@SalesTXN_BrandID", SqlDbType.Decimal).Value = info.ChainID;
                    command.Parameters.Add("@SalesTXN_Date", SqlDbType.SmallDateTime).Value = DateTime.Now.AddHours(Convert.ToDouble(ConfigurationManager.AppSettings["Timedifference"]));
                    command.Parameters.Add("@SalesTXN_VoucherValue", SqlDbType.Real).Value = info.total;
                    command.Parameters.Add("@SalesTXN_VoidCount", SqlDbType.BigInt).Value = info.Void_Count;
                    command.Parameters.Add("@SalesTXN_VoidAmount", SqlDbType.Real).Value = info.VoidAmount;
                    //command.Parameters.Add("@SalesTXN_VoucherID", SqlDbType.BigInt).Value = info.Voucher_Number;
                    //command.Parameters.Add("@param10", SqlDbType.Int).Value = info.Void_Count;
                    //command.Parameters.Add("@param11", SqlDbType.Real).Value = info.VoidAmount;
                    command.Parameters.Add("@SalesTXN_Type", SqlDbType.NVarChar).Value = info.OrderType;
                    command.Parameters.Add("@SalesTXN_VoucherStatus", SqlDbType.NVarChar).Value = info.Voucher_Status;
                    command.Parameters.Add("@SalesTXN_GridID", SqlDbType.NVarChar).Value = info.Grid_ID;
                    command.Parameters.Add("@SalesTXN_LocationID", SqlDbType.NVarChar).Value = info.Location_Code;
                    command.Parameters.Add("@SalesTXN_DeliveryTime", SqlDbType.DateTime).Value = DateTime.Now.AddHours(Convert.ToDouble(ConfigurationManager.AppSettings["Timedifference"]));
                    //command.Parameters.Add("@param17", SqlDbType.DateTime).Value = info.DeliveryTime;
                    command.Parameters.Add("@SalesTXN_Comments", SqlDbType.NVarChar).Value = info.Remarks;
                    command.Parameters.Add("@SalesTXN_OtherCharges", SqlDbType.Decimal).Value = info.OtherCharge;
                    command.Parameters.Add("@SalesTXN_DeliveryCharges", SqlDbType.Decimal).Value = info.DeliveryCharge;
                    command.Parameters.Add("@SalesTXN_Schedule", SqlDbType.Bit).Value = false;
                    command.Parameters.Add("@SalesTXN_SerialID", SqlDbType.Decimal).Value = info.Serial_Number;




                    //command.Parameters.Add("@param23", SqlDbType.Int).Value = info.Del_Minutes;
                    //command.Parameters.Add("@param24", SqlDbType.Int).Value = info.Serial_Number;
                    //command.Parameters.Add("@param25", SqlDbType.Bit).Value = info.Kitchen_PrintID;

                    //if (Connection.State == ConnectionState.Closed)
                    // Connection.Open();
                    //command.Transaction = Connection.BeginTransaction();
                    SqlDataAdapter dap = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dap.Fill(dataTable);
                    info.SalesTXNID = Convert.ToInt32(dataTable.Rows[0]["SalesTXN_ID"]);
                }

                using (SqlConnection Connection = Global_BLL.GetConnection())
                {
                   // info.Voucher_Number = Convert.ToInt32(dataTable.Rows[0]["SalesTXN_VoucherID"]);
                    // Get the Voucher Number
                  //  info.Voucher_Number = selectCurrentVoucherNumber();


                    //  Connection.Close();
                    int i = 1;

                    foreach (CheckOut_Info TempInfo in listInfo)
                    {

                        SqlCommand LineCommand = new SqlCommand("KFGSP_SALESTXN_DETAILS_INSERT", Connection);
                        LineCommand.CommandType = CommandType.StoredProcedure;


                        LineCommand.Parameters.Add("@SalesTXNDetail_SalesTXNID", SqlDbType.BigInt).Value = info.SalesTXNID;
                        LineCommand.Parameters.Add("@SalesTXNDetail_ItemID", SqlDbType.NVarChar).Value = TempInfo.Item_Code;
                        LineCommand.Parameters.Add("@SalesTXNDetail_Price", SqlDbType.Real).Value = TempInfo.Item_Price;
                        LineCommand.Parameters.Add("@SalesTXNDetail_QTY", SqlDbType.BigInt).Value = TempInfo.Item_Quantity;
                        LineCommand.Parameters.Add("@SalesTXNDetail_SerialGroupID", SqlDbType.Int).Value = info.LineNumber;
                        LineCommand.Parameters.Add("@SalesTXNDetail_Date", SqlDbType.DateTime).Value = TempInfo.Voucher_Date;
                        LineCommand.Parameters.Add("@SalesTXNDetail_Name", SqlDbType.NVarChar).Value = TempInfo.Item_Name;
                        LineCommand.Parameters.Add("@SalesTXNDetail_SerialID", SqlDbType.Real).Value =i;

                        //   Connection.Open();
                        LineCommand.ExecuteNonQuery();
                        // Connection.Close();

                        i++;

                    }


                }

                return true;



            }
            catch (Exception exc)
            {

                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
                return false;
            }


        }


        public bool SaveOrdersToCOT(ref CheckOut_Info info, List<CheckOut_Info> listInfo)
        {
            try
            {
                    SqlCommand command = new SqlCommand(@"Insert Into SL_TRX_SALES_ORDER_HDR (SYS_COMPANY_ID, IV_CHAIN_ID, SL_LOC_ID, SL_VOUCHER_NO, SL_VOUCHER_DATE, PR_EMPLOYEE_ID, SL_START_DATE, SL_START_TIME, SL_TRX_SALES, SL_ORDER_TYPE, SL_VOUCHER_STATUS, COT_CUST_TELEPHONE, COT_GRID_ID, COT_LOCATION_ID, COT_MODIFIED, COT_COMMENTS, COT_OTHER_CHARGE, COT_DELIVERY_CHARGE, COT_TIMED_ORDER, COT_DEL_MINUTES, COT_SERIAL_NUMBER, SL_KITCHEN_PRINTED, SL_CUSTCARD_NO, SL_VOID_USER, SL_TABLE_NO, SL_VOID_REASON, COT_CUST_TELEPHONE_EXT, COT_COMPLAINT_ID, COT_COMPLAINT_COMMENTS, COT_STATUS, COT_DRIVER_ID, COT_COMPLAINT_ACTIVITY, COT_ACTIVITY_USER, COT_ACTIVITY_APPROVED)
                                                             values (@SYS_COMPANY_ID, @IV_CHAIN_ID, @SL_LOC_ID, @SL_VOUCHER_NO, @SL_VOUCHER_DATE, @PR_EMPLOYEE_ID, @SL_START_DATE, @SL_START_TIME, @SL_TRX_SALES, @SL_ORDER_TYPE, @SL_VOUCHER_STATUS, @COT_CUST_TELEPHONE, @COT_GRID_ID, @COT_LOCATION_ID, @COT_MODIFIED, @COT_COMMENTS, @COT_OTHER_CHARGE, @COT_DELIVERY_CHARGE, @COT_TIMED_ORDER, @COT_DEL_MINUTES, @COT_SERIAL_NUMBER, @SL_KITCHEN_PRINTED, ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' )");


                    command.Parameters.Add("@SYS_COMPANY_ID", SqlDbType.NVarChar).Value = info.companyID;
                    command.Parameters.Add("@IV_CHAIN_ID", SqlDbType.NVarChar).Value = info.ChainID;
                    command.Parameters.Add("@SL_LOC_ID", SqlDbType.NVarChar).Value = info.LocationID;
                    command.Parameters.Add("@SL_VOUCHER_NO", SqlDbType.Int).Value = info.SalesTXNID;
                    command.Parameters.Add("@SL_VOUCHER_DATE", SqlDbType.SmallDateTime).Value = info.Voucher_Date;
                    command.Parameters.Add("@PR_EMPLOYEE_ID", SqlDbType.NVarChar).Value = info.EmployeeID;
                    command.Parameters.Add("@SL_START_DATE", SqlDbType.SmallDateTime).Value = info.startDate;
                    command.Parameters.Add("@SL_START_TIME", SqlDbType.DateTime).Value = info.startTime;
                    command.Parameters.Add("@SL_TRX_SALES", SqlDbType.Real).Value = info.total;
                    //command.Parameters.Add("@param10", SqlDbType.Int).Value = info.Void_Count;
                    //command.Parameters.Add("@param11", SqlDbType.Real).Value = info.VoidAmount;
                    command.Parameters.Add("@SL_ORDER_TYPE", SqlDbType.NVarChar).Value = info.OrderType;
                    command.Parameters.Add("@SL_VOUCHER_STATUS", SqlDbType.NVarChar).Value = info.Voucher_Status;
                    command.Parameters.Add("@COT_CUST_TELEPHONE", SqlDbType.NVarChar).Value = info.Telephone;
                    command.Parameters.Add("@COT_GRID_ID", SqlDbType.NVarChar).Value = info.Grid_ID;
                    command.Parameters.Add("@COT_LOCATION_ID", SqlDbType.NVarChar).Value = info.Location_Code;
                    //command.Parameters.Add("@param17", SqlDbType.DateTime).Value = info.DeliveryTime;
                    command.Parameters.Add("@COT_MODIFIED", SqlDbType.Bit).Value = info.Modified;
                    command.Parameters.Add("@COT_COMMENTS", SqlDbType.NVarChar).Value = info.Remarks;
                    command.Parameters.Add("@COT_OTHER_CHARGE", SqlDbType.Int).Value = info.OtherCharge;
                    command.Parameters.Add("@COT_DELIVERY_CHARGE", SqlDbType.Real).Value = info.DeliveryCharge;
                    command.Parameters.Add("@COT_TIMED_ORDER", SqlDbType.Bit).Value = info.Timed_Order;
                    command.Parameters.Add("@COT_DEL_MINUTES", SqlDbType.Int).Value = info.Del_Minutes;
                    command.Parameters.Add("@COT_SERIAL_NUMBER", SqlDbType.Int).Value = info.Serial_Number;
                    command.Parameters.Add("@SL_KITCHEN_PRINTED", SqlDbType.Bit).Value = info.Kitchen_PrintID;

                    //if (Connection.State == ConnectionState.Closed)
                   // Connection.Open();
                    //command.Transaction = Connection.BeginTransaction();
                    KFGDAL.ExecuteNoneQuery(command,false, Global_BLL.GetCOTconnection());
                  //  Connection.Close();

                    int i = 1;

                    foreach (CheckOut_Info TempInfo in listInfo)
                    {

                        SqlCommand LineCommand = new SqlCommand(@"Insert Into SL_TRX_SALES_ORDER_LNE (SYS_COMPANY_ID, IV_CHAIN_ID, SL_LOC_ID, PR_EMPLOYEE_ID, SL_VOUCHER_NO, SL_VOUCHER_DATE, SL_ITEM_ID, SL_SELLING_PRICE, SL_QTY, SL_LINE_NO, SL_SALE_STATUS, SL_SYSTEM_DATE, SL_SYSTEM_TIME, SL_LINENAME, COT_LINE_ID, COT_LOCATION_ID, SL_PAID)
                                                                        Values(@SYS_COMPANY_ID, @IV_CHAIN_ID, @SL_LOC_ID, @PR_EMPLOYEE_ID, @SL_VOUCHER_NO, @SL_VOUCHER_DATE, @SL_ITEM_ID, @SL_SELLING_PRICE, @SL_QTY, @SL_LINE_NO, @SL_SALE_STATUS, @SL_SYSTEM_DATE, @SL_SYSTEM_TIME, @SL_LINENAME, @COT_LINE_ID, @COT_LOCATION_ID, @SL_PAID)");


                        LineCommand.Parameters.Add("@SYS_COMPANY_ID", SqlDbType.NVarChar).Value = TempInfo.companyID;
                        LineCommand.Parameters.Add("@IV_CHAIN_ID", SqlDbType.NVarChar).Value = TempInfo.ChainID;
                        LineCommand.Parameters.Add("@SL_LOC_ID", SqlDbType.NVarChar).Value = TempInfo.LocationID;
                        LineCommand.Parameters.Add("@PR_EMPLOYEE_ID", SqlDbType.NVarChar).Value = TempInfo.EmployeeID;
                        LineCommand.Parameters.Add("@SL_VOUCHER_NO", SqlDbType.Int).Value = info.SalesTXNID;
                        LineCommand.Parameters.Add("@SL_VOUCHER_DATE", SqlDbType.SmallDateTime).Value = TempInfo.Voucher_Date;
                        LineCommand.Parameters.Add("@SL_ITEM_ID", SqlDbType.NVarChar).Value = TempInfo.Item_Code;
                        LineCommand.Parameters.Add("@SL_SELLING_PRICE", SqlDbType.Real).Value = TempInfo.Item_Price;
                        LineCommand.Parameters.Add("@SL_QTY", SqlDbType.Real).Value = TempInfo.Item_Quantity;
                        LineCommand.Parameters.Add("@SL_LINE_NO", SqlDbType.Int).Value = TempInfo.LineNumber;
                        LineCommand.Parameters.Add("@SL_SALE_STATUS", SqlDbType.NVarChar).Value = TempInfo.Sales_Status;
                        LineCommand.Parameters.Add("@SL_SYSTEM_DATE", SqlDbType.SmallDateTime).Value = TempInfo.System_Date;
                        LineCommand.Parameters.Add("@SL_SYSTEM_TIME", SqlDbType.DateTime).Value = TempInfo.System_Time;
                        LineCommand.Parameters.Add("@SL_LINENAME", SqlDbType.NVarChar).Value = "item";
                        LineCommand.Parameters.Add("@COT_LINE_ID", SqlDbType.Int).Value = i;

                        // Grid
                        LineCommand.Parameters.Add("@COT_LOCATION_ID", SqlDbType.NVarChar).Value = HttpContext.Current.Server.HtmlDecode(info.Location_Code);
                        LineCommand.Parameters.Add("@SL_PAID", SqlDbType.Bit).Value = true;


                        KFGDAL.ExecuteNoneQuery(LineCommand, false, Global_BLL.GetCOTconnection());
                     //   Connection.Open();
                       // LineCommand.ExecuteNonQuery();
                       // Connection.Close();

                        i++;

                    }

                    SaveCOT_Status("Save To COT Complete", info.SalesTXNID);

                    return true;

                



            }
            catch (Exception exc)
            {
                SaveCOT_Status(exc.Message, info.SalesTXNID);
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
                return false;
            }
           

        }



        public string Select_ItemCode(string id, string OrderSorting)
        {
            try
            {
                SqlCommand command = new SqlCommand("KFGSP_CHECKOUT_SELECTITEMCODES");
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ITEMID", SqlDbType.NVarChar).Value = id;
                SqlDataAdapter dap = new SqlDataAdapter(command);
                DataTable dataTable = KFGDAL.ExecuteDataTable(command);
                // dap.Fill(dataSet);

                string OrderType = HttpContext.Current.Request.Cookies["OrderType"].Value.ToLower(),
                        ColumnName = String.Format("SP_Type{0}_{1}_Code",OrderSorting, OrderType);;


                return dataTable.Rows[0][ColumnName].ToString();
                  
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
                return "";
            }
           

        }

        //private int selectCurrentVoucherNumber()
        //{
        //    try
        //    {

        //        using (SqlConnection connection = Global_BLL.GetCOTconnection())
        //        {
        //            SqlCommand command = new SqlCommand("select max(SL_VOUCHER_NO) voucherno from SL_TRX_SALES_ORDER_HDR where IV_CHAIN_ID = 33", connection);
        //            SqlDataAdapter dap = new SqlDataAdapter(command);
        //            DataTable dataTable = new DataTable();
        //            dap.Fill(dataTable);

        //            return Convert.ToInt32(dataTable.Rows[0]["voucherno"]) + 1;
        //        }
        //    }

        //    catch (Exception exc)
        //    {
        //        ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
        //        return 0;
        //    }
        //}


        private int selectCurrentVoucherNumber()
        {
            try
            {
                dataTable = KFGDAL.ExecuteDataTable("select max(SalesTXN_VoucherID) voucherid from KFGCMS_SalesTXNs where SalesTXN_BrandID = 33");
                return Convert.ToInt32(dataTable.Rows[0]["voucherid"]);
                
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
                return 0;
            }
        }



        private void SaveCOT_Status(string Message, long id)
        {
            try
            {
        
                KFGDAL.ExecuteNoneQuery(string.Format("update KFGCMS_SalesTXNs set SalesTXN_COTMessage = N'{0}' where SalesTXN_ID ={1}", Message, id));
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
            }
        }

     



        public string GetLocationCode(string GridCode)
        {
            try
            {
                SqlCommand command = new SqlCommand("KFGSP_CHECKOUT_GETLOCATION");
                command.CommandType = CommandType.StoredProcedure;
                dataTable = KFGDAL.ExecuteDataTable(command);

                return dataTable.Rows[0]["Location_Code"].ToString();
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
                return "";
              
            }


        }



    }
}
