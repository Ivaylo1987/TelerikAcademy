namespace StudentSystem.DataContext.Migrations
{
    using StudentSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentSystem.DataContext.StudentSystemContext";
        }

        protected override void Seed(StudentSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Students.AddOrUpdate(
                new Student() { Name = "Pesho", Number = 123456 },
                new Student() { Name = "Dechko", Number = 423457 },
                new Student() { Name = "Gosho", Number = 123458 },
                new Student() { Name = "Mara", Number = 523459 },
                new Student() { Name = "Ivcho", Number = 123436 },
                new Student() { Name = "Mitko", Number = 223416 },
                new Student() { Name = "Venci", Number = 123116 },
                new Student() { Name = "jorka", Number = 173456 }
                );
            context.Courses.AddOrUpdate(
                new Course() { Name = "DSA" },
                new Course() { Name = "Databases" }
                );
        }
    }
}
