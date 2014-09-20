namespace SoundCloud.Web.Controllers
{
    using SoundCoud.Data.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class BaseApiController : ApiController
    {
        private SoundCloudData data;

        public BaseApiController()
            : this(new SoundCloudData())
        {
        }

        public BaseApiController(SoundCloudData data)
        {
            this.data = data;
        }

        protected SoundCloudData Data
        { 
            get
            {
                return this.data;
            } 
        }
    }
}
