using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class data_connectivity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {   
            dbconnection db1 = new dbconnection(); //create object
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "insert into student values(@id_value,@name_value,@age_value)";
            cmd.Parameters.AddWithValue("@id_value", int.Parse(TextBox2.Text));
            cmd.Parameters.AddWithValue("@name_value", TextBox1.Text);
            cmd.Parameters.AddWithValue("@age_value", int.Parse(TextBox3.Text));

            db1.execute(cmd);
        }
    }
}