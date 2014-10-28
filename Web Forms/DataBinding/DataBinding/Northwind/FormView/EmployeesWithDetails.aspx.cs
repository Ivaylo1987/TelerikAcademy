using Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBinding.Northwind.FormView
{
    public partial class EmployeesWithDetails : System.Web.UI.Page
    {
        List<Employee> employees = new NorthwindEntities().Employees.ToList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.FormViewEmployee.DataSource = employees;
                this.ListViewEmployees.DataSource = employees;
            }
        }

        protected void FormViewEmployee_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            this.FormViewEmployee.PageIndex = e.NewPageIndex;
            this.FormViewEmployee.DataSource = employees;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.DataBind();
        }
    }
}