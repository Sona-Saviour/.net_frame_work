using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class addd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(Text1.Text);
            int n2 = int.Parse(Text2.Text);
            int sum = n1 + n2;
            result.Text= sum.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(Text1.Text);
            int n2 = int.Parse(Text2.Text);
            int sub = n1 - n2;
            result.Text = sub.ToString();
        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(Text1.Text);
            int n2 = int.Parse(Text2.Text);
            int mul = n1 * n2;
            result.Text = mul.ToString();
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(Text1.Text);
            int n2 = int.Parse(Text2.Text);
            int div = n1/n2;
            result.Text = div.ToString();
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            Text1.Text = "";
            Text2.Text = "";
            result.Text = "";
        }
    }
}