using ExamPrep.Models;
using ExamPrep.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamPrep.Web
{
    public partial class Search : BasePage
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
        public IQueryable<Book> ListViewResults_GetData([QueryString("q")]string query)
        {
            if (query == null)
            {
                return this.Data.Books;
            }

            var books = this.Data.Books.Where(b => b.Title.Contains(query) || b.Author.Contains(query));
            return books;
        }
    }
}