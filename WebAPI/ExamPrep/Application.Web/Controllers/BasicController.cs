namespace Application.Web.Controllers
{
    using Application.Data.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using Microsoft.AspNet.Identity;
    using System.Threading;
    using Application.Models;

    public class BasicController : ApiController
    {
        private IApplicationData data;

        public BasicController()
            : this(new ApplicationData())
        {
        }

        public BasicController(IApplicationData data)
        {
            this.data = data;
        }

        public IApplicationData Data { get { return this.data; } }

        [NonAction]
        protected string GetUserId()
        {
            return Thread.CurrentPrincipal.Identity.GetUserId();
        }

        [NonAction]
        protected User GetUserById()
        {
            var userId = this.GetUserId();
            var currentUser = this.Data.Users.SearchFor(u => u.Id == userId).First();

            return currentUser;
        }
    }
}
