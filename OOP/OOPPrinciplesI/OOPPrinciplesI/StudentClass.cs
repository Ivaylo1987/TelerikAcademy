namespace School
{
    using System;
    using System.Collections.Generic;

    public class StudentClass : IComment
    {

        private string identifier;
        private List<Teacher> teachers;

        public StudentClass( string identier, params Teacher[] teachers)
        {
            this.Identifier = identier;
            this.teachers = new List<Teacher>(teachers);
        }

        // Properties
        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                this.identifier = value;
            }
        }

        public List<Teacher> Teachers 
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
        }

        public string Comment { get; set; }

        // Methods
        public void AddTeacher (Teacher teacher)
        {
            teachers.Add(teacher);
        }
    }
}
