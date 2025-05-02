using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class radiobutton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {   
            if (rbtmale.Checked)
                    {
                    Label1.Text="you have selected "+ rbtmale.Text;
                }

            else if(rbtfemale.Checked)
                    {
                Label1.Text = "you have selected " + rbtfemale.Text;
            }
            else if (rbtothers.Checked)
            {
                Label1.Text = "you have selected " + rbtothers.Text;
            }
            else
            {
                Label1.Text = "select any option ";
            }
        }
    }
}