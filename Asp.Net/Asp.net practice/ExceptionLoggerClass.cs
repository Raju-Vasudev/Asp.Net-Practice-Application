using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Diagnostics;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Asp.Net.Asp.net_practice
{
    public class ExceptionLoggerClass
    {
        public static void Log(Exception exception)
        {
            // Create an instance of StringBuilder. This class is in System.Text namespace
            StringBuilder sbExceptionMessage = new StringBuilder();

            sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
           
            // Get the exception type
            sbExceptionMessage.Append(exception.GetType().Name);
           
            // Environment.NewLine writes new line character - \n
            sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
            sbExceptionMessage.Append("Message" + Environment.NewLine);
            
            // Get the exception message
            sbExceptionMessage.Append(exception.Message + Environment.NewLine + Environment.NewLine);

            sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
            
            // Get the exception stack trace
            sbExceptionMessage.Append(exception.StackTrace + Environment.NewLine + Environment.NewLine);

            // Retrieve inner exception if any
            Exception innerException = exception.InnerException;
           
            // If inner exception exists
            while (innerException != null)
            {
                sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.GetType().Name);
                sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Message" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.Message + Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.StackTrace + Environment.NewLine + Environment.NewLine);

                // Retrieve inner exception if any
                innerException = innerException.InnerException;
            }

            // If the Event log source exists
            if (EventLog.SourceExists("Raju.com"))
            {
                // Create an instance of the eventlog
                EventLog log = new EventLog("Raju_Custom_Event_Log");
                // set the source for the eventlog
                log.Source = "Raju.com";
                // Write the exception details to the event log as an error
                log.WriteEntry(sbExceptionMessage.ToString(), EventLogEntryType.Error);

                LogToDB(sbExceptionMessage.ToString());
            }
        }

        public static void LogToDB(string exceptionstringbuilderfromlogmethod)
        {
            // ConfigurationManager class is in System.Configuration namespace
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
           
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_ExeceptionLog", con);
               
                // CommandType is in System.Data namespace
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@Exeception_Message", exceptionstringbuilderfromlogmethod);
                cmd.Parameters.Add(parameter);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

