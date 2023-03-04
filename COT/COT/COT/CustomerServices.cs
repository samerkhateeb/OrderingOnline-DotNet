using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace COT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CustomerServices : ICustomerServices
    {
        string connString = "";

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public string ExecuteNoneQuery(SqlCommand command)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand comm = command;
                    comm.Connection = connection;
                    comm.ExecuteNonQuery();
                }
                return "Success " + DateTime.Now.ToString();
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
