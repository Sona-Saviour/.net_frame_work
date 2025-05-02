using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Marksheet1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"]=TextBox1.Text;
            Session["m1"] =TextBox2.Text;
            Session["m2"] = TextBox3.Text;
            Session["m3"] = TextBox4.Text;
            Session["m4"] = TextBox5.Text;
            Response.Redirect("Marksheet2.aspx");
        }
    }
}