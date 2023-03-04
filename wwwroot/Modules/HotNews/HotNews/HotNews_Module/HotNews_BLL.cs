using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KFGCMS.BLL;


namespace HotNews_Module
{
    public class HotNews_BLL
    {
        #region Memebers
        static string active = "";
        #endregion

        public static List<string> Generate(DataTable NewsDataTable)
        {
            int count = 0;
            StringBuilder ItemsStringBuilder = new StringBuilder(),
                    ulStringBuilder = new StringBuilder();
            count = NewsDataTable.Rows.Count;
            foreach (DataRow row in NewsDataTable.Rows)
            {
                ItemsStringBuilder.Append(
                    String.Format(@"<LI>
                                <a href='{1}'>
                                <img width='850' height='380' align='right' border='0' alt='{0}'src='{2}' ></a>", 
                                row["Name"],
                                GetEncodedLink(row),
                                Media_BLL.ProcessImage(row["Thumbnail"])));

                //ulStringBuilder.Append(String.Format(@"<LI><A class='slide{0}{1}' href='javascript:void(0)'>{0}</A></LI>",count, active));
                active = "";
                count--;

            }
            List<string> NewsResult = new List<string>();

            NewsResult.Add(ItemsStringBuilder.ToString());
           // NewsResult.Add(ulStringBuilder.ToString());
            return NewsResult;
        }

        private static object GetEncodedLink(DataRow row)
        {
            if (row["Source"].ToString().ToLower() == "subpage")
                return Pages_BLL.GenerateUrl(row["ID"], row["Source"], row["Type"], row["StaticLink"]);
            else
                return Pages_BLL.GenerateUrl(row["ParentID"], row["Source"], row["Parent_Type"], row["Parent_StaticLink"]);

        }

    }
}
