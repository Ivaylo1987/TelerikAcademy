using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsBasics
{
    public partial class ExecutionAssembly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonAssembly_Click(object sender, EventArgs e)
        {
            var result = Assembly.GetExecutingAssembly().Location;
            this.TextAssemblyInfo.Text = result;
        }
    }
}