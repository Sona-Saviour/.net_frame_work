using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "")
            {
                Label6.Text = "enter name";
            }
            else
            {
                Label6.Text = "";
            }
            if (DropDownList1.SelectedItem.Value == "-1")
            {
                Label7.Text = "select your qualification";
            }
            else
            {
                Label7.Text = "";
            }
            if (!RadioButton1.Checked && !RadioButton2.Checked && !RadioButton3.Checked)
            {
                Label8.Text = "select your gender";
            }
            else
            {
                Label8.Text = "";
            }
            if (DropDownList2.SelectedItem.Value == "-1")
            {
                Label11.Text = "select district";
            }
            else
            {
                Label11.Text = "";
            }
            if (!CheckBox1.Checked)
            {
                Label9.Text = "please confirm";
            }
            else
            {
                Label9.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = -1;
            RadioButton1.Checked=false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            TextBox2.Text = "";
            DropDownList2.SelectedIndex = -1;
            CheckBox1.Checked = false;
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label11.Text = "";

        }
    }
}