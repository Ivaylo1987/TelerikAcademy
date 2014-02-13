namespace StudentQueries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StudentExtensions
    {
        public static IEnumerable<Student> RetunrGroup2ByFirstname(this List<Student> students)
        {
            var result = students.Where(s => s.GroupNumer == 2).OrderBy(s => s.FirstName);

            return result;
        }

        public static IEnumerable<Student> RetunrWithTwo2Marks(this List<Student> students)
        {
            var result = students.Where(s => s.Marks.Where(m => m == 2).Count() == 2);

            return result;
        }

        // Task 19
        public static void PrintStundetByGroups(this List<Student> students)
        {
            var groupedByGroupNumber = students.GroupBy(s => s.GroupNumer);

            foreach (var group in groupedByGroupNumber)
            {
                Console.WriteLine("Group {0}", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            }
        }
    }
}
