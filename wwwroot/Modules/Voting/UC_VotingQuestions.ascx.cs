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
using System.Text;
using KFGCMS.BLL;

public partial class Portals_Controls_UC_VotingQuestions : System.Web.UI.UserControl
{

    public DataSet DataContent
    {
        set
        {
            DataSet dataSet = (DataSet)value;

            string language = Pages_BLL.GetLanguage(),
                        headerText= "";


            // init Parent Gridview
            VotingParentGridView.DataSource = dataSet.Tables[0];
            VotingParentGridView.DataBind();

            if (language == "arb")
            headerText = "التصويت";
            else
                headerText = "Voting and Surveys";
            
            // Init Grid Header
            //GridViewRow ParentHeaderRow = VotingParentGridView.HeaderRow;
            //if (ParentHeaderRow != null)
            //{
                //Label ParentHeaderLabel = ParentHeaderRow.FindControl("HeaderLabel") as Label;
                ParentHeaderLabel.Text = headerText;
                ParentHeaderLabel.DataBind();
            //}


            DataView dataView = new DataView(dataSet.Tables[1]);
            string questionID;
            foreach (GridViewRow row in VotingParentGridView.Rows)
            {
                questionID = dataSet.Tables[0].Rows[row.RowIndex]["VQuestion_ID"].ToString();

                // get child grid view inside this parent gridview row
                //GridView VotingChildGridView = VotingParentGridView.Rows[row.RowIndex].FindControl("VotingChildGridView") as GridView;

                //// init Child Grid View to Bind always with one row
                //VotingChildGridView.DataSource = ChildOneRow;
                //VotingChildGridView.DataBind();

                // filter Data View to get the question id
                dataView.RowFilter = String.Format("VAnswer_VQuestionID={0}", dataSet.Tables[0].Rows[row.RowIndex]["VQuestion_ID"]);

                // get and init the RadioButtonList in this child gridview
                RadioButtonList radioButtonList = row.FindControl("VotingRadioButtonList") as RadioButtonList;
                radioButtonList.DataSource = dataView;
                radioButtonList.DataTextField = "VAnswer_Name" + language;
                radioButtonList.DataValueField = "VAnswer_ID" ;

                radioButtonList.DataBind();


                // Init Submit Button Value
                LinkButton SubmitLinkButton = row.FindControl("SubmitLinkButton") as LinkButton,
                            ResultLinkButton = row.FindControl("ResultLinkButton") as LinkButton;
                
                // Set Validation to current controls in this row
                RequiredFieldValidator validation = row.FindControl("VotingRequiredFieldValidator") as RequiredFieldValidator;
                validation.ControlToValidate = radioButtonList.ID;
                validation.ValidationGroup = "Voting" + row.RowIndex;
                SubmitLinkButton.ValidationGroup = "Voting" + row.RowIndex;
                radioButtonList.ValidationGroup = "Voting" + row.RowIndex;


                // Voting Avaliability
                HttpCookie cookie = Request.Cookies["Voting" + questionID]; // always create cookie for any new question
                if (cookie == null)
                    cookie = new HttpCookie("Voting" + questionID); // check this value to check if user voted or not
                if (cookie["Question" + questionID] != null)
                    SubmitLinkButton.Enabled = false;
                
                Response.Cookies.Add(cookie);

                // Assign Question ID for Submit and Result LinkButtons
                SubmitLinkButton.CommandArgument = questionID;
                ResultLinkButton.CommandArgument = questionID;
                ResultLinkButton.CausesValidation = false;
              //  SubmitLinkButton.CommandName = dataSet.Tables[1].Rows[row.RowIndex]["VAnswer_Total"].ToString();

                Label HeaderLabel = row.FindControl("HeaderLabel") as Label;

                //set Question Header text 
                if (HeaderLabel!=null)
                    HeaderLabel.Text = dataSet.Tables[0].Rows[row.RowIndex]["VQuestion_Name" + language].ToString();

                //set submit linkbutton text according to current language
                //if (SubmitLinkButton != null)
                //{
                //    if (language == "arb")
                //        SubmitLinkButton.Text = "تصويت";
                //    else
                //        SubmitLinkButton.Text = "Vote";
                //}

                ////set result linkbutton text according to current language
                //if (ResultLinkButton != null)
                //{
                //    if (language == "arb")
                //        ResultLinkButton.Text = "النتيجة";
                //    else
                //        ResultLinkButton.Text = "Result";
                //}

            }
        }
    }

    



    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void VotingChildGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       



        //    Voting.Voting_Update(A, B, C, cookie["ID"].ToString());
        //    cookie["Status"] = "voted";
        //    ParticipateImageButton.Enabled = false;
        //}
        //else
        //{
        //    cookie["Status"] = "voted";
        //    ParticipateImageButton.Enabled = false;
        //    ParticipateImageButton.ImageUrl = "~/images/Voting_Btn__Selected.gif";
        //}
    }
    protected void VotingParentGridView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
     //   HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //HttpCookie cookie = Request.Cookies["VotingInfo"];

        //if (cookie == null)
        //{
        //    cookie = new HttpCookie("VotingInfo");
        //    cookie["Status"] = "new";
        //}

 //     System.Threading.Thread.Sleep(1000);

            try
            {
                if (e.CommandName == "result")
                    VotingPopup((Control)e.CommandSource, "result", e.CommandArgument);
                else
                {
                    GridViewRow row = (GridViewRow)((Control)e.CommandSource).Parent.Parent.Parent;
                    RadioButtonList radioButtonList = row.FindControl("VotingRadioButtonList") as RadioButtonList;

                    //int itemsCount = radioButtonList.Items.Count;
                    //double selectedAvarage,
                    //       total = Convert.ToDouble(e.CommandName);
                    //StringBuilder avarage = new StringBuilder();


                    string itemID = "";


                    foreach (ListItem item in radioButtonList.Items)
                    {
                        //  init selectedAvarage Value


                        // if item selected, add one to the selected item
                        if (item.Selected)
                        {
                            itemID = item.Value;
                            break;
                        }

                    }

                    // update selected value and return all voting result

                    VotingPopup((Control)e.CommandSource, itemID, e.CommandArgument);

                    LinkButton Submit = (LinkButton)((Control)e.CommandSource);
                    Submit.Enabled = false;

                }
                //DataSet VotingResultDataSet = Voting_BLL.Voting_Update(itemID, e.CommandArgument);
                

            }

            catch (Exception exc)
            {
                ExceptionsLog_BLL.SaveException(exc, "Portal.UI", this.GetType().Name);
            }
    }

    public void VotingPopup(Control control, string itemID, object QuestionID)
    {
        ScriptManager.RegisterClientScriptBlock(control, control.GetType(), "VotingPopup", String.Format("window.open('../VotingResult/?focus={0}&qid={1}&info={2}','VotingResultWindow{0}','menubar=0,resizable=0,scroll=true,width=500,height=300')", itemID, QuestionID,Request.QueryString["info"]), true);
    }
}
