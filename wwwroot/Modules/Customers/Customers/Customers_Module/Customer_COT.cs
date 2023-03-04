using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using KFGCMS.BLL;
using System.Configuration;
using KFGCMS.Utilities;
using KFGCMS.DAL;

namespace Customer_Module
{
    public class Customer_COT
    {
        #region Members
        // 168.187.119.154

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dap;
        DataSet dataset;
        DataTable dataTable;
        #endregion

        public string Customer_Activation(Customer_Info info)
        {
            try
            {
                if (!CustomerExistInCOT(info))
                {
                        command = new SqlCommand(@"Insert into COT_SETP_CUSTOMER (COT_CUST_TELEPHONE, COT_CUST_NAME_ENGLISH, COT_STATUS_ID, COT_ADDRESS_LINE_1, COT_ADDRESS_LINE_2, COT_ADDRESS_LINE_3, COT_ADDRESS_LINE_4, COT_ADDRESS_LINE_5, COT_ADDRESS_LINE_6, COT_ADDRESS_LINE_7, COT_CUST_CREATION_DATETIME, COT_REMARKS, COT_CUST_TELEPHONE_EXT)
                                                        values (@COT_CUST_TELEPHONE, @COT_CUST_NAME_ENGLISH, @COT_STATUS_ID, @COT_ADDRESS_LINE_1, @COT_ADDRESS_LINE_2, @COT_ADDRESS_LINE_3, @COT_ADDRESS_LINE_4, @COT_ADDRESS_LINE_5, @COT_ADDRESS_LINE_6, @COT_ADDRESS_LINE_7, @COT_CUST_CREATION_DATETIME, @COT_REMARKS,' ' )", connection);

                        command.Parameters.Add("@COT_CUST_TELEPHONE", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Telephone);
                        command.Parameters.Add("@COT_CUST_NAME_ENGLISH", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Name);
                        command.Parameters.Add("@COT_STATUS_ID", SqlDbType.NVarChar).Value = "GOOD";
                        command.Parameters.Add("@COT_ADDRESS_LINE_1", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.GridID);
                        command.Parameters.Add("@COT_ADDRESS_LINE_2", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.AreaID.ToString());
                        command.Parameters.Add("@COT_ADDRESS_LINE_3", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Building);
                        command.Parameters.Add("@COT_ADDRESS_LINE_4", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Street);
                        command.Parameters.Add("@COT_ADDRESS_LINE_5", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Floor);
                        command.Parameters.Add("@COT_ADDRESS_LINE_6", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Flat);
                        command.Parameters.Add("@COT_ADDRESS_LINE_7", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Address_Others);
                        command.Parameters.Add("@COT_CUST_CREATION_DATETIME", SqlDbType.DateTime).Value = info.date;
                        command.Parameters.Add("@COT_REMARKS", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Remarks);
                        //KFGHostServices.Service1 service = new KFGHostServices.Service1();
                        //service.ExecuteNoneQuery(command);

                        KFGDAL.ExecuteNoneQuery(command,false,Global_BLL.GetCOTconnection());
                       
                }

                return "ok";
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                return exc.Message;
            }

        }


        private bool CustomerExistInCOT(Customer_Info info)
        {
            try
            {
                command = new SqlCommand(@"Select Count(*) from COT_SETP_CUSTOMER where (COT_CUST_TELEPHONE=@Telephone )", connection);

                command.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = info.Telephone;

                dataTable = KFGDAL.ExecuteDataTable(command,Global_BLL.GetCOTconnection());

                if (dataTable.Rows.Count != 0 && dataTable.Rows[0][0].ToString() != "0")
                    return true;
                else
                    return false;
                
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                return false;
            }
        }


        public string Customer_UpdateOrderDelivery(Customer_Info info)
        {
            string customerStatus = "no";
            try
            {
                if (CustomerExistInCOT(info))
                {

                   
                    
                        command = new SqlCommand(@"update COT_SETP_CUSTOMER set COT_ADDRESS_LINE_1=@COT_ADDRESS_LINE_1, COT_ADDRESS_LINE_2=@COT_ADDRESS_LINE_2, COT_ADDRESS_LINE_3=@COT_ADDRESS_LINE_3, COT_ADDRESS_LINE_4=@COT_ADDRESS_LINE_4, COT_ADDRESS_LINE_5=@COT_ADDRESS_LINE_5, COT_ADDRESS_LINE_6=@COT_ADDRESS_LINE_6, COT_ADDRESS_LINE_7=@COT_ADDRESS_LINE_7, COT_CUST_CREATION_DATETIME=@COT_CUST_CREATION_DATETIME
                                                        where COT_CUST_TELEPHONE = @COT_CUST_TELEPHONE", connection);

                        command.Parameters.Add("@COT_CUST_TELEPHONE", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Telephone);

                        command.Parameters.Add("@COT_ADDRESS_LINE_1", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.GridID);
                        command.Parameters.Add("@COT_ADDRESS_LINE_2", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.AreaID.ToString());
                        command.Parameters.Add("@COT_ADDRESS_LINE_3", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Building);
                        command.Parameters.Add("@COT_ADDRESS_LINE_4", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Street);
                        command.Parameters.Add("@COT_ADDRESS_LINE_5", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Floor);
                        command.Parameters.Add("@COT_ADDRESS_LINE_6", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Flat);
                        command.Parameters.Add("@COT_ADDRESS_LINE_7", SqlDbType.NVarChar).Value = Security.ExcludeInjection(info.Address_Others);
                        command.Parameters.Add("@COT_CUST_CREATION_DATETIME", SqlDbType.DateTime).Value = info.date;

                        KFGDAL.ExecuteNoneQuery(command, false, Global_BLL.GetCOTconnection());

                        //KFGHostServices.Service1 service = new KFGHostServices.Service1();
                        //service.ExecuteNoneQuery(command);

                        // connection.Open();
                        //command.ExecuteNonQuery();

                        customerStatus = "ok";
                    
                }
                return customerStatus;


            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                return exc.Message;
            }

        }


    }
}
