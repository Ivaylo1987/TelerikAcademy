using Application.Models;
using Application.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Application.Web.Controllers
{
    public class ArticlesController : BasicController
    {

        private const int DefaultPageSize = 4;

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(ArticleModel articleModel)
        {
            if (articleModel == null)
            {
                return BadRequest("Article model is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = this.GetUserId();
            var currentAuthor = this.Data.Users.SearchFor(u => u.Id == userId).First();
            var tags = this.GetTags(articleModel);
            var category = this.GetCategory(articleModel.Category);

            var article = new Article()
            {
                Author = currentAuthor,
                Content = articleModel.Content,
                Title = articleModel.Title,
                Category = category,
                DateCreate = DateTime.Now,
                Tags = tags
            };

            this.Data.Articles.Add(article);
            this.Data.SaveChanges();

            ArticleModel result = GetResult(articleModel, article);

            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var article = this.Data.Articles.All().Where(a => a.Id == id).Select(ArticleModel.FromArticle).FirstOrDefault();
            return Ok(article);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var articles = GetArticles(0, null);
            return Ok(articles);
        }

        [HttpGet]
        public IHttpActionResult GetAll(int page)
        {
            var articles = GetArticles(page, null);
            return Ok(articles);
        }

        [HttpGet]
        public IHttpActionResult GetAll(string category)
        {
            var articles = GetArticles(0, category);
            return Ok(articles);
        }

        [HttpGet]
        public IHttpActionResult GetAll(int page, string category)
        {
            var articles = GetArticles(page, category);
            return Ok(articles);
        }

        private IQueryable<ArticleModel> GetArticles(int page, string category)
        {
            var articles = this.Data.Articles.All()
                               .OrderByDescending(a => a.DateCreate)
                               .Skip(page * DefaultPageSize)
                               .Take(DefaultPageSize * (page + 1))
                               .Where(a => category == null ? true : category == a.Category.Name)
                               .Select(ArticleModel.FromArticle);

            return articles;
        }

        private ArticleModel GetResult(ArticleModel articleModel, Article article)
        {
            var result = articleModel;
            result.Id = article.Id;
            result.Category = article.Category.Name;
            result.Content = article.Content;
            result.DateCreated = article.DateCreate;
            result.Tags = article.Tags.AsQueryable().Select(TagModel.FromTag).ToArray();
            result.Comments = article.Comments.AsQueryable().Select(CommentModel.FromComment).ToArray();
            result.Likes = article.Likes.AsQueryable().Select(LikeModel.FromLike).ToArray();

            return result;
        }

        private Category GetCategory(string categoryName)
        {
            var category = this.Data.Categories.All().FirstOrDefault(c => c.Name == categoryName);

            if (category == null)
            {
                category = new Category()
                {
                    Name = categoryName
                };

                this.Data.Categories.Add(category);
            }

            return category;
        }

        private ICollection<Tag> GetTags(ArticleModel item)
        {
            var allTags = new HashSet<string>();
            var currentArticleTags = new HashSet<Tag>();

            // Get article title words as tags.
            var titleTags = item.Title.Split(' ').ToArray();
            allTags.UnionWith(titleTags);

            // Get all tags sent with the request
            if (item.Tags != null && item.Tags.Count() > 0)
            {
                foreach (var tag in item.Tags)
                {
                    allTags.Add(tag.Name);
                }
            }

            // Create or Add tags to the final collection
            foreach (var tagName in allTags)
            {
                var currentTag = this.Data.Tags.All().FirstOrDefault(t => t.Name == tagName);

                if (currentTag == null)
                {
                    currentTag = new Tag()
                    {
                        Name = tagName
                    };

                    this.Data.Tags.Add(currentTag);
                }

                currentArticleTags.Add(currentTag);
            }

            return currentArticleTags;
        }
    }
}
