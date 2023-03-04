using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using KFGCMS.BASE;
using Microsoft.ApplicationBlocks.Data;

namespace KFGCMS.DAL
{
    public class KFGDAL
    {
        #region Members
        static SqlCommand sqlCommand = new SqlCommand();
        
        #endregion

        //private static SqlConnection sqlConnection = new SqlConnection() ;

        ///// <summary>
        ///// Set SqlConnectionString value and open this connection.
        ///// </summary>
        //public static string ConnectionString
        //{
        //    set
        //    {

        //        if (sqlConnection.State != ConnectionState.Open)
        //        {
        //            sqlConnection.ConnectionString = value;
        //            sqlConnection.Open();
        //        }
        //    }
        //}

        /// <summary>
        /// return dataSet according to the selected query
        /// </summary>
        /// <param name="query">sql Query</param>
        /// <returns>DataSet</returns>
        public static DataSet ExecuteDataSet(string query)
        {
            

            return ExecuteDataSet(query, Global_Base.GetConnection());
        }

        public static DataSet ExecuteDataSet(string query, SqlConnection sqlConnection)
        {
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            using (SqlConnection Connection = sqlConnection)
            {
                try
                {

                    Command.Transaction = Connection.BeginTransaction();
                    Command.CommandText = query;
                    Command.Connection = Connection;
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataSet);
                    Command.Transaction.Commit();
                    Connection.Close();

                }

                catch (Exception exc)
                {
                    //Command.Transaction.Rollback();
                    Connection.Dispose();
                    Connection.Close();
                    throw exc;
                }

                return dataSet;
            }
        }


