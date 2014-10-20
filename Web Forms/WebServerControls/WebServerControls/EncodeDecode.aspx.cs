using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServerControls
{
    public partial class EncodeDecode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGetText_Click(object sender, EventArgs e)
        {
            var input = this.TextImput.Text;

            var encoded = Server.HtmlEncode(input);
            this.LabelOutputEncoded.Text = encoded;
            this.LabelOutputNotEncoded.Text = input;
            this.TextOutput.Text = input;

            var doubleEncoded = Server.HtmlEncode(encoded);
            this.LabelOutputDoubleEncoded.Text = doubleEncoded;
        }
    }
}