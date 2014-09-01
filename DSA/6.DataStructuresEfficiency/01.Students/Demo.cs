namespace Students
{
    using System;

    public class Demo
    {
        public static void Main()
        {
            var studentsDatabase = new StudentsDatabase("../../studentsData.txt");
            Console.WriteLine(studentsDatabase.ShowStudentsByCourse());
        }
    }
}
