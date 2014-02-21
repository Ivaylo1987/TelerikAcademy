using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class PersonTC
    {
        private string name;
        private int? age;

        public PersonTC(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get 
            {
                return this.name;

            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Cannot be blank of null!");
                }

                this.name = value;
            }
        }

        public int? Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            
            return this.Name + " " + this.Age ?? " - no age specified";
        }
    }
}
