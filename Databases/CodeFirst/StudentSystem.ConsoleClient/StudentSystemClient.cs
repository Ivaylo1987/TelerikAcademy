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
            DatabaseInitiaze();
            var db = new StudentSystemContext();
            var students = db.Students;

            var DSACourse = db.Courses.First(c => c.Name == "DSA");

            foreach (var student in students)
            {
                student.Courses.Add(DSACourse);
            }

            db.SaveChanges();
        }
    }
}
