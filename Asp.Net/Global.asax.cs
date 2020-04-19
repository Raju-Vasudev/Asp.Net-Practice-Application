using Asp.Net.Asp.net_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Asp.Net
{
    public class Global : HttpApplication
    {



        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Application_Error(object sender, EventArgs e)
        {
           Exception exception = Server.GetLastError();
            if(exception != null)
            {
                ExceptionLoggerClass.Log(exception);
                ExceptionLoggerClass.LogToDB(exception.ToString());
                Server.ClearError();
                Server.Transfer("~/Asp.net practice/Error.aspx");
            }

        }
    }
}