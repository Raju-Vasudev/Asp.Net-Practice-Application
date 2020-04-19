using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Asp.Net.Asp.net_practice
{
    public partial class _79_Tracing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string mailbody = TextBox1.Text;
           
            Server.Transfer("~/Asp.net practice/Confirmation.aspx");
           // Response.Write("Mail hes sent.");

        }
        
    }
}