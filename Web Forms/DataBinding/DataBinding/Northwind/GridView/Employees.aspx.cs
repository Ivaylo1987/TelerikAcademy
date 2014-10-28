using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Northwind;

namespace DataBinding.Northwind
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();

            var employees = db.Employees.Select(em => new { 
                Id = em.EmployeeID,
                FullName = em.FirstName + " " + em.LastName
            }).ToArray();

            if (!Page.IsPostBack)
            {
                this.GridViewEmployees.DataSource = employees;
                this.GridViewEmployees.DataBind();
            }
        }
    }
}