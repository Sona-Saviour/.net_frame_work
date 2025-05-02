using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Multiplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n= int.Parse(T4.Text);
            string table = "";
            for (int i = 0; i <= 10; i++) {
                table += $"{n} x {i} = {n * i}<br/>";
            }
            Label2.Text = table;
        }
    }
}