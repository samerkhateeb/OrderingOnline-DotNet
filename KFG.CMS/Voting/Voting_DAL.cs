using System;
using System.Data;
using System.Configuration;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;


namespace KFGCMS.BLL
{
    class Voting_DAL
    {
        public Voting_DAL()
        {

        }
        public static DataSet Voting_QuestionSelect()
        {
            DataSet ds;
            return ds = SqlHelper.ExecuteDataset(Global_Base.Getconnection(), "SP_VOTING_SELECT");

        }
        public static DataSet Voting_Update(string itemID, object questionID, string language)
        {
            return SqlHelper.ExecuteDataset(Voting_Base.GetConnection(), "SP_VOTING_Question_UPDATE", itemID, questionID, language);   
        }

        public static DataSet Voting_Result(string questionID, string language)
        {
            return SqlHelper.ExecuteDataset(Voting_Base.GetConnection(), "SP_VOTING_RESULT", questionID, language);   

        }
    }
}
