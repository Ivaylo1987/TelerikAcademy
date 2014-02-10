namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        // Fields
        private int size;
        private int numberOfColors;

        // Constructors
        public Display()
        {

        }

        public Display(int sizeInInches, int colorNumber)
        {
            this.Size = sizeInInches;
            this.NumberOfColors = colorNumber;
        }

        // Properties
        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size cannot ne less than 0!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number Of colors cannot be less than 0!");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

        public override string ToString()
        {
            return this.Size + " - " + this.NumberOfColors;
        }
    }
}
