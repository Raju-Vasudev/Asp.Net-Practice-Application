using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net.Asp.net_practice
{
    public partial class _85_Anonymous_Authentication_part1 : System.Web.UI.Page
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


            /*We can add anonymous authentication to the web application from web server(IIS) by click on APPLICATION and select the Autyentication(Double click)
            and by default it is enabled.*/
            /*IUSE is the deafult Anoymous account in iis 10.*/

        }
    }
}