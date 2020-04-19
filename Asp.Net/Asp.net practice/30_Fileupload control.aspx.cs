using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class _30_Fileupload_control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileExtension.ToLower() != ".doc" && fileExtension.ToLower() != ".docx")
                {
                    Response.Write("Please upload .doc or .docx");
                }
                else
                {
                    int filesize = FileUpload1.PostedFile.ContentLength;
                    if (filesize > 2097152)
                    {
                        Label1.Text = "File size is more than 2MB";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Local Uploads/" + FileUpload1.FileName));
                        Label1.Text = "File Uploaded";
                        Label1.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                Label1.Text = "Please choose the file to upload";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}