using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class bmi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_Click(object sender, EventArgs e)
        {
            int w=int.Parse(weight.Text);
            int h=int.Parse(height.Text);
            double m = h / 100.0;
            double y = w / (m * m);
            bm.Text=y.ToString();
        }
    }
}