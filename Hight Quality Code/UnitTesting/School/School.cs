namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        public School()
        {
            this.Courses = new List<Course>();
            this.Students = new List<Student>();
        }

        public IList<Student> Students { get; private set; }

        public IList<Course> Courses { get; private set; }

        public void AddStundent(Student student)
        {
            if (this.Students == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.Students.Contains(student))
            {
                throw new ArgumentException("Student already exists in the course!");
            }

            this.Students.Add(student);
        }
    }
}
