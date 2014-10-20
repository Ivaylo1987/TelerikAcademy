using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsBasics
{
    public partial class HelloName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonDisplay_Click(object sender, EventArgs e)
        {
            var result = "Hello, " + this.TextName.Text;

            TextResult.Text = result;
        }
    }
}