namespace Application.Data
{
    using Application.Data.Repositories;
    using Application.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Application.Data.Migrations;

    public class DbContext : IdentityDbContext<User>, IDbContext
    {
        public DbContext()
            : base("ArticleSystem", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContext, Configuration>());
        }

        public static DbContext Create()
        {
            return new DbContext();
        }

       public IDbSet<Article> Articles { get; set; }
       public IDbSet<Comment> Comments { get; set; }
       public IDbSet<Tag> Tags { get; set; }
       public IDbSet<Category> Categories { get; set; }
    }
}
