namespace Worker
{
    using System;
    public class Student : Human
    {
        private int grade;

        public Student(string firstname, string lastname)
            : base(firstname, lastname)
        {
            
        }

        public Student(string firstname, string lastname, int grade)
            : base(firstname, lastname)
        {
            this.Grade = grade;
        }

        public int Grade 
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
