namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestSchool
    {
        private School school = new School();

        [TestMethod]
        public void TestSchool_AddFirstStudent()
        {
            var studentsCountBefore = this.school.Students.Count;
            this.school.AddStundent(new Student("Pesho", 12345));
            var studentsCountAfter = this.school.Students.Count;

            Assert.AreEqual(studentsCountBefore + 1, studentsCountAfter);
        }

        [TestMethod]
        public void TestSchool_AddStudentWithRandomNumber()
        {
            var studentGosho = new Student("Gosho", 16001);
            this.school.AddStundent(studentGosho);

            var isNewStudentAdded = this.school.Students.Contains(studentGosho);
            Assert.IsTrue(isNewStudentAdded);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchool_AddDuplicateStudent()
        {
            var studentMaria = new Student("Maria", 16001);
            this.school.AddStundent(studentMaria);

            var studentPenka = new Student("Penka", 16001);
            this.school.AddStundent(studentPenka);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchool_AddNullStudent()
        {
            this.school.AddStundent(null);
        }
    }
}
