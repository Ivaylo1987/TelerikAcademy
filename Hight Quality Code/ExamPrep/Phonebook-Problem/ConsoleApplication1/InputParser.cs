namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InputParser
    {
        public CommandInfo Parse(string inputLine)
        {
            int indexOfStartingBracket = inputLine.IndexOf('(');
            if (indexOfStartingBracket == -1)
            {
                throw new ArgumentException("Invalid input!");
            }

            string commandName = inputLine.Substring(0, indexOfStartingBracket);

            if (!inputLine.EndsWith(")"))
            {
                throw new ArgumentException("Invalid command ending!");
            }

            string commandBody = inputLine.Substring(indexOfStartingBracket + 1, inputLine.Length - indexOfStartingBracket - 2);
            string[] commandParams = commandBody.Split(',');

            for (int j = 0; j < commandParams.Length; j++)
            {
                commandParams[j] = commandParams[j].Trim();
            }

            var result = new CommandInfo(commandName, commandParams);

            return result;
        }
    }
}
