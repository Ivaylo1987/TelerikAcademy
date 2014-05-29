namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;

        public Course(string courseName)
            : this(courseName, null, new List<string>())
        {
        }

        public Course(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>())
        {
        }

        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        // I  presume that only course name is really mandatory field
        public string Name 
        { 
            get
            {
                return this.name;
            }

            set
            {
                if (value == null  || value == string.Empty)
                {
                    throw new ArgumentException("Course name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public string TeacherName { get;  set; }

        public IList<string> Students { get;  set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        protected virtual string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return null;
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
