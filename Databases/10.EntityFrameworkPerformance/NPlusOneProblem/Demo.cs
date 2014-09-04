namespace NPlusOneProblem
{
    using System;
    using System.Data.Entity;
    using TelerikAcademy.Model;

    class Demo
    {
        static void Main()
        {
            var telerikAcademyDb = new TelerikAcademyEntities();

            using (telerikAcademyDb)
            {
                var employees = telerikAcademyDb.Employees;

                Slow(employees);
                Console.WriteLine();
                Fast(employees);
            }
        }

        private static void Fast(DbSet<Employee> employees)
        {
            // fast way to do it - nice!
            foreach (var employee in employees.Include("Department").Include("Address").Include("Address.Town"))
            {
                Console.WriteLine("{0}, {1}, {2}", employee.FirstName, employee.Department.Name, employee.Address.Town.Name);
            }
        }

        private static void Slow(DbSet<Employee> employees)
        {
            // slow way to to it - not good
            foreach (var employee in employees)
            {
                Console.WriteLine("{0}, {1}, {2}", employee.FirstName, employee.Department.Name, employee.Address.Town.Name);
            }
        }
    }
}
