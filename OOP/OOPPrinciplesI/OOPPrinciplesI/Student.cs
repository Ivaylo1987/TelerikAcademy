namespace School
{
    using System;
    public class Student : Person
    {
        private string studentId;
        public Student(string name, string iD)
            :base(name)
        {
            this.StudentID = iD;
        }

        public string StudentID
        {
            get
            {
                return this.studentId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                this.studentId = value;
            }
        }
    }
}
