using Application.Models;
using Application.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.Web.Controllers
{
    public class CommentsController : BasicController
    {
        [Authorize]
        [HttpPost]
        public IHttpActionResult PostComment(int id, [FromBody]CommentModel comment)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var article = this.Data.Articles.SearchFor(a => a.Id == id).First();

            if (article == null)
            {
                return BadRequest("No such article");
            }

            var userId = this.GetUserId();
            var currentAuthor = this.Data.Users.SearchFor(u => u.Id == userId).First();

            var newComment = new Comment()
            {
                DateCreated = DateTime.Now,
                Author = currentAuthor,
                Content = comment.Content,
                Article = article
            };

            this.Data.Comments.Add(newComment);
            this.Data.SaveChanges();

            comment.AuthorName = currentAuthor.UserName;
            comment.Id = newComment.Id;

            return Ok(comment);
        }
    }
}
