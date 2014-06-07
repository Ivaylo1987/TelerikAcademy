namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
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
                if (value.Count > 30)
                {
                    throw new ArgumentOutOfRangeException("Course cannot contain more than 30 students.");
                }

                this.students = value;
            }
        }

        public string Name { get; private set; }

        public void AddStudent(Student student)
        {
            if (students == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.Students.Contains(student))
            {
                throw new ArgumentException("Student already exists in the course!");
            }

            this.Students.Add(student);
        }

        public bool RemoveStudent(Student student)
        {
            if (students == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            return this.Students.Remove(student);
        }
    }
}
