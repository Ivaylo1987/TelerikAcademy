using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Application.Web.Models
{
    public class CategoryModel
    {
        public static Expression<Func<Category, CategoryModel>> FromCategory
        {
            get
            {
                return c => new CategoryModel()
                {
                    Name = c.Name
                };
            }
        }
        public string Name { get; set; }
    }
}