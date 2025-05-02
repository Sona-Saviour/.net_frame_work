using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Reverse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TextBox1.Text);
            int rev = 0;
            while (n != 0)
            {
                int r = n % 10;
                rev = (rev * 10) + r;
                n = n / 10;
            }
             res.Text = rev.ToString();
        }
    }
}