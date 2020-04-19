using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class _28_BulletedList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Properties of BulletedList
        //BulletStyle - This property, is used to customize the bullets style.If CustomImage is specified as the BulletStyle, then BulletImageURL, also needs to be specified.


        //FirstBulletNumber - The Number at which the ordered list starts.
        //DisplayMode - Can be Text, HyperLink or LinkButton.The default is Text.

        protected void CountriesBulletedList_Click(object sender, BulletedListEventArgs e)
        {
            ListItem li = CountriesBulletedList.Items[e.Index];
            Response.Write("Text = " + li.Text + "<br/>");
            Response.Write("Value = " + li.Value + "<br/>");
            Response.Write("Index = " + e.Index.ToString());
        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}