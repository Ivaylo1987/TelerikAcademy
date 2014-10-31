using ExamPrep.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamPrep.Web
{
    public partial class ViewArticle : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.User.Identity.IsAuthenticated)
            {
               var likePanel = this.FormViewAViewArticle.FindControl("LikePanle") as Panel;
               likePanel.Visible = true;
            }
        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public ExamPrep.Models.Article FormViewAViewArticle_GetItem()
        {
            var id = int.Parse(this.Request.Params["id"]);
            var article = this.Data.Articles.Find(id);

            return article;
        }
    }
}