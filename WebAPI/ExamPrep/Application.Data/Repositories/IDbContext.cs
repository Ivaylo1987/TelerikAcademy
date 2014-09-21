namespace Application.Data.Repositories
{
    using Application.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public interface IDbContext
    {
        IDbSet<Article> Articles { get; set; }

        IDbSet<Comment> Comments { get; set; }

        IDbSet<Tag> Tags { get; set; }

        IDbSet<Category> Categories { get; set; }

        DbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();
    }
}
