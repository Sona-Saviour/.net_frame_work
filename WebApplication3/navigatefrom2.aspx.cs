using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class navigatefrom2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string un=TextBox1.Text;
            string pw = TextBox2.Text;



            Response.Redirect("navigateto2.aspx?n1=" + un + "&n2=" + pw); 
        }
    }
}