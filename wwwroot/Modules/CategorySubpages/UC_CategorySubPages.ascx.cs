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

public partial class Portals_Controls_UC_CategorySubPages : System.Web.UI.UserControl
{
    DataTable dataTable ,
    CategoryDataTable = new DataTable();
    DataRow row;
    public DataTable DataContent
    {
        set
        {

            string language = Pages_BLL.GetLanguage();
 
            dataTable = value;
            DataRow row = dataTable.Rows[0];
            //CategoryDataTable.Columns.Add("ID");
            //CategoryDataTable.Columns.Add("Title");
            //CategoryDataTable.Columns.Add("Description");
            //CategoryDataTable.Columns.Add("Type");
            //CategoryDataTable.Columns.Add("StaticLink");
            //CategoryDataTable.Columns.Add("Thumbnail");
            
           

            int rowIndex = 0;

            RootHyperLink.Text = row["Root_Title"].ToString();
            RootHyperLink.NavigateUrl = Pages_BLL.GenerateMenuUrl(row["RootID"], "Page", row["Root_Type"], row["Root_StaticLink"]);

            ParentHeaderLabel.Text = row["Parent_Title"].ToString();
            //ParentHeaderHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(row["ParentID"], "Category", row["Parent_Type"], row["Parent_StaticLink"]);

            HeaderHyperLink.Text = row["Title"].ToString();
            HeaderHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(row["ID"], "SubPage", row["Type"], row["StaticLink"]);

            ParentImage.ImageUrl = Global_BLL.FilterImagePathToThumbnail(row["Thumbnail"]);
            HeaderDescriptionLabel.Text = row["Description"].ToString();
            
            //PathParentLabel.Text = row["Parent_Title"].ToString();

            //InitDataTable(dataTable);

            dataTable.Rows.RemoveAt(0);

            //for (rowIndex = 0; rowIndex < 15; rowIndex++)
            //{
            //    if (dataTable.Rows.Count != 0)
            //    { 
            //        //add row to image categroy table.
            //        CategoryDataTable.ImportRow(dataTable.Rows[0]);

            //        // remove row from the gridview table
            //        dataTable.Rows.RemoveAt(0);
            //      //  rowIndex++;
            //    }
            //    else
            //        break;
            //}
            


            // Category DataList DataSource
            //CategoryDataList.DataSource = dataTable;
            //CategoryDataList.DataBind();

           //  Category GridView DataSource
            if (dataTable.Rows.Count != 0)
            {
                CategoryGridView.DataSource = dataTable;
                CategoryGridView.DataBind();

                Label HeaderLabel = CategoryGridView.HeaderRow.FindControl("HeaderLabel") as Label;
                if (language == "arb")
                    HeaderLabel.Text = "إقرأ أيضاُ: ";
                else
                    HeaderLabel.Text = "Read More: ";
                
                HeaderLabel.DataBind();

            }
        }
    }




    public void InitDataTable(DataTable dataTable)
    {
        // remove the first news
        dataTable.Rows.RemoveAt(0);

        for (int rowIndex = 0; rowIndex < 15; rowIndex++)
        {
            if (dataTable.Rows.Count != 0)
            {
                //add row to image categroy table.
                CategoryDataTable.ImportRow(dataTable.Rows[0]);

                // remove row from the gridview table
                dataTable.Rows.RemoveAt(0);
                //  rowIndex++;
            }
            else
                break;
        }
    }

    public  string CatID
    {
        set
        {
            IDHiddenField.Value = value;
        }
        get
        {
            return IDHiddenField.Value;
        }
    }



    public  string Source
    {
        set
        {
            SourceHiddenField.Value = value;                
        }
        get
        {
            return SourceHiddenField.Value;
        }
    }



    public string Type
    {
        set
        {
            TypeHiddenField.Value = value;
        }
        get
        {
            return TypeHiddenField.Value;
        }
    }

    public string DataTableType(DataTable dataTable)
    {
        row = dataTable.Rows[0];
        return row["TableType"].ToString();
    }

    protected void CategoryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
     //   System.Threading.Thread.Sleep(1000);
        DataSet dataSet = Pages_BLL.ObjectData(CatID, Source, Type);
        string tableType = "";
        foreach (DataTable ChildDataTable in dataSet.Tables)
        {
            // get table type
            tableType = DataTableType(ChildDataTable);

             // check if table is empty or not
                if (row[0].ToString().ToLower() == "empty")
                {
                    continue;
                }

                switch (tableType.ToLower())
                {
                    case "content":
                        {
                            // Init Page Title
                            Pages_BLL.ChangePageTitle(this.Page, dataSet.Tables[0].Rows[0]["Title"].ToString());

                            InitDataTable(ChildDataTable);

                            //  Category GridView DataSource
                            if (ChildDataTable.Rows.Count != 0)
                            {
                                CategoryGridView.DataSource = ChildDataTable;
                                CategoryGridView.DataBind();
                            }


                            break;
                        }
                }
        }

        CategoryGridView.PageIndex = e.NewPageIndex;
        CategoryGridView.DataBind();
    }
}
