using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class States : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (int.Parse(ddlstates.SelectedItem.Value) == -1)
            {
                Label2.Text = "select an state";
                return;
            }
              

            else if (int.Parse(ddlstates.SelectedValue) == 001)
            {
                Label2.Text = "";
                ddlDistricts.Items.Clear();
                Dictionary <string, string> state = new Dictionary<string, string>
            {
                {"Select district","Select district "},
                {"Thrissur","Thrissur" },
                {"Kottayam","Kottayam" },
                {"Kozhikode","Kozhikode" }
            };
           
                foreach (var s in state)
                {

                    ddlDistricts.Items.Add(new ListItem(s.Value, s.Key));
                }
            }

            else if (int.Parse(ddlstates.SelectedValue) == 002)
            {
                Label2.Text = "";
                ddlDistricts.Items.Clear();
                Dictionary<string, string> stat = new Dictionary<string, string>
            {   

                {"Select district","Select district "},
                {"Chennai","Chennai" },
                {"Madurai","Madurai" },
                {"Coimbatore","Coimbatore" }
            };

                foreach (var ss in stat)
                {

                    ddlDistricts.Items.Add(new ListItem(ss.Value, ss.Key));
                }
            }
            else if (int.Parse(ddlstates.SelectedValue) == 003)
            {
                Label2.Text = "";
                ddlDistricts.Items.Clear();
                Dictionary<string, string> sta = new Dictionary<string, string>
            {
                {"Select district","Select district "},
                {"Bangalore","Bangalore" },
                {"Mysore","Mysore" },
                {"Udupi","Udupi" }
            };

                foreach (var sss in sta)
                {

                    ddlDistricts.Items.Add(new ListItem(sss.Value, sss.Key));
                }
            }
            else
            {
                //ddlDistricts.Items.Clear();
                //ddlDistricts.Items.Add("Select District");
            }
        }

        protected void ddlDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}