using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class gridview1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbconnection  db= new dbconnection(); 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from student";
            
            SqlDataReader dr = db.getresult(cmd);

            GridView2.DataSource = dr; 
            GridView2.DataBind(); 
        }
    }
}