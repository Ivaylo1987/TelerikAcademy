namespace SoundCoud.Data.Repositories
{
    using SoundCloud.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public interface ISoundCloundDbContext
    {
        IDbSet<Song> Songs { get; set; }

        IDbSet<Artist> Artists { get; set; }

        IDbSet<Album> Albums { get; set; }

        DbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();
    }
}
