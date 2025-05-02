using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class grade_card : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void n0_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btng_Click(object sender, EventArgs e)
        {
            string m = n.Text;
            int m1 = int.Parse(n1.Text);
            int m2 = int.Parse(n2.Text);
            int m3 = int.Parse(n3.Text);
            int m4 = int.Parse(n4.Text);
            double t = m1 + m2 + m3 + m4;
            double p = (t / 200) * 100;

            string grade = "";
            if (p >= 90)
            {
                grade = "A grade";
            }
            else if (p >= 80)
            {
                grade = "B grade";
            }
            else if (p >= 70)
            {
                grade = "C grade";
            }

            else if (p >= 60)
            {
                grade = "D grade";
            }
            else if (p >= 50)
            {
                grade = "E grade";
            }
            else
            {
                grade = "failed";
            }

                c.Text = "Student Name: " + m + "<br>" +
            "Total Marks: " + t.ToString() + "<br>" +
            "Percentage: " + p.ToString() + "%<br>" +
            "Grade: " + grade;
            }
        }
    }