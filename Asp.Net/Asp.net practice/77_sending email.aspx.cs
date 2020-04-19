using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Asp.Net.Asp.net_practice
{
    public partial class _77_sending_email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string mailbody= TextBox1.Text;
           SendMail(mailbody);
           Server.Transfer("~/Asp.net practice/Confirmation.aspx");
           Response.Write("Mail hes sent.");

        }
        private void SendMail(string mailbody)
        {
            MailMessage mailMessage = new MailMessage("testexample588@gmail.com", "chittemvaibhav134@gmail.com");
            mailMessage.Subject = "Testing mail";
            mailMessage.Body=mailbody;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "testexample588@gmail.com",
                Password = "123abc!@#"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);

        }
    }

}