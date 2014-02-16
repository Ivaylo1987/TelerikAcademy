namespace Worker
{
    using System;
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }

        public decimal WeekSalary 
        {
            get 
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentException();
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return WeekSalary / WorkHoursPerDay * 5;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + MoneyPerHour();
        }
    }
}