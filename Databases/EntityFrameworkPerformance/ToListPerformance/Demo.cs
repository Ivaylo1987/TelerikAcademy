namespace ToListPerformance
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using TelerikAcademy.Model;

    class Demo
    {
        static void Main()
        {
            var telerikAcademyDb = new TelerikAcademyEntities();

            using (telerikAcademyDb)
            {
                var employees = telerikAcademyDb.Employees;
                var timer = new Stopwatch();
                timer.Restart();
                Slow(employees);
                Console.WriteLine("Elapsed time {0}", timer.Elapsed);

                //Fast(employees);
                timer.Restart();
                Fast(employees);
                Console.WriteLine("Elapsed time {0}", timer.Elapsed);
                timer.Stop();
            }
        }

        private static void Fast(DbSet<Employee> employees)
        {
            // fast way to do it - nice!
            var employeesFromSofia = employees.Where(e => e.Address.Town.Name == "Sofia").ToList();
        }

        private static void Slow(DbSet<Employee> employees)
        {
            // slow way to to it - not good
            var sofia = employees.ToList()
                                  .Select(e => e.Address).ToList()
                                  .Select(a => a.Town).ToList()
                                  .Where(t => t.Name == "Sofia");
        }
    }
}
