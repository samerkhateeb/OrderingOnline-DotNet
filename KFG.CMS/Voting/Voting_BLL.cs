using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KFGCMS.BLL
{
    public class Voting_BLL
    {

        public static DataSet Voting_Update(string itemID, object questionID, string language)
        {
            return Voting_DAL.Voting_Update(itemID, questionID, language);
        }

        public static DataSet Voting_Result(string questionID, string language)
        {
            return Voting_DAL.Voting_Result(questionID, language) ;

        }
    }
}
