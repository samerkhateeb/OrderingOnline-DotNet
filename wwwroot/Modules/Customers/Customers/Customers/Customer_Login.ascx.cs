using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_Module;
using KFGCMS.BLL;
using System.Configuration;

namespace Customers
{
    public partial class Customer_Login : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LogoutStatusLabel.Visible = false;

                if (!IsPostBack)
                {

                    CheckLoginStatus = true;
                }

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "LoginClientIDs", "var LoginButton='#" + LoginButton.ClientID + "', LoginPasswordTextBox='#"+PasswordTextBox.ClientID+"';", true);
            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.UI", this.GetType().Name);

            }
        }

        public string CustomerHeader
        {
            set
            {
                ContainerHeaderControl.InnerText = value;

            }
        }

        public bool CheckLoginStatus
        {
            set
            {
                if (value)
                {
                    Customer_BLL customerBll = new Customer_BLL();
                    if (customerBll.CheckLoginStatus())
                    {
                        WelcomeLabel.Text = "Welcome " + Request.Cookies["CustomerInfo"]["Customer_Name"].ToString();
                        WelcomeLabel.DataBind();

                        // Check Activation - Hide / Show
                        if (Request.Cookies["CustomerInfo"]["Customer_RegistrationStatus"].ToString() == "0")
                            ActivationPanel.Visible = true;
                        
                            
                        LoginControlsPanel.Visible = false;
                        LoginUserPanel.Visible = true;
                    }
                }
            }
        }

        protected void LoginLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer_LoginBLL loginBll = new Customer_LoginBLL();
                Customer_Info info = new Customer_Info();
                info.Email = EmailTextBox.Text;
                info.Password = PasswordTextBox.Text;

                int result = loginBll.CheckLogin(info);

                if (Convert.ToBoolean(result))
                {
                    if (!String.IsNullOrEmpty(Request.QueryString["i"]))
                    {
                        Response.Redirect("~/Portals/Checkout", false);                        
                    }
                    else
                        Response.Redirect(ConfigurationManager.AppSettings["WebsiteUrl"], false);                        

                }
                else
                {
                    LogoutStatusLabel.Text = "Login failed, please try again";
                    LogoutStatusLabel.Visible = true;
                    LogoutStatusLabel.DataBind();
                    // Refresh the page
                    //Response.Redirect(Request.Url.ToString(), false);
                }
            }
            
            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.Customer.UI", this.GetType().Name);

            }


        }

        protected void ActivateLinkButton_Click(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["CustomerInfo"];
            if (cookie != null)
            {
                Customer_BLL customerBll = new Customer_BLL();
                Customer_Info customerInfo = customerBll.Customer_Select(cookie["Customer_Telephone"].ToString());

                // Send SMS for the customer.
                SMS_BLL smsBll = new SMS_BLL();
                smsBll.Send(customerInfo.Telephone, String.Format("Welcome To {0} Website, your Authorization Code is: {1}", ConfigurationManager.AppSettings["SiteName"], customerInfo.AuthCode));


                // Send Email for the customer
                Email_BLL emailBll = new Email_BLL();
                emailBll.Send(String.Format("Welcome To {0} website", ConfigurationManager.AppSettings["SiteName"]), customerInfo.Email, String.Format("<b>Welcome to {0} Website.</b> <br /> your Authorization Code is:{1}", ConfigurationManager.AppSettings["SiteName"], customerInfo.AuthCode));

                Response.Redirect("~/Portals/Activation/");
            }
        }
    }
}