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
using Microsoft.ApplicationBlocks.Data;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Text;

/// <summary>
/// Summary description for Global_BLL
/// </summary>
namespace KFGCMS.BLL
{

    public class Global_BLL : Global_Base
    {

        #region Members
            static string strKey = "MuslimKiLLWestHack";
            static string  [] split = {"&","#", " "};
            static string[] split_Inside = {"="};
            static int KeyLenght = strKey.Length;
        #endregion

        public Global_BLL()
        {

        }

        public void RemoveDataTable(DataSet SourceDataSet, DataTable DestinationDataTable)
        {
            if (SourceDataSet.Tables.CanRemove(DestinationDataTable))
                SourceDataSet.Tables.Remove(DestinationDataTable);
        }

        public void RemoveDataTable(DataSet SourceDataSet, int tableIndex)
        {
            //if (SourceDataSet.Tables.CanRemove(DestinationDataTable))
            SourceDataSet.Tables.RemoveAt(tableIndex);
        }

        public DataTable DataSetToDataTable(DataSet dataSet)
        {
            DataTable ReturnDataTable = new DataTable();
            ReturnDataTable.Columns.Add("ID");
            ReturnDataTable.Columns.Add("Type");
            ReturnDataTable.Columns.Add("Title");
            ReturnDataTable.Columns.Add("StaticLink");
            ReturnDataTable.Columns.Add("Description");
            ReturnDataTable.Columns.Add("TableType");
            ReturnDataTable.Columns.Add("MenuPostion");
            ReturnDataTable.Columns.Add("ParentID");
            ReturnDataTable.Columns.Add("Parent_Title");
            ReturnDataTable.Columns.Add("Parent_Type");
            ReturnDataTable.Columns.Add("Parent_StaticLink");
            ReturnDataTable.Columns.Add("Parent_Description");
            ReturnDataTable.Columns.Add("Parent_MenuPosition");
            
            foreach (DataTable dataTable in dataSet.Tables)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    ReturnDataTable.ImportRow(row);
                }
            }

