using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServerControls
{
    public partial class RandomNumberWebControls : System.Web.UI.Page
    {
        private Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGetNumber_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var first = int.Parse(this.ImputFirstDigit.Text);
                var second = int.Parse(this.ImputSecondDigit.Text);

                var result = this.random.Next(first, second + 1);

                this.ImputResult.Text = result.ToString();
            }
            catch (Exception exeption)
            {

                this.ImputResult.Text = "Invalid input value";
            }
        }
    }
}