namespace DotNetExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {

        public Student()
        {
        }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            Marks = new List<int>();
        }

        // Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FacNumber { get; set; }

        public string Mail { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumer { get; set; }


        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