            return ReturnDataTable;
        }

        public DataTable Footer1DataTable(DataSet dataSet)
        {
            DataTable ReturnDataTable = new DataTable();
            ReturnDataTable.Columns.Add("ParentID");
            ReturnDataTable.Columns.Add("Parent_Title");
            ReturnDataTable.Columns.Add("Parent_Type");
            ReturnDataTable.Columns.Add("Parent_StaticLink");
            ReturnDataTable.Columns.Add("Parent_Description");
            ReturnDataTable.Columns.Add("Parent_MenuPosition");


             foreach (DataTable dataTable in dataSet.Tables)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    ReturnDataTable.ImportRow(row);
                }
            }

            return new DataView(ReturnDataTable).ToTable(true,"ParentID","Parent_Title","Parent_Type","Parent_StaticLink", "Parent_Description", "Parent_MenuPosition");
            
        }

        public int ExecuteNoneQuery(string command)
        {
            using (SqlConnection connection = Getconnection())
            {
                return SqlHelper.ExecuteNonQuery(connection, CommandType.Text, command);
            }

        }


        public static SqlConnection GetConnection()
        {

            return Getconnection();
        }

        public static string FilterImagePathToThumbnail(object imagePath)
        {
            string AssetsMainFolder = ConfigurationManager.AppSettings["AssetsMainFolder"].ToString(), 
                   ThumbnailFolder= ConfigurationManager.AppSettings["ThumbmailFolder"].ToString(), 
                   emptyImage = "", fileName = "", NameJust="", extension="", DirectoryName="";

            try
            {

                emptyImage = "/Assets" + ConfigurationManager.AppSettings["EmptyThumbnailImage"].ToString(); 
                fileName = imagePath.ToString();
                NameJust = Path.GetFileNameWithoutExtension(fileName);
                extension = Path.GetExtension(fileName);
                DirectoryName = Path.GetDirectoryName(fileName);

                if (fileName != "" && NameJust != "" && extension != "")
                {
                    return AssetsMainFolder + DirectoryName + "/" + ThumbnailFolder + "/" + NameJust + "_TH.jpg";
                }

                else
                    return emptyImage;

            }
            catch (Exception exc)
            {
                return emptyImage;
            }
        }


        public static string ResolveImagePath(object imagePath)
        {
            string AssetsMainFolder = ConfigurationManager.AppSettings["AssetsMainFolder"].ToString(),
                   GeneralFolder = ConfigurationManager.AppSettings["GeneralFolder"].ToString(),
                   portalsFolder = "", portalAlias = "", emptyImage = "", fileName = "", NameJust = "", extension = "", DirectoryName = "";

            try
            {

               // portalsFolder = ConfigurationManager.AppSettings["LocalRoot"].ToString();
                //portalAlias = ConfigurationManager.AppSettings["PortalAlias"].ToString();
                emptyImage = "/assets" + ConfigurationManager.AppSettings["EmptyImage"].ToString();
                fileName = imagePath.ToString();
                NameJust = Path.GetFileNameWithoutExtension(fileName);
                extension = Path.GetExtension(fileName);
                DirectoryName = Path.GetDirectoryName(fileName);

                if (fileName != "" && NameJust != "" && extension != "")
                {

                    return AssetsMainFolder + "/" + GeneralFolder + "/" + NameJust + extension;
                }

                else
                    return emptyImage;

            }
            catch (Exception exc)
            {
                return emptyImage;
            }

        }
        //public static void FireException(object control, string message)
        //{
        //    Control thisControl = (Control)control;
        //    ScriptManager.RegisterClientScriptBlock(thisControl, thisControl.GetType(), "ScriptMessage", String.Format("alert('{0}');", message), true);
        //}
         public static void Alert(object control, string message)
        {
            Control thisControl = (Control)control;
            ScriptManager.RegisterClientScriptBlock(thisControl, thisControl.GetType(), "ScriptMessage", String.Format("alert('{0}');", message), true);
        }

        public static string FilterDateToStandardFormat(string date)
        {
            return (Convert.ToDateTime(date)).ToString("d/M/yyyy-h:mmtt");
        }

        public static string FilterDateToDay(string Date)
        {
            return (Convert.ToDateTime(Date)).ToString("dddd");
        }


        public static string ChangeIDToType(string id)
        {
            if (id == "1")
                return "Page";
            else
                if (id == "2")
                    return "StaticLink";
                else
                    if (id == "3")
                        return "Photo";
                    else
                        if (id == "4")
                            return "Audio";
                        else
                            if (id == "5")
                                return "Video";
                            else
                                return "Category";
        }


        public static string EncodeUrl(params string[] quereyStrings)
        {
            StringBuilder queryBuilder = new StringBuilder();

            foreach (string query in quereyStrings)
            {
                queryBuilder.Append(query + "&");
            }

            string encodedString = queryBuilder.ToString();


            Random random = new Random(3);
            int num = Convert.ToInt32((KeyLenght * random.Next(0, 3)) + 1);

            for (int i = 1; i <= num; i++)
                encodedString = Convert.ToBase64String(ConvertStringToByte(encodedString), Base64FormattingOptions.None);

            char[] Seed_Array = strKey.ToCharArray();
            encodedString = String.Format("{0}+{1}", encodedString, Seed_Array[num]);

            encodedString = Convert.ToBase64String(ConvertStringToByte(encodedString), Base64FormattingOptions.None);
            return encodedString;

        }

        public static void DecodeUrlStatic(object originalQuereyStrings)
        {
            char[] Seed_Array = strKey.ToCharArray();
            string  decodeOriginalString = originalQuereyStrings.ToString().Split('.')[0],
                    strDecode = ConvertBytesToString(Convert.FromBase64String(decodeOriginalString));
            char letter = Convert.ToChar(strDecode.Split('+')[1]);
            string queryLeft = "", queryRight = "";
            strDecode = strDecode.Split('+')[0];

            int i = 0;
            for (i = 0; i < Seed_Array.Length; i++)
                if (Seed_Array[i] == letter)
                    break;

            for (int j = 0; j < i; j++)
                strDecode = ConvertBytesToString(Convert.FromBase64String(strDecode));


            foreach (string query in strDecode.Split(split, StringSplitOptions.None))
            {
                try
                {
                    queryLeft = query.Split(split_Inside, StringSplitOptions.None)[0];
                    queryRight = query.Split(split_Inside, StringSplitOptions.None)[1];
                }
                catch
                {
                }

                if (queryLeft.ToLower() == "id")
                    QueryString_Info.ID = queryRight;
                else

                    if (queryLeft.ToLower() == "source")
                        QueryString_Info.Source = queryRight;

                    else

                        if (queryLeft.ToLower() == "type")
                            QueryString_Info.Type = queryRight;

                        else

                            if (queryLeft.ToLower() == "language")
                                QueryString_Info.Language = queryRight;
                            else


                                if (queryLeft.ToLower() == "questionnaireid")
                                    QueryString_Info.QuestionnaireID = queryRight;
                                else

                                    if (queryLeft.ToLower() == "groupid")
                                        QueryString_Info.GroupID = queryRight;
                                    else
                                        if (queryLeft.ToLower() == "dynamic")
                                            QueryString_Info.DynamicID = queryRight;
                                        
                                        
                                        //// registration section
                                        //if (queryLeft.ToLower() == "username")
                                        //    Signup_Info.Name = queryRight;
                                        //else
                                        //    if (queryLeft.ToLower() == "password")
                                        //        Signup_Info.Password = queryRight;      
                                        //    else
                                        //        if (queryLeft.ToLower() == "email")
                                        //            Signup_Info.email = queryRight;      
                                        //        else
                                        //            if (queryLeft.ToLower() == "phone")
                                        //                Signup_Info.Phone = queryRight;

                                        //            else
                                        //                if (queryLeft.ToLower() == "comment")
                                        //                    Signup_Info.Comment = queryRight;
                                        //                else
                                        //                    if (queryLeft.ToLower() == "date")
                                        //                        Signup_Info.Date = Convert.ToDateTime(queryRight);

            }
        }


        public static string EncodeUrl(object ObjectID,object thisSource, object ObjectType, string language)
        {
            string encodedString = String.Format("{0}&{1}&{2}&{3}",ObjectID, thisSource ,ObjectType ,language);

            Random random = new Random(3);
            int num = Convert.ToInt32((KeyLenght * random.Next(0, 3)) + 1);

            for (int i = 1; i <= num; i++)
                encodedString = Convert.ToBase64String(ConvertStringToByte(encodedString), Base64FormattingOptions.None);

            char[] Seed_Array = strKey.ToCharArray();
            encodedString = String.Format("{0}+{1}", encodedString, Seed_Array[num]);

            encodedString = Convert.ToBase64String(ConvertStringToByte(encodedString), Base64FormattingOptions.None);
            return encodedString;

        }

        public static void DecodeUrl(object decodeOriginalObject)
        {
            
            char[] Seed_Array = strKey.ToCharArray();
            string decodeOriginalString = decodeOriginalObject.ToString().Split('.')[0];
            string strDecode = ConvertBytesToString(Convert.FromBase64String(decodeOriginalString));
            char letter = Convert.ToChar(strDecode.Split('+')[1]);
            strDecode = strDecode.Split('+')[0];

            int i = 0;
            for (i = 0; i < Seed_Array.Length; i++)
                if (Seed_Array[i] == letter)
                    break;

            for (int j = 0; j < i; j++)
                strDecode = ConvertBytesToString(Convert.FromBase64String(strDecode));

            QueryString_Info.ID = strDecode.Split(split, StringSplitOptions.None)[0];
            QueryString_Info.Source = strDecode.Split(split, StringSplitOptions.None)[1];
            QueryString_Info.Type = strDecode.Split(split, StringSplitOptions.None)[2];
            QueryString_Info.Language = strDecode.Split(split, StringSplitOptions.None)[3];

//            return strDecode;
        }


        public static byte[] ConvertStringToByte(string original)
        {
            System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            return ascii.GetBytes(original.ToCharArray());
        }

        public static string ConvertBytesToString(Byte[] encoded)
        {
            System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            return new String(ascii.GetChars(encoded));
        }
        



    }
}