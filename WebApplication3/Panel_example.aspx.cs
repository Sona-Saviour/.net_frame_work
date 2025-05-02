using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Panel_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Panel2.Visible = false;
                Panel3.Visible = false;
            }
        } 

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel2.Visible=true;
            TextBox1.Text = DropDownList1.SelectedItem.Value;
            Panel3.Visible=false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int p=Convert.ToInt32(TextBox1.Text);
            int n=Convert.ToInt32(TextBox2.Text);
            int price = p * n;
            Panel3.Visible=true;
            TextBox3.Text=price.ToString();
        }
    }
}