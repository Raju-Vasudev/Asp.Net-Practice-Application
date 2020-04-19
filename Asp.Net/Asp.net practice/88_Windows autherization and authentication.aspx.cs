using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net.Asp.net_practice
{
    public partial class _88_Windows_autherization_and_authentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Name of the App Pool Ideentity used to run this Application ::");
            Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name + "<br/>");

            Response.Write("Is User Authenticated ::");
            Response.Write(User.Identity.IsAuthenticated + "<br/>");

            Response.Write("Authentication type, If authenticated ::");
            Response.Write(User.Identity.AuthenticationType + "<br/>");

            Response.Write("Name of the user ::");
            Response.Write(User.Identity.Name + "<br/>");
        }
    }
}