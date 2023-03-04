using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KFGCMS.BLL;
using System.Configuration;
using System.Web.UI.HtmlControls;


namespace Menu
{
    public partial class Menu : System.Web.UI.UserControl
    {
        public string CurrentMenuType
        {
            set
            {
                CurrentMenuTypeHiddenField.Value = value;
            }
            get
            {
                return CurrentMenuTypeHiddenField.Value;
            }
        }

        public string SideMenuGenerator
        {
            set
            {
                if (value == "ImageMenu")
                {
                    RightMenuLabel.Text = Pages_BLL.MenuSideGenerator();
                    RightMenuLabel.DataBind();
                }
            }
        }

        public DataTable DataContent_Footer
        {
            set
            {
                FooterPanel.Visible = true;
                MenuFooter1DataList.DataSource = value;
                MenuFooter1DataList.DataBind();
            }


        }

        public DataTable DataContent_Header {
            set
            {
                TopPanel.Visible = true;
                TopDataList.DataSource = value;
                TopDataList.DataBind();
            }
        }

        public DataTable DataContent_PageCategories
        { 
            set 
            {
                PageCategoriesPanel.Visible = true;
                PageCategoriesDataList.DataSource = value;
                PageCategoriesDataList.DataBind();


            }
        }

        public string PageCategories_SelectedValue
        {
            set
            {
                foreach (DataListItem item in PageCategoriesDataList.Items)
	            {
                    if (PageCategoriesDataList.DataKeys[item.ItemIndex].ToString() == value)
                    {
                        HyperLink MenuHyperLink = item.FindControl("MenuHyperLink") as HyperLink;

                        MenuHyperLink.CssClass = "Menu_PageCateogires_LinkButton_Selected";
                        break;
                    }
	            }
                

            }
        }




        public DataTable DataContent
        {
            set
            {
                if (value.Rows.Count != 0)
                {
                    DataRow row = value.Rows[0];

                    // Both Or Right
                    if (CurrentMenuType == "Right" && (row["Parent_MenuPosition"].ToString() == "0" || row["Parent_MenuPosition"].ToString() == "1"))
                    {
                        MenuRightGridView.DataSource = value;
                        MenuRightGridView.DataBind();
                    }

                    else // Both Or Footer
                        if (CurrentMenuType == "footer" && (row["Parent_MenuPosition"].ToString() == "0" || row["Parent_MenuPosition"].ToString() == "2"))
                        {
                            MenuFooter1DataList.DataSource = value;
                            MenuFooter1DataList.DataBind();
                        }

                }
            }

        }

        protected void LogLinkButton_Click(object sender, EventArgs e)
        {

            HttpCookie userCookie = Request.Cookies["CustomerInfo"];
            if (userCookie != null)
            {
                CookieManager cookieManager = new CookieManager();
                cookieManager.ClearOrderCookies();
                cookieManager.ClearUserCookies();

                // Refresh the page
                Response.Redirect(ConfigurationManager.AppSettings["WebsiteUrl"]);
                //Response.Redirect("~/default.aspx");
                //Response.Redirect(Request.Url.ToString());
            }
            else
                Response.Redirect("~/Portals/Login/");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie userCookie = Request.Cookies["CustomerInfo"];

                if (userCookie != null)
                {
                    LogLinkButton.Text = "Logout";
                }
                else
                    LogLinkButton.Text = "Login";

                LogLinkButton.DataBind();
            }
        }
    }
}