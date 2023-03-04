using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using KFGCMS.BLL;
using System.Data;
using System.Web;
using KFGCMS.DAL;



namespace Customer_Module
{
    // GridInfo Class
    public class Grid_Info
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Block_ID { get; set; }

    }
    // Customer Class
    public class Customer_BLL
    {


        #region Members
            SqlCommand command;
            DataSet dataSet;
            DataTable dataTable;
            DataRow row;
            Customer_Info info;
        #endregion


            public Customer_Info Customer_Select(string Telephone)
            {
                try
                {
                        command = new SqlCommand("KFGSP_Customer_SELECT");
                        command.Parameters.Add("@CUSTOMER_TELEPHONE", SqlDbType.NVarChar).Value = Telephone;
                        command.CommandType = CommandType.StoredProcedure;

                        dataTable = KFGDAL.ExecuteDataTable(command);

                        info = new Customer_Info();
                        // Fill the customer information
                        if (dataTable.Rows.Count !=0)
	                    {
                            row = dataTable.Rows[0];
                            
                            info.ID = Convert.ToInt32(row["Customer_ID"]);
                            info.Name = row["Customer_Name"].ToString();
                            info.Telephone = row["Customer_Telephone"].ToString();
                            info.GridID = row["Customer_Address_GridID"].ToString();
                            info.AreaID = row["Customer_Address_BlockID"].ToString();
                            info.Building = row["Customer_Address_Building"].ToString();
                            info.Street = row["Customer_Address_Street"].ToString();
                            info.Floor = row["Customer_Address_Floor"].ToString();
                            info.Flat = row["Customer_Address_Flat"].ToString();
                            info.Address_Others = row["Customer_Address_Other"].ToString();
                            info.status = Convert.ToBoolean(row["Customer_Status"]);
                            info.Email = row["Customer_Email"].ToString();
                            info.Password = row["Customer_Password"].ToString();
                            info.Remarks = row["Customer_Remarks"].ToString();
                            info.date = Convert.ToDateTime(row["Customer_Date"]);
                            info.RegistrationStatus = Convert.ToInt32(row["Customer_RegistrationStatus"]);
                            info.AuthCode = String.IsNullOrEmpty(row["Customer_AuthCode"].ToString())? "":row["Customer_AuthCode"].ToString();
	                    }

                        return info;
                    
                }

                catch (Exception exc)
                {
                    ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                    return info;
                }
            }



            public DataTable Customer_SelectGrids()
            {
                dataTable = new DataTable();

                try
                {
                       command = new SqlCommand("KFGSP_GRIDLOCATIONS_SELECT");
                       command.CommandType = CommandType.StoredProcedure;
                       dataTable = KFGDAL.ExecuteDataTable(command);

                       return dataTable;
                } 

                catch (Exception exc)
                {
                    ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                    return dataTable;

                }
            }


            public DataTable FilterGrids(DataTable dataTable)
            {
                DataTable tempDataTable = new DataTable();
                tempDataTable.Columns.Add("Name");
                tempDataTable.Columns.Add("Value");
                string tempstring = "";
               // List<Grid_Info> gridList = new List<Grid_Info>();
              //  Grid_Info gridInfo;
                foreach (DataRow row in dataTable.Rows)
                {
                    DataRow tempRow = tempDataTable.NewRow();

                    tempRow["Name"] = row["Grid_Name"].ToString().TrimEnd(' ');

                    if (row["Grid_Code"].ToString().Split(' ').Length > 1)
                    {
                        tempstring = row["Grid_Code"].ToString();
                        tempRow["Value"] = tempstring.Substring(0, tempstring.LastIndexOf(' ')).ToLower().TrimEnd(' ');
                    }
                    else
                    {
                        //gridInfo.Value = row["Grid_Code"].ToString();
                        //gridInfo.Block_ID = "0";

                       // tempRow["Name"] = row["Grid_Code"].ToString().Split(' ')[0];
                        tempRow["Value"] = row["Grid_Code"].ToString().ToLower().TrimEnd(' ');
                    }

                    tempDataTable.Rows.Add(tempRow);

                  

                }

                DataView dataView = tempDataTable.DefaultView;
                

                return dataView.ToTable(true,"Name", "Value");
            }

            public List<Grid_Info> FilterBlocks(DataTable dataTable, string SelectedValue)
            {
                List<Grid_Info> blockList = new List<Grid_Info>();
                string tempValue = "", BlockName = "";
                Grid_Info gridInfo;

                try
                {
                   
                    foreach (DataRow row in dataTable.Rows)
                    {

                        tempValue = row["Grid_Code"].ToString().ToLower();

                        if (tempValue.Split(' ').Length > 1)
                            tempValue = tempValue.Split(' ')[0];

                        // BlockName = row["Grid_Code"].ToString();
                        if (tempValue == SelectedValue && row["Grid_Code"].ToString().IndexOf(' ') != -1 )
                        {
                            gridInfo = new Grid_Info();

                            BlockName = row["Grid_Code"].ToString().Split(' ')[1];

                            gridInfo.Name = BlockName;
                            gridInfo.Value = BlockName;

                            blockList.Add(gridInfo);
                        }

                    }

                    // If its empty
                    if (blockList.Count == 0)
                    {
                        gridInfo = new Grid_Info();
                        gridInfo.Name = "Block Is Empty";
                        gridInfo.Value = "";
                        blockList.Add(gridInfo);
                    }
                   

                }

                catch (Exception exc)
                {
                   
                    ExceptionsLog_BLL.SaveException(exc, "Portal.BLL", this.GetType().Name);
                  
                }

                return blockList;
            }

            public DataTable Customer_SelectBlocks(string GridCode)
            {
                dataTable = new DataTable();
                try
                {
                    command = new SqlCommand("KFGSP_Customer_SELECT_GRIDBLOCKS");
                    command.Parameters.Add("@GridCode", SqlDbType.NVarChar).Value = GridCode;
                    command.CommandType = CommandType.StoredProcedure;
                    dataTable = KFGDAL.ExecuteDataTable(command);
                    return dataTable;
                }

                catch (Exception exc)
                {
                    ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                    return dataTable;

                }
            }


            public DataTable Customer_Registration_Insert(Customer_Info info)
            {
                try
                {
                   
                        command = new SqlCommand("KFGSP_Customer_Registration_INSERT");
                        command.Parameters.Add("@Customer_Name", SqlDbType.NVarChar).Value = info.Name;
                        command.Parameters.Add("@Customer_Email", SqlDbType.NVarChar).Value = info.Email;
                        command.Parameters.Add("@Customer_Password", SqlDbType.NVarChar).Value = info.Password;
                        command.Parameters.Add("@Customer_Telephone", SqlDbType.NVarChar).Value = info.Telephone;
                        command.Parameters.Add("@Customer_Address_GridID", SqlDbType.NVarChar).Value = info.GridID;
                        command.Parameters.Add("@Customer_Address_AreaID", SqlDbType.NVarChar).Value = info.AreaID;
                        command.Parameters.Add("@Customer_Address_Building", SqlDbType.NVarChar).Value = info.Building;
                        command.Parameters.Add("@Customer_Address_Street", SqlDbType.NVarChar).Value = info.Street;
                        command.Parameters.Add("@Customer_Address_Floor", SqlDbType.NVarChar).Value = info.Floor;
                        command.Parameters.Add("@Customer_Address_Flat", SqlDbType.NVarChar).Value = info.Flat;
                        command.Parameters.Add("@Customer_Address_Other", SqlDbType.NVarChar).Value = info.Address_Others;
                        command.Parameters.Add("@Customer_Date", SqlDbType.DateTime).Value = info.date;
                        command.Parameters.Add("@Customer_Remarks", SqlDbType.NVarChar).Value = info.Remarks;
                        command.Parameters.Add("@Customer_Status", SqlDbType.Bit).Value = info.status;
                        command.Parameters.Add("@Customer_Sorting", SqlDbType.Real).Value = info.sorting;
                        command.Parameters.Add("@Customer_Gender", SqlDbType.Int).Value = info.Gender;
                        command.Parameters.Add("@Customer_BirthDate", SqlDbType.DateTime).Value = info.BirthDate;
                        command.Parameters.Add("@Customer_Occupation", SqlDbType.NVarChar).Value = info.Occupation;
                        command.Parameters.Add("@Customer_AuthCode", SqlDbType.NVarChar).Value = info.AuthCode;
                        command.Parameters.Add("@Customer_RegistrationStatus", SqlDbType.Int).Value = info.RegistrationStatus;

                        command.CommandType = CommandType.StoredProcedure;

                        dataTable = KFGDAL.ExecuteDataTable(command);

                        return dataTable;
                        //int returnvalue = Convert.ToInt32(dataTable.Rows[0]["NewCustomerID"]);
                        //if (returnvalue == 0)
                        //    returnvalue = Convert.ToInt32(dataTable.Rows[0]["Customer_RegistrationStatus"]);

                        //return returnvalue;
                    
                }

                catch (Exception exc)
                {
                    ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                    return dataTable;
                }

            }


            public int Customer_Registration_Update(Customer_Info info)
            {
                try
                {
                        command = new SqlCommand("KFGSP_Customer_Registration_Update");
                        command.Parameters.Add("@Customer_Email", SqlDbType.NVarChar).Value = info.Email;
                        command.Parameters.Add("@Customer_Telephone", SqlDbType.NVarChar).Value = info.Telephone;
                        command.Parameters.Add("@Customer_Address_GridID", SqlDbType.NVarChar).Value = info.GridID;
                        command.Parameters.Add("@Customer_Address_AreaID", SqlDbType.NVarChar).Value = info.AreaID;
                        command.Parameters.Add("@Customer_Address_Building", SqlDbType.NVarChar).Value = info.Building;
                        command.Parameters.Add("@Customer_Address_Street", SqlDbType.NVarChar).Value = info.Street;
                        command.Parameters.Add("@Customer_Address_Floor", SqlDbType.NVarChar).Value = info.Floor;
                        command.Parameters.Add("@Customer_Address_Flat", SqlDbType.NVarChar).Value = info.Flat;
                        command.Parameters.Add("@Customer_Date", SqlDbType.DateTime).Value = info.date;
                        
                        command.CommandType = CommandType.StoredProcedure;
                        KFGDAL.ExecuteNoneQuery(command, false);
                        //command.ExecuteNonQuery();

                        return 1;
                }

                catch (Exception exc)
                {
                    ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                    return 0;
                }

            }



        public void Customer_AuthorizationCode_Update(Customer_Info info)
        {
            try
            {
                command = new SqlCommand("KFGSP_Customer_AUTHCODE_UPDATE");
                command.Parameters.Add("@Customer_ID", SqlDbType.BigInt).Value = info.ID;
                command.Parameters.Add("@CUSTOMER_AUTHCODE", SqlDbType.NVarChar).Value = info.AuthCode;

                command.CommandType = CommandType.StoredProcedure;
                KFGDAL.ExecuteNoneQuery(command, false);
                
            }
            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);               
            }
        }

        public string Customer_AuthCode_Generate (long CustomerID)
        {
            Random ran = new Random();
            double x = ran.Next(0, 9999),
                y = ran.Next(0, 9999);
            return x.ToString() + CustomerID.ToString() + y.ToString();
        }



        public bool Customer_Activation(Customer_Info info)
        {
            try
            {
                command = new SqlCommand("KFGSP_Customer_Registration_ACTIVATION");
                command.Parameters.Add("@CUSTOMER_TELEPHONE", SqlDbType.NVarChar).Value = info.Telephone;
                command.Parameters.Add("@CUSTOMER_AUTHORIZATIONCODE", SqlDbType.NVarChar).Value = info.AuthCode;
               // command.Parameters.Add("@CUSTOMER_OUTPUT", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.CommandType = CommandType.StoredProcedure;
                //Reader = command.ExecuteReader();
                DataTable dataTable = KFGDAL.ExecuteDataTable(command);
                bool returnValue = false;
                if (dataTable.Rows.Count != 0 && dataTable.Rows[0][0].ToString() != "0")
                {
                    returnValue = true;
                }

                // return Convert.ToBoolean(command.Parameters["@CUSTOMER_OUTPUT"].Value);
                return returnValue;
                
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                return false;
            }
        }

        public bool CheckLoginStatus()
        {
            HttpCookie userCookie = HttpContext.Current.Request.Cookies["CustomerInfo"];

            if (userCookie != null)
                return true;
            else
                return false;
        }


        public void Customer_SaveCOTStatus(Customer_Info customerInfo)
        {

            try
            {
                KFGDAL.ExecuteNoneQuery(String.Format("update KFGCMS_Customers set Customer_COTMessage = '{0}' where Customer_ID = '{1}' ", customerInfo.COTMessage, customerInfo.ID));
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                
            }
        }



    }
}



