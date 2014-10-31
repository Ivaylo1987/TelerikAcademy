using ExamPrep.Models;
using ExamPrep.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace ExamPrep.Web.LoggedIn
{
    public partial class NewArticle : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.DropDownCategories.DataSource = this.Data.Categories.ToArray();
                this.DropDownCategories.DataBind();
            }
            
        }

        protected void LinkButtonUpdate_Click(object sender, EventArgs e)
        {
            var title = this.ArticleTitle.Text;
            var description = this.ArticleContent.Text;
            var categoryId = this.DropDownCategories.SelectedValue;

            var article = new Article()
            {
                Title = title,
                Content = description,
                CategoryId = int.Parse(categoryId),
                DateCreated = DateTime.Now,
                Author = this.Data.Users.Find(Thread.CurrentPrincipal.Identity.GetUserId())
            };

            this.Data.Articles.Add(article);
            this.Data.SaveChanges();
            this.Response.Redirect("~/LoggedIn/Articles");
        }

        protected void LinkButtonCancel_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/LoggedIn/Articles");
        }
    }
}