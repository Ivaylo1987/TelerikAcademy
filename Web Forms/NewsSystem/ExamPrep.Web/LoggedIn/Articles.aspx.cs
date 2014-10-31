using ExamPrep.Models;
using ExamPrep.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamPrep.Web.LoggedIn
{
    public partial class Articles : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<ExamPrep.Models.Article> ListViewArticles_GetData()
        {
            var articles = this.Data.Articles.OrderByDescending(a => a.Id);
            return articles;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_DeleteItem(int id)
        {
            var toDelete = this.Data.Articles.Find(id);
            this.Data.Articles.Remove(toDelete);
            this.Data.SaveChanges();
        }

        public IQueryable<Category> DropDownListCategoriesCreate_GetData()
        {
            return this.Data.Categories.OrderBy(b => b.Name);
        }

        public void ListViewArticles_InsertItem()
        {
            var item = new ExamPrep.Models.Article();
            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                this.Data.Articles.Add(item);
                this.Data.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewArticles_UpdateItem(int id)
        {
            Article item = this.Data.Articles.Find(id);
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.Data.SaveChanges();
            }
        }

        protected void LinkButtonInsertNewArticle_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/LoggedIn/NewArticle");
        }

    }
}