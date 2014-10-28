using ExamPrep.Models;
using ExamPrep.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamPrep.Web
{
    public partial class BookDetails : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Book BooksDetails_GetItem()
        {
            var id = this.Request.Params["id"];
            return this.Data.Books.First(b=> b.Id.ToString() == id);
        }
    }
}