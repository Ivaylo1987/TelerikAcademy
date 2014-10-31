namespace ExamPrep.Web.Models
{
    using ExamPrep.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;

    public class BasePage : Page
    {
        public BasePage()
        {
            this.Data = new ApplicationDbContext();
        }

        public ApplicationDbContext Data { get; private set; }
    }
}