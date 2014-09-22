namespace Application.Web.Models
{
    using Application.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;

    public class LikeModel
    {
        public static Expression<Func<Like, LikeModel>> FromLike
        {
            get
            {
                return l => new LikeModel()
                {
                    Id = l.Id
                };
            }
        }

        public int Id { get; set; }
    }
}