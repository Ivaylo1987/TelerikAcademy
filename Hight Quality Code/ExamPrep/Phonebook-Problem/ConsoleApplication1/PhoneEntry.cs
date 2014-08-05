namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PhoneEntry : IComparable<PhoneEntry>
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public SortedSet<string> PhoneNumbers { get; set; }

        public override string ToString()
        {
            StringBuilder entryRepresentation = new StringBuilder();
            entryRepresentation.Clear();
            entryRepresentation.Append('[');
            entryRepresentation.Append(this.Name);
            bool isName = true;

            foreach (var phone in this.PhoneNumbers)
            {
                if (isName)
                {
                    entryRepresentation.Append(": ");
                    isName = false;
                }
                else
                {
                    entryRepresentation.Append(", ");
                }

                entryRepresentation.Append(phone);
            }

            entryRepresentation.Append(']');
            return entryRepresentation.ToString();
        }

        public int CompareTo(PhoneEntry other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}