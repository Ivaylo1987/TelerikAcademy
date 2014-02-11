namespace DotNetExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestQueries
    {
        static void Main()
        {
            // Task 3
            // Array of anonymous type
            var students = new[] 
            {
                new {FistName = "Anton", LastName = "Ivov", Age = 22},
                new {FistName = "Vladi", LastName = "Simeonov", Age = 19},
                new {FistName = "Martina", LastName = "Hristova", Age = 22},
                new {FistName ="Borislav", LastName = "Antonov", Age = 25}
            };

            var firstNameBeforLast =
                from s in students
                where s.FistName.CompareTo(s.LastName) <= 0
                select s;
                //students.Where(s => s.FistName.CompareTo(s.LastName) <= 0);

            foreach (var student in firstNameBeforLast)
            {
                Console.WriteLine(student.FistName + " " + student.LastName);
            }

            Console.WriteLine(new string('-', 20));

            // Task 4
            var ageSelection =
                from s in students
                where s.Age >= 18 && s.Age <= 24
                select s;
                //students.Where(s => s.Age >= 18 && s.Age <= 24);

            foreach (var student in ageSelection)
            {
                Console.WriteLine(student.FistName + " " + student.LastName);
            }

            Console.WriteLine(new string('-', 20));

            // Task 5

            var orderedStudent = students.OrderByDescending(s => s.FistName).ThenByDescending(s => s.LastName);
            //    from s in students
            //    orderby s.FistName descending, s.LastName descending
            //    select s;

            foreach (var student in orderedStudent)
            {
                Console.WriteLine(student.FistName + " " + student.LastName);
            }

        }
    }
}
