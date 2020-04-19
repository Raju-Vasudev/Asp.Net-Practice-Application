using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region ListBox
//        Properties
//Rows : The number of visible rows in the Listbox.A scrollbar is automatically generated, if the total number of item are greater than the number of visible rows in the listbox.
//SelectionMode : SelectionMode can be Single or Multimple. By default, this property value is Single, meaning when the listbox renders, the user can select only one item from the listbox. Set this property to Multimple, to enable multiple item selections.To select, multiple items from the listbox, hold-down the CTRL key, while the listitem's are selected.

        #endregion
        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    Response.Write("Text = " + li.Text + ", ");
                    Response.Write("Value = " + li.Value + ", ");
                    Response.Write("Index = " + ListBox1.Items.IndexOf(li).ToString());
                    Response.Write("<br/>");
                }
            }
        }
    }
}