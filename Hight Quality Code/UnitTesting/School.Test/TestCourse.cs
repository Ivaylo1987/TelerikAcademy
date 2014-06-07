namespace School.Test
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void TestCreateOrdinaryCourse()
        {
            var students = this.Create30Students();
            var course = new Course("HQC", students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateWithMoreThan30Studens()
        {
            var students = this.Create30Students();
            students.Add(new Student("31st", 313131));
            students.Add(new Student("32st", 313132));

            new Course("HQC", students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddStudents_Add31st()
        {
            var students = this.Create30Students();
            var hqc = new Course("HQC", students);
            HQC.AddStudent(new Student("31st", 31313));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAdd_NullStudent()
        {
            var math = new Course("Math", this.Create30Students());
            math.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemove_NullStudent()
        {
            var math = new Course("Math", this.Create30Students());
            math.RemoveStudent(null);
        }

        [TestMethod]
        public void TestRemove_ExistingStudent()
        {
            var math = new Course("Math", this.Create30Students());
            math.RemoveStudent(new Student("Student 1", 10001));
        }

        private IList<Student> Create30Students()
        {
            List<Student> studentsCollection = new List<Student>();

            for (int i = 1; i <= 30; i++)
            {
                var name = string.Format("Student {0}", i);
                studentsCollection.Add(new Student(name, 10000 + i));
            }

            return studentsCollection;
        }
    }
}
