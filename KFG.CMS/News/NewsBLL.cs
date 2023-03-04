using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// Summary description for NewsBLL
/// </summary>
namespace KFGCMS.BLL
{
    public class NewsBLL
    {
        public NewsBLL()
        {

        }
        public static DataSet NewsDBGenerator()
        {
            return NewsDAL.NewsDBGenerator();
        }

        StringBuilder newsContent, newsLinks;

        public string[] NewsScriptGenerator(DataTable dataTable)
        {
            //DataSet dataSet = NewsDBGenerator();

            int i = 0;

            newsContent = new StringBuilder();
            newsLinks = new StringBuilder();

            newsContent.Append("<script language='JavaScript'>\n\n");

            string Title = "",
                   Link = "",
                   Thumbnail = "",
                   strProcThumbnail,
                   Description = "",
                   strType = "",
                   strID = "";

            foreach (DataRow row in dataTable.Rows)
            {
                strType = row["TYPE"].ToString();
                strID = row["ID"].ToString();
                switch (strType) // change type from "number" to "text" for separate it when news event
                {
                    case "1": strType = "Page";
                        break;

                    case "2": strType = "StaticLink";
                        break;

                    case "3": strType = "Photo";
                        break;

                    case "4": strType = "Audio";
                        break;

                    case "5": strType = "Video";
                        break;

                    case "6": strType = "Category";
                        break;

                }

                if (strType == "Photo")
                    strProcThumbnail = row["FileName"].ToString();


                else
                    if (String.IsNullOrEmpty(row["Thumbnail"].ToString()))
                        strProcThumbnail = ConfigurationManager.AppSettings["MediaEmptyThumbnail"].ToString();
                    else
                        strProcThumbnail = row["Thumbnail"].ToString();


                if (row["TBLID"].ToString() == "1")
                    Link = string.Format("javascript:RequestChildDataCollection(&#39;{0} Category {1}&#39;)", strID, strType);

                else
                    if (row["TBLID"].ToString() == "2")
                        Link = string.Format("javascript:RequestChildDataCollection(&#39;{0} Media {1}&#39;)", strID, strType);
                    else
                        if (row["TBLID"].ToString() == "3")
                            Link = string.Format("javascript:RequestChildDataCollection(&#39;{0} SubPage {1}&#39;)", strID, strType);


                Title = row["Title"].ToString();
                Thumbnail = "\\\\" + ConfigurationManager.AppSettings["LocalRoot"].ToString() + "\\\\" + ConfigurationManager.AppSettings["DirectoryPathMain"] + "\\\\" + FilterThumbnail(strProcThumbnail);
                Description = row["Description"].ToString();

                newsContent.Append(
                    String.Format("setMarkup('64875{0}','\\n<div class=\\\"preview\\\">\\n'"
                    + "+ '<div class=\\\"preview-image\\\">\\n'"
                    + "+ '<!-- image -->\\n<a href=\\\"{1}\\\" onmouseover=\\\"tooltip(event,this,\\\'{2}\\\');\\\">'"
                    + "+ '\\n<img width=265px height=240px src=\\\"{3}\\\" style=\\\"margin-left:0px;margin-top:0px\\\" border=\\\"0\\\" alt=\\\"\\\" />'"
                    + "+ '</a>\\n</div>\\n'"
                    + "+ '<div id=\\\"mainnews-caption\\\" class=\\\"noleadin\\\">\\n'"
                    + "+ '<div class=\\\"topstories-controls-cutout\\\">\\n<!--H1 Title-->\\n</div>\\n'"
                    + "+ '<div class=\\\"headline\\\"><a href=\\\"{1}\\\" onmouseover=\\\"tooltip(event,this,\\\'{2}\\\');\\\">{2}</a>\\n</div>\\n'"
                    + "+ '<div class=\\\"lead-in\\\">\\n{4}...\\n</div>\\n'"
                    + "+ '<div  style=\"font-familt:arial, serif; font-weight:bold; font-size: 16px; text-align:left;padding:0 0 0 5px;\"><hr /><br /><a href=\\\"{1}\\\">للمزيد إضغط هنا</a><div>'"
                    + "+ '</div>\\n</div>').parse();\n\n", i + 10, Link, Title, Thumbnail, Description)
                );

                newsLinks.Append(
                    String.Format("<div id=\"mainNews64862{0}\" class='iteminActive'>"
                                + "<div class=\"iteminner\">"
                                + "<div class=\"regitem-bullet\"> <a href=\"javascript:void(0);\" onmouseover=\"mainNewsItemMouseover('64862{0}')\""
                                + " onmouseout=\"mainNewsItemMouseout()\" onclick=\"_hbLink('[MainNewsHeadline]','{1}')\" tabindex=\"-1\" class=\"mnh1\"> "
                                + "{2}</a></div></div></div>"
                                , i + 10, i + 1, Title)
                                );
                i++;

            }

            newsContent.Append("\n\n</script>");

            string[] returnedValue = { newsContent.ToString(), newsLinks.ToString() };
            return returnedValue;
        }
        protected string FilterThumbnail(string thumbnail) // get the image name only to put '\\\\' before the image name to use it in javascript redering 
        {
            string[] separator = { "/", "//", "\\" };
            string imageName = "";
            foreach (string sub in thumbnail.Split(separator, StringSplitOptions.None))
            {
                imageName = sub;
            }

            return imageName;

        }


        //protected static string LinksScriptBuilder()
        //{
        //    StringBuilder linksScript = new StringBuilder();
        //    linksScript.Append("mainNewsPlaylist = new Playlist('mainNewsPlaylist');"
        //        + " mainNewsPlaylist.setInterval(20000);"
        //        + " mainNewsManager = new UrlPlaylistManager(mainNewsPlaylist);"
        //        + " mainNewsManager.lookupProducer = function(){return plPane.content;};"
        //        + " mainNewsManager.pane=getPane('topstories-widget');"
        //        + " mainNewsManager.transition = mnDefaultAnim;"
        //        + " mainNewsManager.activeClass = \"itemActive\";"
        //        + " mainNewsManager.inactiveClass = \"iteminActive\"; "
        //        + " mainNewsManager.addItems(["
        //        + " 'mainNews6486210','6487510','mainNews6486211','6487511','mainNews6486212','6487512',"
        //        + " 'mainNews6486213','6487513','mainNews6486214','6487514','mainNews6486215','6487515',"
        //        + " 'mainNews6486216','6487516','mainNews6486217','6487517','mainNews6486218','6487518',"
        //        + " 'mainNews6486219','6487519','mainNews6486220','6487520','mainNews6486221','6487521',"
        //        + " 'mainNews6486222','6487522','mainNews6486223','6487523','mainNews6486224','6487524']);"
        //        + " mainNewsPlaylist.play(mnQuickAnim);"
        //        + " mainNewsPlaylist.setInterval(13000);"
        //        + " var mnMarkup = new Markup();"
        //        + " mnMarkup.contentElement=document.getElementById('mnPlaylist');"
        //        + "plPane.setMarkup(mnMarkup);"
        //}

    }
}