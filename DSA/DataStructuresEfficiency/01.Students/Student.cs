namespace Students
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CourseName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
