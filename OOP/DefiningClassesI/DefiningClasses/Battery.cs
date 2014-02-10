namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Battery
    {
        // Fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        // Constructors

        public Battery(string batModel, BatteryType batType)
        {
            this.Type = batType;
            this.Model = batModel;
        }

        public Battery(string batModel, BatteryType batType, int idleHours, int talkHours)
            : this(batModel, batType)
        {
            this.HoursIdle = idleHours;
            this.HoursTalk = talkHours;
        }

        // Properties
        public BatteryType Type { get; set; }

        public int HoursIdle
        {
            get 
            { 
                return this.hoursIdle;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Hours cannot be less than 0!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int HoursTalk
        {
            get 
            { 
                return this.hoursTalk;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Hours cannot be less than 0!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public string Model
        {
            get 
            { 
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model Cannot be Blank");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public override string ToString()
        {
            return (this.Model + " - " + this.Type.ToString());
        }
    }
}
