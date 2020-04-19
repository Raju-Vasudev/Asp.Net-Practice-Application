using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class _29_List_controls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddListItems(DropDownList1);
                AddListItems(CheckBoxList1);
                AddListItems(RadioButtonList1);
                AddListItems(ListBox1);
                AddListItems(BulletedList1);
            }
        }
        private void AddListItems(ListControl listControl)
        {
            ListItem li1 = new ListItem("Item1", "1");
            ListItem li2 = new ListItem("Item2", "2");
            ListItem li3 = new ListItem("Item3", "3");

            listControl.Items.Add(li1);
            listControl.Items.Add(li2);
            listControl.Items.Add(li3);
        }
        //ListBox(If SelectionMode = Multiple) and CheckBoxList allows user to select multiple items.So, to retrieve all the selected listitem's Text, Value and Index use a foreach loop.
        //Reusable method that can be used with any control that derives from ListControl class, but works best with controls that allows multiple selections.

        private void RetrieveMultipleSelections(ListControl listControl)
        {
            foreach (ListItem li in listControl.Items)
            {
                if (li.Selected)
                {
                    Response.Write("Text = " + li.Text + ", Value = " + li.Value +
                        ", Index = " + listControl.Items.IndexOf(li).ToString() + "<br/>");
                }
            }
        }

        //ListBox(If SelectionMode = Single), RadioButtonList and DropDownList allows user to select only one item.So, use SelectedIndex and SelectedItem properties to retrieve the Text, Value and Index of the selected listitem.
        //Reusable method that can be used with any control that derives from ListControl class, but works best with controls that allows single selection.

        private void RetrieveSelectedItemTextValueandIndex(ListControl listControl)
        {
            if (listControl.SelectedIndex != -1)
            {
                Response.Write("Text = " + listControl.SelectedItem.Text + "<br/>");
                Response.Write("Value = " + listControl.SelectedItem.Value + "<br/>");
                Response.Write("Index = " + listControl.SelectedIndex.ToString());
            }
        }

        //BulletedList(If DisplayMode = LinkButton) - In the click event handler, use the BulletedListEventArgs parameter object to retrieve the Text, Value and Index of the listitem, the user has clicked.

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {
            ListItem li = BulletedList1.Items[e.Index];
            Response.Write("Text = " + li.Text + "<br/>");
            Response.Write("Value = " + li.Value + "<br/>");
            Response.Write("Index = " + e.Index.ToString());
        }
    }

}