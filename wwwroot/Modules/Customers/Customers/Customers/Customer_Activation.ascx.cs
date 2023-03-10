using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_Module;
using System.Data;
using System.Configuration;
using KFGCMS.BLL;

namespace Customer
{
    public partial class Customer_Activation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    // Fill Phone if exist
                    HttpCookie UserCookie = Request.Cookies["CustomerInfo"];
                    if (UserCookie != null)
                    {
                        PhoneTextBox.Text = UserCookie["Customer_Telephone"].ToString();
                        PhoneTextBox.DataBind();

                        WelcomeLabel.Text = "Welcome " + UserCookie["Customer_Name"].ToString();
                        WelcomeLabel.Visible = true;
                        WelcomeLabel.DataBind();
                    }

                }
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.UI", this.GetType().Name);

            }
        }

        protected void AuthorizeLinkButton_Click(object sender, EventArgs e)
        {
            try
            {

                Customer_Info info = new Customer_Info
                {
                    Telephone = PhoneTextBox.Text,
                    AuthCode = AuthorizationTextBox.Text
                };

                Customer_BLL bll = new Customer_BLL();
                // check the the customer on the local DB and activate it localy,
                if (bll.Customer_Activation(info))
                {
                    // Fill the customer information regarding to the phone number 
                    info = bll.Customer_Select(PhoneTextBox.Text);

                    Customer_COT CustomerCot = new Customer_COT();

                    // activate the customer in the COT DB
                    string CheckCustomerCOT = CustomerCot.Customer_Activation(info);

                    if (CheckCustomerCOT == "ok")
                    {
                        info.COTMessage = "Saved Successfully";
                        bll.Customer_SaveCOTStatus(info);

                        Customer_LoginBLL loginBll = new Customer_LoginBLL();
                        loginBll.DoLogin(info);
                        Response.Redirect(ConfigurationManager.AppSettings["WebsiteUrl"].ToString(), false);
                    }

                    else
                    {
                        info.COTMessage = CheckCustomerCOT;
                        bll.Customer_SaveCOTStatus(info);

                        AuthorizationTextBox.Text = string.Format("A problem happened while registration process, the admin informed, please contact <a class='Customer_ResultLink' href='mailto:{0}'>{0}</a> or try again later", ConfigurationManager.AppSettings["AdminEmail"]);
                        AuthorizationTextBox.Visible = true;
                        AuthorizationTextBox.DataBind();
                    }

                }

                else // Unable to authorize
                {
                    //AuthorizationTextBox.Text = "";
                    //AuthorizationTextBox.DataBind();
                    AuthorizationStatusLabel.Visible = true;
                    AuthorizationStatusLabel.DataBind();
                }
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.UI", this.GetType().Name);

            }


        }
    }
}