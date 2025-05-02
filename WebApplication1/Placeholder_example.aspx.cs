using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
    
{
    public partial class Placeholder_example : System.Web.UI.Page
    {    

        public Label textlabel=new Label();
        public TextBox textBox=new TextBox();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // create new label control
            textlabel.Text = "This is dynamically added label";

            // add the label to the placeholder

            PlaceHolder1.Controls.Add(textlabel);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}