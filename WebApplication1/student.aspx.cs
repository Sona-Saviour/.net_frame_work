using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sa_Click(object sender, EventArgs e)
        {
            int a = int.Parse(phy.Text);
            int b = int.Parse(mat.Text);
            int c = int.Parse(eng.Text);
            int sum = a+b+c;
            int avg = sum / 3;
            res.Text = "sum:"+ sum.ToString()+"<br>"+"avg:"+ avg.ToString();
           
        }
    }
}