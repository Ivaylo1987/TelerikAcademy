namespace StudentQueries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestStudent
    {
        private static void Print(IEnumerable<Student> studentsToPrint, string explanation)
        {
            Console.WriteLine(explanation);
            foreach (var student in studentsToPrint)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            Console.WriteLine(new string('-', 20));
        }

        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Goshev", 1238406, "022432001", "pesho@abv.bg", new List<int>{5, 6, 6, 6, 4}, 2),
                new Student("Todor", "Todorov", 3852244, "02432001", "todor@academy.bg", new List<int>{3, 2, 2, 6, 6}, 1),
                new Student("Kristina", "Penkova", 3212853, "0889240011", "kris@aBbv.bg", new List<int>{5, 2, 5, 5, 5}, 2),
                new Student("Maria", "Grigorova", 2132151, "0882432001", "mimeto@academy.bg", new List<int>{6, 5, 6, 5, 3}, 3),
                new Student("Gosho", "Simeonov", 1732206, "022432001", "jorko@academy.bg", new List<int>{5, 2, 2, 5, 4}, 4),
                new Student("Anton", "Penev", 1994527, "087432441", "anton@abv.bg", new List<int>{4, 4, 4, 6, 4}, 1),
                new Student("Ivo", "Nikolov", 1832276, "089320701", "ivaka@abv.bg", new List<int>{5, 5, 5, 5, 4}, 3),
                new Student("Petq", "Rachina", 1323106, "024532251", "pepi@academy.bg", new List<int>{6, 6, 6, 6, 6}, 3)
            };

            // Task 9
            var group2ByFirstname = students.Where(s => s.GroupNumer == 2).OrderBy(s => s.FirstName);
            Print(group2ByFirstname, "Second group - sorted by first name:");

            // Tastk 10
            Print(students.RetunrGroup2ByFirstname(), "Second group - sorted by first name - With Extension:");

            // Task 11
            Print(students.Where(s => s.Mail.Substring(s.Mail.IndexOf('@')) == "@abv.bg"), "Stundents with abv mail:");

            // Task 12
            Print(students.Where(s => s.Phone.StartsWith("02")), "Students which phone is in Sofia:");

            // Task 13
            var studentsWithAtLeastOne6 =
                from student in students
                where student.Marks.Any(m => m == 6)
                select new
                    {
                        FirstName = student.FirstName,
                        Marks = student.Marks
                    };

            Console.WriteLine("Student with atleast one 6 mark:");
            foreach (var student in studentsWithAtLeastOne6)
            {
                Console.WriteLine(student.FirstName + " " + string.Join(", ", student.Marks));
            }

            Console.WriteLine(new string('-', 20));

            // Task 14 
            Print(students.RetunrWithTwo2Marks(), "Students with exactly two marks equal to 2");

            // Task 15
            Print(students.Where(s => s.FacNumber.ToString().Substring(5, 2) == "06"), "Enrolled in year 2006th:");

            // Таск 17
            List<string> arrayOfStrings = new List<string> { "pesho", "mrazi", "matematika", "i", "obicha", "kiufteta!" };

            Console.WriteLine("Longest string in list: ");
            var longestStr = arrayOfStrings.Where(s => s.Length == arrayOfStrings.Max(str => str.Length));
            foreach (var item in longestStr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));

            // Task 18
            var groupedByGroupNumber = students.GroupBy(s => s.GroupNumer);   // returns IGrouping - a group of key = group index and students in the group

            foreach (var group in groupedByGroupNumber)
            {
                Console.WriteLine("Group {0}", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            }

            Console.WriteLine("Students by gropus wiht extension method.");
            //Task 19
            students.PrintStundetByGroups();
        }
    }
}
