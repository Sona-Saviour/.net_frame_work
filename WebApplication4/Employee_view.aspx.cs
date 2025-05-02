using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Employee_view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbconnection d = new dbconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Employee";

            SqlDataReader dr = d.getresult(cmd);

            GridView1.DataSource = dr;
            GridView1.DataBind();
        }
    }
}