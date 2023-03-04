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
using System.IO;
using System.Text;
using System.Net.Mail;
using System.Xml;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.ApplicationBlocks.Data;
using KFGCMS.Info;
using System.Data.SqlClient;
using KFGCMS.DAL;

/// <summary>
/// Summary description for Pages_BLL
/// </summary>
namespace KFGCMS.BLL
{
    public class Pages_BLL
    {
        #region Members.

        static string strDescription = "",
                      urlEncode = "",
                      newsBarImage = String.Format("<img src='{0}/images/NewsBarIcon.gif'>",ConfigurationManager.AppSettings["PortalAlias"]);
        static string[] newsBarSplitter = { "!@#", "||" };

        #endregion


        public Pages_BLL()
        {

        }



        //public string DataTableType(DataTable dataTable)
        //{
        //    string tableType = "";
            
        //    dataTable.Rows[0]
        //    if (dataTable.Rows.Count != 0)
        //    {
        //        return dataTable.Rows[0]["TableType"].ToString();
        //    }
        //    else
        //        return "empty";

        //}
      
        public static DataSet HomePage_Default (string counterStatus, DateTime dateTime, string language)
        {
          

            return Pages_DAL.HomePage(counterStatus, dateTime, language);
        }


        public static void SettingsSave(DataTable dataTable)
        {
            DataSet MasterdataSet = new DataSet();
            MasterdataSet.Tables.Add(dataTable.Copy());

            Pages_Info.pageSettings = MasterdataSet;
        }

        public static DataSet SettingsReturn()
        {
            
            return Pages_Info.pageSettings;
        }

        public static DataSet ObjectData_Static()
        {
            SqlCommand Command = new SqlCommand("KFGSP_OBJECT_CONTENT_STATIC");
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add("@ID", SqlDbType.Int).Value = 0;
            Command.Parameters.Add("@SOURCE", SqlDbType.NVarChar).Value = "control";
            Command.Parameters.Add("@TYPE", SqlDbType.Int).Value = 0;
            Command.Parameters.Add("@COUNTER_TYPE", SqlDbType.NVarChar).Value = "control";
            Command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = GetLanguage();

            return KFGDAL.ExecuteDataSet(Command);

           // return Pages_DAL.ObjectData_Static(0, "control", 0, "control", Pages_BLL.GetLanguage(), 0);
        }

        public static string GetLanguage()
        {
            string info, language = "eng";

            try
            {
                info = HttpContext.Current.Request.QueryString["info"];

                if (!String.IsNullOrEmpty(info))
                {
                    Global_BLL.DecodeUrlStatic(info);
                    if (!String.IsNullOrEmpty(QueryString_Info.Language))
                        language = QueryString_Info.Language;
                    else
                        language = "eng";

                }
            }

            catch (Exception exc)
            { 
                
            }
            
            return language;
        }



        public static string MenuSideGenerator()
        {
            return @"<a href='http://www.za-school.com/Portals/Content/?info=TlRNeUpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Menu_Right_GM'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TWpZbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_About'></a>
                     <a href='http://www.za-school.com/Portals/Category/?info=TVRBMUprTmhkR1ZuYjNKNUpqWW1ZWEppK3U=.plx' class='Menu_Right_Management'></a>
                     <a href='http://www.za-school.com/Portals/Category/?info=TVRZMEprTmhkR1ZuYjNKNUpqWW1ZWEppK3U=.plx' class='Menu_Right_Faculty'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TXpJbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_Depts'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TXpNbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_Culture'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TXpRbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_Exams'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TXpVbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_Students'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TXpZbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_Photo'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TXpjbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_Audio'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TVRjbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_Video'></a>
                     <a href='http://www.za-school.com/Portals/PageCats/?info=TXpnbVVHRm5aU1kySm1GeVlnPT0rdQ==.plx' class='Menu_Right_Advertisements'></a>
                    ";
        }


        public static string MenuItemStyleSelect(int count)
        {
            if (count == 0)
                return "Menu_Right_PresonalInfo";
            else
                 if (count == 1)
                     return "Menu_Right_Password";
            else
                 if (count == 2)
                     return "Menu_Right_MyPicture";
            else
                 if (count == 3)
                return "Menu_Right_PresonalInfo";
            else
                 if (count == 4)
                     return "Menu_Right_Inbox";
            else
                 if (count == 5)
                     return "Menu_Right_Favorite";
            else
                 if (count == 6)
                     return "Menu_Right_SearchAdvanced";
            else
                 if (count == 7)
                     return "Menu_Right_Ideal";
                 else
                     if (count == 8)
                         return "Menu_Right_UsersPictures";
                     else
                       //  if (count == 9)
                             return "Menu_Right_Users";

        }

