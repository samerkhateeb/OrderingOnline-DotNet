using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data;

namespace Plex.CMS.PlexCode
{
    class Courses_DAL
    {
        public static object Course_UserSignUp(string name, string password, string email, string phone, string comment, string RegistrationDate)
        {

            return SqlHelper.ExecuteScalar(Course_Base.GetConnection(), "SP_COURSE_User_SignUp", name, password, email, phone, comment, RegistrationDate);
            
        }



        /// <summary>
        /// Check Courses Login DAL
        /// </summary>
        /// <param name="userName"> user Name</param>
        /// <param name="password"> password</param>
        /// <returns>DataSet</returns>
        public static DataSet CourseCheckLogin (string userName, string password)
        {
            SqlConnection Connection = Course_Base.GetConnection();
            SqlCommand command = new SqlCommand("SP_COURSE_CheckAuthentication", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@userName", SqlDbType.NVarChar).Value = userName;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }




        public static DataSet CourseDefaultData(string type, string id, string source, string language)
        {

            SqlConnection Connection = Course_Base.GetConnection();
            SqlCommand command = new SqlCommand("SP_COURSE_DATA", Connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@SOURCE", SqlDbType.NVarChar).Value = source;
            command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = language;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public static DataSet CourseUserData(string userID, string language)
        {
            SqlConnection Connection = Course_Base.GetConnection();
            SqlCommand command = new SqlCommand("SP_COURSE_Select_USER_Courses", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
            command.Parameters.Add("@lang", SqlDbType.NChar).Value = language;
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        internal static DataSet CourseUserLessonsCheck(string userID, string courseID)
        {
            SqlConnection Connection = Course_Base.GetConnection();
            SqlCommand command = new SqlCommand("SP_COURSE_Check_USER_Course_Count", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
            command.Parameters.Add("@CourseID", SqlDbType.Int).Value = courseID;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }


        internal static DataSet CourseData_Static(string language)
        {
            SqlConnection Connection = Course_Base.GetConnection();
            SqlCommand command = new SqlCommand("SP_COURSE_CONTENT_STATIC", Connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@lang", SqlDbType.NVarChar).Value = language;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        internal static DataSet CheckUserAuthenticationToDownloadLesson(string userID, string courseID, string lessonID)
        { 
             SqlConnection Connection = Course_Base.GetConnection();
             SqlCommand command = new SqlCommand("SP_COURSE_AUTHENTICATE_USER_TO_DOWNLOAD_LESSON", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
            command.Parameters.Add("@LessonID", SqlDbType.Int).Value = lessonID;
            command.Parameters.Add("@CourseID", SqlDbType.Int).Value = courseID;


            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        internal static void SaveUserToCourse(string courseID, string userID, string sorting, bool status, string date)
        {
             SqlConnection Connection = Course_Base.GetConnection();
             SqlCommand command = new SqlCommand("SP_COURSE_USER_Course_INSERT", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@CourseID", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@USERID", SqlDbType.Int).Value = userID;
            command.Parameters.Add("@SORTING", SqlDbType.Float).Value = sorting;
            command.Parameters.Add("@STATUS", SqlDbType.Bit).Value = status;
            command.Parameters.Add("@DATE", SqlDbType.NVarChar).Value = date;

            command.ExecuteNonQuery();
        }
    }
}
