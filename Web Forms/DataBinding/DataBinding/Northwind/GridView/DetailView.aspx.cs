using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Northwind;

namespace DataBinding.Northwind.GridView
{
    public partial class DetailView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employeeID = this.Request["id"];
            var db = new NorthwindEntities();

            var employee = db.Employees.Where(em => em.EmployeeID.ToString() == employeeID).ToArray();

            if (!Page.IsPostBack)
            {
                this.DetailsViewEmployee.DataSource = employee;
                this.DetailsViewEmployee.DataBind();
            }
        }
    }
}