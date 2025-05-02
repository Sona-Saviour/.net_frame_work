using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class age : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int b = int.Parse(a.Text);
            if (b >= 18)
            {
                Label2.Text = "major";
            }
            else
            {
                Label2.Text = "minor";
            }
        }
    }
}