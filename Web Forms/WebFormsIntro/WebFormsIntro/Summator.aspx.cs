using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsIntro
{
    public partial class Summator : Page
    {
        
        protected void btnSum_Click(object sender, EventArgs e)
        {
            this.TextResult.Enabled = false;
            try
            {
                var first = decimal.Parse(this.TextFirstDigit.Text);
                var second = decimal.Parse(this.TextSecondDigit.Text);
                this.TextResult.Text = (first + second).ToString();
            }
            catch (Exception)
            {
                this.TextResult.Text = "Invalid input";
            }
            
        }
    }
}