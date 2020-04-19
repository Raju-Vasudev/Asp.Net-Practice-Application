using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class _27_RadiobuttonList_Control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem != null)
            {
                Response.Write("Text " + RadioButtonList1.SelectedItem.Value + "</br>");
                Response.Write("Text " + RadioButtonList1.SelectedItem.Text + "</br>");
                Response.Write("Text " + RadioButtonList1.SelectedIndex.ToString() + "</br>");
            }
            // If the user has not selected anything
            else
            {
                Response.Write("Please select ");
            }
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            RadioButtonList1.SelectedIndex = -1;
        }
    }
}