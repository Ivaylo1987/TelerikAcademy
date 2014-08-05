namespace PhoneBook
{
    using System;

    public class CommandInfo
    {
        public CommandInfo(string name, string[] parameters)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be null or empty!");
            }

            if (parameters == null)
            {
                throw new ArgumentNullException("Parameters cannot be null or empty");
            }

            this.Name = name;
            this.Parameters = parameters;
        }

        public string Name { get; private set; }

        public string[] Parameters { get; private set; }
    }
}