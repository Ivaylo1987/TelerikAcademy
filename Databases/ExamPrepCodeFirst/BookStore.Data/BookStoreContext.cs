namespace BookStore.Data
{
    using BookStore.Data.Migrations;
    using BookStore.Model;
    using System.Data.Entity;

    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("BookStoreConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookStoreContext, Configuration>());
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
