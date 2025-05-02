using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Panel4.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel3.Visible = false;
            Panel4.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(T1.Text);
            int count = num.ToString().Length;
            int t = num;
            int s = 0;
            while (t != 0)
            {
                int r = t % 10;
               
                s = (int) (s + Math.Pow(r, count));
                t = t / 10;

            }
            if (s == num)
            {
                Label2.Text = "armstrong number";
            }
            else
            {
                Label2.Text = "not an armstrong nmumber";
            }
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int ll = int.Parse(T2.Text);
            int ul = int.Parse(T3.Text);
            
            string result = "";
            for (int i = ll; i < ul; i++)
            {
                int t = i;
                int count = 0;
                while (t != 0)
                {
                
                    t = t / 10;
                    count++;

                }
                t = i;
                int s = 0;
                while (t != 0)
                {
                    int r = t % 10;

                    s = (int)(s + Math.Pow(r, count));
                    t = t / 10;

                }
                if (s == i)
                {
                    result += " " + i + "<br> ";
                }
                

            }
            Label5.Text = "Armstrong numbers: " + result+"<br>";
        }

    }
}