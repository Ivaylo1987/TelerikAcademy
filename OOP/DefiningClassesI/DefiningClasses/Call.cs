namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        // Constructors
        public Call(DateTime dateAndTimeOfCall, TimeSpan callDuration)
        {
            this.DateAndTimeOfCall = dateAndTimeOfCall;
            this.DurationOfCall = callDuration;

        }

        public Call(DateTime dateAndTimeOfCall, TimeSpan callDuration, string dialedNumber) : this(dateAndTimeOfCall, callDuration)
        {
            this.DialedNumber = dialedNumber;
        }

        // Properties
        public DateTime DateAndTimeOfCall { get; set; }

        public TimeSpan DurationOfCall { get; set; }

        public string DialedNumber { get; set; }

        public override string ToString()
        {
            
            return "Call on: " + DateAndTimeOfCall + " - Duration: " + DurationOfCall;
        }
    }
}
