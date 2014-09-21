namespace Application.Data.Repositories
{
    using Application.Models;
    public interface IApplicationData
    {
        IGenericRepository<Article> Articles { get; }

        IGenericRepository<Comment> Comments { get; }

        IGenericRepository<Tag> Tags { get; }

        IGenericRepository<Category> Categories { get; }
    }
}
