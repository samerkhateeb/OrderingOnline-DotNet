using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using CheckOut_Module;
using KFGCMS.BLL;
using System.Data.SqlClient;
using KFGCMS.Utilities;
using Customer_Module;
using Customer;

namespace CheckOut
{
    public partial class CheckOut : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie cookie = Request.Cookies["myown"];
            //string cookievalue = cookie==null?"":String.Format("{0},{1};", cookie.Value, cookie.Expires);
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "stringtype","alert('sad"+cookievalue+"')" , true);

            if (!IsPostBack)
            {
                HttpCookie userCookie = Request.Cookies["CustomerInfo"];
                if (userCookie != null)
	            {

                    CheckOut_Info info = new CheckOut_Info();
                    CheckOut_BLL bll = new CheckOut_BLL();

                    // get the customer existing information
                    Customer_BLL customerBll = new Customer_BLL();
                    Customer_Info customerInfo = customerBll.Customer_Select(userCookie["Customer_Telephone"]);
                    AddressDetails AddressDetails = ((AddressDetails)AddressDetailsControl);
                    // assign the new values for customer address
                   
                   
                    AddressDetails.Building = customerInfo.Building ;
                    AddressDetails.Street = customerInfo.Street ;
                    AddressDetails.Floor = customerInfo.Floor  ;
                    AddressDetails.Flat = customerInfo.Flat ;
                    AddressDetails.OtherAddress = customerInfo.Address_Others;


                    string GridID = customerInfo.GridID.ToLower(),
                    BlockID = "";

                    if (GridID.LastIndexOf(" ") != -1)
                    {
                        GridID = customerInfo.GridID.Split(' ')[0].ToLower();
                        BlockID = customerInfo.GridID.Split(' ')[1].ToLower();
                    }

                    // put it after ensure the split complete
                    AddressDetails.SetGrid = GridID;

                    ScriptManager.RegisterStartupScript(AddressDetailsControl, AddressDetailsControl.GetType(), "RunScript", "FillBlockList('" + GridID + "');SelectBlockListValue('" + BlockID + "');", true);
                }
            }

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ControlsIDs",
                            String.Format("var deliveryCharge = {0}, NoteTextBox = '#{1}', CheckOutLinkButton = '#" + CheckServerButton.ClientID + "'; ",
                                                ConfigurationManager.AppSettings["DeliveryCharge"],
                                                NoteTextBox.ClientID), true);
        }


        private static object _CheckOutProcess = new object();
        protected void CheckOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                string OrderType = Security.ExcludeInjection(Request.Cookies["OrderType"].Value.ToLower());

                lock (_CheckOutProcess)
                {
                    HttpCookie userCookie = Request.Cookies["CustomerInfo"];

                    CheckOut_Info info = new CheckOut_Info();
                    CheckOut_BLL bll = new CheckOut_BLL();

                    // get the customer existing information
                    Customer_BLL customerBll = new Customer_BLL();
                    Customer_Info customerInfo = customerBll.Customer_Select(userCookie["Customer_Telephone"]);

                    AddressDetails AddressDetails = ((AddressDetails)AddressDetailsControl);
                    // assign the new values for customer address
                    customerInfo.GridID = AddressDetails.GridID + " " + AddressDetails.BlockID;
                    customerInfo.AreaID = AddressDetails.BlockID;
                    customerInfo.Building = AddressDetails.Building;
                    customerInfo.Street = AddressDetails.Street;
                    customerInfo.Floor = AddressDetails.Floor;
                    customerInfo.Flat = AddressDetails.Flat;
                    customerInfo.Address_Others = AddressDetails.OtherAddress;
                    customerInfo.date = DateTime.Now.AddHours(Convert.ToDouble(ConfigurationManager.AppSettings["TimeDifference"]));

                    // do the update process in the website level
                    customerBll.Customer_Registration_Update(customerInfo);

                    // update current COT database for the new address information in COT Level
                    Customer_COT customerCOTBll = new Customer_COT();
                    customerCOTBll.Customer_UpdateOrderDelivery(customerInfo);



                    string customerLocationCode = bll.GetLocationCode(userCookie["Customer_GridID"].ToString()),
                            GridCompleteAddress = "";

                    // Check and Get Complete Grid Address
                   // if (Request.Cookies["OrderType"].Value.ToLower() == "hd")
                        GridCompleteAddress = customerInfo.GridID;
                    //else
                    //    GridCompleteAddress = Request.Cookies["OrderGrid"].Value.Replace('_', ' ').Replace("%20", " ");


                    info.total = Convert.ToDouble(Request.Cookies["total"].Value);
                    info.OrderType = OrderType == "hd" ? "44" : "55";
                    info.Telephone = Security.ExcludeInjection(userCookie["Customer_Telephone"].ToString());
                    info.Grid_ID = GridCompleteAddress;
                    info.Location_Code = Request.Cookies["OrderType"].Value.ToLower() == "hd" ? customerLocationCode : Request.Cookies["OrderLocation"].Value;
                    info.DeliveryTime = DateTime.Now;
                    info.Remarks = Security.ExcludeInjection(NoteTextBox.Text.Replace("%20", " "));
                    info.OtherCharge = 0;
                    info.DeliveryCharge = OrderType == "hd" ? Convert.ToDouble(ConfigurationManager.AppSettings["DeliveryCharge"]):0;

                    List<CheckOut_Info> listInfo = new List<CheckOut_Info>();
                    CheckOut_Info TempInfo;
                    int i = 0;
                    while (Request.Cookies["ItemID" + i] != null)
                    {
                        TempInfo = new CheckOut_Info();
                        TempInfo.Item_Code = bll.Select_ItemCode(Request.Cookies["ItemID" + i].Value, Request.Cookies["ItemSorting" + i].Value);
                        TempInfo.Item_Price = Convert.ToDouble(Request.Cookies["Price" + i].Value);
                        TempInfo.Item_Quantity = Convert.ToDouble(Request.Cookies["Quantity" + i].Value);
                        TempInfo.Item_Name =Security.ExcludeInjection( Request.Cookies["ItemName" + i].Value.Replace("%20", " "));
                        listInfo.Add(TempInfo);

                        i++;
                    }


                    bool SaveWebComplete = bll.SaveOrdersToWeb(ref info, listInfo),
                        SaveCOTComplete = false,
                        Clearcomplete = false; 

                    // Check if save Web Complete
                    if (SaveWebComplete)
                    {
                        SaveCOTComplete = bll.SaveOrdersToCOT(ref info, listInfo);
                    }


                    // Check if save COT Complete
                    if (SaveCOTComplete)
                    {
                        CookieManager cookieManager = new CookieManager();
                        Clearcomplete = cookieManager.ClearOrderCookies();

                        if (Clearcomplete)
                        {
                            SMS_BLL sms = new SMS_BLL();
                            sms.Send(info.Telephone, String.Format(MessageTemplate.sms1, ConfigurationManager.AppSettings["SiteName"], info.SalesTXNID));

                            Email_BLL emailBll = new Email_BLL();
                            emailBll.Send("shopping.com, Thanks For Order", userCookie["Customer_Email"].ToString(), String.Format(MessageTemplate.email2, ConfigurationManager.AppSettings["SiteName"], info.SalesTXNID, info.Telephone));

                            emailBll.Send("shopping Web Order", "me@shopping.com", String.Format(MessageTemplate.email3, info.SalesTXNID, userCookie["Customer_Name"], userCookie["Customer_Telephone"], info.total));
                            Response.Redirect("~/Portals/SuccessCheckOut", false);
                        }
                    }

                }

            }
            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.UI", this.GetType().Name);
                
            }


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
              //  SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["KFGCOT_ConnectionString"].ConnectionString);
              //  //SqlConnection connection = Global_BLL.GetCOTconnection();
              //  //Global_BLL.GetCOTconnection();
              ////  Response.Write(ConfigurationManager.ConnectionStrings["KFGCOT_ConnectionString"].ConnectionString);

              //  SqlCommand command = new SqlCommand("insert into test(TestName) values ('asd fasd fsad f')", connection);
              //  connection.Open();
              //  command.ExecuteNonQuery();
              //  Response.Write(connection.State.ToString());
              //  connection.Close();

            }
            catch (Exception)
            {
                
                throw;
            }
            
        }





    }
}