        public static DataTable FooterMenuGenerator()
        {
            return SqlHelper.ExecuteDataset(Pages_Base.GetConnection(), "KFGSP_HOMEPAGE_MENU_Footer").Tables[0];
        }

       public static string  LogicalPath(string relativePath)
        {
            string RegExpressionString = "[\\\\|]";
            Regex regExpress = new Regex(RegExpressionString);
            return regExpress.Replace(relativePath, "/");
        }

       public string GenerateTopMenu()
       {
           string   loginLink = "",
                    loginText = "",
                    infoLink = "";

           // set the value for logged in user status
           bool loginFlage = HttpContext.Current.Request.Cookies["CourseUser"] == null? false:true;

           if (!String.IsNullOrEmpty(HttpContext.Current.Request.QueryString["Info"]))//decode the original Query String
            Global_BLL.DecodeUrlStatic(HttpContext.Current.Request.QueryString["Info"]);
           
           // Set Dynamic ID
             QueryString_Info.DynamicID = "1";
           // Encode the Query String Again and put it in infolink
            infoLink =  "?info=" + Global_BLL.EncodeUrl(QueryString_Info.StandardQueryString);

            if (!String.IsNullOrEmpty(HttpContext.Current.Request.QueryString["Info"]) && Pages_BLL.GetLanguage() == "eng")
            {

                Global_BLL.DecodeUrlStatic(HttpContext.Current.Request.QueryString["Info"]);

                //infoLink = "?info=" + Global_BLL.EncodeUrl(QueryString_Info.StandardQueryString);

                //infoLink = "?info=" + HttpContext.Current.Request.QueryString["Info"];

            }

           //updatedString = Global_BLL.EncodeUrl(
           
           // check if user logged in
           if (loginFlage)
           {
               loginText = Site_Info.TopMenu_Logout;
               loginLink = String.Format("{0}/Portals/Courses_Logout", ConfigurationManager.AppSettings["PortalAlias"]);
            }
           else // else change loggin text
           {
               loginText = Site_Info.TopMenu_Login;
               loginLink = String.Format("{0}/Portals/CoursesLoginRegistration{1}", ConfigurationManager.AppSettings["PortalAlias"], infoLink);
            }

//            return String.Format(@"<a href='{0}{8}{7}' >{1}</a>  |  
//                        <a href='{0}/Portals/DynamicsLoad' >{2}</a> "
              return String.Format(@" ", ConfigurationManager.AppSettings["PortalAlias"], 
                                                                  Site_Info.TopMenu_Home,
                                                                  Site_Info.TopMenu_CotnactUs,
                                                                  Site_Info.TopMenu_SiteMap,
                                                                  loginLink, loginText,
                                                                  Site_Info.TopMenu_Careers, infoLink,
                                                                  ConfigurationManager.AppSettings["WebsiteHome"]);
           
       }


