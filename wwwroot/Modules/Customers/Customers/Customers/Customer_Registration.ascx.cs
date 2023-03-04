using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_Module;
using System.Configuration;
using KFGCMS.BLL;
using System.Data;

namespace Customers
{
    public partial class Customer_Registration : System.Web.UI.UserControl
    {
        #region Memebers

        int NewCustomerID = 0;

        #endregion


        private static object LockProcess = new object();

        protected void RegisterLinkButton_Click(object sender, EventArgs e)
        {

            lock (LockProcess)
            {
                try
                {

                    Customer_Info info = new Customer_Info
                    {
                        Name = NameTextBox.Text,
                        Email = EmailTextBox.Text,
                        Password = PasswordTextBox.Text,
                        Telephone = TelephoneTextBox.Text,
                        GridID = AddressDetailsControl.GridID + " " + AddressDetailsControl.BlockID,
                        AreaID = AddressDetailsControl.BlockID,
                        Building = AddressDetailsControl.Building,
                        Street = AddressDetailsControl.Street,
                        Floor = AddressDetailsControl.Floor,
                        Flat = AddressDetailsControl.Flat,
                        Address_Others = AddressDetailsControl.OtherAddress,
                        date = DateTime.Now.AddHours(Convert.ToDouble(ConfigurationManager.AppSettings["TimeDifference"])),
                        Remarks = RemarksTextBox.Text,
                        status = true,
                        sorting = 1,
                        Gender = Convert.ToInt32(GenderDropDownList.SelectedValue),
                        BirthDate = Convert.ToDateTime("1/1/1970"),
                        Occupation = OccupationTextBox.Text,
                        AuthCode = "",
                        RegistrationStatus = 0
                    };

                    Customer_BLL customerBLL = new Customer_BLL();

                    // insert the customer
                    DataTable dataTable = customerBLL.Customer_Registration_Insert(info);

                    // check if the user successfully inserted
                    if (dataTable.Rows.Count != 0 && dataTable.Rows[0]["NewCustomerID"].ToString() == "0") // the customer exist but its not active
                    {
                        if (dataTable.Rows[0]["Customer_RegistrationStatus"].ToString() == "1")
                            StatusLabel.Text = "the account information you enetered is already used!! please use another mobile number or email";
                        else
                            StatusLabel.Text = "your account has been created, please <a class='Customer_ResultLink' href='/Portals/CustomerActivation/'>activate it</a>?";

                        StatusLabel.Visible = true;
                        StatusLabel.DataBind();

                        ScriptManager.RegisterStartupScript(AddressDetailsControl, AddressDetailsControl.GetType(), "RunScript", "FillBlockList('" + AddressDetailsControl.GridID + "');SelectBlockListValue('" + AddressDetailsControl.BlockID + "');", true);


                    }
                    else // this is a new user
                    {
                        // Generate AuthCode
                        info.ID = Convert.ToInt64(dataTable.Rows[0]["NewCustomerID"]);

                        info.AuthCode = customerBLL.Customer_AuthCode_Generate(info.ID);

                        // update Authorization Code for that customer
                        customerBLL.Customer_AuthorizationCode_Update(info);

                        // Send SMS for the customer.
                        SMS_BLL smsBll = new SMS_BLL();
                        smsBll.Send(info.Telephone, String.Format(MessageTemplate.sms2, ConfigurationManager.AppSettings["SiteName"], info.AuthCode));


                        // Send Email for the customer
                        Email_BLL emailBll = new Email_BLL();
                        emailBll.Send(String.Format("Welcome To {0} website", ConfigurationManager.AppSettings["SiteName"]), info.Email, String.Format(MessageTemplate.email1, ConfigurationManager.AppSettings["SiteName"], info.AuthCode));

                        Response.Redirect("~/Portals/CustomerActivation/", false);

                    }

                }

                catch (Exception exc)
                {
                    ExceptionsLog_BLL.SaveException(exc, "Portal-UI", this.GetType().Name);


                    StatusLabel.Text = string.Format("A problem happened while registration process, the admin informed, please contact <a class='Customer_ResultLink' href='mailto:{0}'>{0}</a> or try again later", ConfigurationManager.AppSettings["AdminEmail"]);
                    StatusLabel.Visible = true;
                    StatusLabel.DataBind();

                }


            }

           
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //protected void GridDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Customer_BLL bll = new Customer_BLL();
        //    DataTable BlockDataTable = bll.Customer_SelectBlocks(GridDropDownList.SelectedValue);


        //    if (BlockDataTable.Rows.Count != 0)
        //    {
        //        BlockDropDownList.Items.Clear();

        //        BlockDropDownList.DataSource = bll.FilterBlocks(BlockDataTable);
        //        BlockDropDownList.DataTextField = "Block_ID";
        //        BlockDropDownList.DataValueField = "Block_ID";
        //        BlockDropDownList.DataBind();

        //        ListItem ZeroItem = new ListItem("----- Select Block ---- ", "0");
        //        BlockDropDownList.Items.Insert(0, ZeroItem);
                
        //    }

        //    GridDropDownList.DataBind();
           

            

        //}

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Email_BLL emailBll = new Email_BLL();
                emailBll.Send("how are you", "samerk@kfg.com.kw", "how ar eyou");
            }
            catch (Exception exc)
            {

                Response.Write(exc.Message);
            }
        }

        

    }
}