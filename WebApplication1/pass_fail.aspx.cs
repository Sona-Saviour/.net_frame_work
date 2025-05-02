using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class pass_fail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnpf_Click(object sender, EventArgs e)
        {
            int a = int.Parse(m.Text);
            string b = n.Text;
            if (a >= 40)
            {
                s.Text = "congratulations\t"+b+"\tyou have passed";
                s.ForeColor = System.Drawing.Color.Green;
            }
            else {

                s.Text = "Sorry,\t"+b+"\tyou  failed";
                s.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}