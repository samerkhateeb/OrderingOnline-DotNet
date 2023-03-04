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
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Pages_DAL
/// </summary>
namespace KFGCMS.BLL
{
    class Pages_DAL : Pages_Base
    {
        public Pages_DAL()
        {

        }

        public static DataSet HomePage(string counterStatus, DateTime dateTime, string language)
        {
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            using (SqlConnection Connection = Pages_Base.GetConnection())
            {
                try
                {

                    Command.Transaction = Connection.BeginTransaction();
                    Command.CommandText = "KFGSP_HOMEPAGE";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.Add("@CounterStatus",SqlDbType.NVarChar).Value = counterStatus;
                    Command.Parameters.Add("@DATE",SqlDbType.DateTime).Value = dateTime;
                    Command.Parameters.Add("@lang",SqlDbType.NVarChar).Value = language;
                    Command.Connection = Connection;
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataSet);


                }

                catch (Exception exc)
                {
                    try
                    {
                        Command.Transaction.Rollback();
                        Connection.Close();
                    }
                    catch {}
                    throw exc;
                }

                return dataSet;
            }

           // return SqlHelper.ExecuteDataset(, , , , );
        }
        public static DataSet DefaultPageMenu()
        {
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            using (SqlConnection Connection = Pages_Base.GetConnection())
            {
                try
                {

                    Command.Transaction = Connection.BeginTransaction();
                    Command.CommandText = "KFGSP_PAGES_LINKS";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Connection = Connection;
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataSet);

                }

                catch (Exception exc)
                {
                    try
                    {
                        Command.Transaction.Rollback();
                        Connection.Close();
                    }
                    catch { }
                    throw exc;
                }

                return dataSet;
            }

          // return SqlHelper.ExecuteDataset(Pages_Base.GetConnection(), "KFGSP_PAGES_LINKS");
        }

        /// <summary>
        /// retrieve object data when go to simple page
        /// </summary>
        /// <param name="pageID"></param>
        /// <param name="pageType"></param>
        /// <returns></returns>
        public static DataSet ObjectData(object pageID, object thisSource, object pageType, string language)
        {

            SqlCommand Command = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            using (SqlConnection Connection = Pages_Base.GetConnection())
            {
                try
                {

                    Command.Transaction = Connection.BeginTransaction();
                    Command.CommandText = "KFGSP_Object_Data";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = pageID;
                    Command.Parameters.Add("@SOURCE", SqlDbType.NVarChar).Value = thisSource;
                    Command.Parameters.Add("@TYPE", SqlDbType.Int).Value = pageType;
                    Command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = language;
                    Command.Connection = Connection;
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataSet);
                    Connection.Close();

                }

                catch (Exception exc)
                {
                    try
                    {
                        Command.Transaction.Rollback();
                        Connection.Close();
                    }
                    catch { }
                    throw exc;
                }
            }

            return dataSet;

          //  return SqlHelper.ExecuteDataset(Pages_Base.GetConnection(), "KFGSP_Object_Data", , , , );
        }


        /// <summary>
        /// retirve categories for selected page
        /// </summary>
        /// <param name="pageID">categories for this page</param>
        /// <param name="pageType">not necessary</param>
        /// <returns></returns>
        public static DataSet PageCategories(object pageID, object language)
        {
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            using (SqlConnection Connection = Pages_Base.GetConnection())
            {
                try
                {

                    Command.Transaction = Connection.BeginTransaction();
                    Command.CommandText = "KFGSP_OBJECT_PAGE_CATEGORIES";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = pageID;
                    Command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = language;
                    Command.Connection = Connection;
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataSet);

                }

                catch (Exception exc)
                {
                    try
                    {
                        Command.Transaction.Rollback();
                        Connection.Close();
                    }
                    catch { }
                    throw exc;
                }

                return dataSet;
            }

           // return SqlHelper.ExecuteDataset(Pages_Base.GetConnection(), "KFGSP_OBJECT_PAGE_CATEGORIES", pageID, objectType, objectSource);
        }



        public static DataSet ObjectData_Static(int id, string source, int type, string counter_type, string language, int parentId)
        {
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            using (SqlConnection Connection = Pages_Base.GetConnection())
            {
                try
                {

                    Command.Transaction = Connection.BeginTransaction();
                    Command.CommandText = "KFGSP_OBJECT_CONTENT_STATIC";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    Command.Parameters.Add("@SOURCE", SqlDbType.NVarChar).Value = source;
                    Command.Parameters.Add("@TYPE", SqlDbType.Int).Value = type;
                    Command.Parameters.Add("@COUNTER_TYPE", SqlDbType.NVarChar).Value = counter_type;
                    Command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = language;
                    Command.Connection = Connection;
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataSet);

                }

                catch (Exception exc)
                {
                    try
                    {
                        Command.Transaction.Rollback();
                        Connection.Close();
                    }
                    catch { }
                    throw exc;
                }

                return dataSet;
            }

          //  return SqlHelper.ExecuteDataset(Pages_Base.GetConnection(), "KFGSP_OBJECT_CONTENT_STATIC", id, source, type, counter_type, language);

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
            return SqlHelper.ExecuteDataset(Pages_Base.GetConnection(), "KFGSP_OBJECT_PAGE_CATEGORIES", categoryID, categoryType);
        }


        public static DataSet PagesData(string selectedKey, string name_type, string strMediaID)
        {
            return SqlHelper.ExecuteDataset(Pages_Base.GetConnection(), "KFGSP_PAGES_CONTENT", selectedKey, name_type, strMediaID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectID"></param>
        /// <param name="objectType"></param>
        /// <param name="updateType"></param>
        public static void Page_UpdateCounter(object objectID, object objectType, object updateType)
        {
            SqlHelper.ExecuteNonQuery(Pages_Base.GetConnection(), "KFGSP_OBJECT_COUNTER_UPDATE", objectID, objectType, updateType);
        }
    }
}