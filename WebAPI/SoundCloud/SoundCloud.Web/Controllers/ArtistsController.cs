namespace SoundCloud.Web.Controllers
{
    using SoundCloud.Models;
    using SoundCloud.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class ArtistsController : BaseApiController
    {

        [HttpGet]
        public IHttpActionResult All()
        {
            var artists = this.Data.Artists.All().Select(ArtistModel.FromArtist);

            return Ok(artists);
        }

        [HttpPost]
        public IHttpActionResult Create(ArtistModel artist)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var newArtist = new Artist()
                            {
                                Name = artist.Name,
                                Country = artist.Country,
                                DateOfBirth = artist.DateOfBirth
                            };

            this.Data.Artists.Add(newArtist);
            this.Data.SaveChanges();

            return Ok(newArtist.Id);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody]ArtistModel artist)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (!this.Data.Artists.All().Any(a => a.Id == id))
            {
                return this.BadRequest("No such Artist exists!");
            }

            var artistFromDB = this.Data.Artists.SearchFor(a => a.Id == id).First();

            if (artist.Name != null)
            {
                artistFromDB.Name = artist.Name;
            }

            if (artist.Country != null)
            {
                artistFromDB.Country = artist.Country;
            }

            if (artist.DateOfBirth != null)
            {
                artistFromDB.DateOfBirth = artist.DateOfBirth;
            }

            this.Data.SaveChanges();

            return Ok(artist);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (!this.Data.Artists.All().Any(a => a.Id == id))
            {
                return this.BadRequest("Such artist does not exist");   
            }

            var toDelete = this.Data.Artists.All().First(a => a.Id == id);
            this.Data.Artists.Delete(toDelete);
            this.Data.SaveChanges();
            return Ok("Deleted");
        }
    }
}
