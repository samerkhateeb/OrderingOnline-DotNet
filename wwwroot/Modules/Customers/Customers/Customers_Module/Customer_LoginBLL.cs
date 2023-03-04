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
    public class Customer_LoginBLL
    {
    
    #region Members

        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter dap;
        DataTable dataTable;
        DataRow row;

	#endregion

        public int CheckLogin(Customer_Info info)
        {
            int loginStatus = 0;
            try
            {
                    command = new SqlCommand("KFGSP_Customer_Login", connection);
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = info.Email;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = info.Password;
                    command.CommandType = CommandType.StoredProcedure;

                    dataTable = KFGDAL.ExecuteDataTable(command);

                    if (dataTable.Rows.Count != 0)
                    {
                        row = dataTable.Rows[0];
                        info.ID = Convert.ToInt64(row["Customer_ID"]);
                        info.Name = row["Customer_Name"].ToString();
                        info.Password = row["Customer_Password"].ToString();
                        info.Email = row["Customer_Email"].ToString();
                        info.Telephone = row["Customer_telephone"].ToString();
                        info.GridID = row["Customer_Address_GridID"].ToString().Replace(' ','_');
                        info.RegistrationStatus = Convert.ToInt32(row["Customer_RegistrationStatus"]);

                        DoLogin(info);
                        loginStatus = 1;
                    }

                    return loginStatus;
                
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.BLL", this.GetType().Name);
                return loginStatus;
            }
        }


        public void DoLogin(Customer_Info info)
        {
            HttpCookie cookie = new HttpCookie("CustomerInfo");
            cookie["Customer_Name"] = info.Name;
            cookie["Customer_ID"] = info.ID.ToString();
            cookie["Customer_Telephone"] = info.Telephone;
            cookie["Customer_GridID"] = info.GridID;
            cookie["Customer_Email"] = info.Email;
            cookie["Customer_RegistrationStatus"] = info.RegistrationStatus.ToString();
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

    }
}
