namespace SoundCoud.Data.Repositories
{
    using SoundCloud.Models;
    using System;
    using System.Collections.Generic;
    public class SoundCloudData : ISoundCloudData
    {
        private ISoundCloundDbContext context;
        private IDictionary<Type, object> repositories;

        public SoundCloudData()
            : this(new SoundCloundDbContext())
        {
        }

        public SoundCloudData(ISoundCloundDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<Song> Sonds
        {
            get { return this.GetRepository<Song>(); }
        }

        public IGenericRepository<Artist> Artists
        {
            get { return GetRepository<Artist>(); }
        }

        public IGenericRepository<Album> Albums
        {
            get { return GetRepository<Album>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);

            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
