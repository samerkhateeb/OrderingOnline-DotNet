using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CheckOut_Module
{
    public class CheckOut_Info
    {
        public string companyID{ get {return "1200"; }}
        public string ChainID { get { return "33"; }}
        public string LocationID { get { return "COT"; }}
        public long SalesTXNID { get; set; }


        //public int Voucher_Number { get; set; }
        public DateTime Voucher_Date { get { return DateTime.Now.AddHours(Convert.ToDouble(ConfigurationManager.AppSettings["Timedifference"])); } }
        public string EmployeeID { get { return "Webuser"; } }
        public DateTime startDate { get { return DateTime.Now; } }
        public DateTime startTime { get { return DateTime.Now; } }
        public double total { get; set; }
        public int Void_Count { get { return 0; } }
        public double VoidAmount { get{ return 0; } }
        public string OrderType { get; set; }
        public string Voucher_Status { get { return "S"; } }
        public string Telephone { get; set; }
        public string Grid_ID { get; set; }

        public string Location_Code { get; set; }
        public DateTime DeliveryTime { get; set; }
        public bool Modified { get{ return false; }}
        public string Remarks { get; set; }
        public double OtherCharge { get; set; }
        public double DeliveryCharge { get; set; }
        public bool Timed_Order { get { return false; } }
        public int Del_Minutes { get {return 45; }}
        public int Serial_Number { get { return 1; } }






        public string Item_Code { get; set; }
        public double Item_Price { get; set; }
        public double Item_Quantity { get; set; }
        public int LineNumber { get { return 1; } }
        public string Sales_Status { get { return "S"; } }
        public DateTime System_Date { get { return DateTime.Now; } }
        public DateTime System_Time { get { return DateTime.Now; } }
        public string Item_Name { get; set; }
        public int Line_ID { get { return 1; } }



        public bool Kitchen_PrintID { get { return false; } }
    }
}
