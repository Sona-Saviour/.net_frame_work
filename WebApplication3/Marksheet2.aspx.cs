using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Marksheet2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["name"].ToString();
            double n1= Convert.ToDouble(Session["m1"].ToString());
            double n2 = Convert.ToDouble(Session["m2"].ToString());
            double n3 = Convert.ToDouble(Session["m3"].ToString());
            double n4 = Convert.ToDouble(Session["m4"].ToString());
            double sum=n1+ n2 + n3 + n4;
            double avg = sum / 4 ;
            Label2.Text = Math.Round(sum, 2).ToString();
            Label3.Text = Math.Round(avg, 2) + "%";
        }
    }
}