       public static string MenuTop2()
       {
           return String.Format(@"  <a href='{0}{1}' class='Horizontal_Static_Home FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRreEpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_Idea FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRreUpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_Goals FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRrekpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_SignUpWay FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRrMEpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_PreRequests FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRrMUpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_Contact FloatRight'></a>
                                    <a href='{0}/Portals/Content/?info=TkRrMkpsTjFZbEJoWjJVbU1TWmhjbUk9K3U=.plx' class='Horizontal_Static_Prices FloatRight'></a>
                                    ", ConfigurationManager.AppSettings["PortalAlias"], ConfigurationManager.AppSettings["WebsiteHome"]);
       }


        /// <summary>
        /// retirve page content
        /// </summary>
        /// <param name="pageID"></param>
        /// <param name="pageType"></param>
        /// <returns></returns>
        public static DataSet ObjectData(object pageID, object thisSource, object pageType)
        {

            return ObjectData(pageID, thisSource, pageType, GetLanguage());
         // return Pages_DAL.ObjectData(pageID, thisSource, pageType, GetLanguage());
        }

         public static DataSet ObjectData(object pageID, object thisSource, object pageType, string language)
        {

            SqlCommand Command = new SqlCommand("KFGSP_Object_Data");
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.Add("@ID", SqlDbType.Int).Value = pageID;
            Command.Parameters.Add("@SOURCE", SqlDbType.NVarChar).Value = thisSource;
            Command.Parameters.Add("@TYPE", SqlDbType.Int).Value = pageType;
            Command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = language;

            return KFGDAL.ExecuteDataSet(Command);

          //  return Pages_DAL.ObjectData(pageID, thisSource, pageType, language);
        }

        public static string WeatherNow(Page page)
        {
            throw new Exception();

           // XmlTextReader reader = new XmlTextReader("http://xml.weather.yahoo.com/forecastrss?p=JOXX0002&u=c");
           // DataSet dataSet = new DataSet();
           // dataSet.ReadXml(reader);
           //return String.Format("درجة الحرارة الآن {0}س / {1}", dataSet.Tables["condition"].Rows[0]["temp"], Convert.ToDateTime(dataSet.Tables["condition"].Rows[0]["date"].ToString().Substring(0, 26)).ToString("H:mm"));
        }

        public static string DefaultStyleSheetPath(string language)
        {
            string prefex = language;
            //if (language == "arb")
            //    prefex = "_" + language;

            return String.Format(ConfigurationManager.AppSettings["DefaultStyleSheetPath"], prefex);
        }


        /// <summary>
        /// retirve categories for selected page
        /// </summary>
        /// <param name="pageID"></param>
        /// <param name="pageType"></param>
        /// <returns></returns>
        public static DataSet PageCategories(object pageID)
        {
            return Pages_DAL.PageCategories(pageID, GetLanguage());
        }

        /// <summary>
        /// retrive all subpages for this category..
        /// Note.. Here (Category) can also be media, this will set according to parameter type
        /// </summary>
        /// <param name="categoryID"> category ID</param>
        /// <param name="categoryType">category Type</param>
        /// <returns>DataSet</returns>
        public static DataSet CategorySubPages(object categoryID, object categoryType)
        {
            return Pages_DAL.CategorySubPages(categoryID, categoryType);
        }



        public static DataSet PagesData (string selectedKey, string name_type, string strMediaID)
        {
            return Pages_DAL.PagesData (selectedKey, name_type, strMediaID);
        }


        public static void ChangePageTitle(Page page, string pageTitle)
        {
            page.Title = String.Format("{0} {1}", ConfigurationManager.AppSettings["PagesTitle"], pageTitle);
        }

        /// <summary>
        /// only to generate Horizontal Menu Url's
        /// </summary>
        /// <param name="pageID">id for page</param>
        /// <param name="pageType">type will be only Home, Static Link, Simple Page or Category</param>
        /// <param name="staticLink"></param>
        /// <returns></returns>
        public static string GenerateMenuUrl(object pageID, object thisSource, object typeID, object staticLink)
        {
            return (GenerateMenuUrl(pageID, thisSource, typeID, staticLink, GetLanguage()));
        }



        public static string GenerateMenuUrl(object pageID, object thisSource, object typeID, object staticLink, string language)
        {
            string folderName = MenuTypeIDToFolderName(typeID);

            if (folderName.Equals("Home"))
                return ConfigurationManager.AppSettings["PortalAlias"].ToString() + ConfigurationManager.AppSettings["WebsiteHome"].ToString();
            else
                if (folderName.Equals("StaticLink"))
                    return staticLink.ToString();
                else
                {
                    urlEncode = Global_BLL.EncodeUrl(pageID, thisSource, typeID, language);
                    return String.Format("/Portals/{2}/?info={0}.{1}", urlEncode, ConfigurationManager.AppSettings["PortalExtension"], folderName);
                }
        }


        /// <summary>
        /// return folder name accirding to page type 
        /// </summary>
        /// <param name="typeID"></param>
        /// <returns></returns>
        public static string MenuTypeIDToFolderName(object typeID)
        {
            switch (typeID.ToString())
            {
                case "1" : // page simple
                    goto case "content";
                case "8": // subpage simple
                    goto case "content";

                case "2": // static link
                    return "StaticLink";
                   
                    
                case "7":
                    return "Home";

                case "6":
                    return "PageCats";

                case "3":
                goto case "Media";

                case "4":
                goto case "Media";

                case "5":
                goto case "Media";

                default:
                    return "PageCats";

                case "content":
                    return "Content";

                case "Media":
                    return "Media";
                   
            }
                       
                           
        }


        /// <summary>
        /// To Generate Any url to page
        /// </summary>
        /// <param name="pageID">id of page</param>
        /// <param name="pageType">type of page</param>
        /// <param name="staticLink">static link if exist</param>
        /// <returns></returns>
        public static string GenerateUrl(object pageID,object thisSource, object pageType, object staticLink)
        {
            return GenerateUrl(pageID, thisSource, pageType, staticLink, GetLanguage(),"");
        }


        public static string GenerateUrl(object pageID, object thisSource, object pageType, object staticLink, string language, params string[] quereyStrings)
        {
            string folderName = PageTypeIDToFolderName(pageType);

            if (folderName.Equals("Home"))
                return ConfigurationManager.AppSettings["PortalAlias"].ToString() + ConfigurationManager.AppSettings["WebsiteHome"].ToString();
            else
                if (folderName.Equals("StaticLink"))
                    return staticLink.ToString();
                else
                {
                    urlEncode = Global_BLL.EncodeUrl(pageID, thisSource, pageType, language);
                    return String.Format("/Portals/{2}/?info={0}.{1}", urlEncode, ConfigurationManager.AppSettings["PortalExtension"], folderName);
                }
        }

        public static string PageTypeIDToFolderName(object pageTypeID)
        {
            if (pageTypeID.ToString() == "1" || pageTypeID.ToString() == "8")
                return "Content";
            else

            if (pageTypeID.ToString() =="2")
                return "StaticLink";
            else
            if (pageTypeID.ToString() == "3" || pageTypeID.ToString() == "4" || pageTypeID.ToString() == "5")
                return "Media";
            
            else
            if (pageTypeID.ToString() == "6")
                return "Category";
            else
              //  if (pageTypeID.Equals("7"))
                return "Home";
        }

        public static string FilterDescriptionText(object descriptionText, int length)
        {
            strDescription = descriptionText.ToString();
            strDescription = strDescription.Length > length ? strDescription.Substring(0, length) : strDescription;
            return  strDescription;
            
            
        }


        /// <summary>
        /// Init Short News Link
        /// </summary>
        /// <param name="arrValue"></param>
        /// <returns></returns>
        public static String ShorNewsLink(List<object> arrValue)
        {

            object autostart = arrValue[1];
            if ((bool)autostart == true)
                autostart = 1;
            else
                autostart = 0;

            string rootPath = "../";

            return String.Format(@"<div class='ShortNewsDescription'>{2}</div><div class='ShortNewsDiv'>
            <embed  type='application/x-mplayer2' 
            pluginspage='http://www.microsoft.com/Windows/Downloads/Contents/MediaPlayer/'  
            width='100%'  height='100%'  src='{0}'  filename='{0}'  autostart='{1}'  showcontrols='1' 
            showstatusbar='0'  showdisplay='0'  autorewind='1'></embed></div>", rootPath + arrValue[0], autostart, arrValue[2]);

        }


        public static string NewsBarGenerator(string newsBarText)
        {
            StringBuilder newsBarBuilder = new StringBuilder(newsBarImage);
            

            foreach( string newsBarItem in newsBarText.Split(newsBarSplitter, StringSplitOptions.None))
            {
                newsBarBuilder.Append("<Font class='NewsBarText'>&nbsp;&nbsp;" + newsBarItem + "&nbsp;&nbsp;</Font>" + newsBarImage + "");
            }
            return newsBarBuilder.ToString();

        }

        public static void Page_UpdateCounter(string pageUrl, string updateType)
        {
            Global_BLL.DecodeUrl(pageUrl);
            Pages_DAL.Page_UpdateCounter(QueryString_Info.ID, QueryString_Info.Type, updateType);

        }

       



        public static void SendEmail(string senderName, string senderEmail, string recipientEmail, string messageEmail,string pageLink)
        {
           
            MailMessage message = new MailMessage(senderEmail, recipientEmail, String.Format("{0} Invite you to view an article in the website",senderName),"");
            message.IsBodyHtml = true;
            message.Body = EmailBoy( senderName, pageLink);
            message.BodyEncoding = Encoding.UTF8;
            message.Priority = MailPriority.High;
            SmtpClient smtp = new SmtpClient("localhost");
            smtp.Send(message);
        }
        public static string EmailBoy(string senderName, string pageLink)
        {

            StringBuilder htmlEmailBody = new StringBuilder();

            htmlEmailBody.Append(String.Format(@"<b>{0}Invite you to view article in the Website on the following link:
                                                </b><a href='{1}'>{1}</a>", senderName, pageLink));
            
            return htmlEmailBody.ToString();
        }
    }
}