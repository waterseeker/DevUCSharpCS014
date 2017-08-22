using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime myValue = DateTime.Now;
            //resultLabel.Text = myValue.ToString();
            //resultLabel.Text = myValue.ToLongDateString();
            //resultLabel.Text = myValue.ToShortDateString();
            //resultLabel.Text = myValue.ToShortTimeString();

            //adjusting the date
            //resultLabel.Text = myValue.DayOfWeek.ToString();
            //resultLabel.Text = myValue.AddDays(-2).DayOfWeek.ToString();
            resultLabel.Text = myValue.AddHours(-4).ToLongTimeString();
        }
    }
}