namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using StudentSystem.DataContext;
    using StudentSystem.DataContext.Migrations;
    using StudentSystem.Models;

    class StudentSystemClient
    {
        public static void DatabaseInitiaze()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
        }

        public static void Main()
        {
            var db = new StudentSystemContext();
            var courses = db.Courses.Add(new Course() { Name="Databases"});
            
        }
    }
}
