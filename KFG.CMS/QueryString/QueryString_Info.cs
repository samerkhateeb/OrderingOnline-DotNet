using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KFGCMS.BLL
{
    public class QueryString_Info
    {
        /// <summary>
        /// the standar QueryString include ID, Source,Type, Language, QuestionnaireID, GroupID and DynamicID
        /// </summary>
        public static string StandardQueryString
        {
            get
            {
                return String.Format("ID={0}&Source={1}&Type={2}&language={3}&QuestionnaireID={4}&GroupID={5}&DynamicID={6}", QueryString_Info.ID, QueryString_Info.Source, QueryString_Info.Type, QueryString_Info.Language, QueryString_Info.QuestionnaireID, QueryString_Info.GroupID, QueryString_Info.DynamicID);
            }
        }

        public static string ID
        {
            set;
            get;
        }

        public static string Source
        {
            set;
            get;
        }

        public static string Type
        {
            set;
            get;
        }

        public static string Language
        {
            set;
            get;
        }

        public static string QuestionnaireID
        {
            set;
            get;
        }

        public static string GroupID
        {
            set;
            get;
        }

        public static string DynamicID
        {
            set;
            get;
        }



    }
}
