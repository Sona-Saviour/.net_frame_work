using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class progresscard1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["class"] = TextBox2.Text;
            Session["age"] = TextBox3.Text;
            Response.Redirect("progresscard2.aspx");
        }
    }
}