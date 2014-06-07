namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestSchool
    {
        private School school = new School();

        [TestMethod]
        public void TestSchool_CreateFirstStudent()
        {
            var studentsCountBefore = this.school.Students.Count;
            this.school.AddStundent(new Student("Pesho", 12345));
            var studentsCountAfter = this.school.Students.Count;

            Assert.AreEqual(studentsCountBefore + 1, studentsCountAfter);
        }

        [TestMethod]
        public void TestAddStudent_WithRandomNumber()
        {
            var studentGosho = new Student("Gosho", 16001);
            this.school.AddStundent(studentGosho);

            var isNewStudentAdded = this.school.Students.Contains(studentGosho);
            Assert.IsTrue(isNewStudentAdded);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddStudent_DuplicateID()
        {
            var studentMaria = new Student("Maria", 16001);
            this.school.AddStundent(studentMaria);

            var studentPenka = new Student("Penka", 16001);
            this.school.AddStundent(studentPenka);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddStudent_NullStudent()
        {
            this.school.AddStundent(null);
        }
    }
}
