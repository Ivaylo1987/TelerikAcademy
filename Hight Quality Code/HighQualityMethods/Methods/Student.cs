namespace Methods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public DateTime BirthDay { get; set; }

        public bool IsOlderThan(DateTime date)
        {
            return this.BirthDay < date;
        }
    }
}
