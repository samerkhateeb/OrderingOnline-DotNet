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

public partial class Portals_Controls_UC_TabsNews : System.Web.UI.UserControl
{

    int tableIndex;

    public DataSet DataContent
    {
        set
        {
         DataSet dataSet = value;

         foreach (DataTable dataTable in dataSet.Tables)
         {
             tableIndex = dataSet.Tables.IndexOf(dataTable);
             
             TabPanel tabPanel = (TabPanel) NewsTabContainer.Tabs[tableIndex];
             tabPanel.HeaderText =  dataTable.Rows[0]["Parent_Title"].ToString();
             tabPanel.Visible = true;

             DataList dataList = (DataList)tabPanel.FindControl("DataList" + (tableIndex + 1)); 
             dataList.DataSource = dataTable;
             dataList.DataBind();


             if ((bool)dataTable.Rows[0]["DCAT_LayoutTabsActive"])
                 NewsTabContainer.ActiveTab = tabPanel;
             //else
             //    tabPanel.HeaderText += " | ";

         }
         NewsTabContainer.DataBind();
            //DataTable dataTable = value;
            //AjaxControlToolkit.TabPanel tabPanel = new AjaxControlToolkit.TabPanel();
            //tabPanel.ID = "TabsPanel" + dataTable.Rows[0]["ID"];
            //TabMidContainer.Tabs.Add(tabPanel);
            //tabPanel.HeaderTemplate = new ListItemType;

            //if ((bool)dataTable.Rows[0]["DCAT_LayoutTabsActive"])
            //    TabMidContainer.ActiveTab = tabPanel;

            //dataTable = value;

            //DataList1.DataSource = value;
            //DataList1.DataBind();
            
            //CreateTab(value);
            
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
      //  this.Page.LoadComplete +=new EventHandler(CreateTabsEvent);
    }

    //public void CreateTabsEvent (object sender, EventArgs e)
    //{
    //    CreateTab(dataTable);
    //}
    //private void CreateTab (DataSet dataSet)
    //{
    //    TabContainer tabContainer = new TabContainer();
    //    tabContainer.ID = "TabContainer2";
        
    //    //dataSet.Tables.IndexOf(dataTable);

    //    foreach (DataTable dataTable in dataSet.Tables)
    //    {
    //        TabPanel tabPanel = new TabPanel();
    //        DataList dataList = DataList1;
    //        dataList.DataSource = dataTable;
    //        dataList.DataBind();

    //        tabPanel.HeaderTemplate = new DynamicallyCreatedTemplate(ListItemType.Header, dataSet.Tables.IndexOf(dataTable),
    //        tabContainer, dataTable.Rows[0]["DCAT_Title"].ToString());
    //        tabPanel.Controls.Add(dataList);
    //        tabContainer.Tabs.Add(tabPanel);
            
    //    }
        
    //       this.Controls.Add(tabContainer);
    //}

    //public class DynamicallyCreatedTemplate : ITemplate
    //{

    //    ListItemType _itemType;
    //    int _index;
    //    TabContainer _tabContainer;
    //    string _tabHeader ;

    //    public DynamicallyCreatedTemplate(ListItemType itemType, int index, TabContainer tabContainer, string tabHeader)
    //    {
    //        _itemType = itemType;
    //        _index = index;
    //        _tabContainer = tabContainer;
    //        _tabHeader = tabHeader;
    //    }

    //    public void InstantiateIn(System.Web.UI.Control container)
    //    {

    //        switch (_itemType)
    //        {
    //            case ListItemType.Header:
    //                LiteralControl literalControl = new LiteralControl(_tabHeader);
    //                container.Controls.Add(literalControl);

    //                //LinkButton lb = new LinkButton();
    //                //lb.ID = "nextButton";
    //                //lb.Text = "next";
    //               // lb.Click += new EventHandler(lb_Click);
    //               // container.Controls.Add(lb);


    //                break;
    //            case ListItemType.Item: break;
    //        }

    //    }
       

    //}
    

}
