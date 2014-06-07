namespace School
{
    using System;
    public class Student : IComparable<Student>
    {
        private string name;
        private int studentID;

        public Student(string name, int id)
        {
            this.Name = name;
            this.StudentId = id;
        }

        public int StudentId
        {
            get
            {
                return this.studentID;
            }

            set
            {
                if (value < 10000 && 99999 < value)
                {
                    throw new ArgumentOutOfRangeException("Id shoudl be greater than 10000 and less than 99999!");
                }

                this.studentID = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannto be null or empty!");
                }

                this.name = value;
            }
        }

        // Needed for comparing uniqueness
        public int CompareTo(Student other)
        {
            return this.StudentId.CompareTo(other.studentID);
        }
    }
}
