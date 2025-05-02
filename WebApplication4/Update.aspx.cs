using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Update : System.Web.UI.Page
    {
        //string a = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                string a = Request.QueryString["Id"];
                dbconnection db = new dbconnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from Employee where Id=@id;";
                cmd.Parameters.AddWithValue("@id", a);
                SqlDataReader dr = db.getresult(cmd);

                if (dr.Read())
                {
                    TextBox1.Text = dr.GetInt32(0).ToString();
                    TextBox2.Text = dr.GetString(1);
                    TextBox3.Text = dr.GetString(2);
                    TextBox4.Text = dr.GetInt32(3).ToString();
                    TextBox5.Text = dr.GetString(4);

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dbconnection db = new dbconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Employee set ename=@ename,designation=@designation,salary=@salary,dept=@dept where id=@id";
            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ename", TextBox2.Text);
            cmd.Parameters.AddWithValue("@designation", TextBox3.Text);
            cmd.Parameters.AddWithValue("@salary", TextBox4.Text);
            cmd.Parameters.AddWithValue("@dept", TextBox5.Text);
            db.execute(cmd);

            Response.Redirect("data_list_example.aspx");
        }
    }
}