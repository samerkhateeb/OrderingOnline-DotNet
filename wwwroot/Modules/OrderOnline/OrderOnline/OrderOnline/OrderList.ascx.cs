using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace OrderOnline
{
    public partial class OrderList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ControlsIDs",
                            String.Format("var deliveryCharge = {0}, NoteTextBox = '{1}';", 
                                                ConfigurationManager.AppSettings["DeliveryCharge"],
                                                NoteTextBox.ClientID), true);
        }
    }
}