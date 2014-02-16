namespace School
{
    using System;
    class Discipline : IComment
    {
        private int lectures;
        private int excercises;
        private string name;

        public Discipline(string name, int lectures, int excercises)
        {
            this.Name = name;
            this.Excercises = excercises;
            this.Lectures = lectures;
        }

        public int Lectures
        {
            get
            {
                return this.lectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.lectures = value;
            }
        }
        public int Excercises
        {
            get
            {
                return this.excercises;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.excercises = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 2 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }
        public string Comment { get; set; }
    }
}
