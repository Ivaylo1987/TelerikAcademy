using ExamPrep.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ExamPrep.Web.Models
{
    public class BasePage : Page
    {
        public BasePage()
        {
            this.Data = new ApplicationDbContext();
        }

        public ApplicationDbContext Data { get; private set; }
    }
}