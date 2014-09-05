namespace MongoDemos
{
    using System;
    using System.Linq;
    using Mongo.DbConnector;
    using System.Collections.Generic;
    using MongoDB.Driver.Builders;
    using MongoDB.Driver.Linq;
    class Demo
    {
        static void Main()
        {
            var host = "mongodb://127.0.0.1";

            var dbConnector = new Connector();
            var db = dbConnector.GetDatabase(host, "testdb");

            var students = db.GetCollection<Student>("Students");
            var toAdd = new List<Student>()
                {
                    new Student{ FirstName = "Maria", LastName = "Stoyanova"},
                    new Student{ FirstName = "Georgi", LastName = "Ivanov"},
                };

            students.Insert(
                new Student
                {
                    FirstName = "Maria",
                    LastName = "Georgieva"
                }
                );

            var linqQuery = Query<Student>.Where( st => st.FirstName == "Pesho");
            var contains = students.AsQueryable<Student>().Any( st => st.FirstName == "dr");
            Console.WriteLine(contains);

        }
    }
}
