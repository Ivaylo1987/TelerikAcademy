﻿using ExamPrep.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamPrep.Web
{
    public partial class _Default : BasePage
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
            return this.Data.Categories.OrderBy(c => c.Name);
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            var queryParam = this.TextBoxSearch.Text;
            var urlWithQueryString = "Search?q=" + queryParam;

            Response.Redirect(urlWithQueryString);
        }
    }
}