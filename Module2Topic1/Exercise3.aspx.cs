using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                finalGrade.Text = "Submit your grade";
            }
        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            double percentage;
            if (double.TryParse(percentageGrade.Text, out percentage))
            {
                string grade;
                if (percentage >= 96)
                {
                    grade = "1.00";
                }
                else if (percentage >= 91.51 && percentage <= 95.99)
                {
                    grade = "1.25";
                }
                else if (percentage >= 87.01 && percentage <= 91.50)
                {
                    grade = "1.50";
                }
                else if (percentage >= 82.51 && percentage <= 87.00)
                {
                    grade = "1.75";
                }
                else if (percentage >= 78.01 && percentage <= 82.50)
                {
                    grade = "2.00";
                }
                else if (percentage >= 73.51 && percentage <= 78.00)
                {
                    grade = "2.25";
                }
                else if (percentage >= 69.01 && percentage <= 73.50)
                {
                    grade = "2.50";
                }
                else if (percentage >= 64.51 && percentage <= 69.00)
                {
                    grade = "2.75";
                }
                else if (percentage >= 60.00 && percentage <= 64.50)
                {
                    grade = "3.00";
                }
                else if (percentage >= 63.00 && percentage <= 60.00)
                {
                    grade = "5";
                }
                else
                {
                    grade = "Not available";
                }

                finalGrade.Text = grade;

               
            }
           
        }
    }
}
