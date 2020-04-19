using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net.Asp.net_practice
{
    public partial class _36_Wizard_Control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Wizard1.ActiveStepIndex==0)
            {
                //To focus the textbox on page load. 
                txtFirstName.Focus();
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 1)
            {
                //This Id was taken from view source page in browser.

                //"Wizard1_StepNavigationTemplateContainerID_StepNextButton".

                //This below step is added to give onclick functionality to the defaulty added next button programitacally or here we are giving javascript inclientclick event.

                Button stepbutton=(Button)Wizard1.FindControl("StepNavigationTemplateContainerID").FindControl("StepNextButton");

                stepbutton.OnClientClick = "return confirm('Are you sure?')";

                //To focus the textbox on page load. 
                txtEmail.Focus();
            }
        }
        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (e.NextStepIndex == 2)
            {
                lblFirstName.Text = txtFirstName.Text;
                lblLastName.Text = txtLastName.Text;
                lblGender.Text = ddlGender.SelectedValue;

                lblEmail.Text = txtEmail.Text;
                lblMobile.Text = txtMobile.Text;
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Redirect("~/Confirmation.aspx");
        }
    }
}