using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using KFGCMS.BLL;
using System.Web.Services;
using System.Net.Mail;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Xml;

public partial class AJAX : System.Web.UI.Page
{

    #region Members
    
    string[] Separator = { "#", "%20", " ", "&" };
    int rowIndex = 0;
    DataRow row ;
    string tableType = "", cookieCounter = "NoCount";
    DataSet midDataSet = new DataSet(),
            leftContainerDataSet = new DataSet(),
            tabsDataSet = new DataSet(),
            bottomContainerRightDataSet = new DataSet(),
            bottomContainerLeftDataSet = new DataSet(),
            mostDataSet = new DataSet(),
            VotingDataSet = new DataSet(),
            TabLeftDataSet = new DataSet();

    #endregion
   

    public void HideControl (Control control)
    {
        control.Visible = false;
    }

    public string DataTableType (DataTable dataTable)
    {
        if (dataTable.Rows.Count == 0 || dataTable.Rows[0][0].ToString().ToLower() == "empty")
        {
            return "empty";
        }
        else
        {
             row = dataTable.Rows[0];
            return row["TableType"].ToString();
        }
    }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    HttpCookie cookieStart = Request.Cookies["Start"];
                    if (cookieStart == null)
                    {
                        cookieStart = new HttpCookie("Start");
                        cookieCounter = "Start";
                    }

                    HttpCookie cookieRegister = Request.Cookies["succeed"];
                    if (cookieRegister != null)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "registeredSuccessfully", String.Format("alert('{0}');",Server.UrlDecode(cookieRegister["message"].ToString())), true);
                        cookieRegister.Expires = DateTime.Now;
                        Response.Cookies.Add(cookieRegister);
                    }



                    HomePageLoad(cookieCounter);
                }
                catch (Exception exc)
                {
                    ExceptionsLog_BLL.SaveException(exc, "Portal.UI", this.GetType().Name);
                }
            }
        }


        void CheckLogin()
        {

            Customer_LoginControl.CheckLoginStatus = true;
        }

        public void HomePageLoad(string counterStatus)
        {
            DataTable DiscussionDataTable = new DataTable();

            string newsBarDirection = "";
            // change date format to usa format
            DateTime dateTimeString =(DateTime.Now.AddHours(Convert.ToDouble(ConfigurationManager.AppSettings["Timedifference"])));
                string    language = Pages_BLL.GetLanguage();
            
            // Set Current language for further code issue
            Site_Info.CurrentLanguage = language;
            
            // Decode URL to find ID, Type and Source
            if (!String.IsNullOrEmpty(Request.QueryString["info"]))
                Global_BLL.DecodeUrl(Request.QueryString["info"]);

            RightControl.CurrnetType = "right";
            MidControl.CurrnetType = "mid";
            LeftControl.CurrnetType = "left";

            MenuLeftControl.CurrentMenuType = "menuleft";

           
            DataSet masterDataSet = Pages_BLL.HomePage_Default(counterStatus, dateTimeString, language),
                    CopyDataSet = masterDataSet.Copy(),
                    BottomMidDataSet = new DataSet(),
                    BottomRightDataSet = new DataSet(),
                    BottomLeftDataSet = new DataSet(),
                    MenuLeftDataSet = new DataSet();
            //Menu_Info.CurrentPageID = "";
            foreach (DataTable dataTable in masterDataSet.Tables)
            {
                tableType = DataTableType(dataTable);

               
                {
                   
                    switch (tableType.ToLower())
                    {
                        case "settings":
                            {
                                lock (this)
                                {
                                    Pages_BLL.SettingsSave(dataTable);
                                }
                                break;
                            }


                        ////Init Hot News
                        case "hotnews":
                            {
                                HotNewsControl.DataContent = dataTable.Copy();
                                //Master.LeftContainerDataContent = dataTable;
                                break;
                            }

                        // Init Mid Container Control
                        case "mid":
                            {
                                midDataSet.Tables.Add(dataTable.Copy());
                                //UC_MidContainerControl.DataContent = dataTable;
                                break;
                            }


                        //Init Left Container
                        case "leftcontainer":
                            {
                                leftContainerDataSet.Tables.Add(dataTable.Copy());
                                //Master.LeftContainerDataContent = dataTable;
                                break;
                            }



                        //Init Bottom Container Mid
                        case "bottomcontainermid":
                            {
                                BottomMidDataSet.Tables.Add(dataTable.Copy());
                                break;
                            }



                        //Init Menu Left Container 
                        case "menuleft":
                            {
                                MenuLeftControl.DataContent = dataTable.Copy();
                                break;
                            }

                      
                        //Init Bottom Container Right
                        case "bottomcontainerright":
                            {
                                BottomRightDataSet.Tables.Add(dataTable.Copy());
                                break;
                            }


                        //Init Bottom Container left
                        case "bottomcontainerleft":
                            {
                                BottomLeftDataSet.Tables.Add(dataTable.Copy());
                                break;
                            }

                        case "voting":
                            {
                                VotingDataSet.Tables.Add(dataTable.Copy());
                                break;
                            }


                        case "discussion":
                            {
                                DiscussionDataTable = dataTable;
                                break;
                            }

                        case "tableft":
                            {
                                TabLeftDataSet.Tables.Add(dataTable.Copy());
                                break;
                            }

                        default:
                            //new Global_BLL().RemoveDataTable(CopyDataSet, masterDataSet.Tables.IndexOf(dataTable));
                            break;


                    } // end switch case
                }

                    
            } // end foreach

            Pages_BLL.ChangePageTitle(this, Site_Info.TopMenu_Home);
            // Init DataSets To Controls

            if (midDataSet.Tables.Count != 0) // mid container
                MidControl.DataContent = midDataSet;
            else
                HideControl(MidControl);

            if (leftContainerDataSet.Tables.Count !=0) // right container
                LeftControl.DataContent = leftContainerDataSet;
            else
                HideControl(RightControl);
          
            //if (TabLeftDataSet.Tables.Count != 0) // left container
            //    LeftControl.DataContent = TabLeftDataSet;
            //else
            //    HideControl(LeftControl);

            
            Master.StaticContent(CopyDataSet);   


        } 
}
