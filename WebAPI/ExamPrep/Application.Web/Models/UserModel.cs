namespace Application.Web.Models
{
    using Application.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;

    public class UserModel
    {
        public static Expression<Func<User, UserModel>> FromUser
        {
            get
            {
                return u => new UserModel()
                {
                    Id = u.Id,
                };
            }
        }

        public string Id { get; set; }
    }
}