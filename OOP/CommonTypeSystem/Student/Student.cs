namespace Student
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public int SSNumber { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public string Mail { get; set; }

        public int Course { get; set; }

        public SpecialtiesEnum Specialties { get; private set; }

        public FacultiesEnum Faculty { get; private set; }

        public UniversityEnum Univeristy { get; private set; }


        public override bool Equals(object obj)
        {
            var std = obj as Student;
            if (std == null)
            {
                throw new ArgumentException("Invalid obj param!");
            }

            if (this.Address != std.Address)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, std.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.SecondName, std.SecondName))
            {
                return false;
            }

            if (!object.Equals(this.ThirdName, std.ThirdName))
            {
                return false;
            }

            if (this.SSNumber != std.SSNumber)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.ThirdName + " " + this.Mail;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.ThirdName.GetHashCode() ^ this.GetHashCode() ^ this.SSNumber.GetHashCode();
        }

        public static bool operator ==(Student firstStd, Student secondStd)
        {
            return Student.Equals(firstStd, secondStd);
        }

        public static bool operator !=(Student firstStd, Student secondStd)
        {
            return !(Student.Equals(firstStd, secondStd));
        }
    }
}
