using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Dropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> employee = new Dictionary<string, string>
            {
                {"123","Appu" },
                {"234","Karun" },
                {"876","Kiran" }
            };
            foreach (var emp in employee) {

                ddlemployee.Items.Add(new ListItem(emp.Value, emp.Key));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlemployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(ddlemployee.SelectedItem.Value) == -1)
            {
                Label2.Text = "select an employee";
            }
            else { 
            Label2.Text="selected employee:"+ ddlemployee.SelectedItem.Text
                    + "<br> His/Her Emp_code :" + ddlemployee.SelectedValue;            
            }
        } 
    }
}