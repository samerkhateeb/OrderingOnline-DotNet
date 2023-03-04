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
using KFGCMS.BLL;


public partial class Left : System.Web.UI.UserControl
{
    int loopIndex = 0, TablesCount = 0;

    public string CurrnetType
    {
        set
        {
            CurrentTypeHiddenField.Value = value;

        }

        get
        {
            return CurrentTypeHiddenField.Value;
        }
        

    }


    public DataSet DataContent
    {
        set
        {
            DataSet dataSet = value;

            TablesCount = dataSet.Tables.Count;

            DataRow rowView = dataSet.Tables[0].Rows[0];
            DataTable masterDataTable = new DataTable();
            masterDataTable.Columns.Add(new DataColumn("ParentID"));
            GridView ChildGridView;

            // this to create parent rows according to the tables inside it.
            for (loopIndex = 0; loopIndex < TablesCount; loopIndex++)
                masterDataTable.ImportRow(rowView);


            LeftParentGridView.DataSource = masterDataTable;
            LeftParentGridView.DataBind();
            loopIndex = 0;
            foreach (DataTable dataTable in dataSet.Tables)
            {

                // find the row to get child gridview inside
                GridViewRow row = LeftParentGridView.Rows[loopIndex];

             //   if (dataTable.Rows[0]["Parent_SkinID"].ToString() == "0")
                    // Init Grid Items
                    ChildGridView = (GridView)row.FindControl("LeftImageGridView");
                    
                //else
                //    ChildGridView = (GridView)row.FindControl("LeftStaticGridView");


                ChildGridView.DataSource = dataTable;
                ChildGridView.DataBind();

                    // Init Grid Header Text & footer More Link Values
                    GridViewRow HeaderRow = ChildGridView.HeaderRow,
                                FooterRow = ChildGridView.FooterRow;

             //   HyperLink HeaderHyperLink = row.FindControl("HeaderHyperLink") as HyperLink;
               // HtmlGenericControl ChildGridHeader = row.FindControl("ChildGridHeader") as HtmlGenericControl;

                    //if (HeaderHyperLink != null)
                    //{
                    //    if (CurrnetType == "right")
                    //    {
                    //        ChildGridHeader.Attributes.Add("class", "Container_Right_Header_Div");
                    //    }
                    //    else
                    //        if (CurrnetType == "left")
                    //        {
                    //            ChildGridHeader.Attributes.Add("class", "Container_Left_Header_Div");
                    //        }
                    //        else
                    //            if (CurrnetType == "mid")
                    //            {
                    //                ChildGridHeader.Attributes.Add("class", "Container_Mid_Header_Div");
                    //            }
                        //HeaderHyperLink.Text = dataTable.Rows[0]["Name"].ToString();
                        //HeaderHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(dataTable.Rows[0]["ID"], String.Format("{0}", "SubPage"), dataTable.Rows[0]["Type"], dataTable.Rows[0]["STATICLINK"]);
                        //HeaderHyperLink.DataBind();
                   // }
                    
                    
                    //HyperLink MoreHyperLink = FooterRow.FindControl("MoreHyperLink") as HyperLink;
                    //if (MoreHyperLink != null)
                    //{
                    //    MoreHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(dataTable.Rows[0]["ParentID"], String.Format("{0}", "CATEGORY"), dataTable.Rows[0]["Parent_Type"], dataTable.Rows[0]["PARENT_STATICLINK"]);
                    //}

                    //Label HeaderLabel = HeaderRow.FindControl("HeaderLabel") as Label;
                    //HeaderLabel.Text = dataTable.Rows[0]["PARENT_Name"].ToString();
                    
                loopIndex++;
            }
        }
    }


  
}
