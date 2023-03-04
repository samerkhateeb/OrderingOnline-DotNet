using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KFGCMS.BLL;

namespace Category
{
    public partial class Category : System.Web.UI.UserControl
    {
        #region Members
            DataTable dataTable, 
                CategoryDataTable = new DataTable(),
                TempDataTable = new DataTable();
            DataRow row, tempRow;
        #endregion
       
        public DataTable DataContent
        {
            set
            {
                //HttpCookie cookie = Request.Cookies["OrderType"];
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "stringtype", String.Format("alert('{0},{1}');", cookie.Value, cookie.Expires), true);

                //HttpCookie coo = new HttpCookie("myown");
                //coo.Value = "how are you";
                //Response.Cookies.Add(coo);

                string language = Pages_BLL.GetLanguage();

                dataTable = value;
                
                DataRow row = dataTable.Rows[0];

                CategoryGridView.DataSource = value;
                CategoryGridView.DataBind();

               

                int Skin = Convert.ToInt32(value.Rows[0]["Parent_SkinID"]);

                if (Skin == 3)
                {
                    foreach (GridViewRow gridRow in CategoryGridView.Rows)
                    {
                        row = value.Rows[gridRow.RowIndex];

                        Panel Skin3Panel = gridRow.FindControl("Skin3Panel") as Panel;
                        HyperLink HeaderHyperLink = gridRow.FindControl("HeaderHyperLink") as HyperLink;
                        Label DescriptionLabel = gridRow.FindControl("DescriptionLabel") as Label;
                        Image Skin3Image = gridRow.FindControl("Skin3Image") as Image,
                              NewImage = gridRow.FindControl("NewImage") as Image;
                        DataList Skin3DataList = gridRow.FindControl("Skin3DataList") as DataList;


                        Skin3Image.ImageUrl = String.Format("{0}", Global_BLL.FilterImagePathToThumbnail(row["Thumbnail"]));

                        // check the status for the New Image
                        if (!String.IsNullOrEmpty(row["NewIconStatus"].ToString()))
                        {
                            NewImage.Visible = Convert.ToBoolean(row["NewIconStatus"]);

                            // Change the CSS for the Description if there is a description
                            if (!String.IsNullOrEmpty(row["Description"].ToString().Trim(' ')))
                                DescriptionLabel.CssClass = "Category_Skin3_Row_Description_WithNewImage";

                        }
                        

                       //HeaderHyperLink.Text = row["Name"].ToString();
                       // HeaderHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(row["ID"],"SubPage",row["Type"],row["StaticLink"]);
                      //  ImageHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(row["ID"], "SubPage", row["Type"], row["StaticLink"]);
                        if (!String.IsNullOrEmpty(row["Description"].ToString()))
                            DescriptionLabel.Text = row["Description"].ToString();


                        Skin3DataList.DataSource = GenerateModifiersDataTable(row, Skin, gridRow.RowIndex);
                        Skin3DataList.DataBind();
                        Skin3Panel.Visible = true;



                    }
                }

                //int rowIndex = 0;

                //RootHyperLink.Text = row["Root_Name"].ToString();
                //RootHyperLink.NavigateUrl = Pages_BLL.GenerateMenuUrl(row["RootID"], "Page", row["Root_Type"], row["Root_StaticLink"]);

                //ParentHeaderLabel.Text = row["Parent_Title"].ToString();
                ////ParentHeaderHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(row["ParentID"], "Category", row["Parent_Type"], row["Parent_StaticLink"]);

                //HeaderHyperLink.Text = row["Name"].ToString();
                //HeaderHyperLink.NavigateUrl = Pages_BLL.GenerateUrl(row["ID"], "SubPage", row["Type"], row["StaticLink"]);

                //ParentImage.ImageUrl = Global_BLL.FilterImagePathToThumbnail(row["Thumbnail"]);
                //HeaderDescriptionLabel.Text = row["Description"].ToString();

                //PathParentLabel.Text = row["Parent_Title"].ToString();

                //InitDataTable(dataTable);

                //dataTable.Rows.RemoveAt(0);

               
            }
        }



