namespace StudentQueries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestStudent
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Goshev", 123456, "pesho@academy.bg", new List<int>{5, 6, 6, 6, 4}, 2),
                new Student("Todor", "Todorov", 385244, "todor@academy.bg", new List<int>{3, 6, 4, 6, 6}, 1),
                new Student("Kristina", "Penkova", 321853, "kris@academy.bg", new List<int>{5, 6, 5, 5, 5}, 2),
                new Student("Maria", "Grigorova", 213151, "mimeto@academy.bg", new List<int>{6, 5, 6, 5, 3}, 3),
                new Student("Gosho", "Simeonov", 173256, "jorko@academy.bg", new List<int>{5, 5, 5, 5, 4}, 4),
                new Student("Anton", "Penev", 199457, "anton@academy.bg", new List<int>{4, 4, 4, 6, 4}, 1),
                new Student("Ivo", "Nikolov", 183276, "ivaka@academy.bg", new List<int>{5, 5, 5, 5, 4}, 3),
                new Student("Petq", "Rachina", 132305, "pepi@academy.bg", new List<int>{6, 6, 6, 6, 6}, 3)
            };
        }
    }
}
