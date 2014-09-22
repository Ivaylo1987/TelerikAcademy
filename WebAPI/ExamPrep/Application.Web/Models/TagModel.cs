using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Application.Web.Models
{
    public class TagModel
    {
        public static Expression<Func<Tag, TagModel>> FromTag
        {
            get
            {
                return t => new TagModel()
                {
                    Name = t.Name
                };
            }
        }

        public string Name { get; set; }
    }
}