using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class example_file_upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName=FileUpload1.FileName;
                string filePath = Server.MapPath("~/file_upload/" + fileName);
                FileUpload1.SaveAs(filePath);
                Label2.Text = "File uploaded successfully";
            }
            else
            {
                Label2.Text = "Please select a file to upload";
            }
        }
    }
}