using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Quiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int score = 0;


            if (RadioButtonList1.SelectedValue == "1") { score = score + 5; } else if(RadioButtonList1.SelectedValue == "0") { score = score - 1; }
            if (RadioButtonList2.SelectedValue == "1") score = score + 5; else if (RadioButtonList2.SelectedValue == "0") { score = score - 1; }
            if (RadioButtonList3.SelectedValue == "1") score=score+5; else if (RadioButtonList3.SelectedValue == "0") { score = score - 1; }
            if (RadioButtonList4.SelectedValue == "1") score=score+5; else if (RadioButtonList4.SelectedValue == "0") { score = score - 1; }
            if (RadioButtonList5.SelectedValue == "1") score=score+5; else if (RadioButtonList5.SelectedValue == "0")  score = score - 1; 

            Label6.Text = $"Your score : {score}";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RadioButtonList1.ClearSelection();
            RadioButtonList2.ClearSelection();
            RadioButtonList3.ClearSelection();
            RadioButtonList4.ClearSelection();
            RadioButtonList5.ClearSelection();

            Label6.Text = "";
        }
    }
}