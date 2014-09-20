namespace SoundCoud.Data.Repositories
{
    using SoundCloud.Models;
    public interface ISoundCloudData
    {
        IGenericRepository<Song> Sonds { get; }

        IGenericRepository<Artist> Artists { get;  }

        IGenericRepository<Album> Albums { get; }

    }
}
