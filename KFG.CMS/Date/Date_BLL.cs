using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace KFGCMS.BLL
{
    public class Date_BLL
    {
        public string HeaderDate(DateTime DateTime)
        {
            //string hijriDate = Global_BLL.FilterDateToHijriDate(value);
           // string normalDate = Global_BLL.FilterDateToDate(DateTime);

             //String.Format("{0} corresponding to {1}", hijriDate, normalDate)

            if ( Pages_BLL.GetLanguage() == "arb")
                return String.Format("{0}", FilterDateToArbDate(DateTime));
            else
                return String.Format("Date: {0}", FilterDateToUSADateString(DateTime));

        }



        public static string FilterDateToTime(object Date)
        {
            return (Convert.ToDateTime(Date)).ToString("HH:mm");
        }

        public static string FilterDateToDate(object date)
        {

          //return (Convert.ToDateTime(date)).ToString("d/M/yyyy", CultureInfo.CreateSpecificCulture("ar-JO"));
            return (date).ToString().Substring(0, 10);
        }
        
        public static string FilterDateToArbDate(DateTime date)
        {
            return date.ToString("yyyy/MM/dd", CultureInfo.CreateSpecificCulture("ar-JO")).Substring(0, 10);
        }

        public static string FilterDateToUSADateString(DateTime date)
        {
            return date.ToString("MM/dd/yyyy", CultureInfo.CreateSpecificCulture("en-us")).Substring(0, 10);
        }

        public static DateTime FilterDateToUSADate(DateTime date)
        {
            return Convert.ToDateTime(date.ToString("MM/dd/yyyy", CultureInfo.CreateSpecificCulture("en-us")));
        }

        public static string FilterDateToJODate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy", CultureInfo.CreateSpecificCulture("ar-JO")).Substring(0, 10);
        }


        public static string FilterDateToHijriDate(DateTime date)
        {
            return (date).ToString("yyyy/M/d", CultureInfo.CreateSpecificCulture("ar-SA"));
        }
    }
}
