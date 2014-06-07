namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        public const int StudentsMaxCount = 30;

        private IList<Student> students;

        public Course(string name, IList<Student> studentsIncourse)
        {
            this.Students = studentsIncourse;
            this.Name = name;
        }

        public IList<Student> Students 
        {
            get 
            {
                return this.students;
            }
            private set
            {
                if (value.Count > StudentsMaxCount)
                {
                    throw new ArgumentOutOfRangeException("Course cannot contain more than 30 students.");
                }

                this.students = value;
            }
        }

        public string Name { get; private set; }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.Students.Contains(student))
            {
                throw new ArgumentException("Student already exists in the course!");
            }

            if (this.Students.Count == StudentsMaxCount)
            {
                throw new ArgumentOutOfRangeException("Students are already 30. More than 30 is not allowed");
            }

            this.Students.Add(student);
        }

        public bool RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            return this.Students.Remove(student);
        }
    }
}
