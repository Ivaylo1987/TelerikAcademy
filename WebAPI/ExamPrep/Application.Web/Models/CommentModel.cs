namespace Application.Web.Models
{
    using Application.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;

    public class CommentModel
    {

        public static Expression<Func<Comment, CommentModel>> FromComment
        {
            get
            {
                return c => new CommentModel()
                {
                    Id = c.Id,
                    Content = c.Content,
                    DateCreated = c.DateCreated,
                    AuthorName = c.Author.UserName
                };
            }
        }

        public int Id { get; set; }
        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public string AuthorName { get; set; }
    }
}