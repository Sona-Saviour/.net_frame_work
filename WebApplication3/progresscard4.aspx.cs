using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class progresscard4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "student name: "+ Session["name"].ToString();
            Label2.Text=   "class: " + Session["class"].ToString();
            int n1 = Convert.ToInt32(Session["mark1"].ToString());
            int n2 = Convert.ToInt32(Session["mark2"].ToString());
            int n3 = Convert.ToInt32(Session["mark3"].ToString());
            int se = n1 + n2 + n3;

            int m1 = Convert.ToInt32(Session["score1"].ToString());
            int m2 = Convert.ToInt32(Session["score2"].ToString());
            int m3 = Convert.ToInt32(Session["score3"].ToString());
            int si = m1 + m2 + m3;

            Label3.Text= "Total External Marks: " + se.ToString();
            Label4.Text= "Total Internal Marks:" + si.ToString();

            int t = se + si;
            Label5.Text = "Total Marks:" + t.ToString();
        }
    }
}