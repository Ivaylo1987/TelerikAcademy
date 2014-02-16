namespace Worker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestWorker
    {
        static void Main()
        {
            List<Student> student = new List<Student>()
            {
                new Student("Pesho", "Todorov", 2),
                new Student("Anton", "penev", 4),
                new Student("Ivo", "Stoyanov", 1),
                new Student("Nora", "Subova", 2),
                new Student("Denitsa", "Trifonova", 3),
                new Student("Georogi", "Todorov", 5),
                new Student("Todor", "Ivanov", 1),
                new Student("Ivan", "Aleksandrov", 2),
                new Student("Ani", "Martinova", 1),
                new Student("Viktor", "Nikolov", 4),
            };

            var sortedStudent = student.OrderBy(s => s.Grade);

            Console.WriteLine("OrderedStudets: ");
            Console.WriteLine(new string('-', 20));

            foreach (var std in sortedStudent)
            {
                Console.WriteLine(std);
            }

            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Stilian", "Stoyanov", 500, 8),
                new Worker("Ivaylo", "Penev", 600, 8),
                new Worker("Genafi", "Petkov", 300, 8),
                new Worker("Nora", "Subova", 400, 8),
                new Worker("Denitsa", "Trifonova", 480, 8),
                new Worker("Georogi", "Todorov", 700, 8),
                new Worker("Strahil", "Ivanov", 620, 8),
                new Worker("Ivan", "Aleksandrov", 300, 8),
                new Worker("Ani", "Martinova", 400, 8),
                new Worker("Viktor", "Georgiev", 800, 8),
            };

            var sortedWrokers = workers.OrderBy(s => s.MoneyPerHour());

            Console.WriteLine("OrderedWorkers: ");
            Console.WriteLine(new string('-', 20));

            foreach (var worker in sortedWrokers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();
            Console.WriteLine("Combined: ");
            Console.WriteLine(new string('-', 20));

            List<Human> combined = new List<Human>();

            combined.AddRange(sortedStudent);
            combined.AddRange(sortedWrokers);
            var sortedCobined = combined.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            foreach (var human in sortedCobined)
            {
                Console.WriteLine(human);
            }

        }
    }
}
