using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Radiobutton_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dictionary<string, string> gender = new Dictionary<string, string>
            {

                {"1","Male" },
                {"2","Female" },
                {"3","Others" }
            };

                foreach (var gen in gender)
                {
                    RadioButtonList2.Items.Add(new ListItem(gen.Value, gen.Key));
                }
            }
        }


        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text=RadioButtonList1.SelectedItem.Text;
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "Value:   " + RadioButtonList2.SelectedItem.Text;
        }
    }
}