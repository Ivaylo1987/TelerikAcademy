﻿namespace School
{
    using System.Collections.Generic;
    class Teacher : Person
    {
        public Teacher(string name)
            :base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines { get; set; }
    }
}