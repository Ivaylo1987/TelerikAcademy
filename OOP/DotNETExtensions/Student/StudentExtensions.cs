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
    }
}
