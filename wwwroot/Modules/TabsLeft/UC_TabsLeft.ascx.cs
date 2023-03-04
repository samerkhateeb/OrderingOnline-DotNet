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
using AjaxControlToolkit;
using KFGCMS.BLL;

public partial class Portals_Controls_UC_TabsLeft : System.Web.UI.UserControl
{
    #region Members
    int tablesCount, rowResult, tableIndex = 0, loopIndex = 0;
    const int tabsCount = 3;
    DataList dataList;
    #endregion


    public DataSet DataContent
    {
        set
        {




        DataSet dataSet = value;

        tablesCount = dataSet.Tables.Count;
        if (tablesCount > tabsCount)
        {
            rowResult = tablesCount / tabsCount;

            if (tablesCount % tabsCount > 0)
                rowResult += 1;
        }
        else
            rowResult = 1; // tgeres at least one row in this grid

        tablesCount = dataSet.Tables.Count;

        DataRow rowView = dataSet.Tables[0].Rows[0];
        DataTable masterDataTable = new DataTable();
        masterDataTable.Columns.Add(new DataColumn("ParentID"));

        // this to create parent rows according to the tables inside it.
        for (loopIndex = 0; loopIndex < rowResult; loopIndex++)
            masterDataTable.ImportRow(rowView);


        ParentGridView.DataSource = masterDataTable;
        ParentGridView.DataBind();

        loopIndex = 0;
        DataTable dataTable;

            foreach( GridViewRow row in ParentGridView.Rows)
            {
                            
                 for (int index=tableIndex; index<tablesCount; index++)
                 { 
                     TabContainer TabLeftContainer = (TabContainer)row.FindControl("TabLeftContainer");

                     if (loopIndex > 2)
                     {
                         TabLeftContainer.DataBind();
                         loopIndex = 0;
                         break;
                     }

                     else
                     {
                         dataTable = dataSet.Tables[index];

                         TabPanel tabPanel = (TabPanel)TabLeftContainer.Tabs[loopIndex];
                         tabPanel.HeaderText = dataTable.Rows[0]["Parent_Title"].ToString();
                         tabPanel.Visible = true;


                         if ((bool)dataTable.Rows[0]["DCAT_LayoutTabLeftimage"])
                         dataList = (DataList)tabPanel.FindControl("DataList" + (loopIndex + 1)+"Image");
                         else
                             dataList = (DataList)tabPanel.FindControl("DataList" + (loopIndex + 1));

                         dataList.DataSource = dataTable;
                         dataList.DataBind();


                         if ((bool)dataTable.Rows[0]["DCAT_LayoutTabLeftActive"])
                             TabLeftContainer.ActiveTab = tabPanel;

                         HyperLink MoreHypeLink = (HyperLink)tabPanel.FindControl(String.Format("More{0}HyperLink", loopIndex + 1));
                         MoreHypeLink.NavigateUrl = Pages_BLL.GenerateUrl(dataTable.Rows[0]["ParentID"], "Category", dataTable.Rows[0]["Parent_Type"], dataTable.Rows[0]["Parent_StaticLink"]);

                         loopIndex++;
                         tableIndex++;

                     }
                     
                }
                     continue; // skip to second row
            }


        }
    }
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
