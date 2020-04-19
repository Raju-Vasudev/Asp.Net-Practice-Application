using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net.Asp.net_practice
{
    public partial class _86_Impersonate_of_Anonymous_authentication : System.Web.UI.Page
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

            /*This will enable or disable the impersonate.This will ensure that the application code is exxcuted by using the "IUSR" account but earlier the code is executed with IIS pool identity.
            we can add this impersonate from web.conifg file or from iis server.
            To add from web.config----We have to add we have add identity element and within that element set impersonate = "true"
            TO add from server select the pool that the application hosted.edit app pool and select basic settings and MANAGED PIPELINE MODE = CLASSIC.*/
        }
    }
}