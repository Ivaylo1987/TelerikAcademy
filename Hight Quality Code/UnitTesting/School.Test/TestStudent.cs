namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void TestCreateStudenteAssertID()
        {
            var studentIvo = new Student("Ivo", 11212);
            Assert.AreEqual(11212, studentIvo.StudentId);
        }

        public void TestCreateStudenteAssertName()
        {
            var studentMitaka = new Student("Mitak", 11212);
            Assert.AreEqual("Mitaka", studentMitaka.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCreateWithEmptyName()
        {
            var studentPetko = new Student(string.Empty, 11111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateWithTooSmallId()
        {
            var studentIva = new Student("Iva", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateWithTooBigId()
        {
            var studentIvan = new Student("Ivan", 100000);
        }
    }
}
