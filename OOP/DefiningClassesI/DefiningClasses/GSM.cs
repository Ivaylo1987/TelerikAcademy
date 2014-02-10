namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSM
    {
        // Fields
        private static GSM iPhone4s = new GSM("iPhone4S", "Apple", 1024);

        private string model;
        private string manifacturer;
        private decimal price;

        // Constructors
        public GSM(string gsmModel, string gsmManifacturer)
        {
            this.Model = gsmModel;
            this.Manifacturer = gsmManifacturer;
            this.CallHistory = new List<Call>();
        }

        public GSM(string gsmModel, string gsmManifacturer, decimal gsmPrice)
            : this(gsmModel, gsmManifacturer)
        {
            this.Price = gsmPrice;
        }

        public GSM(string gsmModel, string gsmManifacturer, decimal gsmPrice, Battery gsmBattery, Display gsmDisplay)
            : this(gsmModel, gsmManifacturer, gsmPrice)
        {
            this.GSMBattery = gsmBattery;
            this.GSMDisplay = gsmDisplay;
        }

        public GSM(string gsmModel, string gsmManifacturer, decimal gsmPrice, Battery gsmBattery, Display gsmDisplay, string gsmOwner)
            : this(gsmModel, gsmManifacturer, gsmPrice, gsmBattery, gsmDisplay)
        {
            this.Owner = gsmOwner;
        }

        // Properties
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4s;
            }
        }

        public Battery GSMBattery { get; set; }

        public Display GSMDisplay { get; set; }

        public string Owner { get; set; }

        public List<Call> CallHistory { get; private set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                else
                {
                    this.price = value;
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
                    throw new ArgumentException("Model cannot be blank!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manifacturer cannot be empty!");
                }
                else
                {
                    this.manifacturer = value;
                }
            }
        }

        // Methods

        // CallHistory methods
        public void AddCallToHistory(Call callToAdd)
        {
            CallHistory.Add(callToAdd);
        }

        public void DeleteCallFromHistory(int callIndex)
        {
            
            if (CallHistory.Count - 1 >= callIndex)
            {
                CallHistory.RemoveAt(callIndex);
            }
            else
            {
                throw new ArgumentException("Call history does not contain such item!");
            }
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMinute)
        {
            int totalNumberOfSeconds = 0;
            decimal result = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                totalNumberOfSeconds += CallHistory[i].DurationOfCall.Seconds;
            }

            result = totalNumberOfSeconds * (pricePerMinute / 60);
            
            return result;
        }

        // Method that prints all info about GSM
        public void PrintAllInfo()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("GSM Details");
            result.AppendLine(this.Manifacturer.ToString());
            result.AppendLine(this.Model.ToString());
            result.AppendFormat("Price: {0} \n", this.Price.ToString());

            if (this.GSMBattery != null)
            {
                result.AppendFormat("Batery: {0} \n", this.GSMBattery.ToString());
            }

            if (this.GSMDisplay != null)
            {
                result.AppendFormat("Display: {0} \n", this.GSMDisplay.ToString());
            }

            if (this.Owner != null)
            {
                result.AppendFormat("Owner: {0} \n", this.Owner);
            }

            Console.WriteLine(result.ToString().Trim());
        }

        public override string ToString()
        {
            return (this.Manifacturer + " " + this.Model);
        }
    }
}