using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Sessionexample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["uname"] = TextBox1.Text;
            Session["pword"] = TextBox2.Text;
            Response.Redirect("sessionexample2.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}