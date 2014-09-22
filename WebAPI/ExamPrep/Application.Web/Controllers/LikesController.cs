using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.Web.Controllers
{
    public class LikesController : BasicController
    {
        [HttpPost]
        [Authorize]
        public IHttpActionResult PostLike(int id)
        {

            var currentUser = this.GetUserById();
            var currentArticle = this.Data.Articles.SearchFor(a => a.Id == id).First();

            if (currentArticle == null)
            {
                return this.BadRequest("Article is not present!");
            }

            var currentLike = new Like()
            {
                Article = currentArticle,
                Author = currentUser
            };

            this.Data.Likes.Add(currentLike);
            this.Data.SaveChanges();

            return Ok(currentLike.Id);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult RemoveLike(int id)
        {

            var currentUser = this.GetUserById();
            var currentArticle = this.Data.Articles.SearchFor(a => a.Id == id).First();

            if (currentArticle == null)
            {
                return this.BadRequest("Article is not present!");
            }

            var like = currentArticle.Likes.First( l => l.Author.Id == currentUser.Id);

            if (like == null)
            {
                return BadRequest("There is no like form this user");
            }

            currentArticle.Likes.Remove(like);
            this.Data.SaveChanges();

            return Ok("Removed!");
        }
    }
}
