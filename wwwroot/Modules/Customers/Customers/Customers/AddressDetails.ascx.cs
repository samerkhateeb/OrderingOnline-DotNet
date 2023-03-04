using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_Module;
using System.Data;

namespace Customer
{
    public partial class AddressDetails : System.Web.UI.UserControl
    {

        public string GridID
        {
            get
            {
                return GridsDropDownList.SelectedValue.ToLower();
            }
            set
            {
                GridsDropDownList.SelectedValue = value;
            }
        }

        public string SetGrid { get; set; }


        public string BlockID
        {
            get
            {
                return BlockHiddenField.Value.ToLower();
            }
        }

        public string Building
        {
            get
            { 
                return BuildingTextBox.Text;
            }
            set
            {
                BuildingTextBox.Text = value;
            }
        }
        public String Street
        {
            get
            {
                return StreetTextBox.Text;
            }
            set
            {
                StreetTextBox.Text = value;
            }
        }

        public string Floor
        {
            get
            {
                return FloorTextBox.Text;
            }
            set
            {
                FloorTextBox.Text = value;
            }
        }

        public string Flat
        {
            get
            {
                return FlatTextBox.Text;
            }
            set
            {
                FlatTextBox.Text = value;
            }
        }

        public string OtherAddress
        {
            get
            {
                return AddressOtherTextBox.Text;
            }
            set
            {
                AddressOtherTextBox.Text = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DataTable gridDataTable;

                Customer_BLL bll = new Customer_BLL();
                DataTable GridDataTable = bll.Customer_SelectGrids();
                if (GridDataTable.Rows.Count != 0)
                {
                    GridsFullDropDownList.DataSource = GridDataTable;
                    GridsFullDropDownList.DataTextField = "Grid_Name";
                    GridsFullDropDownList.DataValueField = "Grid_Code";
                    GridsFullDropDownList.DataBind();

                    gridDataTable = bll.FilterGrids(GridDataTable);

                    GridsDropDownList.DataSource = gridDataTable;
                    GridsDropDownList.DataTextField = "Name";
                    GridsDropDownList.DataValueField = "Value";
                    GridsDropDownList.SelectedValue = SetGrid;
                    GridsDropDownList.DataBind();

                  //  GridsDropDownList.SelectedIndex = 0;



                    BlockDropDownList.DataSource = bll.FilterBlocks(GridDataTable, GridsDropDownList.SelectedValue);
                    BlockDropDownList.DataTextField = "Name";
                    BlockDropDownList.DataValueField = "Value";
                    BlockDropDownList.DataBind();

                }
            }

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ControlsIDs", @"var RegisterGridsDropDownList='" + GridsDropDownList.ClientID
                                                                                                      + "', RegisterBlocksDropDownList='" + BlockDropDownList.ClientID
                                                                                                      + "',RegisterGridsFullDropDownList='" + GridsFullDropDownList.ClientID + "',"
                                                                                                      + "BlockHiddenField ='#" + BlockHiddenField.ClientID + "';", true);

        }
    }
}