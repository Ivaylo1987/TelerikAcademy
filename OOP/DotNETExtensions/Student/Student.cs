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
        public Student(string firstName, string lastName , int facNumber, string phone, string mail, List<int> marks, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacNumber = facNumber;
            this.Phone = phone;
            this.Mail = mail;
            Marks = new List<int>(marks);
            this.GroupNumer = group;
            
        }

        // Properties
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int FacNumber { get; private set; }

        public string Phone { get; private set; }

        public string Mail { get; private set; }

        public List<int> Marks { get; private set; }

        public int GroupNumer { get; private set; }

        // override ToSting()
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
