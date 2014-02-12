namespace StudentQueries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        //Constructor
        public Student(string firstName, string lastName , int facNumber, string mail, List<int> marks, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacNumber = facNumber;
            this.Mail = mail;
            Marks = new List<int>(marks);
            this.GroupNumer = group;
            
        }

        // Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FacNumber { get; set; }

        public string Mail { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumer { get; set; }

        // override ToSting()
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
