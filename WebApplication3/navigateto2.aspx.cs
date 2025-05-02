using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class navigateto2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["n1"];
            string password = Request.QueryString["n2"];

            Label1.Text = "Welcome " + name + "<br> Your password is " + password; 
        }
    }
}