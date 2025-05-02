using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class progresscard3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["score1"] = TextBox1.Text;
            Session["score2"] = TextBox2.Text;
            Session["score3"] = TextBox3.Text;
            Response.Redirect("progresscard4.aspx");
        }
    }
}