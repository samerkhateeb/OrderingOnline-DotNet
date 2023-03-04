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
using System.Web.Services;
using nStuff.UpdateControls.Design;
using System.IO;
using System.Collections.Generic;
using KFGCMS.BLL;
using HTMLWriterControl;
using Customer_Module;

public partial class Portals_MasterPage : System.Web.UI.MasterPage
{
    #region Members
    ContentPlaceHolder BodyContentPlaceHolderolder;
    string[] separator = { "&"," " };
    string type = "", id = "", name = "", name_type="", strMediCatID, selectedKey,
                     tableType;
    // strMediCatID used to add it in history when get it from database according to media id


     DataRow row;
     DataSet SubpageContainerDataSet = new DataSet();



    #endregion

    #region Properties

    public string SearchText
    {
        set
        {
           // SearchControl.Text = value;
        }

    }

    public string BannerTopDataContent
    {
        set
        {
            BannerControl.DataContent = value;
        }
    }


    public string NewsBar
    {
        set
        {
            marqueeDiv.InnerHtml = value;
        }
    }

   
        //public DateTime HeaderDate
        //{
        //    set
        //    {
        //        DateLabel.Text = new Date_BLL().HeaderDate(value);
        //        DateLabel.DataBind();
        //    }
        //}


        //public void GenerateTopMenu()
        //{


        //    //TopMenu1Literal.Text = new Pages_BLL().GenerateTopMenu();
        //    //TopMenu1Literal.DataBind();

        //    // change Laguage Button Text
        //    //LanguageLinkButton.Text = Site_Info.TopMenu_Language;
        //    //LanguageLinkButton.DataBind();
        //}

    public object TopImage
    {
        set
        {
            TopImageControl.Visible = true;
            TopImageControl.ImageUrl = Global_BLL.ResolveImagePath(value);
            TopImageControl.DataBind();

        }
    }

    public DataTable Menu_PageCategories
    {
        set
        {
            Menu_PageCategoriesControl.DataContent_PageCategories = value;
        }
    }

    public string Menu_PageCategories_Selected
    {
        set
        {
            Menu_PageCategoriesControl.PageCategories_SelectedValue = value;
        }
    }

    #endregion


