namespace SoundCloud.Web.Controllers
{
    using SoundCoud.Data.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class BaseController : ApiController
    {
        private ISoundCloudData data;

        public BaseController()
            : this(new SoundCloudData())
        {
        }

        public BaseController(ISoundCloudData data)
        {
            this.data = data;
        }
    }
}