        DataTable GenerateModifiersDataTable(DataRow row, int skinSize, int RowID)
        {
            TempDataTable = new DataTable();
            TempDataTable.Columns.Add("ID");
            TempDataTable.Columns.Add("ItemSorting");
            TempDataTable.Columns.Add("RowID");
            TempDataTable.Columns.Add("CAT_Type_Name");
            TempDataTable.Columns.Add("CAT_Type_Status");
            TempDataTable.Columns.Add("CAT_Type_Sorting");
            TempDataTable.Columns.Add("SP_Type_Price");
            TempDataTable.Columns.Add("SkinSize");

            //TempDataTable.Columns.Add("SP_Type_Status");
            TempDataTable.Columns.Add("SP_Type_Code");

            //string cookieValue = GetCookie();
            string cookieValue = "HD";
            for (int i = 1; i < skinSize+1; i++)
            {
                try
                {
                    DataRow currentRow = TempDataTable.NewRow();
                    currentRow["CAT_Type_Name"] = row["CAT_Type" + i + "_Name"];
                    currentRow["CAT_Type_Status"] = row["CAT_Type" + i + "_Status"];
                    currentRow["CAT_Type_Sorting"] = row["CAT_Type" + i + "_Sorting"];
                    currentRow["SP_Type_Price"] = row["SP_Type" + i + "_Price"];
                    //currentRow["SP_Type_Status"] = row[String.Format("SP_Type{0}_{1}_Status",i,cookieValue)];
                    currentRow["SP_Type_Code"] = row[String.Format("SP_Type{0}_{1}_Code", i, cookieValue)];
                    currentRow["ItemSorting"] = i;
                    currentRow["RowID"] = RowID;
                    currentRow["ID"] = row["ID"]; ;
                    currentRow["SkinSize"] = skinSize;

                    // check if the Selected Order Type are available
                    if(Convert.ToBoolean(row[String.Format("SP_Type{0}_{1}_Status",i,cookieValue)]))
                    TempDataTable.Rows.Add(currentRow);
                }

                catch {}
                
            }

            return TempDataTable;
        }

        string GetCookie()
        { 
            HttpCookie cookie = Request.Cookies["Order"];
            if (cookie != null)
            {
                return cookie["OrderType"].ToString();
            }
            else
                return "";
        }

        //public void InitDataTable(DataTable dataTable)
        //{
        //    // remove the first news
        //    dataTable.Rows.RemoveAt(0);

        //    for (int rowIndex = 0; rowIndex < 15; rowIndex++)
        //    {
        //        if (dataTable.Rows.Count != 0)
        //        {
        //            //add row to image categroy table.
        //            CategoryDataTable.ImportRow(dataTable.Rows[0]);

        //            // remove row from the gridview table
        //            dataTable.Rows.RemoveAt(0);
        //            //  rowIndex++;
        //        }
        //        else
        //            break;
        //    }
        //}


        //public string DataTableType(DataTable dataTable)
        //{
        //    row = dataTable.Rows[0];
        //    return row["TableType"].ToString();
        //}

        //protected void CategoryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    //   System.Threading.Thread.Sleep(1000);
        //    DataSet dataSet = Pages_BLL.ObjectData(CatID, Source, Type);
        //    string tableType = "";
        //    foreach (DataTable ChildDataTable in dataSet.Tables)
        //    {
        //        // get table type
        //        tableType = DataTableType(ChildDataTable);

        //        // check if table is empty or not
        //        if (row[0].ToString().ToLower() == "empty")
        //        {
        //            continue;
        //        }

        //        switch (tableType.ToLower())
        //        {
        //            case "content":
        //                {
        //                    // Init Page Title
        //                    Pages_BLL.ChangePageTitle(this.Page, dataSet.Tables[0].Rows[0]["Title"].ToString());

        //                    InitDataTable(ChildDataTable);

        //                    //  Category GridView DataSource
        //                    if (ChildDataTable.Rows.Count != 0)
        //                    {
        //                        CategoryGridView.DataSource = ChildDataTable;
        //                        CategoryGridView.DataBind();
        //                    }


        //                    break;
        //                }
        //        }
        //    }

        //    CategoryGridView.PageIndex = e.NewPageIndex;
        //    CategoryGridView.DataBind();
        //}
    }
}