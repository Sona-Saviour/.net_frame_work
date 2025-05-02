using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class dropdownexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Add(TextBox1.Text);
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = DropDownList2.SelectedItem.Text;
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox3.Text= DropDownList3.SelectedItem.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(DropDownList4.SelectedIndex!=null)
            {
                DropDownList4.Items.Remove(DropDownList4.SelectedItem);
            }
        }
    }
}