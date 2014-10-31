using ExamPrep.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamPrep.Web.LoggedIn
{
    public partial class Categories : BasePage
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
        public IQueryable<ExamPrep.Models.Category> ListViewCategories_GetData()
        {
            return this.Data.Categories.OrderBy(c => c.Id);
        }

        public void ListViewCategories_InsertItem()
        {
            var item = new ExamPrep.Models.Category();
            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                this.Data.Categories.Add(item);
                this.Data.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_UpdateItem(int id)
        {
            ExamPrep.Models.Category item = this.Data.Categories.Find(id);
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

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_DeleteItem(int id)
        {
            var toDelete = this.Data.Categories.Find(id);
            this.Data.Categories.Remove(toDelete);
            this.Data.SaveChanges();
        }
    }
}