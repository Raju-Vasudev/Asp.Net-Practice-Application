using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Asp.Net.Asp.net_practice
{
    public partial class _73_Logging_Exceptions__to_the_Windows_Eventviewr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            // DataSet is System.Data namespace
            DataSet ds = new DataSet();
            // This line throws FileNotFoundException
            ds.ReadXml(Server.MapPath("~/Data/Countries.xml"));

            GridView1.DataSource = ds;
            GridView1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLoggerClass.Log(ex);
                Server.ClearError();
                Server.Transfer("~/Asp.net practice/Error.aspx");
            }


        }
    }
}