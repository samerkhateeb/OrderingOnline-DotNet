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
using Microsoft.ApplicationBlocks.Data;
using KFGCMS.BLL;

public partial class Portals_Controls_UC_Comment : System.Web.UI.UserControl
{
    #region Members
    int commentStatus;
    string commentMessage = "عملية الإدخال لم تكتمل ... يرجى المحاولة لاحقاً";

    #endregion

    public DataTable DataContent
    {
        set
        {
            CommentGridView.DataSource = value;
           
            if (value != null && value.Rows.Count != 0)
                CommentGridView.ShowHeader = true; 
            CommentGridView.DataBind();
        }
    }

    public string LanguageChangeText
    {
        set
        {
            CommentHeaderLabel.Text = Site_Info.CommentTitle;
            NameLabel.Text = Site_Info.CommentName;
            EmailLabel.Text = Site_Info.CommentEmail;
            ContentLabel.Text = Site_Info.CommentContent;
        }
    }

    public string ObjectID
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

    public string ObjectSource
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

    public string PageTitle
    {
        set
        {
            TitleHiddenField.Value = value;
        }

        get
        {
            return TitleHiddenField.Value;
        }
    }

   
    protected void SendLinkButton_Click(object sender, EventArgs e)
    {
        try
        {
             SqlHelper.ExecuteNonQuery(Global_Base.Getconnection(), "SP_OBJECT_COMMENT_INSERT", 
                                            ObjectID, 
                                            NameTextBox.Text, 
                                            EmailTextBox.Text, 
                                            DetailsTextBox.Text, 
                                            ObjectSource, 
                                            DateTime.Now.AddHours(Double.Parse(ConfigurationManager.AppSettings["Timedifference"].ToString())).ToString(), 
                                            Pages_BLL.GetLanguage());



            //Comment_Info.CommentName = NameTextBox.Text;
            //Comment_Info.CommentDetails = DetailsTextBox.Text;
            //Comment_Info.CommentEmail = EmailTextBox.Text;

            //// get this when making ajax
            //Comment_Info.SourceName = ObjectSource;
            //Comment_Info.SourceID = ObjectID;


            //Comment_Info.CommentDate = ;

            //commentStatus = Comment_BLL.Comment_Insert();
          //  if (commentStatus == -1)
                commentMessage = "شكرا لتواصلكم معنا";


            NameTextBox.Text = "";
            DetailsTextBox.Text = "";
            EmailTextBox.Text = "";

            ResultLabel.Text = commentMessage;
            ResultLabel.DataBind();
            // Global_BLL.Alert (this, commentMessage);
        }

        catch (Exception exc)
        {
            ExceptionsLog_BLL.SaveException(exc, "Portal.UI", this.GetType().Name);
            ResultLabel.Text = "";
        }
        finally
        {
            Pages_BLL.ChangePageTitle(this.Page, TitleHiddenField.Value);
        }
       
    }

    /// <summary>
    /// Set Comment Row Number
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void CommentGridView_DataBound(object sender, EventArgs e)
    {
        foreach (GridViewRow row in CommentGridView.Rows)
        {
            ((Label)row.Cells[0].FindControl("NumberLabel")).Text = (row.RowIndex+1).ToString() + ".&nbsp;";
        }
    }
}
