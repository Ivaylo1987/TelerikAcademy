namespace Application.Web.Models
{
    using Application.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    public class ArticleModel
    {
        public static Expression<Func<Article, ArticleModel>> FromArticle
        {
            get
            {
                return a => new ArticleModel()
                {
                    Id = a.Id,
                    Title = a.Title,
                    DateCreated = a.DateCreate,
                    Content = a.Content,
                    Category = a.Category.Name,
                    Tags = a.Tags.AsQueryable().Select(TagModel.FromTag),
                    Comments = a.Comments.AsQueryable().Select(CommentModel.FromComment),
                    Likes = a.Likes.AsQueryable().Select(LikeModel.FromLike),
                };
            }
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public virtual string Category { get; set; }
        public virtual IEnumerable<TagModel> Tags { get; set; }
        public virtual IEnumerable<CommentModel> Comments { get; set; }
        public virtual IEnumerable<LikeModel> Likes { get; set; }
    }
}