        /// <summary>
        /// return dataSet according to the Command received
        /// </summary>
        /// <param name="query">SQL Command</param>
        /// <returns>DataSet</returns>
        public static DataSet ExecuteDataSet(SqlCommand Command)
        {
            return ExecuteDataSet(Command, Global_Base.GetConnection());
        }
        public static DataSet ExecuteDataSet(SqlCommand Command, SqlConnection sqlConnection)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Command);
            DataSet dataSet = new DataSet();

            using (SqlConnection Connection = sqlConnection)
            {
                try
                {
                    Command.Connection = Connection;
                    dataAdapter.Fill(dataSet);
                    Connection.Close();

                }

                catch (Exception exc)
                {
                    Command.Transaction.Rollback();
                    if (Connection.State != ConnectionState.Closed)
                        Connection.Close();
                    throw exc;
                }


            }

            return dataSet;
        }


        /// <summary>
        /// return dataTable according to the Command
        /// </summary>
        /// <param name="query">SQL Command</param>
        /// <returns>DataTable</returns>
        public static DataTable ExecuteDataTable(SqlCommand Command)
        {
            return ExecuteDataTable(Command, Global_Base.GetConnection());
        }

        /// <summary>
        /// return dataTable according to the Command
        /// </summary>
        /// <param name="query">SQL Command</param>
        /// /// <param name="query">SQL Connection</param>
        /// <returns>DataTable</returns>
        public static DataTable ExecuteDataTable(SqlCommand Command, SqlConnection sqlConnection)
        {
          
            DataTable dataTable = new DataTable();
            using (SqlConnection Connection = sqlConnection)
            {
                try
                {
                    // Command.Parameters["@CUSTOMER_TELEPHONE"].Value = "96698479";
                    Command.Connection = Connection;
                    //Command.Transaction = Connection.BeginTransaction();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Command);
                    dataAdapter.Fill(dataTable);
                    Command.Dispose();
                    Connection.Close();
                    //dataTable = SqlHelper.ExecuteDataset(Connection, Command).Tables[0];
                }

                catch (Exception exc)
                {
                    Command.Transaction.Rollback();
                    if (Connection.State != ConnectionState.Closed)
                        Connection.Close();
                    throw exc;
                }
            }

            return dataTable;
        }


        /// <summary>
        /// return dataSet according to the selected query
        /// </summary>
        /// <param name="query">sql Query</param>
        /// <returns>DataSet</returns>
        public static DataTable ExecuteDataTable(string query)
        {
            return ExecuteDataTable(query, Global_Base.GetConnection());
        }

        public static DataTable ExecuteDataTable(string query, SqlConnection sqlConnection)
        {
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            using (SqlConnection Connection = sqlConnection)
            {
                try
                {

                    Command.Transaction = Connection.BeginTransaction();
                    Command.CommandText = query;
                    Command.Connection = Connection;
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataTable);
                    Connection.Close();

                }

                catch (Exception exc)
                {
                    Command.Transaction.Rollback();
                    if (Connection.State != ConnectionState.Closed)
                        Connection.Close();
                    throw exc;
                }

                return dataTable;
            }
        }

        public static int ExecuteScaler(SqlCommand Command)
        { 
            SqlDataReader Reader ;
            int count = 0;

            using (SqlConnection Connection = Global_Base.GetConnection())
            {
                try
                {
                    Command.Connection = Connection;
                    Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        count = Convert.ToInt32(Reader.GetValue(0));
                    }

                    Reader.Close();
                    Connection.Close();
                }

                catch (Exception exc)
                {
                    Command.Transaction.Rollback();
                    if (Connection.State != ConnectionState.Closed)
                        Connection.Close();
                    throw exc;
                }

            }

            return count;
        }

        public static int ExecuteScaler(string query)
        {
            return ExecuteScaler(query, Global_Base.GetConnection());
        }

        internal static int ExecuteScaler(string query, SqlConnection sqlConnection)
        { 
            SqlCommand Command = new SqlCommand();
            SqlDataReader Reader ;
            int count = 0;

            using (SqlConnection Connection = sqlConnection)
            {
                try
                {
                    Command.CommandText = query;
                    Command.Connection = Connection;
                    Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        count = (int)Reader.GetValue(0);
                    }

                    Reader.Close();
                    Connection.Close();
                    
                }

                catch (Exception exc)
                {
                    Command.Transaction.Rollback();
                    if (Connection.State != ConnectionState.Closed)
                        Connection.Close();
                    throw exc;
                }
            }


            return count;
        }

        public static int ExecuteNoneQuery(SqlCommand command)
        {
            return ExecuteNoneQuery(command, false);
        }



        public static int ExecuteNoneQuery(SqlCommand command, bool identity)
        {
            return ExecuteNoneQuery(command, identity, Global_Base.GetConnection());
        }



        public static int ExecuteNoneQuery(SqlCommand Command, bool identity, SqlConnection sqlConnection)
        {
            int result = 0;

            if (identity)
                Command.CommandText += ";select @@Identity;";

            using (SqlConnection Connection = sqlConnection)
            {
                try
                {
                    Command.Connection = Connection;
                    Command.Transaction = Connection.BeginTransaction();
                    result = Convert.ToInt32(Command.ExecuteScalar());
                    Command.Transaction.Commit();
                    Connection.Close();

                }
                catch (Exception exc)
                {
                    Command.Transaction.Rollback();
                    if (Connection.State != ConnectionState.Closed)
                        Connection.Close();
                    throw exc;
                }

            }

            return result;
        }


        public static int ExecuteNoneQuery(string Query)
        {
            return ExecuteNoneQuery(Query, false);
        }



        public static int ExecuteNoneQuery(string Query, bool identity)
        {
            return ExecuteNoneQuery(Query, identity, Global_Base.GetConnection());
        }



        public static int ExecuteNoneQuery(string Query, bool identity, SqlConnection sqlConnection)
        {
            int result = 0;

            if (identity)
                Query += ";select @@Identity;";

            using (SqlConnection Connection = sqlConnection)
            {
                try
                {
                    sqlCommand.Connection = Connection;
                    sqlCommand.Transaction = Connection.BeginTransaction();
                    sqlCommand.CommandText = Query;
                    result = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    sqlCommand.Transaction.Commit();
                    Connection.Close();

                }
                catch (Exception exc)
                {
                    sqlCommand.Transaction.Rollback();

                    if (Connection.State != ConnectionState.Closed)
                        Connection.Close();

                    throw exc;
                }

            }

            return result;
        }

    }
}
