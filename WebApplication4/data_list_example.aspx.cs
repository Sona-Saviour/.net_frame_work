using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class data_list_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                BindData();
            }
        }

    
    protected void Button1_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "Remove")
            {
                int idToRemove = Convert.ToInt32(e.CommandArgument);

                dbconnection db = new dbconnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE id=@id");
                cmd.Parameters.AddWithValue("id", idToRemove);
                db.execute(cmd);

                BindData();
            }
        }

        public void BindData()
        {
            dbconnection db = new dbconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Employee";
            SqlDataReader dr = db.getresult(cmd);
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}