        public void  StaticContent (DataSet dataSet)
        {
            Control UC_BannerSubPageControl = BodyContentPlaceHolder.FindControl("UC_BannerSubPage"),
                            UC_LeftContainerControl = BodyContentPlaceHolder.FindControl("UC_LeftContainerControl"),
                            UC_SPGroupsControl = BodyContentPlaceHolder.FindControl("UC_SPGroupsControl"),
                            UC_BannerMid = BodyContentPlaceHolder.FindControl("UC_BannerMid"),
                            UC_BannerLeft = BodyContentPlaceHolder.FindControl("UC_BannerLeft"),
                            UC_BannerMid_Bottom = BodyContentPlaceHolder.FindControl("UC_BannerMid_Bottom"),
                            UC_BannerLeft_Bottom = BodyContentPlaceHolder.FindControl("UC_BannerLeft_Bottom");

            DataSet NavigationBarDataSet = new DataSet(),
                    FooterMenu1DataSet = new DataSet(),
                    FooterMenu2DataSet = new DataSet();
            
            int menuPosition = 0;

            //Menu_Info   ChildMenuInfo = new Menu_Info(),
            //            ParentMenuInfo = new Menu_Info();

            //List<Menu_Info> ListMenu = new List<Menu_Info>();




            LanguageTransfer(Pages_BLL.GetLanguage());

                 try
                {
                    

                foreach (DataTable dataTable in dataSet.Tables)
                {
                    // get table type
                    tableType = DataTableType(dataTable);

                    // check if table is empty or not
                    if (row == null || row[0].ToString().ToLower() == "empty")
                    {
                        continue;
                    }

                    switch (tableType.ToLower())
                    {

                        case "banner":
                            {
                                // bind banners
                                // Check Banners Status
                                if (dataTable.Rows.Count != 0)
                                {
                                    foreach (DataRow bannerRow in dataTable.Rows)
                                    {

                                        if (!String.IsNullOrEmpty(bannerRow["BannerTop"].ToString()))
                                        {
                                            this.BannerTopDataContent = bannerRow["BannerTop"].ToString();
                                        }
                                        
                                        if (UC_BannerLeft !=null && !String.IsNullOrEmpty(bannerRow["BannerLeft"].ToString()))
                                        {
                                            ((Banner.Banner)UC_BannerLeft).DataContent = bannerRow["BannerLeft"].ToString();
                                        }

                                        if (UC_BannerMid !=null && !String.IsNullOrEmpty(bannerRow["BannerMid"].ToString()))
                                        {
                                            ((Banner.Banner)UC_BannerMid).DataContent = bannerRow["BannerMid"].ToString();
                                        }

                                        if (UC_BannerSubPageControl !=null && !String.IsNullOrEmpty(bannerRow["BannerSubPage"].ToString()))
                                        {
                                            ((Banner.Banner)UC_BannerSubPageControl).DataContent = bannerRow["BannerSubPage"].ToString();
                                        }

                                        if (UC_BannerLeft_Bottom != null && !String.IsNullOrEmpty(bannerRow["BannerLeftBottom"].ToString()))
                                        {
                                            ((Banner.Banner)UC_BannerLeft_Bottom).DataContent = bannerRow["BannerLeftBottom"].ToString();
                                        }

                                        if (UC_BannerMid_Bottom != null && !String.IsNullOrEmpty(bannerRow["BannerMidBottom"].ToString()))
                                        {
                                            ((Banner.Banner)UC_BannerMid_Bottom).DataContent = bannerRow["BannerMidBottom"].ToString();
                                        }
                                    }
                                }
                                
                                break;
                            }
                        case "menucategories":
                            {

                                Menu_PageCategories = dataTable;
                                break;
                            }

                        case "menu":
                             {

                                 DataView MenuDataView = new DataView(dataTable);

                                 MenuDataView.RowFilter = "Parent_MENUPOSITION = 3 OR Parent_MENUPOSITION = 2";
                                 MenuFooter.DataContent_Footer = MenuDataView.ToTable();

                                 MenuDataView.RowFilter = "Parent_MENUPOSITION = 3 OR Parent_MENUPOSITION = 1";
                                 MenuTop.DataContent_Header = MenuDataView.ToTable();


                                break;
                            }
                        //Init  Left Container (SubPage Container)
                        case "containersubpage":
                            {
                                SubpageContainerDataSet.Tables.Add(dataTable.Copy());
                                break;
                            }

                        case "group":
                            {
                                if (UC_SPGroupsControl !=null)
                                ((Portals_Controls_UC_SPGroups)UC_SPGroupsControl).DataContent = dataTable;
                                break;
                            }

                        default:
                            {
                                continue;
                            }

                        case "gridslocations":
                            {
                                PopupOrderTypeControl.GridsLocations_Datacontent = dataTable;
                                break;
                            }

                        //case "block":
                        //    {
                        //        PopupOrderTypeControl.Blocks_Datacontent = dataTable;
                        //        break;
                        //    }
                    }
                }

                if (SubpageContainerDataSet.Tables.Count != 0 && UC_LeftContainerControl !=null)
                    ((Left)UC_LeftContainerControl).DataContent = SubpageContainerDataSet;



                CopyRightLabel.Text = "&copy;All Rights Reserved for Kout Food Group " + DateTime.Now.Year.ToString();
                CopyRightLabel.DataBind();
                // Init Page Date
               // this.HeaderDate = DateTime.Now;


                }
                 catch (Exception exc)
                 {
                     ExceptionsLog_BLL.SaveException(exc, "Portal.UI", this.GetType().Name);
                 }
            }
        

        public string DataTableType(DataTable dataTable)
        {
            if (dataTable.Rows.Count != 0)
            {
                row = dataTable.Rows[0];
                return row["TableType"].ToString();
            }
            else
                return "empty";
        }

        public void HideControl(Control control)
        {
            control.Visible = false;
        }

    protected void Page_Load(object sender, EventArgs e)
    {
        // change style According to selected language
            StyleSheetLink.Attributes.Add("href", Pages_BLL.DefaultStyleSheetPath(Pages_BLL.GetLanguage()));  
 
        

    }


    protected void LanguageLinkButton_Click(object sender, EventArgs e)
    {
        string language = Pages_BLL.GetLanguage(),
                path = "";
        if (language == "arb")
            language = "eng";
        else
            language = "arb";

        QueryString_Info.Language = language;

        Response.Redirect(String.Format("?info={0}.{1}", Global_BLL.EncodeUrl(QueryString_Info.StandardQueryString), ConfigurationManager.AppSettings["PortalExtension"]));

    }

    public void LanguageTransfer(string language)
    {
      // SearchControl.WaterMarkText = Site_Info.SearchWaterMarkText;
        
    }




}