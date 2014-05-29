namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string name, string teacherName)
            : base(name, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string courseLab)
            : base(courseName, teacherName, students)
        {
            this.Lab = courseLab;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);

            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");            
            return result.ToString();
        }
    }
}
