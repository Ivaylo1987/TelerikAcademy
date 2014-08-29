namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class Homework
    {
        public Homework()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime TimeSent { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
