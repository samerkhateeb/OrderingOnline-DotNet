using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

namespace Popup
{
    public partial class PopupOrderType : System.Web.UI.UserControl
    {
        //public DataTable Grid_Datacontent
        //{
        //    set
        //    {
        //        GridsDropDownList.DataSource = value;
        //        GridsDropDownList.DataTextField = "Grid_Name";
        //        GridsDropDownList.DataValueField = "Grid_Code";
        //        GridsDropDownList.DataBind();
        //        GridsDropDownList.Items.Insert(0, new ListItem("--- Select Area ---", "0"));
        //        GridsDropDownList.SelectedIndex = 0;
        //    }
        //}


        //public DataTable Blocks_Datacontent
        //{
        //    set
        //    {
        //        //BlocksDropDownList.DataSource = value;
        //        //BlocksDropDownList.DataTextField = "Block_Name";
        //        //BlocksDropDownList.DataValueField = "Block_GridCode";
        //        //BlocksDropDownList.DataBind();

        //        BlocksFullDropDownList.DataSource = value;
        //        BlocksFullDropDownList.DataTextField = "Block_Name";
        //        BlocksFullDropDownList.DataValueField = "Block_GridCode";
        //        BlocksFullDropDownList.DataBind();

        //    }
        //}


          public DataTable GridsLocations_Datacontent
        {
            set
            {
                GridAllDropDownList.DataSource = value;
                GridAllDropDownList.DataTextField = "Location_Code";
                GridAllDropDownList.DataValueField = "Grid_Code";
                GridAllDropDownList.DataBind();

                DataView dataView = value.DefaultView;
                DataTable dataTable = dataView.ToTable(true, "Location_Code", "Location_Name");

                LocationsDropDownList.DataSource = dataTable;
                LocationsDropDownList.DataTextField = "Location_Name";
                LocationsDropDownList.DataValueField = "Location_Code";
                LocationsDropDownList.DataBind();

                LocationsDropDownList.Items.Insert(0, new ListItem("--- Select Location ---", "0"));
                LocationsDropDownList.SelectedIndex = 0;

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), 
                                                     "ControlClientIDs",
                                                     @" var LocationsDropDownList = '" + LocationsDropDownList.ClientID +
                                                     "', GridsDropDownList = '" + GridAllDropDownList.ClientID + 
                                                     "';"
                                                     , true);

        }
    }
}