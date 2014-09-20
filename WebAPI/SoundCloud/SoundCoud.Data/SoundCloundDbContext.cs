namespace SoundCoud.Data
{
    using SoundCloud.Models;
    using SoundCoud.Data.Migrations;
    using SoundCoud.Data.Repositories;
    using System.Data.Entity;
    internal class SoundCloundDbContext : DbContext, ISoundCloundDbContext
    {
        public SoundCloundDbContext()
            : base("SoundCloudConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SoundCloundDbContext, Configuration>());
        }

        public IDbSet<Song> Songs { get; set; }

        public IDbSet<Artist> Artists { get; set; }

        public IDbSet<Album> Albums { get; set; }
    }
}
