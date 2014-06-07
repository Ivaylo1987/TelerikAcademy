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
            var studentsCount = school.Students.Count;
            school.AddStundent(new Student("Pesho", 12345));
            
        }

        [TestMethod]
        public void TestSchool_AddStudentWithRandomNumber()
        {
            school.AddStundent(new Student("Pesho", 16001));
        }
    }
}
