using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

/// <summary>
/// Summary description for DataAccess
/// </summary>
namespace KFGCMS.BLL
{
    public class DataAccess
    {

        private
         SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WDD_ConnectionString"].ConnectionString);
        SqlCommand cmd, cmd2;
        SqlDataReader dr;
        SqlDataAdapter dap;
        DataSet ds;
        public DataAccess()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static string GetMasterPage(string Page_ID, string lang)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WDD_ConnectionString"].ConnectionString);
            int pg_ID = Convert.ToInt32(Page_ID);
            lang = "arb";

            SqlCommand cmd = new SqlCommand("SP_PAGES_TITLE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@LANG", SqlDbType.NVarChar).Value = lang;
            cmd.Parameters.Add("@PAGE_ID", SqlDbType.Int).Value = Page_ID;
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string reader = dr.GetValue(0).ToString();
            connection.Close();
            dr.Close();
            return reader;
        }




        public DataSet GetSubPagesData(string Page_ID, string SubPage_ID)
        {
            cmd = new SqlCommand("SP_SUBPAGES_DATA", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PAGE_ID", SqlDbType.Int).Value = Convert.ToInt32(Page_ID);
            cmd.Parameters.Add("@SUBPAGE_ID", SqlDbType.Int).Value = Convert.ToInt32(SubPage_ID);
            ds = new DataSet();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            return ds;

        }
        /************************************** Start *****************************************************/


        //public int GetPagesCount(string TableName, string WhereConditionColumn,string WhereConditionValue)
        //{


        //    string SQLStatement = string.Format("select count (*) from {0} where {1}='{2}'",TableName,WhereConditionColumn, WhereConditionValue);
        //    SqlCommand cmd = new SqlCommand(SQLStatement,Conn);
        //    Conn.Open();
        //    dr = cmd.ExecuteReader();
        //    dr.Read();
        //    int reader=int.Parse(dr.GetValue(0).ToString());
        //    Conn.Close();
        //    dr.Close();
        //    return reader;

        //}

        //public DataSet GetPagesAllInformation ()
        //{
        //    ds = new DataSet();
        //     dr.Close();
        //     SqlCommand cmd = new SqlCommand("select * from pages where Status='True' order by Sorting", Conn);
        //     SqlDataAdapter dap = new SqlDataAdapter(cmd);
        //     dap.Fill(ds);
        //     return ds;
        //}
        //public static string GetPagesPath(string id,string lang)
        //{
        //    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WDD_ConnectionString"].ConnectionString);
        //    int Page_ID = Convert.ToInt32(id);
        //    string path="";
        //    SqlCommand cmd = new SqlCommand("select Title_" + lang + ",SubPageChild,Sorting from Pages where Page_ID='"+id+"' and Status='True' order by Sorting", connection);
        //    connection.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    dr.Read();
        //    string CheckSubPage = dr.GetValue(1).ToString();
        //    string CheckHome=dr.GetValue(2).ToString();
        //    string EnglishText="";
        //    if(lang=="eng")
        //    EnglishText="English_";

        //    if (CheckHome == "0")
        //        path = string.Format("{2}default.aspx?id={0}&lang={1}", id, lang,EnglishText);
        //    else
        //    if (CheckSubPage == "True")
        //        path = string.Format("{2}SubPage.aspx?id={0}&SubPageChild=1&lang={1}",id,lang,EnglishText);
        //    else
        //        if (CheckSubPage == "False")
        //            path = string.Format("{2}Page.aspx?id={0}&lang={1}",id,lang,EnglishText);
        //    connection.Close();
        //    dr.Close();
        //    return path;
        //}

        public DataSet GetPagesPath()
        {

            cmd = new SqlCommand("SP_PAGES_PATHS", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            return ds;
        }

        public DataSet GetSubPagesPath(int pageid)
        {

            cmd = new SqlCommand("SP_SUBPAGES_PATHS", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PAGE_ID", SqlDbType.Int).Value = pageid;
            ds = new DataSet();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            return ds;
        }

        /**************************************** End*************************************************/


        public void ChangeSubPageChild(string Page_ID)
        {
            string SQLStatement = string.Format("update Pages set  SubPageChild='False' where Page_ID='{0}'", Page_ID);
            cmd = new SqlCommand(SQLStatement, Conn);
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();


        }


        public string UpdatePageDB(string lang, string Page_ID, string Title, string Body, string StaticLink)
        {
            string SQLStatement = String.Format("UPDATE Pages SET Template_ID = '1', Title_{0} = '{1}', Body_{0} = '{2}', Static_Link = '{3}' where Page_ID = '{4}'", lang, Title, Body, StaticLink, Page_ID);
            cmd = new SqlCommand(SQLStatement, Conn);
            Conn.Open();
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("select * from Pages Where Page_ID='" + Page_ID + "'", Conn);
            dr = cmd2.ExecuteReader();
            dr.Read();
            Conn.Close();

            string ReturnUrl = String.Format("EditPage.asp?id={0}&Lang={1}", Page_ID, lang); ;
            return ReturnUrl;

        }
        //public void InsertCity(string city)
        //{ 
        //    string SQLStatement=String.Format("INSERT INTO Cities ([City_Name]) VALUES ('{0}')",city);
        //    cmd = new SqlCommand(SQLStatement, Conn);
        //    Conn.Open();
        //    cmd.ExecuteNonQuery();
        //    Conn.Close();

        //}

        //public DataSet GetTrainingPrograms(string lang)
        //{ 
        //    cmd=new SqlCommand("GET_TRAINING_PROGRAMS",Conn);
        //    cmd.CommandType=CommandType.StoredProcedure;

        //    //cmd.Parameters.Add("@pageid", SqlDbType.Int).Value = pageid;
        //    //cmd.Parameters.Add("@PAGE_ARB", SqlDbType.NText).Direction = ParameterDirection.Output;


        //    cmd.Parameters.Add("@LANG",SqlDbType.NVarChar).Value=lang;
        //    cmd.Parameters.Add("@PROGRAM_TITLES",SqlDbType.NVarChar).Direction=ParameterDirection.Output;

        //    dap = new SqlDataAdapter(cmd);
        //    ds=new DataSet();
        //    dap.Fill(ds);
        //    return ds;
        //}


        /**********MM Gallery****************************/
        public DataSet GetMMGallery(string Catagory_ID)
        {
            cmd = new SqlCommand("SP_MMGALLERY_DATA", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CAT_ID", SqlDbType.Int).Value = Convert.ToInt32(Catagory_ID);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }
        public DataSet GetMMGalleryPage(string Gallery_ID)
        {
            cmd = new SqlCommand("SP_MMGALLERY_PAGE", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MMG_ID", SqlDbType.Int).Value = Convert.ToInt32(Gallery_ID);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        public static string GetMMGalleryPage_Title(string Gallery_ID)
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WDD_ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SP_MMGALLERY_PAGE_Title", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MMG_ID", SqlDbType.Int).Value = Convert.ToInt32(Gallery_ID);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds.Tables[0].Rows[0]["MMG_Name"].ToString();
        }
        /********************End MM Gallery*****************************************/


        /**************************************TRAINING*********************************/

        public DataSet GetCountries()
        {
            cmd = new SqlCommand("SP_COUNTRIES_GETALL", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;

        }

        public DataSet GetCities1Country(int Country_id)
        {
            cmd = new SqlCommand("SP_COUNTRIES_CITIES", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@COUNTRY_ID", SqlDbType.Int).Value = Country_id;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        public void Cities_Insert(string Country_ID, string City_NameArabic, string City_NameEnglish)
        {
            cmd = new SqlCommand("SP_CITY_INSERT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@COUNTRYID", SqlDbType.Int).Value = Convert.ToInt32(Country_ID);
            cmd.Parameters.Add("@CITY_ARB", SqlDbType.NVarChar).Value = City_NameArabic;
            cmd.Parameters.Add("@CITY_ENG", SqlDbType.NVarChar).Value = City_NameEnglish;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public void Country_Insert(string Country_Arabic, string Country_English, string Country_Time)
        {
            cmd = new SqlCommand("SP_COUNTRIES_INSERT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@COUNTRY_ARABIC", SqlDbType.NVarChar).Value = Country_Arabic;
            cmd.Parameters.Add("@COUNTRY_ENGLISH", SqlDbType.NVarChar).Value = Country_English;
            cmd.Parameters.Add("@COUNTRY_TIMEGMT", SqlDbType.NVarChar).Value = Country_Time;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public void ProgramInsert(string Program_Arabic, string Program_English, bool status)
        {
            cmd = new SqlCommand("SP_PROGRAM_INSERT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PNAME_ARABIC", SqlDbType.NVarChar).Value = Program_Arabic;
            cmd.Parameters.Add("@PNAME_ENGLISH", SqlDbType.NVarChar).Value = Program_English;
            cmd.Parameters.Add("@PNAME_STATUS", SqlDbType.Bit).Value = status;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();


        }
        public DataSet Course_Get(int id)
        {
            cmd = new SqlCommand("SP_COURSES_GET", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PROGRAMID", SqlDbType.Int).Value = id;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }
        public void Course_Insert(string program_id, string txt_arabic, string txt_english, string Country_ID, string City_ID, string DateFrom, string DateTo, string Time, bool Status)
        {
            cmd = new SqlCommand("SP_COURSES_INSERT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PROGRAM_ID", SqlDbType.Int).Value = Convert.ToInt32(program_id);
            cmd.Parameters.Add("@TITLE_ARB", SqlDbType.NVarChar).Value = txt_arabic;
            cmd.Parameters.Add("@TITLE_ENGLISH", SqlDbType.NVarChar).Value = txt_english;
            cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = Status;
            //cmd.Parameters.Add("@MAX_ID", SqlDbType.Int).Direction=ParameterDirection.Output;
            //cmd.Parameters.Add ("@MAX_ID",SqlDbType.Int).Direction=ParameterDirection.ReturnValue;
            //dap=new SqlDataAdapter(cmd);
            //ds=new DataSet();
            //dap.Fill(ds);


            //cmd2=new SqlCommand("SP_COURSES_INSERT_DATE",Conn);
            //cmd.CommandType=CommandType.StoredProcedure;
            //cmd.Parameters.Add("@COURSE_ID",SqlDbType.Int).Value=ds.Tables["Courses"].Rows[0][0].ToString();
            cmd.Parameters.Add("@COUNTRY_ID", SqlDbType.Int).Value = Convert.ToInt32(Country_ID);
            cmd.Parameters.Add("@CITY_ID", SqlDbType.Int).Value = Convert.ToInt32(City_ID);
            cmd.Parameters.Add("@DATE_FROM", SqlDbType.NVarChar).Value = DateFrom;
            cmd.Parameters.Add("@DATE_TO", SqlDbType.NVarChar).Value = DateTo;
            cmd.Parameters.Add("@TIME", SqlDbType.NVarChar).Value = Time;

            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();





        }

        public void Courses_Update_Content(string Course_ID, string Title_Arb, string Title_Eng, string Body_Arb, string Body_Eng)
        {
            cmd = new SqlCommand("SP_COURSES_UPDATE_CONTENT", Conn);
            cmd.Parameters.Add("@COURSE_ID", SqlDbType.Int).Value = Course_ID;
            cmd.Parameters.Add("@TITLE_ARB", SqlDbType.NVarChar).Value = Title_Arb;
            cmd.Parameters.Add("@TITLE_ENG", SqlDbType.NVarChar).Value = Title_Eng;
            cmd.Parameters.Add("@BODY_ARB", SqlDbType.Text).Value = Body_Arb;
            cmd.Parameters.Add("@BODY_ENG", SqlDbType.Text).Value = Body_Eng;

            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();

        }

        public void Training_Insert(string Course_ID, string Country_ID, string City_ID, string FName, string LName, string Job, string Company, string Phone, string Fax, string Mobile, string Email)
        {
            cmd = new SqlCommand("SP_TRAINING_INSERT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@COURSE_ID", SqlDbType.Int).Value = Convert.ToInt32(Course_ID);
            cmd.Parameters.Add("@COUNTRY_ID", SqlDbType.Int).Value = Convert.ToInt32(Country_ID);
            cmd.Parameters.Add("@CITY_ID", SqlDbType.Int).Value = Convert.ToInt32(City_ID);
            cmd.Parameters.Add("@FNAME", SqlDbType.NVarChar).Value = FName;
            cmd.Parameters.Add("@LNAME", SqlDbType.NVarChar).Value = LName;
            cmd.Parameters.Add("@JOB", SqlDbType.NVarChar).Value = Job;
            cmd.Parameters.Add("@COMPANY", SqlDbType.NVarChar).Value = Company;
            cmd.Parameters.Add("@PHONE", SqlDbType.NVarChar).Value = Phone;
            cmd.Parameters.Add("@FAX", SqlDbType.NVarChar).Value = Phone;
            cmd.Parameters.Add("@MOBILE", SqlDbType.NVarChar).Value = Mobile;
            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = Email;
            cmd.Parameters.Add("@TRAINEE_ID", SqlDbType.Int).Direction = ParameterDirection.Output;


            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();

        }
        public void Training_Insert_ExtUser(string Course_ID, string Ext_Name, string Company, string Email)
        {
            cmd = new SqlCommand("SP_TRAINING_INSERT_EXTUSER", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@TRAINEE_ID",SqlDbType.Int).Value = Convert.ToInt32(Trainee_ID);
            cmd.Parameters.Add("@COURSE_ID", SqlDbType.Int).Value = Convert.ToInt32(Course_ID);
            cmd.Parameters.Add("@EXT_NAME", SqlDbType.NVarChar).Value = Ext_Name;
            cmd.Parameters.Add("@COMPANY", SqlDbType.NVarChar).Value = Company;
            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = Email;



            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();


        }

        public DataSet Get_Training_Ext()
        {
            cmd = new SqlCommand("SP_TRAINING_GET_EXT_TRAINEE", Conn);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;

        }

        public string GetMaxTraineeID()
        {
            cmd = new SqlCommand("SP_TRAINING_MAXID", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            string value = dr.GetValue(0).ToString();
            Conn.Close();
            return value;


        }

        public string NewsAdd_CP(
            string TitleArb,
            string TitleEng,
            string ArabicBody,
            string LinkText,
            string LinkUrl,
            string ImagePathUpload,
            string NewsType,
            bool status
            )
        {
            try
            {

                cmd = new SqlCommand("SP_NEWSCP_ADD", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TITLE_ARB", SqlDbType.NVarChar).Value = TitleArb;
                cmd.Parameters.Add("@TITLE_ENG", SqlDbType.NVarChar).Value = TitleEng;
                cmd.Parameters.Add("@TITLE_ARABIC_BODY", SqlDbType.NVarChar).Value = ArabicBody;
                cmd.Parameters.Add("@LINK_TEXT", SqlDbType.NVarChar).Value = LinkText;
                cmd.Parameters.Add("@LINK_URL", SqlDbType.NVarChar).Value = LinkUrl;
                cmd.Parameters.Add("@IMAGE_PATH_UPLOAD", SqlDbType.NVarChar).Value = ImagePathUpload;
                cmd.Parameters.Add("@NEWS_TYPE", SqlDbType.NVarChar).Value = NewsType;
                cmd.Parameters.Add("@NEWS_SORTING", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@NEWS_PUBLISH", SqlDbType.Bit).Value = status;



                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
                return "Successfully Inserted";
            }
            catch (Exception ex)
            {
                return "ERROR!! " + ex.Message;
            }


        }
        public static DataSet NewsGet()
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WDD_ConnectionString"].ConnectionString);

            SqlCommand cmd = new SqlCommand("SP_NEWS_GET", Conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            return ds;

        }
        public bool NewsUploadImage(HtmlInputFile FileImagePath)
        {
            string strFileName = "", strUploadedFileName;

            try
            {
                if (FileImagePath.PostedFile != null)
                {
                    strFileName = FileImagePath.PostedFile.FileName;
                    strFileName = Path.GetFileName(strFileName);
                    FileImagePath.PostedFile.SaveAs(HttpContext.Current.Server.MapPath(@"~/NewsFiles/") + strFileName);

                    NewsImageProcessing(strFileName);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void NewsImageProcessing(string imageName)
        {
            string extention = Path.GetExtension(imageName);
            string imageNameJust = Path.GetFileNameWithoutExtension(imageName);

            Bitmap OriginalImage = new Bitmap(HttpContext.Current.Server.MapPath(@"~/NewsFiles/" + imageName));
            Size NewSize = new Size(380, 130);
            Bitmap NewImage = new Bitmap(OriginalImage, NewSize);
            OriginalImage.Dispose();
            NewImage.Save(HttpContext.Current.Server.MapPath(@"~/NewsFiles/" + imageNameJust + extention), ImageFormat.Jpeg);

        }

        public string SubScribeInsert(string email)
        {
            try
            {
                cmd = new SqlCommand("SP_SUBSCRIBE_INSERT", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = email;

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public DataSet NewsBar_Select()
        {
            cmd = new SqlCommand("SP_NEWSBAR_SELECT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        public string NewsBar_Insert(string title_arb, string title_eng, string link, bool status)
        {
            try
            {
                cmd = new SqlCommand("SP_NEWSBAR_INSERT", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TITLE_ARB", SqlDbType.NVarChar, 250).Value = title_arb;
                cmd.Parameters.Add("@TITLE_ENG", SqlDbType.NVarChar, 250).Value = title_eng;
                cmd.Parameters.Add("@LINK", SqlDbType.NVarChar, 250).Value = link;
                cmd.Parameters.Add("@SORTING", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = status;

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
                return "true";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }


        }

        public string SubPage_Insert
            (
             int pageid,
            string title_arb,
            string title_eng,
            string body_arb,
            string static_link,
            int sorting,
            bool status
            )
        {


            cmd = new SqlCommand("SP_SubPage_Insert", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Page_ID", SqlDbType.Int).Value = pageid;
            cmd.Parameters.Add("@TITLE_ARB", SqlDbType.NVarChar).Value = title_arb;
            cmd.Parameters.Add("@title_eng", SqlDbType.NVarChar).Value = title_eng;
            cmd.Parameters.Add("@BODY_ARB", SqlDbType.NVarChar).Value = body_arb;
            cmd.Parameters.Add("@STATIC_LINK", SqlDbType.NVarChar).Value = static_link;
            cmd.Parameters.Add("@SORTING", SqlDbType.Int).Value = sorting;
            cmd.Parameters.Add("@status", SqlDbType.Bit).Value = status;

            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
            return "true";
            //}

            //catch (Exception exc)
            //{
            //    return "false";
            //}
        }

        public DataSet GetPageCategories(string pageid)
        {
            cmd = new SqlCommand("SP_DATACATEGORY_SELECT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PAGEID", SqlDbType.Int).Value = Convert.ToInt32(pageid);

            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);

            return ds;


        }

        public DataSet GetCategory(string pageid)
        {
            cmd = new SqlCommand("SP_DATACATEGORY_SELECT", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PAGEID", SqlDbType.Int).Value = Convert.ToInt32(pageid);

            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);

            return ds;


        }


        public static string GetSubPagesCatBigStatic(string SubPageID)
        {

            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WDD_ConnectionString"].ConnectionString);

            SqlCommand cmd = new SqlCommand("SP_SUBPAGES_SELECT_BIG", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SID", SqlDbType.Int).Value = SubPageID;
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds.Tables[0].Rows[0]["Body_Arb"].ToString();

        }


        public static string GetPagesCatBigStatic(string PageID)
        {

            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WDD_ConnectionString"].ConnectionString);

            SqlCommand cmd = new SqlCommand("SP_PAGES_SELECT_BIG", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PID", SqlDbType.Int).Value = PageID;
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds.Tables[0].Rows[0]["Body_Arb"].ToString();

        }


        public DataSet GetSubPagesCatBig(string SubPageID)
        {
            cmd = new SqlCommand("SP_SUBPAGES_SELECT_BIG", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SID", SqlDbType.Int).Value = SubPageID;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;

        }
        public DataSet GetSubPagesCatSmall(string catid)
        {
            cmd = new SqlCommand("SP_SUBPAGES_SELECT_SMALL", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CATID", SqlDbType.Int).Value = catid;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }


        //this is for news and any page retrieve top4 of page categoris
        public DataSet GetPageCatsTitles(string pageid)
        {
            cmd = new SqlCommand("SP_SUBPAGES_SELECT_TOP4_WPAGE", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PAGEID", SqlDbType.Int).Value = pageid;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }


        public DataSet GetSubPagesCatTOP5(string catid)
        {
            cmd = new SqlCommand("SP_SUBPAGES_SELECT_TOP5", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CATID", SqlDbType.Int).Value = catid;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }


        public DataSet GetCategories(string pageid)
        {
            cmd = new SqlCommand("SP_DATACATEGORY_SELECT", Conn);
            cmd.Parameters.Add("@PAGEID", SqlDbType.Int).Value = pageid;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        //public string SubPageItemAdd(string id, string dcid, string title, string staticLink, HtmlInputFile FileImage)
        //{
        //    try
        //    {
        //        bool CheckUpload = ItemUploadImage(FileImage);
        //        if (CheckUpload == false)
        //            throw new Exception("Upload Image File Error");
        //        else
        //        {
        //            cmd = new SqlCommand("SP_SUBPAGEITEM_INSERT", Conn);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add("@PAGEID", SqlDbType.Int).Value = id;
        //            cmd.Parameters.Add("@CATID", SqlDbType.Int).Value = dcid;
        //            cmd.Parameters.Add("@TITLEARB", SqlDbType.NVarChar,500).Value = title;
        //            cmd.Parameters.Add("@STATICLINK", SqlDbType.NVarChar).Value = staticLink;
        //            cmd.Parameters.Add("@SORTING", SqlDbType.Int).Value = "0";
        //            cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = false;
        //            cmd.Parameters.Add("@IMAGEURL", SqlDbType.NVarChar).Value = FileImage.PostedFile.FileName;

        //            Conn.Open();
        //            cmd.ExecuteNonQuery();
        //            Conn.Close();

        //            return "true";
        //        }

        //    }

        //    catch (Exception exc)
        //    {
        //        return (exc.Message);
        //    }
        //}

        public string ItemUploadImage(HtmlInputFile FileImagePath, int x, int y)
        {
            string strFileName = "";
            string extention = Path.GetExtension(FileImagePath.PostedFile.FileName);
            string imageNameJust = Path.GetFileNameWithoutExtension(FileImagePath.PostedFile.FileName);

            try
            {
                if (FileImagePath.PostedFile != null && FileImagePath.PostedFile.ContentLength.ToString() != "0")
                {
                    strFileName = FileImagePath.PostedFile.FileName;
                    strFileName = Path.GetFileName(strFileName);

                    FileInfo finfo = new FileInfo(HttpContext.Current.Server.MapPath(@"~\Files\") + imageNameJust + extention);
                    if (finfo.Exists == true)
                        imageNameJust += "_Renamed";

                    FileImagePath.PostedFile.SaveAs(HttpContext.Current.Server.MapPath(@"~\Files\") + imageNameJust + extention);

                    strFileName = imageNameJust + extention;

                    ItemImageProcessing(strFileName, x, y);

                }

                return strFileName;
            }
            catch (Exception ex)
            {
                return "false";
            }

        }
        public void ItemImageProcessing(string imageName, int x, int y)
        {
            //System.Drawing.Image img = new System.Drawing.Image();
            //System.Drawing.Image th = new System.Drawing.Image();

            //th = img.GetThumbnailImage(x,y,null,null);
            string extention = Path.GetExtension(imageName);
            string imageNameJust = Path.GetFileNameWithoutExtension(imageName);

            imageNameJust += "_TH";
            Bitmap OriginalImage = new Bitmap(HttpContext.Current.Server.MapPath(@"~/Files/" + imageName));
            Size NewSize = new Size(x, y);
            //object resulution = 72;
            Bitmap NewImage = new Bitmap(OriginalImage, NewSize);
            NewImage.SetResolution(150, 150);
            //OriginalImage.Dispose();
            NewImage.Save(HttpContext.Current.Server.MapPath(@"~/Files/" + imageNameJust + extention), ImageFormat.Jpeg);

        }

        public DataSet BannerGetPage(string pageid)
        {
            cmd = new SqlCommand("BANNER_GET_PAGE", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PAGEID", SqlDbType.Int).Value = pageid;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);

            return ds;
        }

        public DataSet BannerGetInfo(string catid)
        {
            cmd = new SqlCommand("BANNER_GET_INFO", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CATID", SqlDbType.Int).Value = catid;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds);

            return ds;
        }

        public string BannerUploadImage(HtmlInputFile FileImagePath, int x, int y)
        {
            string strFileName = "";
            string extention = Path.GetExtension(FileImagePath.PostedFile.FileName);
            string imageNameJust = Path.GetFileNameWithoutExtension(FileImagePath.PostedFile.FileName);

            try
            {
                if (FileImagePath.PostedFile != null && FileImagePath.PostedFile.ContentLength != 0)
                {
                    strFileName = FileImagePath.PostedFile.FileName;
                    strFileName = Path.GetFileName(strFileName);

                    FileInfo finfo = new FileInfo(FileImagePath.PostedFile.FileName);
                    if (finfo.Exists == true)
                        imageNameJust += "_Renamed";

                    FileImagePath.PostedFile.SaveAs(HttpContext.Current.Server.MapPath(@"~\Files\") + imageNameJust + extention);

                    strFileName = imageNameJust + extention;

                    //ItemImageProcessing(strFileName,x,y);

                }

                return strFileName;
            }
            catch (Exception ex)
            {
                return "false";
            }
        }

        /*********************** Test ************************/
        public DataSet GetTest()
        {
            cmd = new SqlCommand("SP_GETTEST", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "DCATEGORY_TABLE");
            return ds;
        }

    }
}