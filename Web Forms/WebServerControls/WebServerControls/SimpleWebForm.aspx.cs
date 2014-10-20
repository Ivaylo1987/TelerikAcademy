using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServerControls
{
    public partial class SimpleWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PanelMain.GroupingText = "Details";
            this.PanelSubmit.GroupingText = "Submited Data";
            this.PanelSubmit.Visible = false;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.PanelSubmit.Visible = true;

            this.PanelSubmit.Controls.Add(this.GetParagraph("First Name", this.TextFirstName.Text));
            this.PanelSubmit.Controls.Add(this.GetParagraph("Last Name", this.TextFirstName.Text));
            this.PanelSubmit.Controls.Add(this.GetParagraph("Faculty Number", this.TextFacultyNumber.Text));
            this.PanelSubmit.Controls.Add(this.GetParagraph("University", this.DropUniversity.SelectedItem.Text));
            this.PanelSubmit.Controls.Add(this.GetParagraph("Courses"));

            foreach (ListItem item in this.ListCourses.Items)
            {
                if (item.Selected)
                {
                    this.PanelSubmit.Controls.Add(this.GetParagraph("Course", item.Text));
                }
            }
        }

        private LiteralControl GetParagraph(string type, string value = "")
        {
            var literalData = string.Format("<p>{0}: {1}</p>", type, Server.HtmlEncode(value));
            var literalResult = new LiteralControl(literalData);

            return literalResult;
        }
    }
}