using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creating_Windows_Custom_EventLoger
{
    public partial class CustomEventLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonToCreateEventlog_Click(object sender, EventArgs e)
        {
            if(EventLogerTextBox.Text != string.Empty && EventlogSourceTextBox.Text != string.Empty)
            {
                System.Diagnostics.EventLog.CreateEventSource(EventlogSourceTextBox.Text, EventLogerTextBox.Text);
                Response.Write("Event logger created. ");
            }
        }
    }
}