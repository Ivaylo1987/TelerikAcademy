using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneBook.Tests
{
    [TestClass]
    public class AddPhoneTests
    {
        private IPhonebookRepository repo = new PhoneBookRepo();

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddPhoneWithInvalidName()
        {
            var numbers = new List<string>(){"1234", "123456"};

            repo.AddPhone("InvalidName", numbers);
        }
    }
}
