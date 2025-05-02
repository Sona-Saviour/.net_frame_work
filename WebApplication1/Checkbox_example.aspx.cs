using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Checkbox_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dictionary<string, string> employee = new Dictionary<string, string>
            {
                {"1","Anu" },
                {"2","Manu" },
                {"3","Vinu" }
            };
                foreach (var emp in employee)
                {

                    CheckBoxList1.Items.Add(new ListItem(emp.Value, emp.Key));
                }
            }
        }
        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            if (chk1.Checked)
            {
                Label1.Text = Label1.Text + chk1.Text+ "\t";
            }
            if (chk2.Checked)
            { 
               Label1.Text= Label1.Text + chk2.Text+ "\t";
            }
            if (chk3.Checked)
            {
                Label1.Text = Label1.Text + chk3.Text+ "\t";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<string> selectedoptions = new List<string>();
            foreach(ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    selectedoptions.Add(item.Value+"--"+item.Text);
                }
            }
            Label2.Text = string.Join("<br>", selectedoptions);

            Response.Write(String.Join(",", selectedoptions));
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}