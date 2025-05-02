using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class calendar_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //Res
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text=(Calendar1.SelectedDate + "<br>");
            string dattim= Calendar1.SelectedDate.ToString();
            string[] arr = dattim.Split(' ');
            Label1.Text +=("Selected Date: " + arr[0] + "<br>");
            Label1.Text += ("Selected Time: " + arr[1] + "<br>");

        }
    }
}